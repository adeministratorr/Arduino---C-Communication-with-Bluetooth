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
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) //Seri porttan veri geldiðinde
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
