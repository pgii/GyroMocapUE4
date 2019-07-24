using Newtonsoft.Json;
using System;
using System.IO.Ports;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private SerialPort serialPort = new SerialPort();

    public MainForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        GetSerialPortList();
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
            tbSensorName.Text = settingsModel.sensor_name;
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
                ? SensorTuner.Properties.Resources.WiFiConnection
                : SensorTuner.Properties.Resources.WiFiNoConnection;
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
        string sensorName = tbSensorName.Text;
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

    private void rbBone_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton radioButton = (RadioButton) sender;
        tbSensorName.Text = radioButton.Tag.ToString();
    }
}
