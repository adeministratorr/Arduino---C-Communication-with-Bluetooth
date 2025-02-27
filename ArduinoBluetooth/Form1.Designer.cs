namespace ArduinoBluetooth
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbComPort = new ComboBox();
            txtGonder = new TextBox();
            btnGonder = new Button();
            cbBaud = new ComboBox();
            lblBaud = new Label();
            btnConnect = new Button();
            groupBox1 = new GroupBox();
            lblConnectStatus = new Label();
            lblDurumText = new Label();
            gbGonder = new GroupBox();
            gpGelen = new GroupBox();
            btnTemizle = new Button();
            txtGelen = new TextBox();
            pnlLed1 = new Panel();
            lblLed1 = new Label();
            pnlLed2 = new Panel();
            lblLed2 = new Label();
            pnlLed3 = new Panel();
            lblLed3 = new Label();
            pnlLed4 = new Panel();
            lblLed4 = new Label();
            groupBox1.SuspendLayout();
            gbGonder.SuspendLayout();
            gpGelen.SuspendLayout();
            pnlLed1.SuspendLayout();
            pnlLed2.SuspendLayout();
            pnlLed3.SuspendLayout();
            pnlLed4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Com Port:";
            // 
            // cbComPort
            // 
            cbComPort.FormattingEnabled = true;
            cbComPort.Location = new Point(86, 27);
            cbComPort.Name = "cbComPort";
            cbComPort.Size = new Size(121, 23);
            cbComPort.TabIndex = 2;
            // 
            // txtGonder
            // 
            txtGonder.Location = new Point(6, 22);
            txtGonder.Multiline = true;
            txtGonder.Name = "txtGonder";
            txtGonder.Size = new Size(268, 121);
            txtGonder.TabIndex = 3;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(6, 149);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(268, 23);
            btnGonder.TabIndex = 4;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // cbBaud
            // 
            cbBaud.FormattingEnabled = true;
            cbBaud.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "31250", "38400", "57600", "115200" });
            cbBaud.Location = new Point(347, 30);
            cbBaud.Name = "cbBaud";
            cbBaud.Size = new Size(121, 23);
            cbBaud.TabIndex = 5;
            cbBaud.Text = "9600";
            // 
            // lblBaud
            // 
            lblBaud.AutoSize = true;
            lblBaud.Location = new Point(268, 33);
            lblBaud.Name = "lblBaud";
            lblBaud.Size = new Size(60, 15);
            lblBaud.TabIndex = 6;
            lblBaud.Text = "Baud Hızı:";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(500, 25);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Bağlan";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblConnectStatus);
            groupBox1.Controls.Add(lblDurumText);
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbBaud);
            groupBox1.Controls.Add(cbComPort);
            groupBox1.Controls.Add(lblBaud);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bağlantı";
            // 
            // lblConnectStatus
            // 
            lblConnectStatus.AutoSize = true;
            lblConnectStatus.ForeColor = Color.Red;
            lblConnectStatus.Location = new Point(433, 76);
            lblConnectStatus.Name = "lblConnectStatus";
            lblConnectStatus.Size = new Size(63, 15);
            lblConnectStatus.TabIndex = 9;
            lblConnectStatus.Text = "Bağlı Değil";
            // 
            // lblDurumText
            // 
            lblDurumText.AutoSize = true;
            lblDurumText.Location = new Point(380, 76);
            lblDurumText.Name = "lblDurumText";
            lblDurumText.Size = new Size(47, 15);
            lblDurumText.TabIndex = 8;
            lblDurumText.Text = "Durum:";
            // 
            // gbGonder
            // 
            gbGonder.Controls.Add(txtGonder);
            gbGonder.Controls.Add(btnGonder);
            gbGonder.Location = new Point(12, 128);
            gbGonder.Name = "gbGonder";
            gbGonder.Size = new Size(280, 178);
            gbGonder.TabIndex = 9;
            gbGonder.TabStop = false;
            gbGonder.Text = "Gönder";
            // 
            // gpGelen
            // 
            gpGelen.Controls.Add(btnTemizle);
            gpGelen.Controls.Add(txtGelen);
            gpGelen.Location = new Point(315, 128);
            gpGelen.Name = "gpGelen";
            gpGelen.Size = new Size(281, 178);
            gpGelen.TabIndex = 10;
            gpGelen.TabStop = false;
            gpGelen.Text = "Gelen";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(4, 149);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(268, 23);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // txtGelen
            // 
            txtGelen.Location = new Point(6, 22);
            txtGelen.Multiline = true;
            txtGelen.Name = "txtGelen";
            txtGelen.Size = new Size(266, 121);
            txtGelen.TabIndex = 3;
            // 
            // pnlLed1
            // 
            pnlLed1.Controls.Add(lblLed1);
            pnlLed1.Location = new Point(136, 330);
            pnlLed1.Name = "pnlLed1";
            pnlLed1.Size = new Size(57, 40);
            pnlLed1.TabIndex = 11;
            // 
            // lblLed1
            // 
            lblLed1.AutoSize = true;
            lblLed1.Location = new Point(13, 14);
            lblLed1.Name = "lblLed1";
            lblLed1.Size = new Size(32, 15);
            lblLed1.TabIndex = 0;
            lblLed1.Text = "Led1";
            lblLed1.Click += lblLed1_Click;
            // 
            // pnlLed2
            // 
            pnlLed2.Controls.Add(lblLed2);
            pnlLed2.Location = new Point(229, 330);
            pnlLed2.Name = "pnlLed2";
            pnlLed2.Size = new Size(57, 40);
            pnlLed2.TabIndex = 12;
            // 
            // lblLed2
            // 
            lblLed2.AutoSize = true;
            lblLed2.Location = new Point(13, 14);
            lblLed2.Name = "lblLed2";
            lblLed2.Size = new Size(32, 15);
            lblLed2.TabIndex = 0;
            lblLed2.Text = "Led2";
            lblLed2.Click += lblLed2_Click;
            // 
            // pnlLed3
            // 
            pnlLed3.Controls.Add(lblLed3);
            pnlLed3.Location = new Point(315, 330);
            pnlLed3.Name = "pnlLed3";
            pnlLed3.Size = new Size(57, 40);
            pnlLed3.TabIndex = 13;
            // 
            // lblLed3
            // 
            lblLed3.AutoSize = true;
            lblLed3.Location = new Point(13, 14);
            lblLed3.Name = "lblLed3";
            lblLed3.Size = new Size(32, 15);
            lblLed3.TabIndex = 0;
            lblLed3.Text = "Led3";
            lblLed3.Click += lblLed3_Click;
            // 
            // pnlLed4
            // 
            pnlLed4.Controls.Add(lblLed4);
            pnlLed4.Location = new Point(409, 330);
            pnlLed4.Name = "pnlLed4";
            pnlLed4.Size = new Size(57, 40);
            pnlLed4.TabIndex = 14;
            // 
            // lblLed4
            // 
            lblLed4.AutoSize = true;
            lblLed4.Location = new Point(13, 14);
            lblLed4.Name = "lblLed4";
            lblLed4.Size = new Size(32, 15);
            lblLed4.TabIndex = 0;
            lblLed4.Text = "Led4";
            lblLed4.Click += lblLed4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 401);
            Controls.Add(pnlLed4);
            Controls.Add(pnlLed3);
            Controls.Add(pnlLed2);
            Controls.Add(pnlLed1);
            Controls.Add(gpGelen);
            Controls.Add(gbGonder);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bluetooth <-> Arduino";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbGonder.ResumeLayout(false);
            gbGonder.PerformLayout();
            gpGelen.ResumeLayout(false);
            gpGelen.PerformLayout();
            pnlLed1.ResumeLayout(false);
            pnlLed1.PerformLayout();
            pnlLed2.ResumeLayout(false);
            pnlLed2.PerformLayout();
            pnlLed3.ResumeLayout(false);
            pnlLed3.PerformLayout();
            pnlLed4.ResumeLayout(false);
            pnlLed4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox cbComPort;
        private TextBox txtGonder;
        private Button btnGonder;
        private ComboBox cbBaud;
        private Label lblBaud;
        private Button btnConnect;
        private GroupBox groupBox1;
        private Label lblConnectStatus;
        private Label lblDurumText;
        private GroupBox gbGonder;
        private GroupBox gpGelen;
        private TextBox txtGelen;
        private Button btnTemizle;
        private Panel pnlLed1;
        private Label lblLed1;
        private Panel pnlLed2;
        private Label lblLed2;
        private Panel pnlLed3;
        private Label lblLed3;
        private Panel pnlLed4;
        private Label lblLed4;
    }
}
