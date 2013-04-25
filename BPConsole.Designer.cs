namespace BusPirate
{
	partial class BPConsole
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BPConsole));
			this.ComPort = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Connect = new System.Windows.Forms.Button();
			this.groupMode = new System.Windows.Forms.GroupBox();
			this.groupSPI = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.cbSpiOutOC = new System.Windows.Forms.RadioButton();
			this.cbSpiOutNormal = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cbSpiCsPositive = new System.Windows.Forms.RadioButton();
			this.cbSpiCsNegative = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbSpiInputMiddle = new System.Windows.Forms.RadioButton();
			this.cbSpiInputEnd = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbSpiEdgeIdle = new System.Windows.Forms.RadioButton();
			this.cbSpiEdgeActive = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbSpiPolarityLow = new System.Windows.Forms.RadioButton();
			this.cbSpiPolarityHigh = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbSpi30 = new System.Windows.Forms.RadioButton();
			this.cbSpi125 = new System.Windows.Forms.RadioButton();
			this.cbSpi250 = new System.Windows.Forms.RadioButton();
			this.cbSpi1000 = new System.Windows.Forms.RadioButton();
			this.groupI2C = new System.Windows.Forms.GroupBox();
			this.cbI2C400 = new System.Windows.Forms.RadioButton();
			this.cbI2C100 = new System.Windows.Forms.RadioButton();
			this.cbI2C50 = new System.Windows.Forms.RadioButton();
			this.cbI2C5 = new System.Windows.Forms.RadioButton();
			this.groupUART = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.cbUartOutOC = new System.Windows.Forms.RadioButton();
			this.cbUartOutNormal = new System.Windows.Forms.RadioButton();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.cbIdle1 = new System.Windows.Forms.RadioButton();
			this.cbUartIdle0 = new System.Windows.Forms.RadioButton();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.cbStop1 = new System.Windows.Forms.RadioButton();
			this.cbUartStop2 = new System.Windows.Forms.RadioButton();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.cbUart9None = new System.Windows.Forms.RadioButton();
			this.cbUart8Odd = new System.Windows.Forms.RadioButton();
			this.cbUart8None = new System.Windows.Forms.RadioButton();
			this.cbUart8Even = new System.Windows.Forms.RadioButton();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.cbUart115200 = new System.Windows.Forms.RadioButton();
			this.cbUart57600 = new System.Windows.Forms.RadioButton();
			this.cbUart38400 = new System.Windows.Forms.RadioButton();
			this.cbUart19200 = new System.Windows.Forms.RadioButton();
			this.cbUart9600 = new System.Windows.Forms.RadioButton();
			this.cbUART300 = new System.Windows.Forms.RadioButton();
			this.cbUart1200 = new System.Windows.Forms.RadioButton();
			this.cbUart2400 = new System.Windows.Forms.RadioButton();
			this.cbUart4800 = new System.Windows.Forms.RadioButton();
			this.group3WIRE = new System.Windows.Forms.GroupBox();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.cb3WCsPositive = new System.Windows.Forms.RadioButton();
			this.cb3WCsNegative = new System.Windows.Forms.RadioButton();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.cb3WOutOC = new System.Windows.Forms.RadioButton();
			this.cb3WOutNormal = new System.Windows.Forms.RadioButton();
			this.cb3W400 = new System.Windows.Forms.RadioButton();
			this.cb3W100 = new System.Windows.Forms.RadioButton();
			this.cb3W50 = new System.Windows.Forms.RadioButton();
			this.cb3W5 = new System.Windows.Forms.RadioButton();
			this.group2WIRE = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.cb2WOutOC = new System.Windows.Forms.RadioButton();
			this.cb2WOutNormal = new System.Windows.Forms.RadioButton();
			this.cb2W400 = new System.Windows.Forms.RadioButton();
			this.cb2W100 = new System.Windows.Forms.RadioButton();
			this.cb2W50 = new System.Windows.Forms.RadioButton();
			this.cb2W5 = new System.Windows.Forms.RadioButton();
			this.SetMode = new System.Windows.Forms.Button();
			this.Mode = new System.Windows.Forms.ComboBox();
			this.groupCommand = new System.Windows.Forms.GroupBox();
			this.Interval = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ClearLog = new System.Windows.Forms.Button();
			this.AutoInfo = new System.Windows.Forms.CheckBox();
			this.value2 = new System.Windows.Forms.Label();
			this.name2 = new System.Windows.Forms.Label();
			this.value3 = new System.Windows.Forms.Label();
			this.name3 = new System.Windows.Forms.Label();
			this.value4 = new System.Windows.Forms.Label();
			this.name4 = new System.Windows.Forms.Label();
			this.value5 = new System.Windows.Forms.Label();
			this.name5 = new System.Windows.Forms.Label();
			this.value6 = new System.Windows.Forms.Label();
			this.mode6 = new System.Windows.Forms.Label();
			this.name6 = new System.Windows.Forms.Label();
			this.value7 = new System.Windows.Forms.Label();
			this.mode7 = new System.Windows.Forms.Label();
			this.name7 = new System.Windows.Forms.Label();
			this.value8 = new System.Windows.Forms.Label();
			this.mode8 = new System.Windows.Forms.Label();
			this.name8 = new System.Windows.Forms.Label();
			this.value9 = new System.Windows.Forms.Label();
			this.mode9 = new System.Windows.Forms.Label();
			this.name9 = new System.Windows.Forms.Label();
			this.value10 = new System.Windows.Forms.Label();
			this.mode10 = new System.Windows.Forms.Label();
			this.name10 = new System.Windows.Forms.Label();
			this.Info = new System.Windows.Forms.Button();
			this.Reset = new System.Windows.Forms.Button();
			this.Voltage = new System.Windows.Forms.Button();
			this.PowerOn = new System.Windows.Forms.Button();
			this.PowerOff = new System.Windows.Forms.Button();
			this.Delay_mS = new System.Windows.Forms.Button();
			this.Delay = new System.Windows.Forms.NumericUpDown();
			this.Delay_uS = new System.Windows.Forms.Button();
			this.AuxRead = new System.Windows.Forms.Button();
			this.AuxHigh = new System.Windows.Forms.Button();
			this.AuxLow = new System.Windows.Forms.Button();
			this.Run = new System.Windows.Forms.Button();
			this.openDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.FileName = new System.Windows.Forms.TextBox();
			this.Browse = new System.Windows.Forms.Button();
			this.Open = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.Tab = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.label13 = new System.Windows.Forms.Label();
			this.InfoPanel = new System.Windows.Forms.SplitContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.Script = new BusPirate.TextBoxEx();
			this.Log = new BusPirate.TextBoxEx();
			this.groupMode.SuspendLayout();
			this.groupSPI.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupI2C.SuspendLayout();
			this.groupUART.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.group3WIRE.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.group2WIRE.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupCommand.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
			this.InfoPanel.Panel1.SuspendLayout();
			this.InfoPanel.Panel2.SuspendLayout();
			this.InfoPanel.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ComPort
			// 
			this.ComPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.ComPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ComPort.FormattingEnabled = true;
			this.ComPort.Location = new System.Drawing.Point(20, 31);
			this.ComPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ComPort.Name = "ComPort";
			this.ComPort.Size = new System.Drawing.Size(132, 24);
			this.ComPort.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "COM Port";
			// 
			// Connect
			// 
			this.Connect.Location = new System.Drawing.Point(161, 28);
			this.Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(133, 28);
			this.Connect.TabIndex = 1;
			this.Connect.Text = "F8 - Connect";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.Connect_Click);
			// 
			// groupMode
			// 
			this.groupMode.Controls.Add(this.groupSPI);
			this.groupMode.Controls.Add(this.groupI2C);
			this.groupMode.Controls.Add(this.groupUART);
			this.groupMode.Controls.Add(this.group3WIRE);
			this.groupMode.Controls.Add(this.group2WIRE);
			this.groupMode.Controls.Add(this.SetMode);
			this.groupMode.Controls.Add(this.Mode);
			this.groupMode.Enabled = false;
			this.groupMode.Location = new System.Drawing.Point(20, 64);
			this.groupMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupMode.Name = "groupMode";
			this.groupMode.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupMode.Size = new System.Drawing.Size(475, 331);
			this.groupMode.TabIndex = 8;
			this.groupMode.TabStop = false;
			this.groupMode.Text = "Mode";
			// 
			// groupSPI
			// 
			this.groupSPI.Controls.Add(this.groupBox6);
			this.groupSPI.Controls.Add(this.groupBox5);
			this.groupSPI.Controls.Add(this.groupBox4);
			this.groupSPI.Controls.Add(this.groupBox3);
			this.groupSPI.Controls.Add(this.groupBox2);
			this.groupSPI.Controls.Add(this.groupBox1);
			this.groupSPI.Location = new System.Drawing.Point(8, 57);
			this.groupSPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupSPI.Name = "groupSPI";
			this.groupSPI.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupSPI.Size = new System.Drawing.Size(459, 267);
			this.groupSPI.TabIndex = 2;
			this.groupSPI.TabStop = false;
			this.groupSPI.Text = "SPI Parameters";
			this.groupSPI.Visible = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.cbSpiOutOC);
			this.groupBox6.Controls.Add(this.cbSpiOutNormal);
			this.groupBox6.Location = new System.Drawing.Point(124, 183);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox6.Size = new System.Drawing.Size(327, 78);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Select output type";
			// 
			// cbSpiOutOC
			// 
			this.cbSpiOutOC.AutoSize = true;
			this.cbSpiOutOC.Location = new System.Drawing.Point(8, 23);
			this.cbSpiOutOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiOutOC.Name = "cbSpiOutOC";
			this.cbSpiOutOC.Size = new System.Drawing.Size(214, 21);
			this.cbSpiOutOC.TabIndex = 0;
			this.cbSpiOutOC.Text = "Open drain (H=Hi-Z, L=GND)";
			this.cbSpiOutOC.UseVisualStyleBackColor = true;
			// 
			// cbSpiOutNormal
			// 
			this.cbSpiOutNormal.AutoSize = true;
			this.cbSpiOutNormal.Checked = true;
			this.cbSpiOutNormal.Location = new System.Drawing.Point(8, 52);
			this.cbSpiOutNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiOutNormal.Name = "cbSpiOutNormal";
			this.cbSpiOutNormal.Size = new System.Drawing.Size(190, 21);
			this.cbSpiOutNormal.TabIndex = 1;
			this.cbSpiOutNormal.TabStop = true;
			this.cbSpiOutNormal.Text = "Normal (H=3.3V, L=GND)";
			this.cbSpiOutNormal.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cbSpiCsPositive);
			this.groupBox5.Controls.Add(this.cbSpiCsNegative);
			this.groupBox5.Location = new System.Drawing.Point(291, 103);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox5.Size = new System.Drawing.Size(160, 78);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "CS";
			// 
			// cbSpiCsPositive
			// 
			this.cbSpiCsPositive.AutoSize = true;
			this.cbSpiCsPositive.Location = new System.Drawing.Point(8, 23);
			this.cbSpiCsPositive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiCsPositive.Name = "cbSpiCsPositive";
			this.cbSpiCsPositive.Size = new System.Drawing.Size(47, 21);
			this.cbSpiCsPositive.TabIndex = 0;
			this.cbSpiCsPositive.Text = "CS";
			this.cbSpiCsPositive.UseVisualStyleBackColor = true;
			// 
			// cbSpiCsNegative
			// 
			this.cbSpiCsNegative.AutoSize = true;
			this.cbSpiCsNegative.Checked = true;
			this.cbSpiCsNegative.Location = new System.Drawing.Point(8, 52);
			this.cbSpiCsNegative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiCsNegative.Name = "cbSpiCsNegative";
			this.cbSpiCsNegative.Size = new System.Drawing.Size(74, 21);
			this.cbSpiCsNegative.TabIndex = 1;
			this.cbSpiCsNegative.TabStop = true;
			this.cbSpiCsNegative.Text = "/ CS (*)";
			this.cbSpiCsNegative.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cbSpiInputMiddle);
			this.groupBox4.Controls.Add(this.cbSpiInputEnd);
			this.groupBox4.Location = new System.Drawing.Point(124, 103);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox4.Size = new System.Drawing.Size(159, 78);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Input sample phase";
			// 
			// cbSpiInputMiddle
			// 
			this.cbSpiInputMiddle.AutoSize = true;
			this.cbSpiInputMiddle.Checked = true;
			this.cbSpiInputMiddle.Location = new System.Drawing.Point(8, 23);
			this.cbSpiInputMiddle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiInputMiddle.Name = "cbSpiInputMiddle";
			this.cbSpiInputMiddle.Size = new System.Drawing.Size(89, 21);
			this.cbSpiInputMiddle.TabIndex = 0;
			this.cbSpiInputMiddle.TabStop = true;
			this.cbSpiInputMiddle.Text = "Middle (*)";
			this.cbSpiInputMiddle.UseVisualStyleBackColor = true;
			// 
			// cbSpiInputEnd
			// 
			this.cbSpiInputEnd.AutoSize = true;
			this.cbSpiInputEnd.Location = new System.Drawing.Point(8, 52);
			this.cbSpiInputEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiInputEnd.Name = "cbSpiInputEnd";
			this.cbSpiInputEnd.Size = new System.Drawing.Size(54, 21);
			this.cbSpiInputEnd.TabIndex = 1;
			this.cbSpiInputEnd.Text = "End";
			this.cbSpiInputEnd.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbSpiEdgeIdle);
			this.groupBox3.Controls.Add(this.cbSpiEdgeActive);
			this.groupBox3.Location = new System.Drawing.Point(291, 23);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(160, 78);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Output clock edge";
			// 
			// cbSpiEdgeIdle
			// 
			this.cbSpiEdgeIdle.AutoSize = true;
			this.cbSpiEdgeIdle.Location = new System.Drawing.Point(8, 23);
			this.cbSpiEdgeIdle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiEdgeIdle.Name = "cbSpiEdgeIdle";
			this.cbSpiEdgeIdle.Size = new System.Drawing.Size(108, 21);
			this.cbSpiEdgeIdle.TabIndex = 0;
			this.cbSpiEdgeIdle.Text = "Idle to active";
			this.cbSpiEdgeIdle.UseVisualStyleBackColor = true;
			// 
			// cbSpiEdgeActive
			// 
			this.cbSpiEdgeActive.AutoSize = true;
			this.cbSpiEdgeActive.Checked = true;
			this.cbSpiEdgeActive.Location = new System.Drawing.Point(8, 52);
			this.cbSpiEdgeActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiEdgeActive.Name = "cbSpiEdgeActive";
			this.cbSpiEdgeActive.Size = new System.Drawing.Size(128, 21);
			this.cbSpiEdgeActive.TabIndex = 1;
			this.cbSpiEdgeActive.TabStop = true;
			this.cbSpiEdgeActive.Text = "Active to idle (*)";
			this.cbSpiEdgeActive.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbSpiPolarityLow);
			this.groupBox2.Controls.Add(this.cbSpiPolarityHigh);
			this.groupBox2.Location = new System.Drawing.Point(124, 23);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(159, 78);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Clock polarity";
			// 
			// cbSpiPolarityLow
			// 
			this.cbSpiPolarityLow.AutoSize = true;
			this.cbSpiPolarityLow.Checked = true;
			this.cbSpiPolarityLow.Location = new System.Drawing.Point(8, 23);
			this.cbSpiPolarityLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiPolarityLow.Name = "cbSpiPolarityLow";
			this.cbSpiPolarityLow.Size = new System.Drawing.Size(94, 21);
			this.cbSpiPolarityLow.TabIndex = 0;
			this.cbSpiPolarityLow.TabStop = true;
			this.cbSpiPolarityLow.Text = "Idle low (*)";
			this.cbSpiPolarityLow.UseVisualStyleBackColor = true;
			// 
			// cbSpiPolarityHigh
			// 
			this.cbSpiPolarityHigh.AutoSize = true;
			this.cbSpiPolarityHigh.Location = new System.Drawing.Point(8, 52);
			this.cbSpiPolarityHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpiPolarityHigh.Name = "cbSpiPolarityHigh";
			this.cbSpiPolarityHigh.Size = new System.Drawing.Size(82, 21);
			this.cbSpiPolarityHigh.TabIndex = 1;
			this.cbSpiPolarityHigh.Text = "Idle high";
			this.cbSpiPolarityHigh.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbSpi30);
			this.groupBox1.Controls.Add(this.cbSpi125);
			this.groupBox1.Controls.Add(this.cbSpi250);
			this.groupBox1.Controls.Add(this.cbSpi1000);
			this.groupBox1.Location = new System.Drawing.Point(8, 23);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(108, 158);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Speed";
			// 
			// cbSpi30
			// 
			this.cbSpi30.AutoSize = true;
			this.cbSpi30.Location = new System.Drawing.Point(8, 23);
			this.cbSpi30.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpi30.Name = "cbSpi30";
			this.cbSpi30.Size = new System.Drawing.Size(71, 21);
			this.cbSpi30.TabIndex = 0;
			this.cbSpi30.Text = "30KHz";
			this.cbSpi30.UseVisualStyleBackColor = true;
			// 
			// cbSpi125
			// 
			this.cbSpi125.AutoSize = true;
			this.cbSpi125.Location = new System.Drawing.Point(8, 52);
			this.cbSpi125.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpi125.Name = "cbSpi125";
			this.cbSpi125.Size = new System.Drawing.Size(79, 21);
			this.cbSpi125.TabIndex = 1;
			this.cbSpi125.Text = "125KHz";
			this.cbSpi125.UseVisualStyleBackColor = true;
			// 
			// cbSpi250
			// 
			this.cbSpi250.AutoSize = true;
			this.cbSpi250.Checked = true;
			this.cbSpi250.Location = new System.Drawing.Point(8, 80);
			this.cbSpi250.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpi250.Name = "cbSpi250";
			this.cbSpi250.Size = new System.Drawing.Size(79, 21);
			this.cbSpi250.TabIndex = 2;
			this.cbSpi250.TabStop = true;
			this.cbSpi250.Text = "250KHz";
			this.cbSpi250.UseVisualStyleBackColor = true;
			// 
			// cbSpi1000
			// 
			this.cbSpi1000.AutoSize = true;
			this.cbSpi1000.Location = new System.Drawing.Point(8, 108);
			this.cbSpi1000.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSpi1000.Name = "cbSpi1000";
			this.cbSpi1000.Size = new System.Drawing.Size(65, 21);
			this.cbSpi1000.TabIndex = 3;
			this.cbSpi1000.Text = "1MHz";
			this.cbSpi1000.UseVisualStyleBackColor = true;
			// 
			// groupI2C
			// 
			this.groupI2C.Controls.Add(this.cbI2C400);
			this.groupI2C.Controls.Add(this.cbI2C100);
			this.groupI2C.Controls.Add(this.cbI2C50);
			this.groupI2C.Controls.Add(this.cbI2C5);
			this.groupI2C.Location = new System.Drawing.Point(8, 57);
			this.groupI2C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupI2C.Name = "groupI2C";
			this.groupI2C.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupI2C.Size = new System.Drawing.Size(459, 140);
			this.groupI2C.TabIndex = 1;
			this.groupI2C.TabStop = false;
			this.groupI2C.Text = "I2C Parameters";
			this.groupI2C.Visible = false;
			// 
			// cbI2C400
			// 
			this.cbI2C400.AutoSize = true;
			this.cbI2C400.Checked = true;
			this.cbI2C400.Location = new System.Drawing.Point(12, 108);
			this.cbI2C400.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbI2C400.Name = "cbI2C400";
			this.cbI2C400.Size = new System.Drawing.Size(79, 21);
			this.cbI2C400.TabIndex = 3;
			this.cbI2C400.TabStop = true;
			this.cbI2C400.Text = "400KHz";
			this.cbI2C400.UseVisualStyleBackColor = true;
			// 
			// cbI2C100
			// 
			this.cbI2C100.AutoSize = true;
			this.cbI2C100.Location = new System.Drawing.Point(12, 80);
			this.cbI2C100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbI2C100.Name = "cbI2C100";
			this.cbI2C100.Size = new System.Drawing.Size(79, 21);
			this.cbI2C100.TabIndex = 2;
			this.cbI2C100.Text = "100KHz";
			this.cbI2C100.UseVisualStyleBackColor = true;
			// 
			// cbI2C50
			// 
			this.cbI2C50.AutoSize = true;
			this.cbI2C50.Location = new System.Drawing.Point(12, 52);
			this.cbI2C50.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbI2C50.Name = "cbI2C50";
			this.cbI2C50.Size = new System.Drawing.Size(71, 21);
			this.cbI2C50.TabIndex = 1;
			this.cbI2C50.Text = "50KHz";
			this.cbI2C50.UseVisualStyleBackColor = true;
			// 
			// cbI2C5
			// 
			this.cbI2C5.AutoSize = true;
			this.cbI2C5.Location = new System.Drawing.Point(12, 23);
			this.cbI2C5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbI2C5.Name = "cbI2C5";
			this.cbI2C5.Size = new System.Drawing.Size(63, 21);
			this.cbI2C5.TabIndex = 0;
			this.cbI2C5.Text = "5KHz";
			this.cbI2C5.UseVisualStyleBackColor = true;
			// 
			// groupUART
			// 
			this.groupUART.Controls.Add(this.groupBox8);
			this.groupUART.Controls.Add(this.groupBox9);
			this.groupUART.Controls.Add(this.groupBox11);
			this.groupUART.Controls.Add(this.groupBox12);
			this.groupUART.Controls.Add(this.groupBox13);
			this.groupUART.Location = new System.Drawing.Point(8, 57);
			this.groupUART.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupUART.Name = "groupUART";
			this.groupUART.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupUART.Size = new System.Drawing.Size(459, 267);
			this.groupUART.TabIndex = 4;
			this.groupUART.TabStop = false;
			this.groupUART.Text = "UART Parameters";
			this.groupUART.Visible = false;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.cbUartOutOC);
			this.groupBox8.Controls.Add(this.cbUartOutNormal);
			this.groupBox8.Location = new System.Drawing.Point(124, 183);
			this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox8.Size = new System.Drawing.Size(327, 78);
			this.groupBox8.TabIndex = 5;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Select output type";
			// 
			// cbUartOutOC
			// 
			this.cbUartOutOC.AutoSize = true;
			this.cbUartOutOC.Location = new System.Drawing.Point(8, 23);
			this.cbUartOutOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUartOutOC.Name = "cbUartOutOC";
			this.cbUartOutOC.Size = new System.Drawing.Size(214, 21);
			this.cbUartOutOC.TabIndex = 0;
			this.cbUartOutOC.Text = "Open drain (H=Hi-Z, L=GND)";
			this.cbUartOutOC.UseVisualStyleBackColor = true;
			// 
			// cbUartOutNormal
			// 
			this.cbUartOutNormal.AutoSize = true;
			this.cbUartOutNormal.Checked = true;
			this.cbUartOutNormal.Location = new System.Drawing.Point(8, 52);
			this.cbUartOutNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUartOutNormal.Name = "cbUartOutNormal";
			this.cbUartOutNormal.Size = new System.Drawing.Size(190, 21);
			this.cbUartOutNormal.TabIndex = 1;
			this.cbUartOutNormal.TabStop = true;
			this.cbUartOutNormal.Text = "Normal (H=3.3V, L=GND)";
			this.cbUartOutNormal.UseVisualStyleBackColor = true;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.cbIdle1);
			this.groupBox9.Controls.Add(this.cbUartIdle0);
			this.groupBox9.Location = new System.Drawing.Point(291, 102);
			this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox9.Size = new System.Drawing.Size(160, 78);
			this.groupBox9.TabIndex = 4;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Polarity";
			// 
			// cbIdle1
			// 
			this.cbIdle1.AutoSize = true;
			this.cbIdle1.Checked = true;
			this.cbIdle1.Location = new System.Drawing.Point(8, 23);
			this.cbIdle1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbIdle1.Name = "cbIdle1";
			this.cbIdle1.Size = new System.Drawing.Size(82, 21);
			this.cbIdle1.TabIndex = 0;
			this.cbIdle1.TabStop = true;
			this.cbIdle1.Text = "Idle 1 (*)";
			this.cbIdle1.UseVisualStyleBackColor = true;
			// 
			// cbUartIdle0
			// 
			this.cbUartIdle0.AutoSize = true;
			this.cbUartIdle0.Location = new System.Drawing.Point(8, 52);
			this.cbUartIdle0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUartIdle0.Name = "cbUartIdle0";
			this.cbUartIdle0.Size = new System.Drawing.Size(63, 21);
			this.cbUartIdle0.TabIndex = 1;
			this.cbUartIdle0.Text = "Idle 0";
			this.cbUartIdle0.UseVisualStyleBackColor = true;
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.cbStop1);
			this.groupBox11.Controls.Add(this.cbUartStop2);
			this.groupBox11.Location = new System.Drawing.Point(291, 23);
			this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox11.Size = new System.Drawing.Size(160, 75);
			this.groupBox11.TabIndex = 2;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Stop";
			// 
			// cbStop1
			// 
			this.cbStop1.AutoSize = true;
			this.cbStop1.Checked = true;
			this.cbStop1.Location = new System.Drawing.Point(8, 25);
			this.cbStop1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbStop1.Name = "cbStop1";
			this.cbStop1.Size = new System.Drawing.Size(56, 21);
			this.cbStop1.TabIndex = 0;
			this.cbStop1.TabStop = true;
			this.cbStop1.Text = "1 (*)";
			this.cbStop1.UseVisualStyleBackColor = true;
			// 
			// cbUartStop2
			// 
			this.cbUartStop2.AutoSize = true;
			this.cbUartStop2.Location = new System.Drawing.Point(8, 47);
			this.cbUartStop2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUartStop2.Name = "cbUartStop2";
			this.cbUartStop2.Size = new System.Drawing.Size(37, 21);
			this.cbUartStop2.TabIndex = 1;
			this.cbUartStop2.Text = "2";
			this.cbUartStop2.UseVisualStyleBackColor = true;
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.cbUart9None);
			this.groupBox12.Controls.Add(this.cbUart8Odd);
			this.groupBox12.Controls.Add(this.cbUart8None);
			this.groupBox12.Controls.Add(this.cbUart8Even);
			this.groupBox12.Location = new System.Drawing.Point(124, 23);
			this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox12.Size = new System.Drawing.Size(159, 124);
			this.groupBox12.TabIndex = 1;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Data && Parity";
			// 
			// cbUart9None
			// 
			this.cbUart9None.AutoSize = true;
			this.cbUart9None.Location = new System.Drawing.Point(8, 91);
			this.cbUart9None.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart9None.Name = "cbUart9None";
			this.cbUart9None.Size = new System.Drawing.Size(79, 21);
			this.cbUart9None.TabIndex = 3;
			this.cbUart9None.Text = "9, None";
			this.cbUart9None.UseVisualStyleBackColor = true;
			// 
			// cbUart8Odd
			// 
			this.cbUart8Odd.AutoSize = true;
			this.cbUart8Odd.Location = new System.Drawing.Point(8, 69);
			this.cbUart8Odd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart8Odd.Name = "cbUart8Odd";
			this.cbUart8Odd.Size = new System.Drawing.Size(77, 21);
			this.cbUart8Odd.TabIndex = 2;
			this.cbUart8Odd.Text = "8, Even";
			this.cbUart8Odd.UseVisualStyleBackColor = true;
			// 
			// cbUart8None
			// 
			this.cbUart8None.AutoSize = true;
			this.cbUart8None.Checked = true;
			this.cbUart8None.Location = new System.Drawing.Point(8, 25);
			this.cbUart8None.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart8None.Name = "cbUart8None";
			this.cbUart8None.Size = new System.Drawing.Size(98, 21);
			this.cbUart8None.TabIndex = 0;
			this.cbUart8None.TabStop = true;
			this.cbUart8None.Text = "8, None (*)";
			this.cbUart8None.UseVisualStyleBackColor = true;
			// 
			// cbUart8Even
			// 
			this.cbUart8Even.AutoSize = true;
			this.cbUart8Even.Location = new System.Drawing.Point(8, 47);
			this.cbUart8Even.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart8Even.Name = "cbUart8Even";
			this.cbUart8Even.Size = new System.Drawing.Size(77, 21);
			this.cbUart8Even.TabIndex = 1;
			this.cbUart8Even.Text = "8, Even";
			this.cbUart8Even.UseVisualStyleBackColor = true;
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.cbUart115200);
			this.groupBox13.Controls.Add(this.cbUart57600);
			this.groupBox13.Controls.Add(this.cbUart38400);
			this.groupBox13.Controls.Add(this.cbUart19200);
			this.groupBox13.Controls.Add(this.cbUart9600);
			this.groupBox13.Controls.Add(this.cbUART300);
			this.groupBox13.Controls.Add(this.cbUart1200);
			this.groupBox13.Controls.Add(this.cbUart2400);
			this.groupBox13.Controls.Add(this.cbUart4800);
			this.groupBox13.Location = new System.Drawing.Point(8, 23);
			this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox13.Size = new System.Drawing.Size(108, 238);
			this.groupBox13.TabIndex = 0;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Speed";
			// 
			// cbUart115200
			// 
			this.cbUart115200.AutoSize = true;
			this.cbUart115200.Checked = true;
			this.cbUart115200.Location = new System.Drawing.Point(8, 202);
			this.cbUart115200.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart115200.Name = "cbUart115200";
			this.cbUart115200.Size = new System.Drawing.Size(77, 21);
			this.cbUart115200.TabIndex = 8;
			this.cbUart115200.TabStop = true;
			this.cbUart115200.Text = "115200";
			this.cbUart115200.UseVisualStyleBackColor = true;
			// 
			// cbUart57600
			// 
			this.cbUart57600.AutoSize = true;
			this.cbUart57600.Location = new System.Drawing.Point(8, 180);
			this.cbUart57600.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart57600.Name = "cbUart57600";
			this.cbUart57600.Size = new System.Drawing.Size(69, 21);
			this.cbUart57600.TabIndex = 7;
			this.cbUart57600.Text = "57600";
			this.cbUart57600.UseVisualStyleBackColor = true;
			// 
			// cbUart38400
			// 
			this.cbUart38400.AutoSize = true;
			this.cbUart38400.Location = new System.Drawing.Point(8, 158);
			this.cbUart38400.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart38400.Name = "cbUart38400";
			this.cbUart38400.Size = new System.Drawing.Size(69, 21);
			this.cbUart38400.TabIndex = 6;
			this.cbUart38400.Text = "38400";
			this.cbUart38400.UseVisualStyleBackColor = true;
			// 
			// cbUart19200
			// 
			this.cbUart19200.AutoSize = true;
			this.cbUart19200.Location = new System.Drawing.Point(8, 135);
			this.cbUart19200.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart19200.Name = "cbUart19200";
			this.cbUart19200.Size = new System.Drawing.Size(69, 21);
			this.cbUart19200.TabIndex = 5;
			this.cbUart19200.Text = "19200";
			this.cbUart19200.UseVisualStyleBackColor = true;
			// 
			// cbUart9600
			// 
			this.cbUart9600.AutoSize = true;
			this.cbUart9600.Location = new System.Drawing.Point(8, 113);
			this.cbUart9600.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart9600.Name = "cbUart9600";
			this.cbUart9600.Size = new System.Drawing.Size(61, 21);
			this.cbUart9600.TabIndex = 4;
			this.cbUart9600.Text = "9600";
			this.cbUart9600.UseVisualStyleBackColor = true;
			// 
			// cbUART300
			// 
			this.cbUART300.AutoSize = true;
			this.cbUART300.Location = new System.Drawing.Point(8, 25);
			this.cbUART300.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUART300.Name = "cbUART300";
			this.cbUART300.Size = new System.Drawing.Size(53, 21);
			this.cbUART300.TabIndex = 0;
			this.cbUART300.Text = "300";
			this.cbUART300.UseVisualStyleBackColor = true;
			// 
			// cbUart1200
			// 
			this.cbUart1200.AutoSize = true;
			this.cbUart1200.Location = new System.Drawing.Point(8, 47);
			this.cbUart1200.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart1200.Name = "cbUart1200";
			this.cbUart1200.Size = new System.Drawing.Size(61, 21);
			this.cbUart1200.TabIndex = 1;
			this.cbUart1200.Text = "1200";
			this.cbUart1200.UseVisualStyleBackColor = true;
			// 
			// cbUart2400
			// 
			this.cbUart2400.AutoSize = true;
			this.cbUart2400.Location = new System.Drawing.Point(8, 69);
			this.cbUart2400.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart2400.Name = "cbUart2400";
			this.cbUart2400.Size = new System.Drawing.Size(61, 21);
			this.cbUart2400.TabIndex = 2;
			this.cbUart2400.Text = "2400";
			this.cbUart2400.UseVisualStyleBackColor = true;
			// 
			// cbUart4800
			// 
			this.cbUart4800.AutoSize = true;
			this.cbUart4800.Location = new System.Drawing.Point(8, 91);
			this.cbUart4800.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbUart4800.Name = "cbUart4800";
			this.cbUart4800.Size = new System.Drawing.Size(61, 21);
			this.cbUart4800.TabIndex = 3;
			this.cbUart4800.Text = "4800";
			this.cbUart4800.UseVisualStyleBackColor = true;
			// 
			// group3WIRE
			// 
			this.group3WIRE.Controls.Add(this.groupBox10);
			this.group3WIRE.Controls.Add(this.groupBox14);
			this.group3WIRE.Controls.Add(this.cb3W400);
			this.group3WIRE.Controls.Add(this.cb3W100);
			this.group3WIRE.Controls.Add(this.cb3W50);
			this.group3WIRE.Controls.Add(this.cb3W5);
			this.group3WIRE.Location = new System.Drawing.Point(8, 57);
			this.group3WIRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.group3WIRE.Name = "group3WIRE";
			this.group3WIRE.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.group3WIRE.Size = new System.Drawing.Size(459, 192);
			this.group3WIRE.TabIndex = 6;
			this.group3WIRE.TabStop = false;
			this.group3WIRE.Text = "3WIRE Parameters";
			this.group3WIRE.Visible = false;
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.cb3WCsPositive);
			this.groupBox10.Controls.Add(this.cb3WCsNegative);
			this.groupBox10.Location = new System.Drawing.Point(132, 23);
			this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox10.Size = new System.Drawing.Size(160, 78);
			this.groupBox10.TabIndex = 7;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "CS";
			// 
			// cb3WCsPositive
			// 
			this.cb3WCsPositive.AutoSize = true;
			this.cb3WCsPositive.Location = new System.Drawing.Point(8, 23);
			this.cb3WCsPositive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3WCsPositive.Name = "cb3WCsPositive";
			this.cb3WCsPositive.Size = new System.Drawing.Size(47, 21);
			this.cb3WCsPositive.TabIndex = 0;
			this.cb3WCsPositive.Text = "CS";
			this.cb3WCsPositive.UseVisualStyleBackColor = true;
			// 
			// cb3WCsNegative
			// 
			this.cb3WCsNegative.AutoSize = true;
			this.cb3WCsNegative.Checked = true;
			this.cb3WCsNegative.Location = new System.Drawing.Point(8, 52);
			this.cb3WCsNegative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3WCsNegative.Name = "cb3WCsNegative";
			this.cb3WCsNegative.Size = new System.Drawing.Size(74, 21);
			this.cb3WCsNegative.TabIndex = 1;
			this.cb3WCsNegative.TabStop = true;
			this.cb3WCsNegative.Text = "/ CS (*)";
			this.cb3WCsNegative.UseVisualStyleBackColor = true;
			// 
			// groupBox14
			// 
			this.groupBox14.Controls.Add(this.cb3WOutOC);
			this.groupBox14.Controls.Add(this.cb3WOutNormal);
			this.groupBox14.Location = new System.Drawing.Point(124, 108);
			this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox14.Size = new System.Drawing.Size(327, 78);
			this.groupBox14.TabIndex = 6;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Select output type";
			// 
			// cb3WOutOC
			// 
			this.cb3WOutOC.AutoSize = true;
			this.cb3WOutOC.Location = new System.Drawing.Point(8, 23);
			this.cb3WOutOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3WOutOC.Name = "cb3WOutOC";
			this.cb3WOutOC.Size = new System.Drawing.Size(214, 21);
			this.cb3WOutOC.TabIndex = 0;
			this.cb3WOutOC.Text = "Open drain (H=Hi-Z, L=GND)";
			this.cb3WOutOC.UseVisualStyleBackColor = true;
			// 
			// cb3WOutNormal
			// 
			this.cb3WOutNormal.AutoSize = true;
			this.cb3WOutNormal.Checked = true;
			this.cb3WOutNormal.Location = new System.Drawing.Point(8, 52);
			this.cb3WOutNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3WOutNormal.Name = "cb3WOutNormal";
			this.cb3WOutNormal.Size = new System.Drawing.Size(190, 21);
			this.cb3WOutNormal.TabIndex = 1;
			this.cb3WOutNormal.TabStop = true;
			this.cb3WOutNormal.Text = "Normal (H=3.3V, L=GND)";
			this.cb3WOutNormal.UseVisualStyleBackColor = true;
			// 
			// cb3W400
			// 
			this.cb3W400.AutoSize = true;
			this.cb3W400.Checked = true;
			this.cb3W400.Location = new System.Drawing.Point(12, 108);
			this.cb3W400.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3W400.Name = "cb3W400";
			this.cb3W400.Size = new System.Drawing.Size(79, 21);
			this.cb3W400.TabIndex = 3;
			this.cb3W400.TabStop = true;
			this.cb3W400.Text = "400KHz";
			this.cb3W400.UseVisualStyleBackColor = true;
			// 
			// cb3W100
			// 
			this.cb3W100.AutoSize = true;
			this.cb3W100.Location = new System.Drawing.Point(12, 80);
			this.cb3W100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3W100.Name = "cb3W100";
			this.cb3W100.Size = new System.Drawing.Size(79, 21);
			this.cb3W100.TabIndex = 2;
			this.cb3W100.Text = "100KHz";
			this.cb3W100.UseVisualStyleBackColor = true;
			// 
			// cb3W50
			// 
			this.cb3W50.AutoSize = true;
			this.cb3W50.Location = new System.Drawing.Point(12, 52);
			this.cb3W50.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3W50.Name = "cb3W50";
			this.cb3W50.Size = new System.Drawing.Size(71, 21);
			this.cb3W50.TabIndex = 1;
			this.cb3W50.Text = "50KHz";
			this.cb3W50.UseVisualStyleBackColor = true;
			// 
			// cb3W5
			// 
			this.cb3W5.AutoSize = true;
			this.cb3W5.Location = new System.Drawing.Point(12, 23);
			this.cb3W5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb3W5.Name = "cb3W5";
			this.cb3W5.Size = new System.Drawing.Size(63, 21);
			this.cb3W5.TabIndex = 0;
			this.cb3W5.Text = "5KHz";
			this.cb3W5.UseVisualStyleBackColor = true;
			// 
			// group2WIRE
			// 
			this.group2WIRE.Controls.Add(this.groupBox7);
			this.group2WIRE.Controls.Add(this.cb2W400);
			this.group2WIRE.Controls.Add(this.cb2W100);
			this.group2WIRE.Controls.Add(this.cb2W50);
			this.group2WIRE.Controls.Add(this.cb2W5);
			this.group2WIRE.Location = new System.Drawing.Point(8, 57);
			this.group2WIRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.group2WIRE.Name = "group2WIRE";
			this.group2WIRE.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.group2WIRE.Size = new System.Drawing.Size(459, 140);
			this.group2WIRE.TabIndex = 5;
			this.group2WIRE.TabStop = false;
			this.group2WIRE.Text = "2WIRE Parameters";
			this.group2WIRE.Visible = false;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.cb2WOutOC);
			this.groupBox7.Controls.Add(this.cb2WOutNormal);
			this.groupBox7.Location = new System.Drawing.Point(124, 52);
			this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox7.Size = new System.Drawing.Size(327, 78);
			this.groupBox7.TabIndex = 6;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Select output type";
			// 
			// cb2WOutOC
			// 
			this.cb2WOutOC.AutoSize = true;
			this.cb2WOutOC.Location = new System.Drawing.Point(8, 23);
			this.cb2WOutOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb2WOutOC.Name = "cb2WOutOC";
			this.cb2WOutOC.Size = new System.Drawing.Size(214, 21);
			this.cb2WOutOC.TabIndex = 0;
			this.cb2WOutOC.Text = "Open drain (H=Hi-Z, L=GND)";
			this.cb2WOutOC.UseVisualStyleBackColor = true;
			// 
			// cb2WOutNormal
			// 
			this.cb2WOutNormal.AutoSize = true;
			this.cb2WOutNormal.Checked = true;
			this.cb2WOutNormal.Location = new System.Drawing.Point(8, 52);
			this.cb2WOutNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb2WOutNormal.Name = "cb2WOutNormal";
			this.cb2WOutNormal.Size = new System.Drawing.Size(190, 21);
			this.cb2WOutNormal.TabIndex = 1;
			this.cb2WOutNormal.TabStop = true;
			this.cb2WOutNormal.Text = "Normal (H=3.3V, L=GND)";
			this.cb2WOutNormal.UseVisualStyleBackColor = true;
			// 
			// cb2W400
			// 
			this.cb2W400.AutoSize = true;
			this.cb2W400.Checked = true;
			this.cb2W400.Location = new System.Drawing.Point(12, 108);
			this.cb2W400.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb2W400.Name = "cb2W400";
			this.cb2W400.Size = new System.Drawing.Size(79, 21);
			this.cb2W400.TabIndex = 3;
			this.cb2W400.TabStop = true;
			this.cb2W400.Text = "400KHz";
			this.cb2W400.UseVisualStyleBackColor = true;
			// 
			// cb2W100
			// 
			this.cb2W100.AutoSize = true;
			this.cb2W100.Location = new System.Drawing.Point(12, 80);
			this.cb2W100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb2W100.Name = "cb2W100";
			this.cb2W100.Size = new System.Drawing.Size(79, 21);
			this.cb2W100.TabIndex = 2;
			this.cb2W100.Text = "100KHz";
			this.cb2W100.UseVisualStyleBackColor = true;
			// 
			// cb2W50
			// 
			this.cb2W50.AutoSize = true;
			this.cb2W50.Location = new System.Drawing.Point(12, 52);
			this.cb2W50.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb2W50.Name = "cb2W50";
			this.cb2W50.Size = new System.Drawing.Size(71, 21);
			this.cb2W50.TabIndex = 1;
			this.cb2W50.Text = "50KHz";
			this.cb2W50.UseVisualStyleBackColor = true;
			// 
			// cb2W5
			// 
			this.cb2W5.AutoSize = true;
			this.cb2W5.Location = new System.Drawing.Point(12, 23);
			this.cb2W5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb2W5.Name = "cb2W5";
			this.cb2W5.Size = new System.Drawing.Size(63, 21);
			this.cb2W5.TabIndex = 0;
			this.cb2W5.Text = "5KHz";
			this.cb2W5.UseVisualStyleBackColor = true;
			// 
			// SetMode
			// 
			this.SetMode.Location = new System.Drawing.Point(177, 22);
			this.SetMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.SetMode.Name = "SetMode";
			this.SetMode.Size = new System.Drawing.Size(100, 28);
			this.SetMode.TabIndex = 3;
			this.SetMode.Text = "Set";
			this.SetMode.UseVisualStyleBackColor = true;
			this.SetMode.Click += new System.EventHandler(this.SetMode_Click);
			// 
			// Mode
			// 
			this.Mode.FormattingEnabled = true;
			this.Mode.Items.AddRange(new object[] {
            "HiZ",
            "1-WIRE",
            "UART",
            "I2C",
            "SPI",
            "2WIRE",
            "3WIRE",
            "LCD"});
			this.Mode.Location = new System.Drawing.Point(8, 23);
			this.Mode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Mode.Name = "Mode";
			this.Mode.Size = new System.Drawing.Size(159, 24);
			this.Mode.TabIndex = 0;
			this.Mode.SelectedIndexChanged += new System.EventHandler(this.Mode_SelectedIndexChanged);
			// 
			// groupCommand
			// 
			this.groupCommand.Controls.Add(this.Interval);
			this.groupCommand.Controls.Add(this.label12);
			this.groupCommand.Controls.Add(this.label11);
			this.groupCommand.Controls.Add(this.label10);
			this.groupCommand.Controls.Add(this.label9);
			this.groupCommand.Controls.Add(this.label8);
			this.groupCommand.Controls.Add(this.label7);
			this.groupCommand.Controls.Add(this.label6);
			this.groupCommand.Controls.Add(this.label5);
			this.groupCommand.Controls.Add(this.label4);
			this.groupCommand.Controls.Add(this.label3);
			this.groupCommand.Controls.Add(this.label2);
			this.groupCommand.Controls.Add(this.ClearLog);
			this.groupCommand.Controls.Add(this.AutoInfo);
			this.groupCommand.Controls.Add(this.value2);
			this.groupCommand.Controls.Add(this.name2);
			this.groupCommand.Controls.Add(this.value3);
			this.groupCommand.Controls.Add(this.name3);
			this.groupCommand.Controls.Add(this.value4);
			this.groupCommand.Controls.Add(this.name4);
			this.groupCommand.Controls.Add(this.value5);
			this.groupCommand.Controls.Add(this.name5);
			this.groupCommand.Controls.Add(this.value6);
			this.groupCommand.Controls.Add(this.mode6);
			this.groupCommand.Controls.Add(this.name6);
			this.groupCommand.Controls.Add(this.value7);
			this.groupCommand.Controls.Add(this.mode7);
			this.groupCommand.Controls.Add(this.name7);
			this.groupCommand.Controls.Add(this.value8);
			this.groupCommand.Controls.Add(this.mode8);
			this.groupCommand.Controls.Add(this.name8);
			this.groupCommand.Controls.Add(this.value9);
			this.groupCommand.Controls.Add(this.mode9);
			this.groupCommand.Controls.Add(this.name9);
			this.groupCommand.Controls.Add(this.value10);
			this.groupCommand.Controls.Add(this.mode10);
			this.groupCommand.Controls.Add(this.name10);
			this.groupCommand.Controls.Add(this.Info);
			this.groupCommand.Controls.Add(this.Reset);
			this.groupCommand.Controls.Add(this.Voltage);
			this.groupCommand.Controls.Add(this.PowerOn);
			this.groupCommand.Controls.Add(this.PowerOff);
			this.groupCommand.Controls.Add(this.Delay_mS);
			this.groupCommand.Controls.Add(this.Delay);
			this.groupCommand.Controls.Add(this.Delay_uS);
			this.groupCommand.Controls.Add(this.AuxRead);
			this.groupCommand.Controls.Add(this.AuxHigh);
			this.groupCommand.Controls.Add(this.AuxLow);
			this.groupCommand.Enabled = false;
			this.groupCommand.Location = new System.Drawing.Point(20, 402);
			this.groupCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupCommand.Name = "groupCommand";
			this.groupCommand.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupCommand.Size = new System.Drawing.Size(475, 342);
			this.groupCommand.TabIndex = 9;
			this.groupCommand.TabStop = false;
			this.groupCommand.Text = "Commands";
			// 
			// Interval
			// 
			this.Interval.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.Interval.Location = new System.Drawing.Point(16, 112);
			this.Interval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.Interval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.Interval.Name = "Interval";
			this.Interval.Size = new System.Drawing.Size(92, 22);
			this.Interval.TabIndex = 47;
			this.Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Interval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(119, 149);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 28);
			this.label12.TabIndex = 46;
			this.label12.Text = "GND";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(224, 272);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(16, 17);
			this.label11.TabIndex = 45;
			this.label11.Text = "1";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(189, 272);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(16, 17);
			this.label10.TabIndex = 44;
			this.label10.Text = "2";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(224, 244);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 17);
			this.label9.TabIndex = 43;
			this.label9.Text = "3";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(189, 244);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 17);
			this.label8.TabIndex = 42;
			this.label8.Text = "4";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(224, 155);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 17);
			this.label7.TabIndex = 41;
			this.label7.Text = "9";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(189, 185);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 17);
			this.label6.TabIndex = 40;
			this.label6.Text = "8";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(224, 185);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 17);
			this.label5.TabIndex = 39;
			this.label5.Text = "7";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(189, 214);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 17);
			this.label4.TabIndex = 38;
			this.label4.Text = "6";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 214);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 17);
			this.label3.TabIndex = 37;
			this.label3.Text = "5";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(189, 155);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 17);
			this.label2.TabIndex = 36;
			this.label2.Text = "10";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ClearLog
			// 
			this.ClearLog.Location = new System.Drawing.Point(367, 306);
			this.ClearLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ClearLog.Name = "ClearLog";
			this.ClearLog.Size = new System.Drawing.Size(100, 28);
			this.ClearLog.TabIndex = 35;
			this.ClearLog.Text = "Clear Log";
			this.ClearLog.UseVisualStyleBackColor = true;
			this.ClearLog.Click += new System.EventHandler(this.ClearLog_Click);
			// 
			// AutoInfo
			// 
			this.AutoInfo.AutoSize = true;
			this.AutoInfo.Checked = true;
			this.AutoInfo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoInfo.Location = new System.Drawing.Point(111, 113);
			this.AutoInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.AutoInfo.Name = "AutoInfo";
			this.AutoInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.AutoInfo.Size = new System.Drawing.Size(111, 21);
			this.AutoInfo.TabIndex = 7;
			this.AutoInfo.Text = "Auto Voltage";
			this.AutoInfo.UseVisualStyleBackColor = true;
			this.AutoInfo.CheckedChanged += new System.EventHandler(this.AutoInfo_CheckedChanged);
			// 
			// value2
			// 
			this.value2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value2.Location = new System.Drawing.Point(316, 149);
			this.value2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value2.Name = "value2";
			this.value2.Size = new System.Drawing.Size(53, 28);
			this.value2.TabIndex = 34;
			this.value2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// name2
			// 
			this.name2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name2.Location = new System.Drawing.Point(248, 149);
			this.name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name2.Name = "name2";
			this.name2.Size = new System.Drawing.Size(67, 28);
			this.name2.TabIndex = 33;
			this.name2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// value3
			// 
			this.value3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value3.Location = new System.Drawing.Point(51, 178);
			this.value3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value3.Name = "value3";
			this.value3.Size = new System.Drawing.Size(67, 28);
			this.value3.TabIndex = 32;
			this.value3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// name3
			// 
			this.name3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name3.Location = new System.Drawing.Point(119, 178);
			this.name3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name3.Name = "name3";
			this.name3.Size = new System.Drawing.Size(67, 28);
			this.name3.TabIndex = 31;
			this.name3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// value4
			// 
			this.value4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value4.Location = new System.Drawing.Point(316, 178);
			this.value4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value4.Name = "value4";
			this.value4.Size = new System.Drawing.Size(53, 28);
			this.value4.TabIndex = 30;
			this.value4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// name4
			// 
			this.name4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name4.Location = new System.Drawing.Point(248, 178);
			this.name4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name4.Name = "name4";
			this.name4.Size = new System.Drawing.Size(67, 28);
			this.name4.TabIndex = 29;
			this.name4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// value5
			// 
			this.value5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value5.Location = new System.Drawing.Point(51, 208);
			this.value5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value5.Name = "value5";
			this.value5.Size = new System.Drawing.Size(67, 28);
			this.value5.TabIndex = 28;
			this.value5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// name5
			// 
			this.name5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name5.Location = new System.Drawing.Point(119, 208);
			this.name5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name5.Name = "name5";
			this.name5.Size = new System.Drawing.Size(67, 28);
			this.name5.TabIndex = 27;
			this.name5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// value6
			// 
			this.value6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value6.Location = new System.Drawing.Point(316, 208);
			this.value6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value6.Name = "value6";
			this.value6.Size = new System.Drawing.Size(53, 28);
			this.value6.TabIndex = 26;
			this.value6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mode6
			// 
			this.mode6.BackColor = System.Drawing.SystemColors.Control;
			this.mode6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mode6.ForeColor = System.Drawing.Color.White;
			this.mode6.Location = new System.Drawing.Point(373, 208);
			this.mode6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mode6.Name = "mode6";
			this.mode6.Size = new System.Drawing.Size(31, 28);
			this.mode6.TabIndex = 25;
			this.mode6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// name6
			// 
			this.name6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name6.Location = new System.Drawing.Point(248, 208);
			this.name6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name6.Name = "name6";
			this.name6.Size = new System.Drawing.Size(67, 28);
			this.name6.TabIndex = 24;
			this.name6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// value7
			// 
			this.value7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value7.Location = new System.Drawing.Point(119, 238);
			this.value7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value7.Name = "value7";
			this.value7.Size = new System.Drawing.Size(67, 28);
			this.value7.TabIndex = 23;
			this.value7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mode7
			// 
			this.mode7.BackColor = System.Drawing.SystemColors.Control;
			this.mode7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mode7.ForeColor = System.Drawing.Color.White;
			this.mode7.Location = new System.Drawing.Point(16, 238);
			this.mode7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mode7.Name = "mode7";
			this.mode7.Size = new System.Drawing.Size(31, 28);
			this.mode7.TabIndex = 22;
			this.mode7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// name7
			// 
			this.name7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name7.Location = new System.Drawing.Point(51, 238);
			this.name7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name7.Name = "name7";
			this.name7.Size = new System.Drawing.Size(67, 28);
			this.name7.TabIndex = 21;
			this.name7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// value8
			// 
			this.value8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value8.Location = new System.Drawing.Point(316, 238);
			this.value8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value8.Name = "value8";
			this.value8.Size = new System.Drawing.Size(53, 28);
			this.value8.TabIndex = 20;
			this.value8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mode8
			// 
			this.mode8.BackColor = System.Drawing.SystemColors.Control;
			this.mode8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mode8.ForeColor = System.Drawing.Color.White;
			this.mode8.Location = new System.Drawing.Point(373, 238);
			this.mode8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mode8.Name = "mode8";
			this.mode8.Size = new System.Drawing.Size(31, 28);
			this.mode8.TabIndex = 19;
			this.mode8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// name8
			// 
			this.name8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name8.Location = new System.Drawing.Point(248, 238);
			this.name8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name8.Name = "name8";
			this.name8.Size = new System.Drawing.Size(67, 28);
			this.name8.TabIndex = 18;
			this.name8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// value9
			// 
			this.value9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value9.Location = new System.Drawing.Point(119, 266);
			this.value9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value9.Name = "value9";
			this.value9.Size = new System.Drawing.Size(67, 28);
			this.value9.TabIndex = 17;
			this.value9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mode9
			// 
			this.mode9.BackColor = System.Drawing.SystemColors.Control;
			this.mode9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mode9.ForeColor = System.Drawing.Color.White;
			this.mode9.Location = new System.Drawing.Point(16, 266);
			this.mode9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mode9.Name = "mode9";
			this.mode9.Size = new System.Drawing.Size(31, 28);
			this.mode9.TabIndex = 16;
			this.mode9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// name9
			// 
			this.name9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name9.Location = new System.Drawing.Point(51, 266);
			this.name9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name9.Name = "name9";
			this.name9.Size = new System.Drawing.Size(67, 28);
			this.name9.TabIndex = 15;
			this.name9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// value10
			// 
			this.value10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.value10.Location = new System.Drawing.Point(316, 266);
			this.value10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.value10.Name = "value10";
			this.value10.Size = new System.Drawing.Size(53, 28);
			this.value10.TabIndex = 14;
			this.value10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mode10
			// 
			this.mode10.BackColor = System.Drawing.SystemColors.Control;
			this.mode10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mode10.ForeColor = System.Drawing.Color.White;
			this.mode10.Location = new System.Drawing.Point(373, 266);
			this.mode10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mode10.Name = "mode10";
			this.mode10.Size = new System.Drawing.Size(31, 28);
			this.mode10.TabIndex = 13;
			this.mode10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// name10
			// 
			this.name10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.name10.Location = new System.Drawing.Point(248, 266);
			this.name10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name10.Name = "name10";
			this.name10.Size = new System.Drawing.Size(67, 28);
			this.name10.TabIndex = 12;
			this.name10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Info
			// 
			this.Info.Location = new System.Drawing.Point(233, 80);
			this.Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Info.Name = "Info";
			this.Info.Size = new System.Drawing.Size(100, 28);
			this.Info.TabIndex = 6;
			this.Info.Text = "Info";
			this.Info.UseVisualStyleBackColor = true;
			this.Info.Click += new System.EventHandler(this.Info_Click);
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(367, 108);
			this.Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(100, 28);
			this.Reset.TabIndex = 11;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// Voltage
			// 
			this.Voltage.Location = new System.Drawing.Point(233, 108);
			this.Voltage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Voltage.Name = "Voltage";
			this.Voltage.Size = new System.Drawing.Size(100, 28);
			this.Voltage.TabIndex = 8;
			this.Voltage.Text = "Voltage";
			this.Voltage.UseVisualStyleBackColor = true;
			this.Voltage.Click += new System.EventHandler(this.Voltage_Click);
			// 
			// PowerOn
			// 
			this.PowerOn.Location = new System.Drawing.Point(367, 52);
			this.PowerOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PowerOn.Name = "PowerOn";
			this.PowerOn.Size = new System.Drawing.Size(100, 28);
			this.PowerOn.TabIndex = 10;
			this.PowerOn.Text = "Power On";
			this.PowerOn.UseVisualStyleBackColor = true;
			this.PowerOn.Click += new System.EventHandler(this.PowerOn_Click);
			// 
			// PowerOff
			// 
			this.PowerOff.Location = new System.Drawing.Point(367, 22);
			this.PowerOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PowerOff.Name = "PowerOff";
			this.PowerOff.Size = new System.Drawing.Size(100, 28);
			this.PowerOff.TabIndex = 9;
			this.PowerOff.Text = "Power Off";
			this.PowerOff.UseVisualStyleBackColor = true;
			this.PowerOff.Click += new System.EventHandler(this.PowerOff_Click);
			// 
			// Delay_mS
			// 
			this.Delay_mS.Location = new System.Drawing.Point(233, 52);
			this.Delay_mS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Delay_mS.Name = "Delay_mS";
			this.Delay_mS.Size = new System.Drawing.Size(100, 28);
			this.Delay_mS.TabIndex = 5;
			this.Delay_mS.Text = "Delay mS";
			this.Delay_mS.UseVisualStyleBackColor = true;
			this.Delay_mS.Click += new System.EventHandler(this.Delay_mS_Click);
			// 
			// Delay
			// 
			this.Delay.Location = new System.Drawing.Point(144, 26);
			this.Delay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Delay.Name = "Delay";
			this.Delay.Size = new System.Drawing.Size(83, 22);
			this.Delay.TabIndex = 3;
			this.Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Delay_uS
			// 
			this.Delay_uS.Location = new System.Drawing.Point(233, 23);
			this.Delay_uS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Delay_uS.Name = "Delay_uS";
			this.Delay_uS.Size = new System.Drawing.Size(100, 28);
			this.Delay_uS.TabIndex = 4;
			this.Delay_uS.Text = "Delay uS";
			this.Delay_uS.UseVisualStyleBackColor = true;
			this.Delay_uS.Click += new System.EventHandler(this.Delay_uS_Click);
			// 
			// AuxRead
			// 
			this.AuxRead.Location = new System.Drawing.Point(16, 80);
			this.AuxRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.AuxRead.Name = "AuxRead";
			this.AuxRead.Size = new System.Drawing.Size(100, 28);
			this.AuxRead.TabIndex = 2;
			this.AuxRead.Text = "AUX Read";
			this.AuxRead.UseVisualStyleBackColor = true;
			this.AuxRead.Click += new System.EventHandler(this.AuxRead_Click);
			// 
			// AuxHigh
			// 
			this.AuxHigh.Location = new System.Drawing.Point(16, 52);
			this.AuxHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.AuxHigh.Name = "AuxHigh";
			this.AuxHigh.Size = new System.Drawing.Size(100, 28);
			this.AuxHigh.TabIndex = 1;
			this.AuxHigh.Text = "AUX High";
			this.AuxHigh.UseVisualStyleBackColor = true;
			this.AuxHigh.Click += new System.EventHandler(this.AuxHigh_Click);
			// 
			// AuxLow
			// 
			this.AuxLow.Location = new System.Drawing.Point(16, 23);
			this.AuxLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.AuxLow.Name = "AuxLow";
			this.AuxLow.Size = new System.Drawing.Size(100, 28);
			this.AuxLow.TabIndex = 0;
			this.AuxLow.Text = "AUX Low";
			this.AuxLow.UseVisualStyleBackColor = true;
			this.AuxLow.Click += new System.EventHandler(this.AuxLow_Click);
			// 
			// Run
			// 
			this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Run.Location = new System.Drawing.Point(1196, 28);
			this.Run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Run.Name = "Run";
			this.Run.Size = new System.Drawing.Size(100, 28);
			this.Run.TabIndex = 7;
			this.Run.Text = "F5 - Run";
			this.Run.UseVisualStyleBackColor = true;
			this.Run.Click += new System.EventHandler(this.Run_Click);
			// 
			// openDialog
			// 
			this.openDialog.DefaultExt = "bp";
			this.openDialog.Filter = "BusPirate scripts|*.bp|All Files|*.*";
			this.openDialog.RestoreDirectory = true;
			// 
			// saveDialog
			// 
			this.saveDialog.DefaultExt = "bp";
			this.saveDialog.Filter = "BusPirate scripts|*.bp|All Files|*.*";
			this.saveDialog.RestoreDirectory = true;
			// 
			// FileName
			// 
			this.FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FileName.Location = new System.Drawing.Point(503, 31);
			this.FileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FileName.Name = "FileName";
			this.FileName.Size = new System.Drawing.Size(303, 22);
			this.FileName.TabIndex = 2;
			// 
			// Browse
			// 
			this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Browse.Location = new System.Drawing.Point(815, 28);
			this.Browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(33, 28);
			this.Browse.TabIndex = 3;
			this.Browse.Text = "...";
			this.Browse.UseVisualStyleBackColor = true;
			this.Browse.Click += new System.EventHandler(this.Browse_Click);
			// 
			// Open
			// 
			this.Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Open.Location = new System.Drawing.Point(856, 28);
			this.Open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Open.Name = "Open";
			this.Open.Size = new System.Drawing.Size(100, 28);
			this.Open.TabIndex = 4;
			this.Open.Text = "F2 - Open";
			this.Open.UseVisualStyleBackColor = true;
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// Save
			// 
			this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Save.Location = new System.Drawing.Point(964, 28);
			this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(100, 28);
			this.Save.TabIndex = 5;
			this.Save.Text = "F3 - Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Tab
			// 
			this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Tab.Location = new System.Drawing.Point(1088, 28);
			this.Tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Tab.Name = "Tab";
			this.Tab.Size = new System.Drawing.Size(100, 28);
			this.Tab.TabIndex = 11;
			this.Tab.Text = "Insert TAB";
			this.Tab.UseVisualStyleBackColor = true;
			this.Tab.Click += new System.EventHandler(this.Tab_Click);
			// 
			// timer
			// 
			this.timer.Interval = 5000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(500, 10);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(69, 17);
			this.label13.TabIndex = 12;
			this.label13.Text = "File name";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InfoPanel
			// 
			this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InfoPanel.Location = new System.Drawing.Point(503, 62);
			this.InfoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.InfoPanel.Name = "InfoPanel";
			this.InfoPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// InfoPanel.Panel1
			// 
			this.InfoPanel.Panel1.Controls.Add(this.Script);
			// 
			// InfoPanel.Panel2
			// 
			this.InfoPanel.Panel2.Controls.Add(this.Log);
			this.InfoPanel.Size = new System.Drawing.Size(793, 679);
			this.InfoPanel.SplitterDistance = 324;
			this.InfoPanel.SplitterWidth = 5;
			this.InfoPanel.TabIndex = 13;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 758);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1312, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Status
			// 
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(1297, 17);
			this.Status.Spring = true;
			this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Script
			// 
			this.Script.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Script.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Script.Location = new System.Drawing.Point(0, 0);
			this.Script.Margin = new System.Windows.Forms.Padding(4);
			this.Script.Multiline = true;
			this.Script.Name = "Script";
			this.Script.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Script.Size = new System.Drawing.Size(793, 324);
			this.Script.TabIndex = 6;
			this.Script.WordWrap = false;
			this.Script.TextChanged += new System.EventHandler(this.Script_TextChanged);
			// 
			// Log
			// 
			this.Log.BackColor = System.Drawing.SystemColors.Window;
			this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Log.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Log.Location = new System.Drawing.Point(0, 0);
			this.Log.Margin = new System.Windows.Forms.Padding(4);
			this.Log.Multiline = true;
			this.Log.Name = "Log";
			this.Log.ReadOnly = true;
			this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Log.Size = new System.Drawing.Size(793, 350);
			this.Log.TabIndex = 10;
			this.Log.WordWrap = false;
			this.Log.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Log_KeyPress);
			// 
			// BPConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1312, 780);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.InfoPanel);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.Tab);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Open);
			this.Controls.Add(this.Browse);
			this.Controls.Add(this.FileName);
			this.Controls.Add(this.Run);
			this.Controls.Add(this.groupCommand);
			this.Controls.Add(this.Connect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ComPort);
			this.Controls.Add(this.groupMode);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "BPConsole";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BusPirate Control";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BPConsole_KeyUp);
			this.groupMode.ResumeLayout(false);
			this.groupSPI.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupI2C.ResumeLayout(false);
			this.groupI2C.PerformLayout();
			this.groupUART.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.groupBox13.ResumeLayout(false);
			this.groupBox13.PerformLayout();
			this.group3WIRE.ResumeLayout(false);
			this.group3WIRE.PerformLayout();
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox14.ResumeLayout(false);
			this.groupBox14.PerformLayout();
			this.group2WIRE.ResumeLayout(false);
			this.group2WIRE.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupCommand.ResumeLayout(false);
			this.groupCommand.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
			this.InfoPanel.Panel1.ResumeLayout(false);
			this.InfoPanel.Panel1.PerformLayout();
			this.InfoPanel.Panel2.ResumeLayout(false);
			this.InfoPanel.Panel2.PerformLayout();
			this.InfoPanel.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ComPort;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Connect;
		private System.Windows.Forms.GroupBox groupMode;
		private System.Windows.Forms.ComboBox Mode;
		private System.Windows.Forms.Button SetMode;
		private System.Windows.Forms.GroupBox groupSPI;
		private System.Windows.Forms.GroupBox groupI2C;
		private System.Windows.Forms.RadioButton cbI2C5;
		private System.Windows.Forms.RadioButton cbI2C400;
		private System.Windows.Forms.RadioButton cbI2C100;
		private System.Windows.Forms.RadioButton cbI2C50;
		private System.Windows.Forms.RadioButton cbSpiPolarityLow;
		private System.Windows.Forms.RadioButton cbSpiPolarityHigh;
		private System.Windows.Forms.RadioButton cbSpi1000;
		private System.Windows.Forms.RadioButton cbSpi250;
		private System.Windows.Forms.RadioButton cbSpi125;
		private System.Windows.Forms.RadioButton cbSpi30;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton cbSpiInputMiddle;
		private System.Windows.Forms.RadioButton cbSpiInputEnd;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton cbSpiEdgeIdle;
		private System.Windows.Forms.RadioButton cbSpiEdgeActive;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.RadioButton cbSpiOutOC;
		private System.Windows.Forms.RadioButton cbSpiOutNormal;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton cbSpiCsPositive;
		private System.Windows.Forms.RadioButton cbSpiCsNegative;
		private TextBoxEx Log;
		private System.Windows.Forms.GroupBox groupCommand;
		private System.Windows.Forms.Button AuxLow;
		private System.Windows.Forms.Button AuxHigh;
		private System.Windows.Forms.Button AuxRead;
		private System.Windows.Forms.Button Delay_mS;
		private System.Windows.Forms.NumericUpDown Delay;
		private System.Windows.Forms.Button Delay_uS;
		private System.Windows.Forms.Button PowerOn;
		private System.Windows.Forms.Button PowerOff;
		private System.Windows.Forms.Button Voltage;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button Info;
		private System.Windows.Forms.Label value10;
		private System.Windows.Forms.Label mode10;
		private System.Windows.Forms.Label name10;
		private System.Windows.Forms.Label value9;
		private System.Windows.Forms.Label mode9;
		private System.Windows.Forms.Label name9;
		private System.Windows.Forms.Label value7;
		private System.Windows.Forms.Label mode7;
		private System.Windows.Forms.Label name7;
		private System.Windows.Forms.Label value8;
		private System.Windows.Forms.Label mode8;
		private System.Windows.Forms.Label name8;
		private System.Windows.Forms.Label value6;
		private System.Windows.Forms.Label mode6;
		private System.Windows.Forms.Label name6;
		private System.Windows.Forms.Label value5;
		private System.Windows.Forms.Label name5;
		private System.Windows.Forms.Label value4;
		private System.Windows.Forms.Label name4;
		private System.Windows.Forms.Label value3;
		private System.Windows.Forms.Label name3;
		private System.Windows.Forms.Label value2;
		private System.Windows.Forms.Label name2;
		private System.Windows.Forms.GroupBox groupUART;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.RadioButton cbUartOutOC;
		private System.Windows.Forms.RadioButton cbUartOutNormal;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.RadioButton cbIdle1;
		private System.Windows.Forms.RadioButton cbUartIdle0;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.RadioButton cbStop1;
		private System.Windows.Forms.RadioButton cbUartStop2;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.RadioButton cbUart8None;
		private System.Windows.Forms.RadioButton cbUart8Even;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.RadioButton cbUART300;
		private System.Windows.Forms.RadioButton cbUart1200;
		private System.Windows.Forms.RadioButton cbUart2400;
		private System.Windows.Forms.RadioButton cbUart4800;
		private System.Windows.Forms.RadioButton cbUart57600;
		private System.Windows.Forms.RadioButton cbUart38400;
		private System.Windows.Forms.RadioButton cbUart19200;
		private System.Windows.Forms.RadioButton cbUart9600;
		private System.Windows.Forms.RadioButton cbUart115200;
		private System.Windows.Forms.RadioButton cbUart9None;
		private System.Windows.Forms.RadioButton cbUart8Odd;
		private TextBoxEx Script;
		private System.Windows.Forms.Button Run;
		private System.Windows.Forms.OpenFileDialog openDialog;
		private System.Windows.Forms.SaveFileDialog saveDialog;
		private System.Windows.Forms.TextBox FileName;
		private System.Windows.Forms.Button Browse;
		private System.Windows.Forms.Button Open;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Tab;
		private System.Windows.Forms.CheckBox AutoInfo;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button ClearLog;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown Interval;
		private System.Windows.Forms.GroupBox group2WIRE;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton cb2WOutOC;
		private System.Windows.Forms.RadioButton cb2WOutNormal;
		private System.Windows.Forms.RadioButton cb2W400;
		private System.Windows.Forms.RadioButton cb2W100;
		private System.Windows.Forms.RadioButton cb2W50;
		private System.Windows.Forms.RadioButton cb2W5;
		private System.Windows.Forms.GroupBox group3WIRE;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.RadioButton cb3WCsPositive;
		private System.Windows.Forms.RadioButton cb3WCsNegative;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.RadioButton cb3WOutOC;
		private System.Windows.Forms.RadioButton cb3WOutNormal;
		private System.Windows.Forms.RadioButton cb3W400;
		private System.Windows.Forms.RadioButton cb3W100;
		private System.Windows.Forms.RadioButton cb3W50;
		private System.Windows.Forms.RadioButton cb3W5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.SplitContainer InfoPanel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel Status;
	}
}

