using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Sim900A_Rx
{
    public partial class Form1 : Form
    {
        SerialPort mySerialPort = new SerialPort("COM7", 9600);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_UnLoad(object sender, EventArgs e)
        {
           timer.Enabled = false;
           mySerialPort.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                datelabel.Text= String.Format("{0:MM/dd/yyyy}", DateTime.Now);          // "09/05/2012"
                
                mySerialPort.Open();
              
                // mySerialPort.WriteLine(message);
                // mySerialPort.Write(new byte[] { 13 }, 0, 1);
                // mySerialPort.Write(command);
                timer.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
                //SentBox.Text = ex.ToString();
                //Console.WriteLine(ex);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // mySerialPort.Write("RING\r\n");
            try
            {
                // Open the serial port.
               // serialPort.Open();

                // Read a line from the serial port.
                string data = mySerialPort.ReadLine();
                string leftPart = data.Substring(0, 4); // "RING"
                
                ReceivedBox.Text= (leftPart);
                // ReceivedBox.Text = ReceivedBox.Text + data;
                
                //ReceivedBox.Text = "";
                // Console.WriteLine("Received data: " + data);
            }
            catch (Exception ex)
            {
               // Console.WriteLine("Error: " + ex.Message);
                ReceivedBox.Text = ("Error: " + ex.Message);
            }
        }

        private void serRxBox_TextChanged(object sender, EventArgs e)
        {
            if (serRxBox.Text == "RING")
            {
              //  serRxBox.Text = ReceivedBox.Text;
                RxLed.BackColor = Color.LawnGreen;
            }
            
            //serRxBox.Text = "";
        }

        private void ReceivedBox_TextChanged(object sender, EventArgs e)
        {

            if (ReceivedBox.Text == "RING")
            {
                serRxBox.Text = ReceivedBox.Text;
                RxLed.BackColor = Color.Orange;
                mySerialPort.Write("AT+CLCC\r\n");
            }
           
        }

        private void RxLed_Click(object sender, EventArgs e)
        {

        }
    }
}
