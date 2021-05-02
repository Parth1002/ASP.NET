namespace ClientActivatedClient
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
            this.components = new System.ComponentModel.Container();
            this.rbtnSoap = new System.Windows.Forms.RadioButton();
            this.txtStatusBar = new System.Windows.Forms.TextBox();
            this.cbtnFullTrust = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBinary = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnHttpChannel = new System.Windows.Forms.RadioButton();
            this.rbtnTcpChannel = new System.Windows.Forms.RadioButton();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnSoap
            // 
            this.rbtnSoap.Location = new System.Drawing.Point(120, 24);
            this.rbtnSoap.Name = "rbtnSoap";
            this.rbtnSoap.Size = new System.Drawing.Size(56, 16);
            this.rbtnSoap.TabIndex = 11;
            this.rbtnSoap.Text = "Soap";
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatusBar.Enabled = false;
            this.txtStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusBar.Location = new System.Drawing.Point(58, 366);
            this.txtStatusBar.Multiline = true;
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.ReadOnly = true;
            this.txtStatusBar.Size = new System.Drawing.Size(256, 40);
            this.txtStatusBar.TabIndex = 76;
            this.txtStatusBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbtnFullTrust
            // 
            this.cbtnFullTrust.Location = new System.Drawing.Point(202, 336);
            this.cbtnFullTrust.Name = "cbtnFullTrust";
            this.cbtnFullTrust.Size = new System.Drawing.Size(72, 24);
            this.cbtnFullTrust.TabIndex = 75;
            this.cbtnFullTrust.Text = "Full Trust";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbtnSoap);
            this.GroupBox1.Controls.Add(this.rbtnBinary);
            this.GroupBox1.Location = new System.Drawing.Point(58, 282);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(208, 48);
            this.GroupBox1.TabIndex = 74;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Formatter Sink Provider";
            // 
            // rbtnBinary
            // 
            this.rbtnBinary.Checked = true;
            this.rbtnBinary.Location = new System.Drawing.Point(40, 24);
            this.rbtnBinary.Name = "rbtnBinary";
            this.rbtnBinary.Size = new System.Drawing.Size(64, 16);
            this.rbtnBinary.TabIndex = 10;
            this.rbtnBinary.TabStop = true;
            this.rbtnBinary.Text = "Binary";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rbtnHttpChannel);
            this.GroupBox2.Controls.Add(this.rbtnTcpChannel);
            this.GroupBox2.Location = new System.Drawing.Point(58, 215);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(208, 48);
            this.GroupBox2.TabIndex = 73;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Channel";
            // 
            // rbtnHttpChannel
            // 
            this.rbtnHttpChannel.Location = new System.Drawing.Point(112, 16);
            this.rbtnHttpChannel.Name = "rbtnHttpChannel";
            this.rbtnHttpChannel.Size = new System.Drawing.Size(88, 24);
            this.rbtnHttpChannel.TabIndex = 9;
            this.rbtnHttpChannel.Text = "HttpChannel";
            this.rbtnHttpChannel.CheckedChanged += new System.EventHandler(this.rbtnHttpChannel_CheckedChanged);
            // 
            // rbtnTcpChannel
            // 
            this.rbtnTcpChannel.Checked = true;
            this.rbtnTcpChannel.Location = new System.Drawing.Point(16, 16);
            this.rbtnTcpChannel.Name = "rbtnTcpChannel";
            this.rbtnTcpChannel.Size = new System.Drawing.Size(88, 24);
            this.rbtnTcpChannel.TabIndex = 8;
            this.rbtnTcpChannel.TabStop = true;
            this.rbtnTcpChannel.Text = "TcpChannel";
            this.rbtnTcpChannel.CheckedChanged += new System.EventHandler(this.rbtnTcpChannel_CheckedChanged);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.TextBox2);
            this.GroupBox5.Location = new System.Drawing.Point(194, 150);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(80, 48);
            this.GroupBox5.TabIndex = 72;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Port No";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(8, 16);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(64, 20);
            this.TextBox2.TabIndex = 18;
            this.TextBox2.Text = "8086";
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(58, 110);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(112, 32);
            this.Button4.TabIndex = 70;
            this.Button4.Text = "Disconnect";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(186, 110);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(112, 32);
            this.Button3.TabIndex = 69;
            this.Button3.Text = "Get Count";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(186, 62);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(112, 32);
            this.Button2.TabIndex = 68;
            this.Button2.Text = "Greeting";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(58, 62);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(112, 32);
            this.Button1.TabIndex = 67;
            this.Button1.Text = "Connect";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(55, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 16);
            this.Label1.TabIndex = 66;
            this.Label1.Text = "My Code Name :";
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(58, 158);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(112, 32);
            this.Button5.TabIndex = 71;
            this.Button5.Text = "Climb the Cliff";
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(151, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(120, 20);
            this.TextBox1.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 422);
            this.Controls.Add(this.txtStatusBar);
            this.Controls.Add(this.cbtnFullTrust);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnSoap;
        private System.Windows.Forms.TextBox txtStatusBar;
        private System.Windows.Forms.CheckBox cbtnFullTrust;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton rbtnBinary;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton rbtnHttpChannel;
        private System.Windows.Forms.RadioButton rbtnTcpChannel;
        private System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.TextBox TextBox1;
    }
}

