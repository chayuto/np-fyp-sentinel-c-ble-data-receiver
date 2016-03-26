using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
    

namespace SerialPortRead
{
    public partial class FYP_Perimeter_read : Form
    {

        byte[] data = new byte[20];
        int[,] dataset = new int[1000, 5]; //for graph plotting
        int x_val, y_val, z_val,adc_val;
        
        

        public FYP_Perimeter_read()
        {
            InitializeComponent();
            ScaledomainUpDown.SelectedIndex = 4;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                
                StartButton.Text = "Open";
               
            }
            else
            {
                serialPort1.PortName = PorttextBox.Text;
                try
                {   
                    serialPort1.Open();
                    StartButton.Text = "Close";
                    serialPort1.RtsEnable = true;
                    serialPort1.DtrEnable = true;
                    serialPort1.BaudRate = 115200;


                    

                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int i=0;
            string[] int_buf = new string[20];
            string out_string = "0000";

            int count =0;

            try
            {
                count = serialPort1.Read(data, 0, data.Length);
            }
            catch { }

            
            
           //display raw response          
            for (i = 0; i < data.Length; i++)
            {
                int_buf[i] = data[i].ToString("X2");
            }  
            out_string = string.Join(":",int_buf);

            if (DataLabel.InvokeRequired)
            {
                DataLabel.BeginInvoke(new MethodInvoker(delegate { DataLabel.Text = out_string; }));
            }
            else
            {
                DataLabel.Text = out_string;
            }


            identify_rx();
           //=================read data count================================
            if ((count != 0) )
            {
                

                if (LenthLabel.InvokeRequired)
                {
                    LenthLabel.BeginInvoke(new MethodInvoker(delegate { LenthLabel.Text = count.ToString(); }));
                }
                else
                {
                    LenthLabel.Text = count.ToString();
                }

                

            }

            }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //submit raw command
        private void SendButton_Click(object sender, EventArgs e)
        {
            int i =0;
            byte[] cmd_buff = new byte[100];


            for (i = 0; (i*2) < CmdTextBox.Text.Length; i++)
            {
               cmd_buff[i]= Convert.ToByte(CmdTextBox.Text.Substring((i*2), 2), 16);
            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(cmd_buff, 0, i);
            }
        }

        //classify which type of data in coming in
        private void identify_rx()
        {
            string status;

            if ((data[2] == 0x03) && (data[3] == 0x00))//connection successful
            {
                Enable_BLE_notify();
                   
            }
                
            else 
            {
                int i = 0;
                for (i = 0; i <= 10; i++)
                {

                    if ((data[i] == 0x99)&& (data[i+9]==0x99)) //is attribute for data
                    {
                        DataSetUpdate(data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i +5], data[i + 6], data[i + 7], data[i + 8]);

                        status = "accdata - " + i.ToString();
                        if (StatusLabel.InvokeRequired)
                        {
                            StatusLabel.BeginInvoke(new MethodInvoker(delegate { StatusLabel.Text = status; }));
                        }
                        else
                        {
                            StatusLabel.Text = status;
                        }
                    }
                }
                for (i = 0; i <= 14; i++)
                {
                    if ((data[i] == 0x98) && (data[i + 3] == 0x98))
                    {
                            TempDataUpdate(data[i + 1], data[i + 2]);
                            status = "Tempdata - " + i.ToString();
                            if (StatusLabel.InvokeRequired)
                            {
                                StatusLabel.BeginInvoke(new MethodInvoker(delegate { StatusLabel.Text = status; }));
                            }
                            else
                            {
                                StatusLabel.Text = status;
                            }
                    }
                }
                for (i = 0; i <= 14; i++)
                {
                    if ((data[i] == 0x96) && (data[i + 2] == 0x96))
                    {
                        if (data[i + 1] == 0x10)
                        {
                            if (EventListBox.InvokeRequired)
                            {
                                StatusLabel.BeginInvoke(new MethodInvoker(delegate { EventListBox.Items.Add(DateTime.Now.ToLongTimeString() + " Fall Detected"); }));
                            }
                            else
                            {
                                EventListBox.Items.Add(DateTime.Now.ToLongTimeString() + " Fall Detected");
                            }
                        }
                        if (data[i + 1] == 0x20)
                        {

                            if (EventListBox.InvokeRequired)
                            {
                                StatusLabel.BeginInvoke(new MethodInvoker(delegate { EventListBox.Items.Add(DateTime.Now.ToLongTimeString() + " Impact Detected"); }));
                            }
                            else
                            {
                                EventListBox.Items.Add(DateTime.Now.ToLongTimeString() + " Impact Detected");
                            }
                        }


                    }

                }

                
            }
                
           
        }

        private void TempDataUpdate(byte Temp1, byte Temp0)
        {
            int rawTemp;
            float Temp;
            string status;

            rawTemp = 0;
            rawTemp = Temp1 & 0x1F;
            rawTemp = rawTemp << 8;
            rawTemp = rawTemp + Temp0;
            Temp = (float)rawTemp / 16.0f;

            status = "Temp= " + Temp.ToString() + " 'C";
            if ( TempLabel.InvokeRequired)
            {
                TempLabel.BeginInvoke(new MethodInvoker(delegate { TempLabel.Text  = status; }));
            }
            else
            {
                TempLabel.Text = status;
            }
        }

        private void DataSetUpdate(byte x1, byte x0, byte y1, byte y0, byte z1, byte z0, byte adc1, byte adc0)
        {

            //Convert X 
            if (x0 > 127)
            {
                x_val = 255;
                x_val = x_val << 8;
                x_val = x_val + 255;
                x_val = x_val << 8;
            }
            else { x_val = 0; }
            x_val = x_val + x0;
            x_val = x_val << 8;
            x_val = x_val + x1;

            //convert Y
            if (y0 > 127)
            {
                y_val = 255;
                y_val = y_val << 8;
                y_val = y_val + 255;
                y_val = y_val << 8;
            }
            else { y_val = 0; }
            y_val = y_val + y0;
            y_val = y_val << 8;
            y_val = y_val + y1;

            //convert Z
            if (z0 > 127)
            {
                z_val = 255;
                z_val = z_val << 8;
                z_val = z_val + 255;
                z_val = z_val << 8;
            }
            else { z_val = 0; }
            z_val = z_val + z0;
            z_val = z_val << 8;
            z_val = z_val + z1;

           // convert adc
            if (adc0 > 127)
            {
                adc_val = 255;
                adc_val = adc_val << 8;
                adc_val = adc_val + 255;
                adc_val = adc_val << 8;
                adc_val = adc_val + 255;
                adc_val = adc_val << 8;
            }
            else { adc_val = 0; }
            
            adc_val = adc_val + adc0;
            adc_val = adc_val << 4;
            adc_val = adc_val + (adc1>>4);//Remove insignificant 4 LSB then asign
           

            //update raw data labels
            if (xLabel.InvokeRequired)
            { xLabel.Invoke(new MethodInvoker(delegate { xLabel.Text = x_val.ToString(); })); }
            else { xLabel.Text = x_val.ToString(); }
            if (yLabel.InvokeRequired)
            { yLabel.Invoke(new MethodInvoker(delegate { yLabel.Text = y_val.ToString(); })); }
            else { yLabel.Text = y_val.ToString(); }
            if (zLabel.InvokeRequired)
            { zLabel.Invoke(new MethodInvoker(delegate { zLabel.Text = z_val.ToString(); })); }
            else { zLabel.Text = z_val.ToString(); }
            if (RawDataLabel.InvokeRequired)
            { RawDataLabel.Invoke(new MethodInvoker(delegate { RawDataLabel.Text = adc_val.ToString(); }));} //(fltMag / 256f).ToString();
            else RawDataLabel.Text = adc_val.ToString();//(fltMag / 256f).ToString();
            

        

            //Plot Graph
            if (GraphpictureBox.InvokeRequired)
            {
                GraphpictureBox.Invoke(new MethodInvoker(delegate { GraphpictureBox.Refresh(); }));
            }
            else
            {
                GraphpictureBox.Refresh();
            }
        }

        private void GraphpictureBox_Paint(object sender, PaintEventArgs e)
        {
            int i, j;

            int pw = GraphpictureBox.Size.Width;
            int ph = GraphpictureBox.Size.Height;
            int w = GraphpictureBox.Size.Width / 2;
            int h = GraphpictureBox.Size.Height / 2;
            Graphics objGraphics = this.GraphpictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkGray);
            //changing scale of graph
            int scaleFactor = int.Parse(ScaledomainUpDown.Text);


            for (i = -10; i <= 10; i++)
            {
                e.Graphics.DrawLine(pen, 0, ph - ((256 * i) / scaleFactor) - h, pw, ph - ((256 * i) / scaleFactor) - h);
            }


            //datashift

            for (i = 0; i <= 4; i++)
            {
                for (j = pw; j >= 1; j--)
                {
                    dataset[j, i] = dataset[j - 1, i];
                }
            }


            //load new values into array
            dataset[0, 0] = ph - (x_val / scaleFactor) - h;
            dataset[0, 1] = ph - (y_val / scaleFactor) - h;
            dataset[0, 2] = ph - (z_val / scaleFactor) - h;
            dataset[0, 3] = ph - (int)(Calculate_Acc_Mag() / scaleFactor) - h;
            dataset[0, 4] = ph - (int)((float)(adc_val * ph) / 9000.0) - h;

            for (i = 4; i >= 0; i--)
            {
                //change colour for each axis
                if (i == 0) { pen.Color = Color.Red; }
                if (i == 1) { pen.Color = Color.Blue; }
                if (i == 2) { pen.Color = Color.Green; }
                if (i == 3) { pen.Color = Color.Wheat; }
                if (i == 4) { pen.Color = Color.Purple; }
                //plot each axis
                for (j = pw; j >= 1; j--)
                {
                    e.Graphics.DrawLine(pen, j, dataset[j, i], j - 1, dataset[j - 1, i]);
                }


            }


        }

        private float Calculate_Acc_Mag()
        {
            float fltX, fltY, fltZ, fltMag;

            fltX = (float)x_val;
            fltY = (float)y_val;
            fltZ = (float)z_val;
            fltMag = (float)Math.Sqrt((fltX * fltX) + (fltY * fltY) + (fltZ * fltZ));

      

            return fltMag;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            byte[] bt_address = new byte[6];
            if (serialPort1.IsOpen && (AddressTextBox.Text.Length==12))
            {
                for (i = 0; (i * 2) < AddressTextBox.Text.Length; i++)
                {
                    bt_address[i] = Convert.ToByte(CmdTextBox.Text.Substring((i * 2), 2), 16);
                }

               
                    byte[] bytesToSend = new byte[19] { 0x00, 0x0f, 0x06, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x3c, 0x00, 0x3c, 0x00, 0x64, 0x00, 0x00, 0x00 }; // direct connect
                    //for (i = 0; i < 6; i++)
                    //{
                    //    bytesToSend[i + 4] = bt_address[i];
                    //}
                     serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
              
               
                   
               
            }
            else
            {
                MessageBox.Show("Invalid address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteBtn_Click(object sender, EventArgs e)
        {
            Enable_BLE_notify();
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            
                if (serialPort1.IsOpen)
                    {
                        byte[] bytesToSend = new byte[5] { 0x00, 0x01, 0x03, 0x00, 0x00 }; // write 01 to attribute 15 to enable notification
                        serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
                        
                    }
        }

        private void Write_CTL_REG_BTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                byte reg1 = 0x13;
                byte data_byte = 0x01;
                byte[] bytesToSend = new byte[9] { 0x00, 0x05, 0x04, 0x05, 0x00, reg1, 0x00, 0x01, data_byte }; // write data_byte to att 
                serialPort1.Write(bytesToSend, 0, bytesToSend.Length);

            }
        }

        private void Enable_BLE_notify()
        {
            if (serialPort1.IsOpen)
            {
                byte reg1 = 0x10;
                byte reg2 = 0x17;

                byte[] bytesToSend2 = new byte[9] { 0x00, 0x05, 0x04, 0x05, 0x00, reg2, 0x00, 0x01, 0x01 }; // write 01 to attribute 2 //00 05 04 05 00 17 00 01 01
                serialPort1.Write(bytesToSend2, 0, bytesToSend2.Length);
                
                byte[] bytesToSend = new byte[9] { 0x00, 0x05, 0x04, 0x05, 0x00, reg1, 0x00, 0x01, 0x01 }; // write 01 to attribute 1
                serialPort1.Write(bytesToSend, 0, bytesToSend.Length);

               
            }


            
        }

        private void ClearLogBtn_Click(object sender, EventArgs e)
        {
            if (EventListBox.InvokeRequired)
            {
                StatusLabel.BeginInvoke(new MethodInvoker(delegate { EventListBox.Items.Clear(); }));
            }
            else
            {
                EventListBox.Items.Clear();
            }
        }

  

      
  
   

    }
}
