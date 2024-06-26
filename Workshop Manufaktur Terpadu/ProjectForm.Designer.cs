﻿namespace Workshop_Manufaktur_Terpadu
{
    partial class ProjectForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baudrateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPortComboBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plcOffTest_button = new System.Windows.Forms.Button();
            this.plcOnTest_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.message_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkUltSensor = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBottom = new System.Windows.Forms.CheckBox();
            this.checkTop = new System.Windows.Forms.CheckBox();
            this.checkProx = new System.Windows.Forms.CheckBox();
            this.checkTemptSensor = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.counterVal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkGateDown = new System.Windows.Forms.CheckBox();
            this.checkGateUp = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.ultSensor = new System.Windows.Forms.Panel();
            this.tempSensor = new System.Windows.Forms.Panel();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDoor = new System.Windows.Forms.Button();
            this.openDoorTimer = new System.Windows.Forms.Timer(this.components);
            this.closeDoorTimer = new System.Windows.Forms.Timer(this.components);
            this.topLSSensor = new System.Windows.Forms.Panel();
            this.bottomLSSensor = new System.Windows.Forms.Panel();
            this.btnStartProject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectStatus = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.proxSensor = new System.Windows.Forms.Panel();
            this.checkTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baudrateComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.close_button);
            this.groupBox1.Controls.Add(this.connect_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serialPortComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connectivity";
            // 
            // baudrateComboBox
            // 
            this.baudrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateComboBox.FormattingEnabled = true;
            this.baudrateComboBox.Items.AddRange(new object[] {
            "",
            "9600",
            "19200",
            "38400"});
            this.baudrateComboBox.Location = new System.Drawing.Point(75, 46);
            this.baudrateComboBox.Name = "baudrateComboBox";
            this.baudrateComboBox.Size = new System.Drawing.Size(88, 21);
            this.baudrateComboBox.TabIndex = 5;
            this.baudrateComboBox.SelectedIndexChanged += new System.EventHandler(this.baudrateComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baudrate";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(6, 122);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(157, 28);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(6, 91);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(157, 29);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // serialPortComboBox
            // 
            this.serialPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortComboBox.FormattingEnabled = true;
            this.serialPortComboBox.Location = new System.Drawing.Point(75, 19);
            this.serialPortComboBox.Name = "serialPortComboBox";
            this.serialPortComboBox.Size = new System.Drawing.Size(88, 21);
            this.serialPortComboBox.TabIndex = 0;
            this.serialPortComboBox.SelectedIndexChanged += new System.EventHandler(this.serialPortComboBox_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plcOffTest_button);
            this.groupBox2.Controls.Add(this.plcOnTest_button);
            this.groupBox2.Location = new System.Drawing.Point(187, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLC Connection Test";
            // 
            // plcOffTest_button
            // 
            this.plcOffTest_button.Location = new System.Drawing.Point(6, 91);
            this.plcOffTest_button.Name = "plcOffTest_button";
            this.plcOffTest_button.Size = new System.Drawing.Size(157, 59);
            this.plcOffTest_button.TabIndex = 1;
            this.plcOffTest_button.Text = "OFF";
            this.plcOffTest_button.UseVisualStyleBackColor = true;
            this.plcOffTest_button.Click += new System.EventHandler(this.plcOffTest_button_Click);
            // 
            // plcOnTest_button
            // 
            this.plcOnTest_button.Location = new System.Drawing.Point(6, 19);
            this.plcOnTest_button.Name = "plcOnTest_button";
            this.plcOnTest_button.Size = new System.Drawing.Size(157, 59);
            this.plcOnTest_button.TabIndex = 0;
            this.plcOnTest_button.Text = "ON";
            this.plcOnTest_button.UseVisualStyleBackColor = true;
            this.plcOnTest_button.Click += new System.EventHandler(this.plcOnTest_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.message_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(716, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // message_toolStripStatusLabel
            // 
            this.message_toolStripStatusLabel.Name = "message_toolStripStatusLabel";
            this.message_toolStripStatusLabel.Size = new System.Drawing.Size(53, 17);
            this.message_toolStripStatusLabel.Text = "Message";
            // 
            // checkUltSensor
            // 
            this.checkUltSensor.AutoCheck = false;
            this.checkUltSensor.AutoSize = true;
            this.checkUltSensor.Location = new System.Drawing.Point(6, 19);
            this.checkUltSensor.Name = "checkUltSensor";
            this.checkUltSensor.Size = new System.Drawing.Size(73, 17);
            this.checkUltSensor.TabIndex = 3;
            this.checkUltSensor.Text = "Ultrasonic";
            this.checkUltSensor.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBottom);
            this.groupBox3.Controls.Add(this.checkTop);
            this.groupBox3.Controls.Add(this.checkProx);
            this.groupBox3.Controls.Add(this.checkTemptSensor);
            this.groupBox3.Controls.Add(this.checkUltSensor);
            this.groupBox3.Location = new System.Drawing.Point(362, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 156);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor Status";
            // 
            // checkBottom
            // 
            this.checkBottom.AutoCheck = false;
            this.checkBottom.AutoSize = true;
            this.checkBottom.Location = new System.Drawing.Point(6, 111);
            this.checkBottom.Name = "checkBottom";
            this.checkBottom.Size = new System.Drawing.Size(118, 17);
            this.checkBottom.TabIndex = 7;
            this.checkBottom.Text = "Bottom Limit Switch";
            this.checkBottom.UseVisualStyleBackColor = true;
            // 
            // checkTop
            // 
            this.checkTop.AutoCheck = false;
            this.checkTop.AutoSize = true;
            this.checkTop.Location = new System.Drawing.Point(6, 88);
            this.checkTop.Name = "checkTop";
            this.checkTop.Size = new System.Drawing.Size(104, 17);
            this.checkTop.TabIndex = 6;
            this.checkTop.Text = "Top Limit Switch";
            this.checkTop.UseVisualStyleBackColor = true;
            // 
            // checkProx
            // 
            this.checkProx.AutoCheck = false;
            this.checkProx.AutoSize = true;
            this.checkProx.Location = new System.Drawing.Point(6, 65);
            this.checkProx.Name = "checkProx";
            this.checkProx.Size = new System.Drawing.Size(67, 17);
            this.checkProx.TabIndex = 5;
            this.checkProx.Text = "Proximity";
            this.checkProx.UseVisualStyleBackColor = true;
            // 
            // checkTemptSensor
            // 
            this.checkTemptSensor.AutoCheck = false;
            this.checkTemptSensor.AutoSize = true;
            this.checkTemptSensor.Location = new System.Drawing.Point(6, 42);
            this.checkTemptSensor.Name = "checkTemptSensor";
            this.checkTemptSensor.Size = new System.Drawing.Size(86, 17);
            this.checkTemptSensor.TabIndex = 4;
            this.checkTemptSensor.Text = "Temperature";
            this.checkTemptSensor.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.counterVal);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.checkGateDown);
            this.groupBox4.Controls.Add(this.checkGateUp);
            this.groupBox4.Location = new System.Drawing.Point(523, 379);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 156);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output Status";
            // 
            // counterVal
            // 
            this.counterVal.AutoSize = true;
            this.counterVal.Location = new System.Drawing.Point(149, 92);
            this.counterVal.Name = "counterVal";
            this.counterVal.Size = new System.Drawing.Size(19, 13);
            this.counterVal.TabIndex = 19;
            this.counterVal.Text = "00";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reset Capacity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Warehouse Capacity";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 88);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(136, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // checkGateDown
            // 
            this.checkGateDown.AutoCheck = false;
            this.checkGateDown.AutoSize = true;
            this.checkGateDown.Location = new System.Drawing.Point(7, 42);
            this.checkGateDown.Name = "checkGateDown";
            this.checkGateDown.Size = new System.Drawing.Size(110, 17);
            this.checkGateDown.TabIndex = 9;
            this.checkGateDown.Text = "Gate Motor Down";
            this.checkGateDown.UseVisualStyleBackColor = true;
            // 
            // checkGateUp
            // 
            this.checkGateUp.AutoCheck = false;
            this.checkGateUp.AutoSize = true;
            this.checkGateUp.Location = new System.Drawing.Point(7, 20);
            this.checkGateUp.Name = "checkGateUp";
            this.checkGateUp.Size = new System.Drawing.Size(96, 17);
            this.checkGateUp.TabIndex = 8;
            this.checkGateUp.Text = "Gate Motor Up";
            this.checkGateUp.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnRight);
            this.groupBox5.Location = new System.Drawing.Point(12, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Truck Control Simulation";
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(6, 20);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(154, 74);
            this.BtnRight.TabIndex = 1;
            this.BtnRight.Text = "Drive Truck";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRight_MouseDown);
            this.BtnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRight_MouseUp);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(12, 224);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(692, 33);
            this.BtnLeft.TabIndex = 0;
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLeft_MouseDown);
            this.BtnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLeft_MouseUp);
            // 
            // ultSensor
            // 
            this.ultSensor.BackColor = System.Drawing.Color.Transparent;
            this.ultSensor.Location = new System.Drawing.Point(362, 125);
            this.ultSensor.Name = "ultSensor";
            this.ultSensor.Size = new System.Drawing.Size(10, 10);
            this.ultSensor.TabIndex = 10;
            // 
            // tempSensor
            // 
            this.tempSensor.BackColor = System.Drawing.Color.IndianRed;
            this.tempSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempSensor.Location = new System.Drawing.Point(362, 186);
            this.tempSensor.Name = "tempSensor";
            this.tempSensor.Size = new System.Drawing.Size(10, 10);
            this.tempSensor.TabIndex = 11;
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 50;
            // 
            // btnDoor
            // 
            this.btnDoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDoor.Location = new System.Drawing.Point(394, 114);
            this.btnDoor.Name = "btnDoor";
            this.btnDoor.Size = new System.Drawing.Size(41, 104);
            this.btnDoor.TabIndex = 12;
            this.btnDoor.UseVisualStyleBackColor = false;
            this.btnDoor.Click += new System.EventHandler(this.btnDoor_Click);
            // 
            // openDoorTimer
            // 
            this.openDoorTimer.Interval = 50;
            // 
            // closeDoorTimer
            // 
            this.closeDoorTimer.Interval = 50;
            // 
            // topLSSensor
            // 
            this.topLSSensor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.topLSSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topLSSensor.Location = new System.Drawing.Point(410, 119);
            this.topLSSensor.Name = "topLSSensor";
            this.topLSSensor.Size = new System.Drawing.Size(10, 10);
            this.topLSSensor.TabIndex = 13;
            // 
            // bottomLSSensor
            // 
            this.bottomLSSensor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bottomLSSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomLSSensor.Location = new System.Drawing.Point(410, 203);
            this.bottomLSSensor.Name = "bottomLSSensor";
            this.bottomLSSensor.Size = new System.Drawing.Size(10, 10);
            this.bottomLSSensor.TabIndex = 14;
            // 
            // btnStartProject
            // 
            this.btnStartProject.Location = new System.Drawing.Point(193, 293);
            this.btnStartProject.Name = "btnStartProject";
            this.btnStartProject.Size = new System.Drawing.Size(75, 74);
            this.btnStartProject.TabIndex = 2;
            this.btnStartProject.Text = "Start";
            this.btnStartProject.UseVisualStyleBackColor = true;
            this.btnStartProject.Click += new System.EventHandler(this.btnStartProject_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 15;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStopProject_Click);
            // 
            // projectStatus
            // 
            this.projectStatus.AutoCheck = false;
            this.projectStatus.AutoSize = true;
            this.projectStatus.Location = new System.Drawing.Point(195, 273);
            this.projectStatus.Name = "projectStatus";
            this.projectStatus.Size = new System.Drawing.Size(92, 17);
            this.projectStatus.TabIndex = 8;
            this.projectStatus.Text = "Project Status";
            this.projectStatus.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(362, 291);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 82);
            this.listBox1.TabIndex = 16;
            // 
            // proxSensor
            // 
            this.proxSensor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.proxSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.proxSensor.Location = new System.Drawing.Point(410, 186);
            this.proxSensor.Name = "proxSensor";
            this.proxSensor.Size = new System.Drawing.Size(10, 10);
            this.proxSensor.TabIndex = 12;
            // 
            // checkTimer
            // 
            this.checkTimer.Tick += new System.EventHandler(this.checkTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "I/O Log";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Workshop_Manufaktur_Terpadu.Properties.Resources._9rgbhln61a3ojg2m3fv6vskk2m;
            this.pictureBox1.Location = new System.Drawing.Point(313, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // picCar
            // 
            this.picCar.BackColor = System.Drawing.Color.Transparent;
            this.picCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCar.Image = global::Workshop_Manufaktur_Terpadu.Properties.Resources.vecteezy_ai_generated_black_delivery_truck_on_transparent_background_359073991;
            this.picCar.Location = new System.Drawing.Point(12, 130);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(220, 88);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 8;
            this.picCar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.panel3);
            this.groupBox6.Controls.Add(this.panel2);
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Location = new System.Drawing.Point(569, 274);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(135, 99);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(6, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(6, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 10);
            this.panel3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Temperature Sensor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Limit Switch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Proximity Sensor";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 560);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnDoor);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.proxSensor);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.projectStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStartProject);
            this.Controls.Add(this.bottomLSSensor);
            this.Controls.Add(this.topLSSensor);
            this.Controls.Add(this.tempSensor);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ultSensor);
            this.Name = "ProjectForm";
            this.Text = "Final Project: Truck\'s Gate Solution";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialPortComboBox;
        private System.Windows.Forms.Button close_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button plcOffTest_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel message_toolStripStatusLabel;
        private System.Windows.Forms.CheckBox checkUltSensor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkProx;
        private System.Windows.Forms.CheckBox checkTemptSensor;
        private System.Windows.Forms.CheckBox checkBottom;
        private System.Windows.Forms.CheckBox checkTop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox baudrateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkGateDown;
        private System.Windows.Forms.CheckBox checkGateUp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Panel ultSensor;
        private System.Windows.Forms.Panel tempSensor;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Button btnDoor;
        private System.Windows.Forms.Timer openDoorTimer;
        private System.Windows.Forms.Timer closeDoorTimer;
        private System.Windows.Forms.Panel topLSSensor;
        private System.Windows.Forms.Panel bottomLSSensor;
        private System.Windows.Forms.Button plcOnTest_button;
        private System.Windows.Forms.Button btnStartProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox projectStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel proxSensor;
        private System.Windows.Forms.Timer checkTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label counterVal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}