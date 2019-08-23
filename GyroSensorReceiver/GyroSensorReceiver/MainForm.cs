using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private SerialPort serialPort = new SerialPort();

    SensorCalibration sensorCalibration = new SensorCalibration();

    UDPAsyncSocket recieveUDPServer = new UDPAsyncSocket();
    UDPAsyncSocket senderUDPClient = new UDPAsyncSocket();

    Cube3D cube3D = new Cube3D(100);

    public MainForm()
    {
        InitializeComponent();

        GetSerialPortList();

        cbSensorName.SelectedIndex = 0;

        cbSelectorSensor.SelectedIndex = 0;
        cbReplaceAxisX.SelectedIndex = 0;
        cbReplaceAxisY.SelectedIndex = 1;
        cbReplaceAxisZ.SelectedIndex = 2;

        Cube3DRender(new GyroQuaternion("None", 0.25f, 0.25f, 0.25f, -1));

        EventReceiveUDPServer eventReceiveUDPServer = new EventReceiveUDPServer();
        Eventing.eventReceiveUDPServer = eventReceiveUDPServer;
        Eventing.eventReceiveUDPServer.OnNewReceiveUDPServer += OnNewReceiveUDPServerEvent;
    }

    void OnNewReceiveUDPServerEvent(object sender, NewEventReceiveUDPServerArgs e)
    {
        try
        {
            sensorCalibration.Push(e.ReceiveUDPServerMessage);

            GyroQuaternion gyroQuaternionInverse = GyroQuaternion.Inverse(e.ReceiveUDPServerMessage);
            GyroQuaternion gyroQuaternionCalibrationResult = sensorCalibration.GetCalibrationResult(e.ReceiveUDPServerMessage.sensorName);

            if (gyroQuaternionCalibrationResult != null)
            {
                GyroQuaternion gyroQuaternion = GyroQuaternion.Multiply(gyroQuaternionInverse, gyroQuaternionCalibrationResult);

                gyroQuaternion = GetSettingsAxis(gyroQuaternion);

                if (senderUDPClient.udpSocket != null && senderUDPClient.udpSocket.Connected)
                    senderUDPClient.Send(gyroQuaternion);

                if (e.ReceiveUDPServerMessage.sensorName == GetSelectorSensorValue())
                    Cube3DRender(gyroQuaternion);
            }
        }
        catch (Exception ex)
        {
            
        }
    }

    private GyroQuaternion GetSettingsAxis(GyroQuaternion gyroQuaternion)
    {
        float tmpX = 0, tmpY = 0, tmpZ = 0, tmpW = 0;

        MethodInvoker methodInvokerDelegate = delegate ()
        {
            switch (cbReplaceAxisX.SelectedIndex)
            {
                case 0: tmpX = gyroQuaternion.qX; break;
                case 1: tmpX = gyroQuaternion.qY; break;
                case 2: tmpX = gyroQuaternion.qZ; break;
            }
            switch (cbReplaceAxisY.SelectedIndex)
            {
                case 0: tmpY = gyroQuaternion.qX; break;
                case 1: tmpY = gyroQuaternion.qY; break;
                case 2: tmpY = gyroQuaternion.qZ; break;
            }
            switch (cbReplaceAxisZ.SelectedIndex)
            {
                case 0: tmpZ = gyroQuaternion.qX; break;
                case 1: tmpZ = gyroQuaternion.qY; break;
                case 2: tmpZ = gyroQuaternion.qZ; break;
            }

            tmpW = gyroQuaternion.qW;

            if (chbInverseAxisX.Checked)
                tmpX *= -1;
            if (chbInverseAxisY.Checked)
                tmpY *= -1;
            if (chbInverseAxisZ.Checked)
                tmpZ *= -1;
        };

        if (InvokeRequired)
            Invoke(methodInvokerDelegate);
        else
            methodInvokerDelegate();

        return new GyroQuaternion(gyroQuaternion.sensorName, tmpX, tmpY, tmpZ, tmpW);
    }


    private string GetSelectorSensorValue()
    {
        string selectorSensorValue = string.Empty;

        MethodInvoker methodInvokerDelegate = delegate () { selectorSensorValue = cbSelectorSensor.Text; };

        if (InvokeRequired)
            Invoke(methodInvokerDelegate);
        else
            methodInvokerDelegate();

        return selectorSensorValue;
    }

    private void Cube3DRender(GyroQuaternion quat)
    {
        Point3D point3D = GyroQuaternion.QuatToEuler(quat);

        cube3D.RotateX = point3D.X;
        cube3D.RotateY = point3D.Y;
        cube3D.RotateZ = point3D.Z;

        Point origin = new Point(pbCube3D.Width / 2, pbCube3D.Height / 2);

        pbCube3D.Image = cube3D.drawCube(origin);
    }

    private void GetSerialPortList()
    {
        string[] portNameArray = SerialPort.GetPortNames();
        foreach (string port in portNameArray)
            cbPortName.Items.Add(port);

        if (portNameArray.Length > 0)
            cbPortName.SelectedIndex = 0;
    }


    private void ConnectToSerialPort()
    {
        if (cbPortName.SelectedIndex != -1)
        {
            serialPort.PortName = cbPortName.Text;
            serialPort.BaudRate = 115200;

            try
            {
                serialPort.Open();
                serialPort.DataReceived += serialPort_DataReceived;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open the Serial Port.");
            }
        }
        else
        {
            MessageBox.Show("Please select Serial Port");
        }

        if (serialPort.IsOpen)
            btnConnect.Text = "Disconnect";
    }

    private void Disconnect()
    {
        serialPort.Close();
        btnConnect.Text = "Connect";
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (serialPort.IsOpen)
            Disconnect();
        else
            ConnectToSerialPort();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        rtxtDataArea.Clear();
    }

    private void SendData(string str)
    {
        if (!serialPort.IsOpen)
            return;

        serialPort.Write(str);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (serialPort.IsOpen)
            serialPort.Close();
    }

    private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        if (!serialPort.IsOpen)
            return;

        string recievedString = serialPort.ReadLine().Replace("\r", "").Replace("\n", "");
        if (!string.IsNullOrWhiteSpace(recievedString))
            SerialPortParseReceived(recievedString);
    }

    private void SerialPortParseReceived(string recievedString)
    {
        BaseModel baseModel = ProtocolHelper.ParseBaseModel(recievedString);

        if (baseModel.type == "loadSettingsResult")
        {
            SettingsModel settingsModel = ProtocolHelper.ParseSettingsModel(recievedString);

            SetSettingsControl(settingsModel);
        }

        if (baseModel.type == "saveSettingsResult")
        {
            SaveSettingsResultModel saveSettingsResultModel = ProtocolHelper.ParseSaveSettingsResultModel(recievedString);

            if (saveSettingsResultModel.error == 0)
                MessageBox.Show("Save completed");
        }

        if (baseModel.type == "resetSettingsResult")
        {
            ResetSettingsResultModel resetSettingsResultModel =
                ProtocolHelper.ParseResetSettingsResultModel(recievedString);

            if (resetSettingsResultModel.error == 0)
                MessageBox.Show("Reset completed");
        }

        if (baseModel.type == "getStatusResult")
        {
            StatusModel statusModel = ProtocolHelper.ParseStatusModel(recievedString);

            SetStatusControl(statusModel);
        }

        SetReceiveLog(recievedString);
    }

    private void SetSettingsControl(SettingsModel settingsModel)
    {
        MethodInvoker methodInvokerDelegate = delegate()
        {
            tbWiFiSSID.Text = settingsModel.wifi_ssid;
            tbWiFiPass.Text = settingsModel.wifi_pass;
            cbSensorName.Text = settingsModel.sensor_name;
            tbMocapServer.Text = settingsModel.mocap_server;
            nudMocapServerPort.Text = settingsModel.mocap_server_port;
        };

        if (InvokeRequired)
            Invoke(methodInvokerDelegate);
        else
            methodInvokerDelegate();
    }

    private void SetStatusControl(StatusModel statusModel)
    {
        MethodInvoker methodInvokerDelegate = delegate()
        {
            pbWiFiStatus.Image = statusModel.wifi_status == 1
                ? GyroSensorReceiver.Properties.Resources.WiFiConnection
                : GyroSensorReceiver.Properties.Resources.WiFiNoConnection;
            tbIPAddress.Text = statusModel.local_ip;
        };

        if (InvokeRequired)
            Invoke(methodInvokerDelegate);
        else
            methodInvokerDelegate();
    }

    private void SetReceiveLog(string recievedData)
    {
        MethodInvoker methodInvokerDelegate = delegate()
        {
            rtxtDataArea.AppendText(recievedData + Environment.NewLine);
        };

        if (InvokeRequired)
            Invoke(methodInvokerDelegate);
        else
            methodInvokerDelegate();
    }

    private void btnLoadSettings_Click(object sender, EventArgs e)
    {
        object loadSettingsObject = new {type = "loadSettings"};
        string loadSettingsJSONString = JsonConvert.SerializeObject(loadSettingsObject);

        SendData(loadSettingsJSONString);
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
        string wifiSSID = tbWiFiSSID.Text;
        string wifiPass = tbWiFiPass.Text;
        string sensorName = cbSensorName.Text;
        string mocapServer = tbMocapServer.Text;
        string mocapServerPort = nudMocapServerPort.Text.ToString();

        object saveSettingsObject = new
        {
            type = "saveSettings",
            wifi_ssid = wifiSSID,
            wifi_pass = wifiPass,
            sensor_name = sensorName,
            mocap_server = mocapServer,
            mocap_server_port = mocapServerPort
        };

        string saveSettingsJSONString = JsonConvert.SerializeObject(saveSettingsObject);
        SendData(saveSettingsJSONString);
    }

    private void btnResetSettings_Click(object sender, EventArgs e)
    {
        object resetSettingsObject = new {type = "resetSettings"};
        string resetSettingsJSONString = JsonConvert.SerializeObject(resetSettingsObject);

        SendData(resetSettingsJSONString);
    }

    private void btnGetStatus_Click(object sender, EventArgs e)
    {
        object getStatusObject = new {type = "getStatus"};
        string getStatusJSONString = JsonConvert.SerializeObject(getStatusObject);

        SendData(getStatusJSONString);
    }

    private void btnStartUDPServer_Click(object sender, EventArgs e)
    {
        if (recieveUDPServer.udpSocket == null || !recieveUDPServer.udpSocket.IsBound)
        {
            recieveUDPServer = new UDPAsyncSocket();
            recieveUDPServer.StartServer((int)nudUDPServerRecieverPort.Value);
        }
    }

    private void btnStartUDPClientSender_Click(object sender, EventArgs e)
    {
        if (senderUDPClient.udpSocket != null)
            if (senderUDPClient.udpSocket.Connected)
                senderUDPClient.udpSocket.Close();

        senderUDPClient = new UDPAsyncSocket();
        senderUDPClient.StartClient("127.0.0.1", (int) nudUDPClientSenderPort.Value);
    }

    private void btnCalibration_Click(object sender, EventArgs e)
    {
        sensorCalibration = new SensorCalibration();
    }
}
