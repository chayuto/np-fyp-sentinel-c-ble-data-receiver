using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
    

namespace SerialPortRead
{
    public partial class FYP_Perimeter_read : Form
    {

        
        byte[] data =  new byte[20];
        int count = 0;
        int x_val, y_val, z_val, adc_val;
        //===============Dataset==============================
        int[,] dataset = new int[1000, 6]; //for graph plotting  
        //0 = X plot , 1= Y , 2 = Z , 3 = mag, 4 =  ADC , 5 = peak
        
        //=============HR Cal=====================================
        Stopwatch stopWatch1 = new Stopwatch();
     

        int Tickcount = 0;

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
                
                StartButton.Text = "Open Port";
               
            }
            else
            {
                serialPort1.PortName = PorttextBox.Text;
                try
                {   
                    serialPort1.Open();
                    StartButton.Text = "Close Port";
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }
                catch
                {
                    MessageBox.Show("Unable to Open Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            //RxString = serialPort1.ReadExisting();
            try
            {
                count = serialPort1.Read(data, 0, data.Length);
            }
            catch { }
            this.Invoke(new EventHandler(Data_rx));
          }

        private void Data_rx(object sender, EventArgs e)
        {
            int i = 0;
            string[] int_buf = new string[20];
            string out_string = "0000";
            

            
            //display raw response          
            for (i = 0; i < data.Length; i++)
            {
                int_buf[i] = data[i].ToString("X2");
            }
            out_string = string.Join(":", int_buf);
            DataLabel.Text = out_string;
     


            identify_rx();
            //=================read data count================================
            //count = RxString.Length;
            if ((count != 0))
            {
                LenthLabel.Text = count.ToString();
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
           

            if ((data[2] == 0x03) && (data[3] == 0x00))//connection successful
            {
                //Enable_BLE_notify(0x10);
                   
            }
                
            else 
            {
                int i = 0;
                for (i = 0; i <= 10; i++)
                {

                    if ((data[i] == 0x99)&& (data[i+9]==0x99)) //is attribute for data
                    {
                        DataSetUpdate(data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i +5], data[i + 6], data[i + 7], data[i + 8]);

                        StatusLabel.Text = "data - " + i.ToString();
                       
                    }
                
                
                    else if ((data[i] == 0x98) && (data[i + 3] == 0x98))
                    {
                            TempDataUpdate(data[i + 1], data[i + 2]);
                            StatusLabel.Text = "Tempdata - " + i.ToString();
                            
                    }
                
                
                    else if ((data[i] == 0x96) && (data[i + 2] == 0x96))
                    {
                        if (data[i + 1] == 0x10)
                        {

                            EventListBox.Items.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + " -- Fall Detected");
                        }
                        else if (data[i + 1] == 0x20)
                        {

                            EventListBox.Items.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + " -- Impact Detected");
                      
                        }
                        else if (data[i + 1] == 0x08)
                        {

                            EventListBox.Items.Add("Pin 1_3 interrupt");

                        }
                        else if (data[i + 1] == 0x04)
                        {

                            EventListBox.Items.Add("Pin 1_2 interrupt");

                        }


                    }

                }

                
            }
                
           
        }

        private void TempDataUpdate(byte Temp1, byte Temp0)
        {
            int rawTemp;
            float Temp;
        

            rawTemp = 0;
            rawTemp = Temp1 & 0x1F;
            rawTemp = rawTemp << 8;
            rawTemp = rawTemp + Temp0;
            Temp = (float)rawTemp / 16.0f;

           

            TempLabel.Text = "Temp= " + Temp.ToString() + " 'C";
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
             xLabel.Text = x_val.ToString(); 
             yLabel.Text = y_val.ToString(); 
             zLabel.Text = z_val.ToString(); 
             RawDataLabel.Text = adc_val.ToString();//(fltMag / 256f).ToString();

             
          

            //Plot Graph
            
                GraphpictureBox.Refresh();
           
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

            for (i = 0; i <= 5; i++)
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
            Detect_Peak(); //determine change too dataset[40,5]
            
            for (i = 5; i >= 0; i--)
            {
                //plot peak
                if (i == 5)
                {
                    pen.Color = Color.Purple;
                    for (j = pw; j >= 1; j--)
                    {
                        if (dataset[j, i] == 1)
                        {
                            e.Graphics.DrawLine(pen, j, 0, j, ph);
                        }
                    }
                }


                //change colour for each axis
                else if (i == 0) { pen.Color = Color.Red; }
                else if (i == 1) { pen.Color = Color.Blue; }
                else if (i == 2) { pen.Color = Color.Green; }
                else if (i == 3) { pen.Color = Color.Wheat; }
                if (i == 4) { pen.Color = Color.Orange ; }
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
            byte[] bytesToSend = new byte[19] { 0x00, 0x0f, 0x06, 0x03, 0x80, 0xd8, 0x60, 0x80, 0x07, 0x00, 0x00, 0x3c, 0x00, 0x3c, 0x00, 0x64, 0x00, 0x00, 0x00 }; // direct connect
            byte[] bytesToSend2 = new byte[19] { 0x00, 0x0f, 0x06, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x3c, 0x00, 0x3c, 0x00, 0x64, 0x00, 0x00, 0x00 }; // direct connect
           
            //0x95, 0xd4, 0x60, 0x80, 0x07, 0x00
            //0xff, 0xff, 0xff, 0xff, 0xff, 0xff
            //80 d8 60 80 07 00
            if (serialPort1.IsOpen && (AddressTextBox.Text.Length==12))
            {
                //for (i = 0; i <= 5; i++)
                //{
                //    bt_address[i] = Convert.ToByte(CmdTextBox.Text.Substring((i * 2), 2), 16);
                //    bytesToSend[i + 4] = bt_address[i];
                //}
                                                                //60800700

                if (radioButton3.Checked == true)
                {
                    serialPort1.Write(bytesToSend, 0, 19);
                }
                else
                {
                    serialPort1.Write(bytesToSend2, 0, 19);
                }
            }
            else if (serialPort1.IsOpen != true)
            {
                MessageBox.Show("Serial Port is not open", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Invalid address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteBtn_Click(object sender, EventArgs e)
        {
            Enable_BLE_notify(0x10);
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            
                if (serialPort1.IsOpen)
                    {
                        byte[] bytesToSend = new byte[5] { 0x00, 0x01, 0x03, 0x00, 0x00 }; 
                        serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
                        
                    }
        }
       
        private void Write_CTL_REG_BTN_Click(object sender, EventArgs e)
        {
            //write value in the CTLval textbx to register 13
            Write_reg_1byte(0x13, Convert.ToByte(CtlValTextBox.Text.Substring(0, 2), 16));
                           
        }

        private void Enable_BLE_notify(byte reg1) // handleer in hex
        {
            if (serialPort1.IsOpen)
            {
                
                byte[] bytesToSend = new byte[9] { 0x00, 0x05, 0x04, 0x05, 0x00, reg1, 0x00, 0x01, 0x01 }; // write 01 to attribute reg
                serialPort1.Write(bytesToSend, 0, bytesToSend.Length); 
            }          
        }

        private void Write_reg_1byte(byte reg,byte val) // handleer in hex
        {
            if (serialPort1.IsOpen)
            {
                byte[] bytesToSend = new byte[9] { 0x00, 0x05, 0x04, 0x05, 0x00, reg, 0x00, 0x01, val }; // write val to attribute reg
                serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }

        private void ClearLogBtn_Click(object sender, EventArgs e)
        {
             EventListBox.Items.Clear();
        }

        private void EnIntBtn_Click(object sender, EventArgs e)
        {
             Enable_BLE_notify(0x17);
        }


        private void Detect_Peak()
        {
            int start_pt = 40;
            int after = 25;
            int before = 17;
            int peak =1;
            int i=0; // counter 

            for (i = 1; (i <= after) && (peak==1);i++)
            {
                if (dataset[start_pt, 4] > dataset[(start_pt - i), 4])
                {
                    peak = 0;
                }

            }
            for (i = 1; (i <= before) && (peak==1); i++)
            {
                if (dataset[start_pt,4] >= dataset[start_pt + i,4])
                {
                    peak = 0;
                }

            }
            if (peak == 1)
            {
                dataset[40, 5] = peak;
                calculate_HR();
            }
           
        }

        private void calculate_HR()
        {
            int HR;
            float period;


            if (Tickcount == 0)
            {
                stopWatch1.Start();
                Tickcount++;
            }


            else if (Tickcount == 3)
            {


                stopWatch1.Stop();
               
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch1.Elapsed;
                //restart stopwatch for next interavl
                stopWatch1.Reset();
                stopWatch1.Start();

                
                period =( (float) ts.TotalMilliseconds / 1000.0f ) /3.0f;
                HR = (int)((1.0f / period)*60.0f );
                if ((HR > 60) && (HR < 200))
                {
                    HRlabel.Text = "HR: " +HR.ToString();
                }

                Tickcount = 1;        
                
            }
            else
            {
                Tickcount++;
            }
        }

     
      

   

    }
}
