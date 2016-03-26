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
            this.Write_client_configBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.Write_CTL_REG_BTN = new System.Windows.Forms.Button();
            this.TempLabel = new System.Windows.Forms.Label();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearLogBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 256000;
            this.serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
            this.serialPort1.PortName = "COM22";
            this.serialPort1.ReadBufferSize = 40;
            this.serialPort1.ReadTimeout = 5;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(17, 14);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(46, 13);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Port No.";
            // 
            // PorttextBox
            // 
            this.PorttextBox.Location = new System.Drawing.Point(69, 11);
            this.PorttextBox.Name = "PorttextBox";
            this.PorttextBox.Size = new System.Drawing.Size(109, 20);
            this.PorttextBox.TabIndex = 1;
            this.PorttextBox.Text = "COM22";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(184, 9);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LenthLabel
            // 
            this.LenthLabel.AutoSize = true;
            this.LenthLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LenthLabel.Location = new System.Drawing.Point(959, 14);
            this.LenthLabel.Name = "LenthLabel";
            this.LenthLabel.Size = new System.Drawing.Size(40, 13);
            this.LenthLabel.TabIndex = 5;
            this.LenthLabel.Text = "Lenght";
            // 
            // CmdTextBox
            // 
            this.CmdTextBox.Location = new System.Drawing.Point(69, 59);
            this.CmdTextBox.Name = "CmdTextBox";
            this.CmdTextBox.Size = new System.Drawing.Size(274, 20);
            this.CmdTextBox.TabIndex = 13;
            this.CmdTextBox.Text = "000504050015000101";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Command:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(349, 57);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 16;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(12, 463);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(30, 13);
            this.DataLabel.TabIndex = 17;
            this.DataLabel.Text = "Data";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(959, 463);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 18;
            this.StatusLabel.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Scale:";
            // 
            // ScaledomainUpDown
            // 
            this.ScaledomainUpDown.Items.Add("14");
            this.ScaledomainUpDown.Items.Add("13");
            this.ScaledomainUpDown.Items.Add("12");
            this.ScaledomainUpDown.Items.Add("11");
            this.ScaledomainUpDown.Items.Add("10");
            this.ScaledomainUpDown.Items.Add("9");
            this.ScaledomainUpDown.Items.Add("8");
            this.ScaledomainUpDown.Items.Add("7");
            this.ScaledomainUpDown.Items.Add("6");
            this.ScaledomainUpDown.Items.Add("5");
            this.ScaledomainUpDown.Items.Add("4");
            this.ScaledomainUpDown.Items.Add("3");
            this.ScaledomainUpDown.Items.Add("2");
            this.ScaledomainUpDown.Items.Add("1");
            this.ScaledomainUpDown.Location = new System.Drawing.Point(464, 11);
            this.ScaledomainUpDown.Name = "ScaledomainUpDown";
            this.ScaledomainUpDown.ReadOnly = true;
            this.ScaledomainUpDown.Size = new System.Drawing.Size(36, 20);
            this.ScaledomainUpDown.TabIndex = 22;
            this.ScaledomainUpDown.Text = "1";
     
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.BackColor = System.Drawing.Color.Black;
            this.zLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zLabel.Location = new System.Drawing.Point(27, 144);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(14, 13);
            this.zLabel.TabIndex = 21;
            this.zLabel.Text = "Z";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.BackColor = System.Drawing.Color.Black;
            this.yLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yLabel.Location = new System.Drawing.Point(28, 121);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 20;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.Black;
            this.xLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xLabel.Location = new System.Drawing.Point(28, 98);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 19;
            this.xLabel.Text = "X";
            // 
            // GraphpictureBox
            // 
            this.GraphpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GraphpictureBox.BackColor = System.Drawing.Color.Black;
            this.GraphpictureBox.Location = new System.Drawing.Point(12, 89);
            this.GraphpictureBox.Name = "GraphpictureBox";
            this.GraphpictureBox.Size = new System.Drawing.Size(719, 346);
            this.GraphpictureBox.TabIndex = 24;
            this.GraphpictureBox.TabStop = false;
            this.GraphpictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphpictureBox_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Magnitude:";
            // 
            // RawDataLabel
            // 
            this.RawDataLabel.AutoSize = true;
            this.RawDataLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RawDataLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RawDataLabel.Location = new System.Drawing.Point(349, 14);
            this.RawDataLabel.Name = "RawDataLabel";
            this.RawDataLabel.Size = new System.Drawing.Size(66, 13);
            this.RawDataLabel.TabIndex = 25;
            this.RawDataLabel.Text = "    RAWdata";
            // 
            // connectBtn
            // 
            this.connectBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.connectBtn.Location = new System.Drawing.Point(311, 450);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 27;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DisconnectBtn.Location = new System.Drawing.Point(392, 450);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.DisconnectBtn.TabIndex = 28;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // Write_client_configBtn
            // 
            this.Write_client_configBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Write_client_configBtn.Location = new System.Drawing.Point(473, 450);
            this.Write_client_configBtn.Name = "Write_client_configBtn";
            this.Write_client_configBtn.Size = new System.Drawing.Size(144, 23);
            this.Write_client_configBtn.TabIndex = 29;
            this.Write_client_configBtn.Text = "Write Client char config";
            this.Write_client_configBtn.UseVisualStyleBackColor = true;
            this.Write_client_configBtn.Click += new System.EventHandler(this.WriteBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(69, 36);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(109, 20);
            this.AddressTextBox.TabIndex = 31;
            this.AddressTextBox.Text = "ffffffffffff";
            // 
            // Write_CTL_REG_BTN
            // 
            this.Write_CTL_REG_BTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Write_CTL_REG_BTN.Location = new System.Drawing.Point(623, 450);
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
            this.TempLabel.Location = new System.Drawing.Point(516, 11);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(49, 20);
            this.TempLabel.TabIndex = 33;
            this.TempLabel.Text = "Temp";
            // 
            // EventListBox
            // 
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.Location = new System.Drawing.Point(753, 89);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.Size = new System.Drawing.Size(224, 355);
            this.EventListBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Event Log";
            // 
            // ClearLogBtn
            // 
            this.ClearLogBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearLogBtn.Location = new System.Drawing.Point(753, 450);
            this.ClearLogBtn.Name = "ClearLogBtn";
            this.ClearLogBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearLogBtn.TabIndex = 36;
            this.ClearLogBtn.Text = "Clear Log";
            this.ClearLogBtn.UseVisualStyleBackColor = true;
            this.ClearLogBtn.Click += new System.EventHandler(this.ClearLogBtn_Click);
            // 
            // FYP_Perimeter_read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 485);
            this.Controls.Add(this.ClearLogBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EventListBox);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.Write_CTL_REG_BTN);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Write_client_configBtn);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RawDataLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScaledomainUpDown);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdTextBox);
            this.Controls.Add(this.LenthLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PorttextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.GraphpictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FYP_Perimeter_read";
            this.Text = "FYP Perimeters Read";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).EndInit();
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
        private System.Windows.Forms.Button Write_client_configBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button Write_CTL_REG_BTN;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.ListBox EventListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearLogBtn;
    }
}

