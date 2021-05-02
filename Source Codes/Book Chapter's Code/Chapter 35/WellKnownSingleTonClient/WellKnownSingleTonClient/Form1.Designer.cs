namespace WellKnownSingleTonClient
{
    partial class Form1
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnSoap = new System.Windows.Forms.RadioButton();
            this.rbtnBinary = new System.Windows.Forms.RadioButton();
            this.txtStatusBar = new System.Windows.Forms.TextBox();
            this.cbtnFullTrust = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnHttpChannel = new System.Windows.Forms.RadioButton();
            this.rbtnTcpChannel = new System.Windows.Forms.RadioButton();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button6);
            this.GroupBox1.Controls.Add(this.Button4);
            this.GroupBox1.Controls.Add(this.Panel1);
            this.GroupBox1.Location = new System.Drawing.Point(321, 28);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(285, 205);
            this.GroupBox1.TabIndex = 85;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Paint Here";
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(74, 170);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(128, 23);
            this.Button6.TabIndex = 32;
            this.Button6.Text = "Choose Color";
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(210, 170);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(72, 23);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "Clear";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Panel1.Location = new System.Drawing.Point(8, 16);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(272, 148);
            this.Panel1.TabIndex = 5;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.rbtnSoap);
            this.GroupBox4.Controls.Add(this.rbtnBinary);
            this.GroupBox4.Location = new System.Drawing.Point(12, 175);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(158, 46);
            this.GroupBox4.TabIndex = 82;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Formatter Sink Provider";
            // 
            // rbtnSoap
            // 
            this.rbtnSoap.Location = new System.Drawing.Point(88, 21);
            this.rbtnSoap.Name = "rbtnSoap";
            this.rbtnSoap.Size = new System.Drawing.Size(56, 16);
            this.rbtnSoap.TabIndex = 11;
            this.rbtnSoap.Text = "Soap";
            // 
            // rbtnBinary
            // 
            this.rbtnBinary.Checked = true;
            this.rbtnBinary.Location = new System.Drawing.Point(16, 21);
            this.rbtnBinary.Name = "rbtnBinary";
            this.rbtnBinary.Size = new System.Drawing.Size(56, 16);
            this.rbtnBinary.TabIndex = 10;
            this.rbtnBinary.TabStop = true;
            this.rbtnBinary.Text = "Binary";
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatusBar.Enabled = false;
            this.txtStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusBar.Location = new System.Drawing.Point(141, 257);
            this.txtStatusBar.Multiline = true;
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.ReadOnly = true;
            this.txtStatusBar.Size = new System.Drawing.Size(324, 39);
            this.txtStatusBar.TabIndex = 84;
            this.txtStatusBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbtnFullTrust
            // 
            this.cbtnFullTrust.Location = new System.Drawing.Point(180, 186);
            this.cbtnFullTrust.Name = "cbtnFullTrust";
            this.cbtnFullTrust.Size = new System.Drawing.Size(72, 26);
            this.cbtnFullTrust.TabIndex = 83;
            this.cbtnFullTrust.Text = "Full Trust";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rbtnHttpChannel);
            this.GroupBox2.Controls.Add(this.rbtnTcpChannel);
            this.GroupBox2.Location = new System.Drawing.Point(13, 127);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(239, 42);
            this.GroupBox2.TabIndex = 81;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Channel";
            // 
            // rbtnHttpChannel
            // 
            this.rbtnHttpChannel.Location = new System.Drawing.Point(128, 16);
            this.rbtnHttpChannel.Name = "rbtnHttpChannel";
            this.rbtnHttpChannel.Size = new System.Drawing.Size(88, 20);
            this.rbtnHttpChannel.TabIndex = 9;
            this.rbtnHttpChannel.Text = "HttpChannel";
            this.rbtnHttpChannel.CheckedChanged += new System.EventHandler(this.rbtnHttpChannel_CheckedChanged);
            // 
            // rbtnTcpChannel
            // 
            this.rbtnTcpChannel.Checked = true;
            this.rbtnTcpChannel.Location = new System.Drawing.Point(15, 16);
            this.rbtnTcpChannel.Name = "rbtnTcpChannel";
            this.rbtnTcpChannel.Size = new System.Drawing.Size(88, 20);
            this.rbtnTcpChannel.TabIndex = 8;
            this.rbtnTcpChannel.TabStop = true;
            this.rbtnTcpChannel.Text = "TcpChannel";
            this.rbtnTcpChannel.CheckedChanged += new System.EventHandler(this.rbtnTcpChannel_CheckedChanged);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.TextBox2);
            this.GroupBox5.Location = new System.Drawing.Point(172, 63);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(80, 58);
            this.GroupBox5.TabIndex = 80;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Port No";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(8, 20);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(64, 20);
            this.TextBox2.TabIndex = 18;
            this.TextBox2.Text = "8086";
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(12, 95);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(72, 25);
            this.Button5.TabIndex = 79;
            this.Button5.Text = "Disconnect";
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(92, 95);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(72, 25);
            this.Button3.TabIndex = 78;
            this.Button3.Text = "Get Count";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(92, 63);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(72, 25);
            this.Button2.TabIndex = 77;
            this.Button2.Text = "Greeting";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 63);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(72, 25);
            this.Button1.TabIndex = 76;
            this.Button1.Text = "Connect";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.TextBox1);
            this.GroupBox3.Location = new System.Drawing.Point(12, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(264, 45);
            this.GroupBox3.TabIndex = 75;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Enter the IP address of the machine to connect to :";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(8, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(224, 20);
            this.TextBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 308);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.txtStatusBar);
            this.Controls.Add(this.cbtnFullTrust);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.RadioButton rbtnSoap;
        private System.Windows.Forms.RadioButton rbtnBinary;
        private System.Windows.Forms.TextBox txtStatusBar;
        private System.Windows.Forms.CheckBox cbtnFullTrust;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton rbtnHttpChannel;
        private System.Windows.Forms.RadioButton rbtnTcpChannel;
        private System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.TextBox TextBox1;
    }
}

