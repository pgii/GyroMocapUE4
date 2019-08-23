partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label2 = new System.Windows.Forms.Label();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.rtxtDataArea = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSensorName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.pbWiFiStatus = new System.Windows.Forms.PictureBox();
            this.lblWiFiStatus = new System.Windows.Forms.Label();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.nudMocapServerPort = new System.Windows.Forms.NumericUpDown();
            this.lblWiFiSSID = new System.Windows.Forms.Label();
            this.lblMocapServerPort = new System.Windows.Forms.Label();
            this.tbWiFiSSID = new System.Windows.Forms.TextBox();
            this.tbMocapServer = new System.Windows.Forms.TextBox();
            this.lblWiFiPass = new System.Windows.Forms.Label();
            this.lblMocapServer = new System.Windows.Forms.Label();
            this.tbWiFiPass = new System.Windows.Forms.TextBox();
            this.lblSensorName = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTuner = new System.Windows.Forms.TabPage();
            this.tabReciever = new System.Windows.Forms.TabPage();
            this.pbCube3D = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbSelectorSensor = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chbInverseAxisX = new System.Windows.Forms.CheckBox();
            this.cbReplaceAxisX = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chbInverseAxisZ = new System.Windows.Forms.CheckBox();
            this.cbReplaceAxisZ = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chbInverseAxisY = new System.Windows.Forms.CheckBox();
            this.cbReplaceAxisY = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudUDPClientSenderPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartUDPClientSender = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudUDPServerRecieverPort = new System.Windows.Forms.NumericUpDown();
            this.lblUDPServerPort = new System.Windows.Forms.Label();
            this.btnStartUDPServerReciever = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWiFiStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMocapServerPort)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabTuner.SuspendLayout();
            this.tabReciever.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCube3D)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUDPClientSenderPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUDPServerRecieverPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serial port:";
            // 
            // cbPortName
            // 
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(94, 20);
            this.cbPortName.Margin = new System.Windows.Forms.Padding(4);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(160, 24);
            this.cbPortName.TabIndex = 0;
            this.cbPortName.Text = "Select Port Name";
            // 
            // rtxtDataArea
            // 
            this.rtxtDataArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDataArea.Location = new System.Drawing.Point(12, 256);
            this.rtxtDataArea.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDataArea.Name = "rtxtDataArea";
            this.rtxtDataArea.ReadOnly = true;
            this.rtxtDataArea.Size = new System.Drawing.Size(737, 138);
            this.rtxtDataArea.TabIndex = 2;
            this.rtxtDataArea.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(262, 13);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 36);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 402);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSensorName);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnLoadSettings);
            this.groupBox2.Controls.Add(this.btnResetSettings);
            this.groupBox2.Controls.Add(this.btnSaveSettings);
            this.groupBox2.Controls.Add(this.nudMocapServerPort);
            this.groupBox2.Controls.Add(this.lblWiFiSSID);
            this.groupBox2.Controls.Add(this.lblMocapServerPort);
            this.groupBox2.Controls.Add(this.tbWiFiSSID);
            this.groupBox2.Controls.Add(this.tbMocapServer);
            this.groupBox2.Controls.Add(this.lblWiFiPass);
            this.groupBox2.Controls.Add(this.lblMocapServer);
            this.groupBox2.Controls.Add(this.tbWiFiPass);
            this.groupBox2.Controls.Add(this.lblSensorName);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 188);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // cbSensorName
            // 
            this.cbSensorName.FormattingEnabled = true;
            this.cbSensorName.Items.AddRange(new object[] {
            "None",
            "GyroSensor01",
            "GyroSensor02",
            "GyroSensor03"});
            this.cbSensorName.Location = new System.Drawing.Point(413, 87);
            this.cbSensorName.Name = "cbSensorName";
            this.cbSensorName.Size = new System.Drawing.Size(140, 24);
            this.cbSensorName.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIPAddress);
            this.groupBox1.Controls.Add(this.btnGetStatus);
            this.groupBox1.Controls.Add(this.lblIPAddress);
            this.groupBox1.Controls.Add(this.pbWiFiStatus);
            this.groupBox1.Controls.Add(this.lblWiFiStatus);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 143);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(92, 47);
            this.tbIPAddress.MaxLength = 15;
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.ReadOnly = true;
            this.tbIPAddress.Size = new System.Drawing.Size(113, 22);
            this.tbIPAddress.TabIndex = 15;
            this.tbIPAddress.Text = "127.0.0.1";
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(43, 78);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(136, 36);
            this.btnGetStatus.TabIndex = 19;
            this.btnGetStatus.Text = "Get Status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(7, 50);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(79, 17);
            this.lblIPAddress.TabIndex = 2;
            this.lblIPAddress.Text = "IP address:";
            // 
            // pbWiFiStatus
            // 
            this.pbWiFiStatus.Image = global::GyroSensorReceiver.Properties.Resources.WiFiNoConnection;
            this.pbWiFiStatus.Location = new System.Drawing.Point(175, 14);
            this.pbWiFiStatus.Name = "pbWiFiStatus";
            this.pbWiFiStatus.Size = new System.Drawing.Size(30, 30);
            this.pbWiFiStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWiFiStatus.TabIndex = 1;
            this.pbWiFiStatus.TabStop = false;
            // 
            // lblWiFiStatus
            // 
            this.lblWiFiStatus.AutoSize = true;
            this.lblWiFiStatus.Location = new System.Drawing.Point(7, 22);
            this.lblWiFiStatus.Name = "lblWiFiStatus";
            this.lblWiFiStatus.Size = new System.Drawing.Size(86, 17);
            this.lblWiFiStatus.TabIndex = 0;
            this.lblWiFiStatus.Text = "Wi-Fi status:";
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(579, 32);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(136, 36);
            this.btnLoadSettings.TabIndex = 46;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Location = new System.Drawing.Point(579, 119);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(136, 36);
            this.btnResetSettings.TabIndex = 58;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(579, 75);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(136, 36);
            this.btnSaveSettings.TabIndex = 47;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // nudMocapServerPort
            // 
            this.nudMocapServerPort.Location = new System.Drawing.Point(413, 144);
            this.nudMocapServerPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMocapServerPort.Name = "nudMocapServerPort";
            this.nudMocapServerPort.Size = new System.Drawing.Size(140, 22);
            this.nudMocapServerPort.TabIndex = 57;
            this.nudMocapServerPort.Value = new decimal(new int[] {
            7755,
            0,
            0,
            0});
            // 
            // lblWiFiSSID
            // 
            this.lblWiFiSSID.AutoSize = true;
            this.lblWiFiSSID.Location = new System.Drawing.Point(280, 38);
            this.lblWiFiSSID.Name = "lblWiFiSSID";
            this.lblWiFiSSID.Size = new System.Drawing.Size(79, 17);
            this.lblWiFiSSID.TabIndex = 48;
            this.lblWiFiSSID.Text = "Wi-Fi SSID:";
            // 
            // lblMocapServerPort
            // 
            this.lblMocapServerPort.AutoSize = true;
            this.lblMocapServerPort.Location = new System.Drawing.Point(280, 149);
            this.lblMocapServerPort.Name = "lblMocapServerPort";
            this.lblMocapServerPort.Size = new System.Drawing.Size(127, 17);
            this.lblMocapServerPort.TabIndex = 56;
            this.lblMocapServerPort.Text = "Mocap server port:";
            // 
            // tbWiFiSSID
            // 
            this.tbWiFiSSID.Location = new System.Drawing.Point(413, 33);
            this.tbWiFiSSID.MaxLength = 15;
            this.tbWiFiSSID.Name = "tbWiFiSSID";
            this.tbWiFiSSID.Size = new System.Drawing.Size(140, 22);
            this.tbWiFiSSID.TabIndex = 49;
            this.tbWiFiSSID.Text = "wifi_ssid";
            // 
            // tbMocapServer
            // 
            this.tbMocapServer.Location = new System.Drawing.Point(413, 116);
            this.tbMocapServer.MaxLength = 15;
            this.tbMocapServer.Name = "tbMocapServer";
            this.tbMocapServer.Size = new System.Drawing.Size(140, 22);
            this.tbMocapServer.TabIndex = 55;
            this.tbMocapServer.Text = "127.0.0.1";
            // 
            // lblWiFiPass
            // 
            this.lblWiFiPass.AutoSize = true;
            this.lblWiFiPass.Location = new System.Drawing.Point(280, 66);
            this.lblWiFiPass.Name = "lblWiFiPass";
            this.lblWiFiPass.Size = new System.Drawing.Size(79, 17);
            this.lblWiFiPass.TabIndex = 50;
            this.lblWiFiPass.Text = "Wi-Fi Pass:";
            // 
            // lblMocapServer
            // 
            this.lblMocapServer.AutoSize = true;
            this.lblMocapServer.Location = new System.Drawing.Point(280, 121);
            this.lblMocapServer.Name = "lblMocapServer";
            this.lblMocapServer.Size = new System.Drawing.Size(98, 17);
            this.lblMocapServer.TabIndex = 54;
            this.lblMocapServer.Text = "Mocap server:";
            // 
            // tbWiFiPass
            // 
            this.tbWiFiPass.Location = new System.Drawing.Point(413, 61);
            this.tbWiFiPass.MaxLength = 15;
            this.tbWiFiPass.Name = "tbWiFiPass";
            this.tbWiFiPass.PasswordChar = '*';
            this.tbWiFiPass.Size = new System.Drawing.Size(140, 22);
            this.tbWiFiPass.TabIndex = 51;
            this.tbWiFiPass.Text = "wifi_pass";
            // 
            // lblSensorName
            // 
            this.lblSensorName.AutoSize = true;
            this.lblSensorName.Location = new System.Drawing.Point(280, 94);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(96, 17);
            this.lblSensorName.TabIndex = 52;
            this.lblSensorName.Text = "Sensor name:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTuner);
            this.tabControl.Controls.Add(this.tabReciever);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(771, 481);
            this.tabControl.TabIndex = 48;
            // 
            // tabTuner
            // 
            this.tabTuner.Controls.Add(this.label2);
            this.tabTuner.Controls.Add(this.groupBox2);
            this.tabTuner.Controls.Add(this.btnClear);
            this.tabTuner.Controls.Add(this.rtxtDataArea);
            this.tabTuner.Controls.Add(this.cbPortName);
            this.tabTuner.Controls.Add(this.btnConnect);
            this.tabTuner.Location = new System.Drawing.Point(4, 25);
            this.tabTuner.Name = "tabTuner";
            this.tabTuner.Padding = new System.Windows.Forms.Padding(3);
            this.tabTuner.Size = new System.Drawing.Size(763, 452);
            this.tabTuner.TabIndex = 0;
            this.tabTuner.Text = "Tuner";
            this.tabTuner.UseVisualStyleBackColor = true;
            // 
            // tabReciever
            // 
            this.tabReciever.Controls.Add(this.pbCube3D);
            this.tabReciever.Controls.Add(this.groupBox10);
            this.tabReciever.Controls.Add(this.groupBox9);
            this.tabReciever.Controls.Add(this.groupBox4);
            this.tabReciever.Controls.Add(this.groupBox3);
            this.tabReciever.Location = new System.Drawing.Point(4, 25);
            this.tabReciever.Name = "tabReciever";
            this.tabReciever.Padding = new System.Windows.Forms.Padding(3);
            this.tabReciever.Size = new System.Drawing.Size(763, 452);
            this.tabReciever.TabIndex = 1;
            this.tabReciever.Text = "Reciever";
            this.tabReciever.UseVisualStyleBackColor = true;
            // 
            // pbCube3D
            // 
            this.pbCube3D.Location = new System.Drawing.Point(87, 133);
            this.pbCube3D.Margin = new System.Windows.Forms.Padding(4);
            this.pbCube3D.Name = "pbCube3D";
            this.pbCube3D.Size = new System.Drawing.Size(300, 300);
            this.pbCube3D.TabIndex = 15;
            this.pbCube3D.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox5);
            this.groupBox10.Controls.Add(this.groupBox8);
            this.groupBox10.Controls.Add(this.groupBox6);
            this.groupBox10.Controls.Add(this.groupBox7);
            this.groupBox10.Location = new System.Drawing.Point(543, 83);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(212, 350);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Quaternion Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbSelectorSensor);
            this.groupBox5.Location = new System.Drawing.Point(6, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 59);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select sensor";
            // 
            // cbSelectorSensor
            // 
            this.cbSelectorSensor.FormattingEnabled = true;
            this.cbSelectorSensor.Items.AddRange(new object[] {
            "None",
            "GyroSensor01",
            "GyroSensor02",
            "GyroSensor03"});
            this.cbSelectorSensor.Location = new System.Drawing.Point(7, 22);
            this.cbSelectorSensor.Name = "cbSelectorSensor";
            this.cbSelectorSensor.Size = new System.Drawing.Size(187, 24);
            this.cbSelectorSensor.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chbInverseAxisX);
            this.groupBox8.Controls.Add(this.cbReplaceAxisX);
            this.groupBox8.Location = new System.Drawing.Point(6, 91);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 80);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Axis X";
            // 
            // chbInverseAxisX
            // 
            this.chbInverseAxisX.AutoSize = true;
            this.chbInverseAxisX.Location = new System.Drawing.Point(7, 53);
            this.chbInverseAxisX.Name = "chbInverseAxisX";
            this.chbInverseAxisX.Size = new System.Drawing.Size(76, 21);
            this.chbInverseAxisX.TabIndex = 1;
            this.chbInverseAxisX.Text = "Inverse";
            this.chbInverseAxisX.UseVisualStyleBackColor = true;
            // 
            // cbReplaceAxisX
            // 
            this.cbReplaceAxisX.FormattingEnabled = true;
            this.cbReplaceAxisX.Items.AddRange(new object[] {
            "Axis X",
            "Axis Y",
            "Axis Z"});
            this.cbReplaceAxisX.Location = new System.Drawing.Point(7, 22);
            this.cbReplaceAxisX.Name = "cbReplaceAxisX";
            this.cbReplaceAxisX.Size = new System.Drawing.Size(187, 24);
            this.cbReplaceAxisX.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chbInverseAxisZ);
            this.groupBox6.Controls.Add(this.cbReplaceAxisZ);
            this.groupBox6.Location = new System.Drawing.Point(6, 263);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 80);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Axis Z";
            // 
            // chbInverseAxisZ
            // 
            this.chbInverseAxisZ.AutoSize = true;
            this.chbInverseAxisZ.Location = new System.Drawing.Point(7, 53);
            this.chbInverseAxisZ.Name = "chbInverseAxisZ";
            this.chbInverseAxisZ.Size = new System.Drawing.Size(76, 21);
            this.chbInverseAxisZ.TabIndex = 1;
            this.chbInverseAxisZ.Text = "Inverse";
            this.chbInverseAxisZ.UseVisualStyleBackColor = true;
            // 
            // cbReplaceAxisZ
            // 
            this.cbReplaceAxisZ.FormattingEnabled = true;
            this.cbReplaceAxisZ.Items.AddRange(new object[] {
            "Axis X",
            "Axis Y",
            "Axis Z"});
            this.cbReplaceAxisZ.Location = new System.Drawing.Point(7, 22);
            this.cbReplaceAxisZ.Name = "cbReplaceAxisZ";
            this.cbReplaceAxisZ.Size = new System.Drawing.Size(187, 24);
            this.cbReplaceAxisZ.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chbInverseAxisY);
            this.groupBox7.Controls.Add(this.cbReplaceAxisY);
            this.groupBox7.Location = new System.Drawing.Point(6, 177);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 80);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Axis Y";
            // 
            // chbInverseAxisY
            // 
            this.chbInverseAxisY.AutoSize = true;
            this.chbInverseAxisY.Location = new System.Drawing.Point(7, 53);
            this.chbInverseAxisY.Name = "chbInverseAxisY";
            this.chbInverseAxisY.Size = new System.Drawing.Size(76, 21);
            this.chbInverseAxisY.TabIndex = 1;
            this.chbInverseAxisY.Text = "Inverse";
            this.chbInverseAxisY.UseVisualStyleBackColor = true;
            // 
            // cbReplaceAxisY
            // 
            this.cbReplaceAxisY.FormattingEnabled = true;
            this.cbReplaceAxisY.Items.AddRange(new object[] {
            "Axis X",
            "Axis Y",
            "Axis Z"});
            this.cbReplaceAxisY.Location = new System.Drawing.Point(7, 22);
            this.cbReplaceAxisY.Name = "cbReplaceAxisY";
            this.cbReplaceAxisY.Size = new System.Drawing.Size(187, 24);
            this.cbReplaceAxisY.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnCalibration);
            this.groupBox9.Location = new System.Drawing.Point(543, 10);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(212, 67);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Calibration";
            // 
            // btnCalibration
            // 
            this.btnCalibration.Location = new System.Drawing.Point(6, 21);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(200, 36);
            this.btnCalibration.TabIndex = 10;
            this.btnCalibration.Text = "Calibration";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudUDPClientSenderPort);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnStartUDPClientSender);
            this.groupBox4.Location = new System.Drawing.Point(246, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UDP Client Sender";
            // 
            // nudUDPClientSenderPort
            // 
            this.nudUDPClientSenderPort.Location = new System.Drawing.Point(59, 27);
            this.nudUDPClientSenderPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudUDPClientSenderPort.Name = "nudUDPClientSenderPort";
            this.nudUDPClientSenderPort.Size = new System.Drawing.Size(82, 22);
            this.nudUDPClientSenderPort.TabIndex = 58;
            this.nudUDPClientSenderPort.Value = new decimal(new int[] {
            8855,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // btnStartUDPClientSender
            // 
            this.btnStartUDPClientSender.Location = new System.Drawing.Point(14, 55);
            this.btnStartUDPClientSender.Name = "btnStartUDPClientSender";
            this.btnStartUDPClientSender.Size = new System.Drawing.Size(203, 36);
            this.btnStartUDPClientSender.TabIndex = 1;
            this.btnStartUDPClientSender.Text = "Start UDP Client Sender";
            this.btnStartUDPClientSender.UseVisualStyleBackColor = true;
            this.btnStartUDPClientSender.Click += new System.EventHandler(this.btnStartUDPClientSender_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudUDPServerRecieverPort);
            this.groupBox3.Controls.Add(this.lblUDPServerPort);
            this.groupBox3.Controls.Add(this.btnStartUDPServerReciever);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UDP Server Reciever";
            // 
            // nudUDPServerRecieverPort
            // 
            this.nudUDPServerRecieverPort.Location = new System.Drawing.Point(59, 27);
            this.nudUDPServerRecieverPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudUDPServerRecieverPort.Name = "nudUDPServerRecieverPort";
            this.nudUDPServerRecieverPort.Size = new System.Drawing.Size(82, 22);
            this.nudUDPServerRecieverPort.TabIndex = 58;
            this.nudUDPServerRecieverPort.Value = new decimal(new int[] {
            7755,
            0,
            0,
            0});
            // 
            // lblUDPServerPort
            // 
            this.lblUDPServerPort.AutoSize = true;
            this.lblUDPServerPort.Location = new System.Drawing.Point(15, 32);
            this.lblUDPServerPort.Name = "lblUDPServerPort";
            this.lblUDPServerPort.Size = new System.Drawing.Size(38, 17);
            this.lblUDPServerPort.TabIndex = 2;
            this.lblUDPServerPort.Text = "Port:";
            // 
            // btnStartUDPServerReciever
            // 
            this.btnStartUDPServerReciever.Location = new System.Drawing.Point(14, 55);
            this.btnStartUDPServerReciever.Name = "btnStartUDPServerReciever";
            this.btnStartUDPServerReciever.Size = new System.Drawing.Size(203, 36);
            this.btnStartUDPServerReciever.TabIndex = 1;
            this.btnStartUDPServerReciever.Text = "Start UDP Server Reciever";
            this.btnStartUDPServerReciever.UseVisualStyleBackColor = true;
            this.btnStartUDPServerReciever.Click += new System.EventHandler(this.btnStartUDPServer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 481);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyro Sensor Receiver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWiFiStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMocapServerPort)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabTuner.ResumeLayout(false);
            this.tabTuner.PerformLayout();
            this.tabReciever.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCube3D)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUDPClientSenderPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUDPServerRecieverPort)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbPortName;
    private System.Windows.Forms.RichTextBox rtxtDataArea;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox tbIPAddress;
    private System.Windows.Forms.Button btnGetStatus;
    private System.Windows.Forms.Label lblIPAddress;
    private System.Windows.Forms.PictureBox pbWiFiStatus;
    private System.Windows.Forms.Label lblWiFiStatus;
    private System.Windows.Forms.Button btnLoadSettings;
    private System.Windows.Forms.Button btnResetSettings;
    private System.Windows.Forms.Button btnSaveSettings;
    private System.Windows.Forms.NumericUpDown nudMocapServerPort;
    private System.Windows.Forms.Label lblWiFiSSID;
    private System.Windows.Forms.Label lblMocapServerPort;
    private System.Windows.Forms.TextBox tbWiFiSSID;
    private System.Windows.Forms.TextBox tbMocapServer;
    private System.Windows.Forms.Label lblWiFiPass;
    private System.Windows.Forms.Label lblMocapServer;
    private System.Windows.Forms.TextBox tbWiFiPass;
    private System.Windows.Forms.Label lblSensorName;
    private System.Windows.Forms.ComboBox cbSensorName;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabTuner;
    private System.Windows.Forms.TabPage tabReciever;
    private System.Windows.Forms.Button btnStartUDPServerReciever;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lblUDPServerPort;
    private System.Windows.Forms.NumericUpDown nudUDPServerRecieverPort;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.NumericUpDown nudUDPClientSenderPort;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnStartUDPClientSender;
    private System.Windows.Forms.Button btnCalibration;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.ComboBox cbSelectorSensor;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.CheckBox chbInverseAxisZ;
    private System.Windows.Forms.ComboBox cbReplaceAxisZ;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.CheckBox chbInverseAxisY;
    private System.Windows.Forms.ComboBox cbReplaceAxisY;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.CheckBox chbInverseAxisX;
    private System.Windows.Forms.ComboBox cbReplaceAxisX;
    private System.Windows.Forms.GroupBox groupBox10;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.PictureBox pbCube3D;
}


