using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private readonly SerialPort _serialPort = new SerialPort();

    SensorCalibration _sensorCalibration = new SensorCalibration();

    UDPAsyncSocket _receiveUdpServer = new UDPAsyncSocket();
    UDPAsyncSocket _senderUdpClient = new UDPAsyncSocket();

    readonly Cube3D _cube3D = new Cube3D(100);

    readonly FilterQuaternion _filterQuaternion = new FilterQuaternion(0.1f, 2.5f, 5, 15);

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

        EventReceiveUDPServer eventReceiveUdpServer = new EventReceiveUDPServer();
        Eventing.eventReceiveUDPServer = eventReceiveUdpServer;
        Eventing.eventReceiveUDPServer.OnNewReceiveUDPServer += OnNewReceiveUdpServerEvent;
    }

    void OnNewReceiveUdpServerEvent(object sender, NewEventReceiveUDPServerArgs e)
    {
        try
        {
            _sensorCalibration.Push(e.ReceiveUDPServerMessage);

            GyroQuaternion gyroQuaternionInverse = GyroQuaternion.Inverse(e.ReceiveUDPServerMessage);
            GyroQuaternion gyroQuaternionCalibrationResult = _sensorCalibration.GetCalibrationResult(e.ReceiveUDPServerMessage.sensorName);

            if (gyroQuaternionCalibrationResult != null)
            {
                GyroQuaternion gyroQuaternion = GyroQuaternion.Multiply(gyroQuaternionInverse, gyroQuaternionCalibrationResult);

                gyroQuaternion = GetSettingsAxis(gyroQuaternion);

                if (_senderUdpClient.UdpSocket != null && _senderUdpClient.UdpSocket.Connected)
                    _senderUdpClient.Send(gyroQuaternion);

                if (e.ReceiveUDPServerMessage.sensorName == GetSelectorSensorValue())
                {
                    gyroQuaternion = _filterQuaternion.Filter(gyroQuaternion);

                    Cube3DRender(gyroQuaternion);
                }

            }
        }
        catch (Exception)
        {
            // ignored
        }
    }

    private GyroQuaternion GetSettingsAxis(GyroQuaternion gyroQuaternion)
    {
        float tmpX = 0, tmpY = 0, tmpZ = 0, tmpW = 0;

        void MethodInvokerDelegate()
        {
            switch (cbReplaceAxisX.SelectedIndex)
            {
                case 0:
                    tmpX = gyroQuaternion.qX;
                    break;
                case 1:
                    tmpX = gyroQuaternion.qY;
                    break;
                case 2:
                    tmpX = gyroQuaternion.qZ;
                    break;
            }

            switch (cbReplaceAxisY.SelectedIndex)
            {
                case 0:
                    tmpY = gyroQuaternion.qX;
                    break;
                case 1:
                    tmpY = gyroQuaternion.qY;
                    break;
                case 2:
                    tmpY = gyroQuaternion.qZ;
                    break;
            }

            switch (cbReplaceAxisZ.SelectedIndex)
            {
                case 0:
                    tmpZ = gyroQuaternion.qX;
                    break;
                case 1:
                    tmpZ = gyroQuaternion.qY;
                    break;
                case 2:
                    tmpZ = gyroQuaternion.qZ;
                    break;
            }

            tmpW = gyroQuaternion.qW;

            if (chbInverseAxisX.Checked) tmpX *= -1;
            if (chbInverseAxisY.Checked) tmpY *= -1;
            if (chbInverseAxisZ.Checked) tmpZ *= -1;
        }

        if (InvokeRequired)
            Invoke((MethodInvoker) MethodInvokerDelegate);
        else
            MethodInvokerDelegate();

        return new GyroQuaternion(gyroQuaternion.sensorName, tmpX, tmpY, tmpZ, tmpW);
    }


    private string GetSelectorSensorValue()
    {
        string selectorSensorValue = string.Empty;

        void MethodInvokerDelegate()
        {
            selectorSensorValue = cbSelectorSensor.Text;
        }

        if (InvokeRequired)
            Invoke((MethodInvoker) MethodInvokerDelegate);
        else
            MethodInvokerDelegate();

        return selectorSensorValue;
    }

    private void Cube3DRender(GyroQuaternion quat)
    {
        Point3D point3D = GyroQuaternion.QuatToEuler(quat);

        _cube3D.RotateX = point3D.X;
        _cube3D.RotateY = point3D.Y;
        _cube3D.RotateZ = point3D.Z;

        Point origin = new Point(pbCube3D.Width / 2, pbCube3D.Height / 2);

        pbCube3D.Image = _cube3D.DrawCube(origin);
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
            _serialPort.PortName = cbPortName.Text;
            _serialPort.BaudRate = 115200;

            try
            {
                _serialPort.Open();
                _serialPort.DataReceived += serialPort_DataReceived;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Could not open the Serial Port.");
            }
        }
        else
        {
            MessageBox.Show(@"Please select Serial Port");
        }

        if (_serialPort.IsOpen)
            btnConnect.Text = @"Disconnect";
    }

    private void Disconnect()
    {
        _serialPort.Close();
        btnConnect.Text = @"Connect";
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (_serialPort.IsOpen)
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
        if (!_serialPort.IsOpen)
            return;

        _serialPort.Write(str);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_serialPort.IsOpen)
            _serialPort.Close();
    }

    private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        if (!_serialPort.IsOpen)
            return;

        string receivedString = _serialPort.ReadLine().Replace("\r", "").Replace("\n", "");
        if (!string.IsNullOrWhiteSpace(receivedString))
            SerialPortParseReceived(receivedString);
    }

    private void SerialPortParseReceived(string receivedString)
    {
        BaseModel baseModel = ProtocolHelper.ParseBaseModel(receivedString);

        if (baseModel.type == "loadSettingsResult")
        {
            SettingsModel settingsModel = ProtocolHelper.ParseSettingsModel(receivedString);

            SetSettingsControl(settingsModel);
        }

        if (baseModel.type == "saveSettingsResult")
        {
            SaveSettingsResultModel saveSettingsResultModel = ProtocolHelper.ParseSaveSettingsResultModel(receivedString);

            if (saveSettingsResultModel.error == 0)
                MessageBox.Show(@"Save completed");
        }

        if (baseModel.type == "resetSettingsResult")
        {
            ResetSettingsResultModel resetSettingsResultModel = ProtocolHelper.ParseResetSettingsResultModel(receivedString);

            if (resetSettingsResultModel.error == 0)
                MessageBox.Show(@"Reset completed");
        }

        if (baseModel.type == "getStatusResult")
        {
            StatusModel statusModel = ProtocolHelper.ParseStatusModel(receivedString);

            SetStatusControl(statusModel);
        }

        SetReceiveLog(receivedString);
    }

    private void SetSettingsControl(SettingsModel settingsModel)
    {
        void MethodInvokerDelegate()
        {
            tbWiFiSSID.Text = settingsModel.wifi_ssid;
            tbWiFiPass.Text = settingsModel.wifi_pass;
            cbSensorName.Text = settingsModel.sensor_name;
            tbMocapServer.Text = settingsModel.mocap_server;
            nudMocapServerPort.Text = settingsModel.mocap_server_port;
        }

        if (InvokeRequired)
            Invoke((MethodInvoker) MethodInvokerDelegate);
        else
            MethodInvokerDelegate();
    }

    private void SetStatusControl(StatusModel statusModel)
    {
        void MethodInvokerDelegate()
        {
            pbWiFiStatus.Image = statusModel.wifi_status == 1
                ? GyroSensorReceiver.Properties.Resources.WiFiConnection
                : GyroSensorReceiver.Properties.Resources.WiFiNoConnection;
            tbIPAddress.Text = statusModel.local_ip;
        }

        if (InvokeRequired)
            Invoke((MethodInvoker) MethodInvokerDelegate);
        else
            MethodInvokerDelegate();
    }

    private void SetReceiveLog(string receivedData)
    {
        void MethodInvokerDelegate()
        {
            rtxtDataArea.AppendText(receivedData + Environment.NewLine);
        }

        if (InvokeRequired)
            Invoke((MethodInvoker) MethodInvokerDelegate);
        else
            MethodInvokerDelegate();
    }

    private void btnLoadSettings_Click(object sender, EventArgs e)
    {
        object loadSettingsObject = new {type = "loadSettings"};
        string loadSettingsJsonString = JsonConvert.SerializeObject(loadSettingsObject);

        SendData(loadSettingsJsonString);
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
        string wifiSsid = tbWiFiSSID.Text;
        string wifiPass = tbWiFiPass.Text;
        string sensorName = cbSensorName.Text;
        string mocapServer = tbMocapServer.Text;
        string mocapServerPort = nudMocapServerPort.Text;

        object saveSettingsObject = new
        {
            type = "saveSettings",
            wifi_ssid = wifiSsid,
            wifi_pass = wifiPass,
            sensor_name = sensorName,
            mocap_server = mocapServer,
            mocap_server_port = mocapServerPort
        };

        string saveSettingsJsonString = JsonConvert.SerializeObject(saveSettingsObject);
        SendData(saveSettingsJsonString);
    }

    private void btnResetSettings_Click(object sender, EventArgs e)
    {
        object resetSettingsObject = new {type = "resetSettings"};
        string resetSettingsJsonString = JsonConvert.SerializeObject(resetSettingsObject);

        SendData(resetSettingsJsonString);
    }

    private void btnGetStatus_Click(object sender, EventArgs e)
    {
        object getStatusObject = new {type = "getStatus"};
        string getStatusJsonString = JsonConvert.SerializeObject(getStatusObject);

        SendData(getStatusJsonString);
    }

    private void btnStartUDPServer_Click(object sender, EventArgs e)
    {
        if (_receiveUdpServer.UdpSocket == null || !_receiveUdpServer.UdpSocket.IsBound)
        {
            _receiveUdpServer = new UDPAsyncSocket();
            _receiveUdpServer.StartServer((int)nudUDPServerRecieverPort.Value);
        }
    }

    private void btnStartUDPClientSender_Click(object sender, EventArgs e)
    {
        if (_senderUdpClient.UdpSocket != null)
            if (_senderUdpClient.UdpSocket.Connected)
                _senderUdpClient.UdpSocket.Close();

        _senderUdpClient = new UDPAsyncSocket();
        _senderUdpClient.StartClient("127.0.0.1", (int) nudUDPClientSenderPort.Value);
    }

    private void btnCalibration_Click(object sender, EventArgs e)
    {
        _sensorCalibration = new SensorCalibration();
    }
}
