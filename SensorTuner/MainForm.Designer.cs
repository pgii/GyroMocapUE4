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
            this.tbSensorName = new System.Windows.Forms.TextBox();
            this.lblSensorName = new System.Windows.Forms.Label();
            this.transparentPanel1 = new TransparentPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFootL = new System.Windows.Forms.RadioButton();
            this.rbHead = new System.Windows.Forms.RadioButton();
            this.rbFootR = new System.Windows.Forms.RadioButton();
            this.rbSpine03 = new System.Windows.Forms.RadioButton();
            this.rbCalfL = new System.Windows.Forms.RadioButton();
            this.rbSpine01 = new System.Windows.Forms.RadioButton();
            this.rbCalfR = new System.Windows.Forms.RadioButton();
            this.rbClavicleR = new System.Windows.Forms.RadioButton();
            this.rbThighL = new System.Windows.Forms.RadioButton();
            this.rbClavicleL = new System.Windows.Forms.RadioButton();
            this.rbThighR = new System.Windows.Forms.RadioButton();
            this.rbUpperArmR = new System.Windows.Forms.RadioButton();
            this.rbHandL = new System.Windows.Forms.RadioButton();
            this.rbUpperArmL = new System.Windows.Forms.RadioButton();
            this.rbHandR = new System.Windows.Forms.RadioButton();
            this.rbLowerArmR = new System.Windows.Forms.RadioButton();
            this.rbLowerArmL = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWiFiStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMocapServerPort)).BeginInit();
            this.transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serial port:";
            // 
            // cbPortName
            // 
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(101, 20);
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
            this.rtxtDataArea.Location = new System.Drawing.Point(19, 256);
            this.rtxtDataArea.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDataArea.Name = "rtxtDataArea";
            this.rtxtDataArea.ReadOnly = true;
            this.rtxtDataArea.Size = new System.Drawing.Size(737, 138);
            this.rtxtDataArea.TabIndex = 2;
            this.rtxtDataArea.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(269, 13);
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
            this.btnClear.Location = new System.Drawing.Point(19, 402);
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
            this.groupBox2.Controls.Add(this.tbSensorName);
            this.groupBox2.Controls.Add(this.lblSensorName);
            this.groupBox2.Location = new System.Drawing.Point(19, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 188);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
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
            this.pbWiFiStatus.Image = global::SensorTuner.Properties.Resources.WiFiNoConnection;
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
            // tbSensorName
            // 
            this.tbSensorName.Location = new System.Drawing.Point(413, 89);
            this.tbSensorName.MaxLength = 13;
            this.tbSensorName.Name = "tbSensorName";
            this.tbSensorName.Size = new System.Drawing.Size(140, 22);
            this.tbSensorName.TabIndex = 53;
            this.tbSensorName.Text = "GyroSensor00";
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
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.label3);
            this.transparentPanel1.Controls.Add(this.label1);
            this.transparentPanel1.Controls.Add(this.rbFootL);
            this.transparentPanel1.Controls.Add(this.rbHead);
            this.transparentPanel1.Controls.Add(this.rbFootR);
            this.transparentPanel1.Controls.Add(this.rbSpine03);
            this.transparentPanel1.Controls.Add(this.rbCalfL);
            this.transparentPanel1.Controls.Add(this.rbSpine01);
            this.transparentPanel1.Controls.Add(this.rbCalfR);
            this.transparentPanel1.Controls.Add(this.rbClavicleR);
            this.transparentPanel1.Controls.Add(this.rbThighL);
            this.transparentPanel1.Controls.Add(this.rbClavicleL);
            this.transparentPanel1.Controls.Add(this.rbThighR);
            this.transparentPanel1.Controls.Add(this.rbUpperArmR);
            this.transparentPanel1.Controls.Add(this.rbHandL);
            this.transparentPanel1.Controls.Add(this.rbUpperArmL);
            this.transparentPanel1.Controls.Add(this.rbHandR);
            this.transparentPanel1.Controls.Add(this.rbLowerArmR);
            this.transparentPanel1.Controls.Add(this.rbLowerArmL);
            this.transparentPanel1.Controls.Add(this.pictureBox1);
            this.transparentPanel1.Location = new System.Drawing.Point(763, 27);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(300, 400);
            this.transparentPanel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Left";
            // 
            // rbFootL
            // 
            this.rbFootL.AutoSize = true;
            this.rbFootL.Location = new System.Drawing.Point(161, 365);
            this.rbFootL.Name = "rbFootL";
            this.rbFootL.Size = new System.Drawing.Size(17, 16);
            this.rbFootL.TabIndex = 27;
            this.rbFootL.TabStop = true;
            this.rbFootL.Tag = "sLeftFoot";
            this.rbFootL.UseVisualStyleBackColor = true;
            this.rbFootL.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbHead
            // 
            this.rbHead.AutoSize = true;
            this.rbHead.Location = new System.Drawing.Point(140, 6);
            this.rbHead.Name = "rbHead";
            this.rbHead.Size = new System.Drawing.Size(17, 16);
            this.rbHead.TabIndex = 11;
            this.rbHead.Tag = "sHead";
            this.rbHead.UseVisualStyleBackColor = true;
            this.rbHead.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbFootR
            // 
            this.rbFootR.AutoSize = true;
            this.rbFootR.Location = new System.Drawing.Point(121, 365);
            this.rbFootR.Name = "rbFootR";
            this.rbFootR.Size = new System.Drawing.Size(17, 16);
            this.rbFootR.TabIndex = 26;
            this.rbFootR.TabStop = true;
            this.rbFootR.Tag = "sRightFoot";
            this.rbFootR.UseVisualStyleBackColor = true;
            this.rbFootR.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbSpine03
            // 
            this.rbSpine03.AutoSize = true;
            this.rbSpine03.Location = new System.Drawing.Point(140, 107);
            this.rbSpine03.Name = "rbSpine03";
            this.rbSpine03.Size = new System.Drawing.Size(17, 16);
            this.rbSpine03.TabIndex = 12;
            this.rbSpine03.TabStop = true;
            this.rbSpine03.Tag = "sSpine2";
            this.rbSpine03.UseVisualStyleBackColor = true;
            this.rbSpine03.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbCalfL
            // 
            this.rbCalfL.AutoSize = true;
            this.rbCalfL.Location = new System.Drawing.Point(165, 310);
            this.rbCalfL.Name = "rbCalfL";
            this.rbCalfL.Size = new System.Drawing.Size(17, 16);
            this.rbCalfL.TabIndex = 25;
            this.rbCalfL.TabStop = true;
            this.rbCalfL.Tag = "sLeftLeg";
            this.rbCalfL.UseVisualStyleBackColor = true;
            this.rbCalfL.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbSpine01
            // 
            this.rbSpine01.AutoSize = true;
            this.rbSpine01.Location = new System.Drawing.Point(140, 155);
            this.rbSpine01.Name = "rbSpine01";
            this.rbSpine01.Size = new System.Drawing.Size(17, 16);
            this.rbSpine01.TabIndex = 13;
            this.rbSpine01.TabStop = true;
            this.rbSpine01.Tag = "sSpine1";
            this.rbSpine01.UseVisualStyleBackColor = true;
            this.rbSpine01.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbCalfR
            // 
            this.rbCalfR.AutoSize = true;
            this.rbCalfR.Location = new System.Drawing.Point(116, 310);
            this.rbCalfR.Name = "rbCalfR";
            this.rbCalfR.Size = new System.Drawing.Size(17, 16);
            this.rbCalfR.TabIndex = 24;
            this.rbCalfR.TabStop = true;
            this.rbCalfR.Tag = "sRightLeg";
            this.rbCalfR.UseVisualStyleBackColor = true;
            this.rbCalfR.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbClavicleR
            // 
            this.rbClavicleR.AutoSize = true;
            this.rbClavicleR.Location = new System.Drawing.Point(103, 66);
            this.rbClavicleR.Name = "rbClavicleR";
            this.rbClavicleR.Size = new System.Drawing.Size(17, 16);
            this.rbClavicleR.TabIndex = 14;
            this.rbClavicleR.TabStop = true;
            this.rbClavicleR.Tag = "sRightShoulder";
            this.rbClavicleR.UseVisualStyleBackColor = true;
            this.rbClavicleR.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbThighL
            // 
            this.rbThighL.AutoSize = true;
            this.rbThighL.Location = new System.Drawing.Point(161, 242);
            this.rbThighL.Name = "rbThighL";
            this.rbThighL.Size = new System.Drawing.Size(17, 16);
            this.rbThighL.TabIndex = 23;
            this.rbThighL.TabStop = true;
            this.rbThighL.Tag = "sLeftUpLeg";
            this.rbThighL.UseVisualStyleBackColor = true;
            this.rbThighL.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbClavicleL
            // 
            this.rbClavicleL.AutoSize = true;
            this.rbClavicleL.Location = new System.Drawing.Point(174, 66);
            this.rbClavicleL.Name = "rbClavicleL";
            this.rbClavicleL.Size = new System.Drawing.Size(17, 16);
            this.rbClavicleL.TabIndex = 15;
            this.rbClavicleL.TabStop = true;
            this.rbClavicleL.Tag = "sLeftShoulder";
            this.rbClavicleL.UseVisualStyleBackColor = true;
            this.rbClavicleL.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbThighR
            // 
            this.rbThighR.AutoSize = true;
            this.rbThighR.Location = new System.Drawing.Point(121, 242);
            this.rbThighR.Name = "rbThighR";
            this.rbThighR.Size = new System.Drawing.Size(17, 16);
            this.rbThighR.TabIndex = 22;
            this.rbThighR.TabStop = true;
            this.rbThighR.Tag = "sRightUpLeg";
            this.rbThighR.UseVisualStyleBackColor = true;
            this.rbThighR.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbUpperArmR
            // 
            this.rbUpperArmR.AutoSize = true;
            this.rbUpperArmR.Location = new System.Drawing.Point(97, 107);
            this.rbUpperArmR.Name = "rbUpperArmR";
            this.rbUpperArmR.Size = new System.Drawing.Size(17, 16);
            this.rbUpperArmR.TabIndex = 16;
            this.rbUpperArmR.TabStop = true;
            this.rbUpperArmR.Tag = "sRightArm";
            this.rbUpperArmR.UseVisualStyleBackColor = true;
            this.rbUpperArmR.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbHandL
            // 
            this.rbHandL.AutoSize = true;
            this.rbHandL.Location = new System.Drawing.Point(188, 206);
            this.rbHandL.Name = "rbHandL";
            this.rbHandL.Size = new System.Drawing.Size(17, 16);
            this.rbHandL.TabIndex = 21;
            this.rbHandL.TabStop = true;
            this.rbHandL.Tag = "sLeftHand";
            this.rbHandL.UseVisualStyleBackColor = true;
            this.rbHandL.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbUpperArmL
            // 
            this.rbUpperArmL.AutoSize = true;
            this.rbUpperArmL.Location = new System.Drawing.Point(184, 107);
            this.rbUpperArmL.Name = "rbUpperArmL";
            this.rbUpperArmL.Size = new System.Drawing.Size(17, 16);
            this.rbUpperArmL.TabIndex = 17;
            this.rbUpperArmL.TabStop = true;
            this.rbUpperArmL.Tag = "sLeftArm";
            this.rbUpperArmL.UseVisualStyleBackColor = true;
            this.rbUpperArmL.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbHandR
            // 
            this.rbHandR.AutoSize = true;
            this.rbHandR.Location = new System.Drawing.Point(95, 206);
            this.rbHandR.Name = "rbHandR";
            this.rbHandR.Size = new System.Drawing.Size(17, 16);
            this.rbHandR.TabIndex = 20;
            this.rbHandR.TabStop = true;
            this.rbHandR.Tag = "sRightHand";
            this.rbHandR.UseVisualStyleBackColor = true;
            this.rbHandR.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbLowerArmR
            // 
            this.rbLowerArmR.AutoSize = true;
            this.rbLowerArmR.Location = new System.Drawing.Point(95, 154);
            this.rbLowerArmR.Name = "rbLowerArmR";
            this.rbLowerArmR.Size = new System.Drawing.Size(17, 16);
            this.rbLowerArmR.TabIndex = 18;
            this.rbLowerArmR.TabStop = true;
            this.rbLowerArmR.Tag = "sRightForeArm";
            this.rbLowerArmR.UseVisualStyleBackColor = true;
            this.rbLowerArmR.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // rbLowerArmL
            // 
            this.rbLowerArmL.AutoSize = true;
            this.rbLowerArmL.Location = new System.Drawing.Point(188, 155);
            this.rbLowerArmL.Name = "rbLowerArmL";
            this.rbLowerArmL.Size = new System.Drawing.Size(17, 16);
            this.rbLowerArmL.TabIndex = 19;
            this.rbLowerArmL.TabStop = true;
            this.rbLowerArmL.Tag = "sLeftForeArm";
            this.rbLowerArmL.UseVisualStyleBackColor = true;
            this.rbLowerArmL.CheckedChanged += new System.EventHandler(this.rbBone_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SensorTuner.Properties.Resources.SilhouettesMan_300_400;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbPortName);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtxtDataArea);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensor tuner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWiFiStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMocapServerPort)).EndInit();
            this.transparentPanel1.ResumeLayout(false);
            this.transparentPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbPortName;
    private System.Windows.Forms.RichTextBox rtxtDataArea;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.RadioButton rbHead;
    private System.Windows.Forms.RadioButton rbSpine03;
    private System.Windows.Forms.RadioButton rbSpine01;
    private System.Windows.Forms.RadioButton rbClavicleR;
    private System.Windows.Forms.RadioButton rbClavicleL;
    private System.Windows.Forms.RadioButton rbUpperArmL;
    private System.Windows.Forms.RadioButton rbUpperArmR;
    private System.Windows.Forms.RadioButton rbLowerArmL;
    private System.Windows.Forms.RadioButton rbLowerArmR;
    private System.Windows.Forms.RadioButton rbHandL;
    private System.Windows.Forms.RadioButton rbHandR;
    private System.Windows.Forms.RadioButton rbThighL;
    private System.Windows.Forms.RadioButton rbThighR;
    private System.Windows.Forms.RadioButton rbCalfL;
    private System.Windows.Forms.RadioButton rbCalfR;
    private System.Windows.Forms.RadioButton rbFootL;
    private System.Windows.Forms.RadioButton rbFootR;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private TransparentPanel transparentPanel1;
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
    private System.Windows.Forms.TextBox tbSensorName;
    private System.Windows.Forms.Label lblSensorName;
}


