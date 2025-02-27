using System.IO.Ports; //SerialPort s�n�f�n� kullanabilmek i�in eklenen k�t�phane

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
            // Bu metot, port a��klamas�n� almak i�in kullan�labilir.
            // �u anda sadece port ad�n� d�nd�r�yor, ancak daha fazla bilgi eklenebilir.
            return portName;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                lblConnectStatus.Text = "Ba�l� De�il";
                btnConnect.Text = "Ba�lan";
                // SerialPort_DataReceived event listener ekleniyor
                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }

            try
            {
                serialPort = new SerialPort(cbComPort.SelectedItem.ToString(), int.Parse(cbBaud.SelectedItem.ToString()));
                serialPort.Open();
                lblConnectStatus.Text = "Ba�l�";
                lblConnectStatus.ForeColor = Color.Green;
                lblConnectStatus.Font = new Font(lblConnectStatus.Font, FontStyle.Bold);
                btnConnect.Text = "Ba�lant�y� Kes";
            }
            catch
            {
                lblConnectStatus.Text = "Ba�l� De�il";
                lblConnectStatus.ForeColor = Color.Red;
                lblConnectStatus.Font = new Font(lblConnectStatus.Font, FontStyle.Bold);
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) //Seri port a��ksa
            {
                string dataToSend = txtGonder.Text; //G�nderilecek veriyi al
                if (!string.IsNullOrEmpty(dataToSend))    
                {
                    serialPort.WriteLine(dataToSend);
                }
            }
            else
            {
                MessageBox.Show("Seri port ba�l� de�il.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) //Seri porttan veri geldi�inde
        {
            string dataReceived = serialPort.ReadLine(); //Gelen veriyi al
            this.Invoke(new MethodInvoker(delegate
            {
                txtGelen.AppendText(dataReceived + Environment.NewLine);
            }));    //Gelen veriyi textbox'a ekle
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

    }
}
