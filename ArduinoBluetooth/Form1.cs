using System.IO.Ports; //SerialPort sýnýfýný kullanabilmek için eklenen kütüphane

namespace ArduinoBluetooth
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbComPort.Items.Add(port);
            }

            if (cbComPort.Items.Count > 0)
            {
                cbComPort.SelectedItem = cbComPort.Items.Contains("COM1") && cbComPort.Items.Count > 1 ? cbComPort.Items[1] : "COM1";
            }

            // SerialPort_DataReceived event listener ekleniyor
            if (serialPort != null)
            {
                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }
        }

        private string GetPortDescription(string portName)
        {
            // Bu metot, port açýklamasýný almak için kullanýlabilir.
            // Þu anda sadece port adýný döndürüyor, ancak daha fazla bilgi eklenebilir.
            return portName;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                lblConnectStatus.Text = "Baðlý Deðil";
                btnConnect.Text = "Baðlan";
                // SerialPort_DataReceived event listener ekleniyor
                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }

            try
            {
                serialPort = new SerialPort(cbComPort.SelectedItem.ToString(), int.Parse(cbBaud.SelectedItem.ToString()));
                serialPort.Open();
                lblConnectStatus.Text = "Baðlý";
                lblConnectStatus.ForeColor = Color.Green;
                lblConnectStatus.Font = new Font(lblConnectStatus.Font, FontStyle.Bold);
                btnConnect.Text = "Baðlantýyý Kes";
            }
            catch
            {
                lblConnectStatus.Text = "Baðlý Deðil";
                lblConnectStatus.ForeColor = Color.Red;
                lblConnectStatus.Font = new Font(lblConnectStatus.Font, FontStyle.Bold);
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) //Seri port açýksa
            {
                string dataToSend = txtGonder.Text; //Gönderilecek veriyi al
                if (!string.IsNullOrEmpty(dataToSend))
                {
                    serialPort.WriteLine(dataToSend);
                }
            }
            else
            {
                MessageBox.Show("Seri port baðlý deðil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataReceived = serialPort.ReadLine();
            this.Invoke(new MethodInvoker(delegate
            {
                txtGelen.AppendText(dataReceived + Environment.NewLine);
                if (dataReceived.Contains("LED1_ON"))
                {
                    pnlLed1.BackColor = Color.Red;
                    lblLed1.BackColor = Color.Red;
                    lblLed1.ForeColor = Color.White;
                }
                else if (dataReceived.Contains("LED1_OFF"))
                {
                    pnlLed1.BackColor = Color.Gray;
                    lblLed1.BackColor = Color.Gray;
                    lblLed1.ForeColor = Color.Black;
                }
                else if (dataReceived.Contains("LED2_ON"))
                {
                    pnlLed2.BackColor = Color.Red;
                    lblLed2.BackColor = Color.Red;
                    lblLed2.ForeColor = Color.White;
                }
                else if (dataReceived.Contains("LED2_OFF"))
                {
                    pnlLed2.BackColor = Color.Gray;
                    lblLed2.BackColor = Color.Gray;
                    lblLed2.ForeColor = Color.Black;
                }
                else if (dataReceived.Contains("LED3_ON"))
                {
                    pnlLed3.BackColor = Color.Red;
                    lblLed3.BackColor = Color.Red;
                    lblLed3.ForeColor = Color.White;
                }
                else if (dataReceived.Contains("LED3_OFF"))
                {
                    pnlLed3.BackColor = Color.Gray;
                    lblLed3.BackColor = Color.Gray;
                    lblLed3.ForeColor = Color.Black;
                }
                else if (dataReceived.Contains("LED4_ON"))
                {
                    pnlLed4.BackColor = Color.Red;
                    lblLed4.BackColor = Color.Red;
                    lblLed4.ForeColor = Color.White;
                }
                else if (dataReceived.Contains("LED4_OFF"))
                {
                    pnlLed4.BackColor = Color.Gray;
                    lblLed4.BackColor = Color.Gray;
                    lblLed4.ForeColor = Color.Black;
                }
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGelen.Clear();
        }

        private void lblLed1_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string command = lblLed1.BackColor == Color.Red ? "LED1_OFF" : "LED1_ON";
                serialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show("Seri port baðlý deðil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLed2_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string command = lblLed2.BackColor == Color.Red ? "LED2_OFF" : "LED2_ON";
                serialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show("Seri port baðlý deðil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLed3_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string command = lblLed3.BackColor == Color.Red ? "LED3_OFF" : "LED3_ON";
                serialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show("Seri port baðlý deðil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLed4_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string command = lblLed4.BackColor == Color.Red ? "LED4_OFF" : "LED4_ON";
                serialPort.WriteLine(command);
            }
            else
            {
                MessageBox.Show("Seri port baðlý deðil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
