namespace SerialPortRead
{
    partial class FYP_Perimeter_read
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FYP_Perimeter_read));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortLabel = new System.Windows.Forms.Label();
            this.PorttextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.LenthLabel = new System.Windows.Forms.Label();
            this.CmdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.DataLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScaledomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.zLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.GraphpictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RawDataLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.EnDataBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.Write_CTL_REG_BTN = new System.Windows.Forms.Button();
            this.TempLabel = new System.Windows.Forms.Label();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearLogBtn = new System.Windows.Forms.Button();
            this.EnIntBtn = new System.Windows.Forms.Button();
            this.HRlabel = new System.Windows.Forms.Label();
            this.CtlValTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.RawDataLabel2 = new System.Windows.Forms.Label();
            this.PPGinvertcheckBox = new System.Windows.Forms.CheckBox();
            this.connectgroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CommandgroupBox = new System.Windows.Forms.GroupBox();
            this.PlotgroupBox = new System.Windows.Forms.GroupBox();
            this.StatusgroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MagLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AlertcheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).BeginInit();
            this.connectgroupBox.SuspendLayout();
            this.CommandgroupBox.SuspendLayout();
            this.PlotgroupBox.SuspendLayout();
            this.StatusgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 256000;
            this.serialPort1.PortName = "COM22";
            this.serialPort1.ReadBufferSize = 50;
            this.serialPort1.ReadTimeout = 5;
            this.serialPort1.ReceivedBytesThreshold = 5;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(12, 14);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(58, 13);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Serial Port:";
            // 
            // PorttextBox
            // 
            this.PorttextBox.Location = new System.Drawing.Point(76, 11);
            this.PorttextBox.Name = "PorttextBox";
            this.PorttextBox.Size = new System.Drawing.Size(70, 20);
            this.PorttextBox.TabIndex = 1;
            this.PorttextBox.Text = "COM22";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(150, 9);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Open Port";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LenthLabel
            // 
            this.LenthLabel.AutoSize = true;
            this.LenthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LenthLabel.Location = new System.Drawing.Point(97, 31);
            this.LenthLabel.Name = "LenthLabel";
            this.LenthLabel.Size = new System.Drawing.Size(40, 13);
            this.LenthLabel.TabIndex = 5;
            this.LenthLabel.Text = "Lenght";
            // 
            // CmdTextBox
            // 
            this.CmdTextBox.Location = new System.Drawing.Point(81, 62);
            this.CmdTextBox.Name = "CmdTextBox";
            this.CmdTextBox.Size = new System.Drawing.Size(165, 20);
            this.CmdTextBox.TabIndex = 13;
            this.CmdTextBox.Text = "000504050015000101";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Command:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(252, 60);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 16;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(97, 18);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(30, 13);
            this.DataLabel.TabIndex = 17;
            this.DataLabel.Text = "Data";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(97, 70);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 18;
            this.StatusLabel.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Scale:";
            // 
            // ScaledomainUpDown
            // 
            this.ScaledomainUpDown.Items.Add("1");
            this.ScaledomainUpDown.Items.Add("2");
            this.ScaledomainUpDown.Items.Add("3");
            this.ScaledomainUpDown.Items.Add("4");
            this.ScaledomainUpDown.Items.Add("5");
            this.ScaledomainUpDown.Items.Add("6");
            this.ScaledomainUpDown.Items.Add("7");
            this.ScaledomainUpDown.Items.Add("8");
            this.ScaledomainUpDown.Items.Add("9");
            this.ScaledomainUpDown.Items.Add("10");
            this.ScaledomainUpDown.Items.Add("11");
            this.ScaledomainUpDown.Items.Add("12");
            this.ScaledomainUpDown.Items.Add("13");
            this.ScaledomainUpDown.Items.Add("14");
            this.ScaledomainUpDown.Location = new System.Drawing.Point(48, 62);
            this.ScaledomainUpDown.Name = "ScaledomainUpDown";
            this.ScaledomainUpDown.ReadOnly = true;
            this.ScaledomainUpDown.Size = new System.Drawing.Size(36, 20);
            this.ScaledomainUpDown.TabIndex = 22;
            this.ScaledomainUpDown.Text = "1";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.zLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zLabel.Location = new System.Drawing.Point(176, 44);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(14, 13);
            this.zLabel.TabIndex = 21;
            this.zLabel.Text = "Z";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.yLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yLabel.Location = new System.Drawing.Point(136, 44);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 20;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.xLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xLabel.Location = new System.Drawing.Point(97, 44);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 19;
            this.xLabel.Text = "X";
            // 
            // GraphpictureBox
            // 
            this.GraphpictureBox.BackColor = System.Drawing.Color.Black;
            this.GraphpictureBox.Location = new System.Drawing.Point(12, 47);
            this.GraphpictureBox.Name = "GraphpictureBox";
            this.GraphpictureBox.Size = new System.Drawing.Size(719, 276);
            this.GraphpictureBox.TabIndex = 24;
            this.GraphpictureBox.TabStop = false;
            this.GraphpictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphpictureBox_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "ADC Magnitude:";
            // 
            // RawDataLabel
            // 
            this.RawDataLabel.AutoSize = true;
            this.RawDataLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RawDataLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RawDataLabel.Location = new System.Drawing.Point(96, 57);
            this.RawDataLabel.Name = "RawDataLabel";
            this.RawDataLabel.Size = new System.Drawing.Size(54, 13);
            this.RawDataLabel.TabIndex = 25;
            this.RawDataLabel.Text = "RAWdata";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(138, 28);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 27;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(138, 67);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.DisconnectBtn.TabIndex = 28;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // EnDataBtn
            // 
            this.EnDataBtn.Location = new System.Drawing.Point(21, 27);
            this.EnDataBtn.Name = "EnDataBtn";
            this.EnDataBtn.Size = new System.Drawing.Size(103, 23);
            this.EnDataBtn.TabIndex = 29;
            this.EnDataBtn.Text = "Enable Data";
            this.EnDataBtn.UseVisualStyleBackColor = true;
            this.EnDataBtn.Click += new System.EventHandler(this.WriteBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(50, 13);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(84, 20);
            this.AddressTextBox.TabIndex = 31;
            this.AddressTextBox.Text = "95d460800700";
            // 
            // Write_CTL_REG_BTN
            // 
            this.Write_CTL_REG_BTN.Location = new System.Drawing.Point(252, 86);
            this.Write_CTL_REG_BTN.Name = "Write_CTL_REG_BTN";
            this.Write_CTL_REG_BTN.Size = new System.Drawing.Size(75, 23);
            this.Write_CTL_REG_BTN.TabIndex = 32;
            this.Write_CTL_REG_BTN.Text = "Write CTL REG";
            this.Write_CTL_REG_BTN.UseVisualStyleBackColor = true;
            this.Write_CTL_REG_BTN.Click += new System.EventHandler(this.Write_CTL_REG_BTN_Click);
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TempLabel.ForeColor = System.Drawing.Color.Red;
            this.TempLabel.Location = new System.Drawing.Point(300, 12);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(49, 20);
            this.TempLabel.TabIndex = 33;
            this.TempLabel.Text = "Temp";
            // 
            // EventListBox
            // 
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.Location = new System.Drawing.Point(737, 50);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.Size = new System.Drawing.Size(251, 459);
            this.EventListBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Event Log:";
            // 
            // ClearLogBtn
            // 
            this.ClearLogBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearLogBtn.Location = new System.Drawing.Point(913, 519);
            this.ClearLogBtn.Name = "ClearLogBtn";
            this.ClearLogBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearLogBtn.TabIndex = 36;
            this.ClearLogBtn.Text = "Clear Log";
            this.ClearLogBtn.UseVisualStyleBackColor = true;
            this.ClearLogBtn.Click += new System.EventHandler(this.ClearLogBtn_Click);
            // 
            // EnIntBtn
            // 
            this.EnIntBtn.Location = new System.Drawing.Point(130, 27);
            this.EnIntBtn.Name = "EnIntBtn";
            this.EnIntBtn.Size = new System.Drawing.Size(103, 23);
            this.EnIntBtn.TabIndex = 37;
            this.EnIntBtn.Text = "Enable Interrupt";
            this.EnIntBtn.UseVisualStyleBackColor = true;
            this.EnIntBtn.Click += new System.EventHandler(this.EnIntBtn_Click);
            // 
            // HRlabel
            // 
            this.HRlabel.AutoSize = true;
            this.HRlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.HRlabel.ForeColor = System.Drawing.Color.Red;
            this.HRlabel.Location = new System.Drawing.Point(415, 11);
            this.HRlabel.Name = "HRlabel";
            this.HRlabel.Size = new System.Drawing.Size(33, 20);
            this.HRlabel.TabIndex = 38;
            this.HRlabel.Text = "HR";
            // 
            // CtlValTextBox
            // 
            this.CtlValTextBox.Location = new System.Drawing.Point(81, 88);
            this.CtlValTextBox.Name = "CtlValTextBox";
            this.CtlValTextBox.Size = new System.Drawing.Size(165, 20);
            this.CtlValTextBox.TabIndex = 39;
            this.CtlValTextBox.Text = "01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Value:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 17);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ffffffffffff (2nd)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(121, 17);
            this.radioButton3.TabIndex = 43;
            this.radioButton3.Text = "80d860800700 (3rd)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // RawDataLabel2
            // 
            this.RawDataLabel2.AutoSize = true;
            this.RawDataLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RawDataLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RawDataLabel2.Location = new System.Drawing.Point(159, 57);
            this.RawDataLabel2.Name = "RawDataLabel2";
            this.RawDataLabel2.Size = new System.Drawing.Size(54, 13);
            this.RawDataLabel2.TabIndex = 44;
            this.RawDataLabel2.Text = "RAWdata";
            // 
            // PPGinvertcheckBox
            // 
            this.PPGinvertcheckBox.AutoSize = true;
            this.PPGinvertcheckBox.Location = new System.Drawing.Point(6, 30);
            this.PPGinvertcheckBox.Name = "PPGinvertcheckBox";
            this.PPGinvertcheckBox.Size = new System.Drawing.Size(78, 17);
            this.PPGinvertcheckBox.TabIndex = 45;
            this.PPGinvertcheckBox.Text = "Invert PPG";
            this.PPGinvertcheckBox.UseVisualStyleBackColor = true;
            // 
            // connectgroupBox
            // 
            this.connectgroupBox.Controls.Add(this.radioButton1);
            this.connectgroupBox.Controls.Add(this.DisconnectBtn);
            this.connectgroupBox.Controls.Add(this.connectBtn);
            this.connectgroupBox.Controls.Add(this.radioButton3);
            this.connectgroupBox.Controls.Add(this.radioButton2);
            this.connectgroupBox.Controls.Add(this.AddressTextBox);
            this.connectgroupBox.Controls.Add(this.label4);
            this.connectgroupBox.Location = new System.Drawing.Point(12, 329);
            this.connectgroupBox.Name = "connectgroupBox";
            this.connectgroupBox.Size = new System.Drawing.Size(229, 121);
            this.connectgroupBox.TabIndex = 46;
            this.connectgroupBox.TabStop = false;
            this.connectgroupBox.Text = "Connection";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 17);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "7bd860800700 (4th)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CommandgroupBox
            // 
            this.CommandgroupBox.Controls.Add(this.EnDataBtn);
            this.CommandgroupBox.Controls.Add(this.EnIntBtn);
            this.CommandgroupBox.Controls.Add(this.label1);
            this.CommandgroupBox.Controls.Add(this.CmdTextBox);
            this.CommandgroupBox.Controls.Add(this.CtlValTextBox);
            this.CommandgroupBox.Controls.Add(this.label6);
            this.CommandgroupBox.Controls.Add(this.SendButton);
            this.CommandgroupBox.Controls.Add(this.Write_CTL_REG_BTN);
            this.CommandgroupBox.Location = new System.Drawing.Point(247, 329);
            this.CommandgroupBox.Name = "CommandgroupBox";
            this.CommandgroupBox.Size = new System.Drawing.Size(336, 121);
            this.CommandgroupBox.TabIndex = 47;
            this.CommandgroupBox.TabStop = false;
            this.CommandgroupBox.Text = "Command";
            // 
            // PlotgroupBox
            // 
            this.PlotgroupBox.Controls.Add(this.PPGinvertcheckBox);
            this.PlotgroupBox.Controls.Add(this.label2);
            this.PlotgroupBox.Controls.Add(this.ScaledomainUpDown);
            this.PlotgroupBox.Location = new System.Drawing.Point(603, 329);
            this.PlotgroupBox.Name = "PlotgroupBox";
            this.PlotgroupBox.Size = new System.Drawing.Size(115, 121);
            this.PlotgroupBox.TabIndex = 48;
            this.PlotgroupBox.TabStop = false;
            this.PlotgroupBox.Text = "Plot Option";
            // 
            // StatusgroupBox
            // 
            this.StatusgroupBox.Controls.Add(this.label10);
            this.StatusgroupBox.Controls.Add(this.label9);
            this.StatusgroupBox.Controls.Add(this.MagLabel);
            this.StatusgroupBox.Controls.Add(this.label8);
            this.StatusgroupBox.Controls.Add(this.label7);
            this.StatusgroupBox.Controls.Add(this.label3);
            this.StatusgroupBox.Controls.Add(this.DataLabel);
            this.StatusgroupBox.Controls.Add(this.StatusLabel);
            this.StatusgroupBox.Controls.Add(this.RawDataLabel2);
            this.StatusgroupBox.Controls.Add(this.RawDataLabel);
            this.StatusgroupBox.Controls.Add(this.xLabel);
            this.StatusgroupBox.Controls.Add(this.LenthLabel);
            this.StatusgroupBox.Controls.Add(this.yLabel);
            this.StatusgroupBox.Controls.Add(this.zLabel);
            this.StatusgroupBox.Location = new System.Drawing.Point(12, 456);
            this.StatusgroupBox.Name = "StatusgroupBox";
            this.StatusgroupBox.Size = new System.Drawing.Size(706, 92);
            this.StatusgroupBox.TabIndex = 49;
            this.StatusgroupBox.TabStop = false;
            this.StatusgroupBox.Text = "System status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Length:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Status:";
            // 
            // MagLabel
            // 
            this.MagLabel.AutoSize = true;
            this.MagLabel.Location = new System.Drawing.Point(216, 44);
            this.MagLabel.Name = "MagLabel";
            this.MagLabel.Size = new System.Drawing.Size(47, 13);
            this.MagLabel.TabIndex = 47;
            this.MagLabel.Text = "AccMag";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Acceletation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Incoming data: ";
            // 
            // AlertcheckBox
            // 
            this.AlertcheckBox.AutoSize = true;
            this.AlertcheckBox.Location = new System.Drawing.Point(737, 523);
            this.AlertcheckBox.Name = "AlertcheckBox";
            this.AlertcheckBox.Size = new System.Drawing.Size(81, 17);
            this.AlertcheckBox.TabIndex = 50;
            this.AlertcheckBox.Text = "Alert Popup";
            this.AlertcheckBox.UseVisualStyleBackColor = true;
            // 
            // FYP_Perimeter_read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 559);
            this.Controls.Add(this.AlertcheckBox);
            this.Controls.Add(this.StatusgroupBox);
            this.Controls.Add(this.PlotgroupBox);
            this.Controls.Add(this.CommandgroupBox);
            this.Controls.Add(this.connectgroupBox);
            this.Controls.Add(this.HRlabel);
            this.Controls.Add(this.ClearLogBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EventListBox);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PorttextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.GraphpictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FYP_Perimeter_read";
            this.Text = "Sentinel Active Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).EndInit();
            this.connectgroupBox.ResumeLayout(false);
            this.connectgroupBox.PerformLayout();
            this.CommandgroupBox.ResumeLayout(false);
            this.CommandgroupBox.PerformLayout();
            this.PlotgroupBox.ResumeLayout(false);
            this.PlotgroupBox.PerformLayout();
            this.StatusgroupBox.ResumeLayout(false);
            this.StatusgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PorttextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label LenthLabel;
        private System.Windows.Forms.TextBox CmdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown ScaledomainUpDown;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.PictureBox GraphpictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RawDataLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button EnDataBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button Write_CTL_REG_BTN;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.ListBox EventListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearLogBtn;
        private System.Windows.Forms.Button EnIntBtn;
        private System.Windows.Forms.Label HRlabel;
        private System.Windows.Forms.TextBox CtlValTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label RawDataLabel2;
        private System.Windows.Forms.CheckBox PPGinvertcheckBox;
        private System.Windows.Forms.GroupBox connectgroupBox;
        private System.Windows.Forms.GroupBox CommandgroupBox;
        private System.Windows.Forms.GroupBox PlotgroupBox;
        private System.Windows.Forms.GroupBox StatusgroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MagLabel;
        private System.Windows.Forms.CheckBox AlertcheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

