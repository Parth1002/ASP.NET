namespace DBServer
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
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.rbtnBinary = new System.Windows.Forms.RadioButton();
            this.rbtnSoap = new System.Windows.Forms.RadioButton();
            this.rbtnTcpChannel = new System.Windows.Forms.RadioButton();
            this.rbtnHttpChannel = new System.Windows.Forms.RadioButton();
            this.rbtnWSingleCall = new System.Windows.Forms.RadioButton();
            this.rbtnWSingleTon = new System.Windows.Forms.RadioButton();
            this.rbtnCActivated = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbServces = new System.Windows.Forms.ListBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnStopSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.cbtnFullTrust = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStatusBar = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(39, 45);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(82, 20);
            this.TextBox2.TabIndex = 0;
            // 
            // rbtnBinary
            // 
            this.rbtnBinary.AutoSize = true;
            this.rbtnBinary.Location = new System.Drawing.Point(6, 35);
            this.rbtnBinary.Name = "rbtnBinary";
            this.rbtnBinary.Size = new System.Drawing.Size(54, 17);
            this.rbtnBinary.TabIndex = 1;
            this.rbtnBinary.TabStop = true;
            this.rbtnBinary.Text = "Binary";
            this.rbtnBinary.UseVisualStyleBackColor = true;
            // 
            // rbtnSoap
            // 
            this.rbtnSoap.AutoSize = true;
            this.rbtnSoap.Location = new System.Drawing.Point(116, 35);
            this.rbtnSoap.Name = "rbtnSoap";
            this.rbtnSoap.Size = new System.Drawing.Size(50, 17);
            this.rbtnSoap.TabIndex = 2;
            this.rbtnSoap.TabStop = true;
            this.rbtnSoap.Text = "Soap";
            this.rbtnSoap.UseVisualStyleBackColor = true;
            // 
            // rbtnTcpChannel
            // 
            this.rbtnTcpChannel.AutoSize = true;
            this.rbtnTcpChannel.Location = new System.Drawing.Point(6, 35);
            this.rbtnTcpChannel.Name = "rbtnTcpChannel";
            this.rbtnTcpChannel.Size = new System.Drawing.Size(83, 17);
            this.rbtnTcpChannel.TabIndex = 4;
            this.rbtnTcpChannel.TabStop = true;
            this.rbtnTcpChannel.Text = "TcpChannel";
            this.rbtnTcpChannel.UseVisualStyleBackColor = true;
            this.rbtnTcpChannel.CheckedChanged += new System.EventHandler(this.rbtnTcpChannel_CheckedChanged);
            // 
            // rbtnHttpChannel
            // 
            this.rbtnHttpChannel.AutoSize = true;
            this.rbtnHttpChannel.Location = new System.Drawing.Point(127, 35);
            this.rbtnHttpChannel.Name = "rbtnHttpChannel";
            this.rbtnHttpChannel.Size = new System.Drawing.Size(84, 17);
            this.rbtnHttpChannel.TabIndex = 5;
            this.rbtnHttpChannel.TabStop = true;
            this.rbtnHttpChannel.Text = "HttpChannel";
            this.rbtnHttpChannel.UseVisualStyleBackColor = true;
            this.rbtnHttpChannel.CheckedChanged += new System.EventHandler(this.rbtnHttpChannel_CheckedChanged);
            // 
            // rbtnWSingleCall
            // 
            this.rbtnWSingleCall.AutoSize = true;
            this.rbtnWSingleCall.Location = new System.Drawing.Point(6, 34);
            this.rbtnWSingleCall.Name = "rbtnWSingleCall";
            this.rbtnWSingleCall.Size = new System.Drawing.Size(131, 17);
            this.rbtnWSingleCall.TabIndex = 6;
            this.rbtnWSingleCall.TabStop = true;
            this.rbtnWSingleCall.Text = "WellKnown. SingleCall";
            this.rbtnWSingleCall.UseVisualStyleBackColor = true;
            // 
            // rbtnWSingleTon
            // 
            this.rbtnWSingleTon.AutoSize = true;
            this.rbtnWSingleTon.Location = new System.Drawing.Point(200, 34);
            this.rbtnWSingleTon.Name = "rbtnWSingleTon";
            this.rbtnWSingleTon.Size = new System.Drawing.Size(133, 17);
            this.rbtnWSingleTon.TabIndex = 7;
            this.rbtnWSingleTon.TabStop = true;
            this.rbtnWSingleTon.Text = "WellKnown. SingleTon";
            this.rbtnWSingleTon.UseVisualStyleBackColor = true;
            // 
            // rbtnCActivated
            // 
            this.rbtnCActivated.AutoSize = true;
            this.rbtnCActivated.Location = new System.Drawing.Point(383, 34);
            this.rbtnCActivated.Name = "rbtnCActivated";
            this.rbtnCActivated.Size = new System.Drawing.Size(99, 17);
            this.rbtnCActivated.TabIndex = 8;
            this.rbtnCActivated.TabStop = true;
            this.rbtnCActivated.Text = "Client Activated";
            this.rbtnCActivated.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 218);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.radioButton3);
            this.GroupBox1.Controls.Add(this.rbtnTcpChannel);
            this.GroupBox1.Controls.Add(this.rbtnHttpChannel);
            this.GroupBox1.Location = new System.Drawing.Point(39, 99);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(230, 80);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Channel";
            // 
            // lbServces
            // 
            this.lbServces.FormattingEnabled = true;
            this.lbServces.Location = new System.Drawing.Point(11, 19);
            this.lbServces.Name = "lbServces";
            this.lbServces.Size = new System.Drawing.Size(150, 108);
            this.lbServces.TabIndex = 12;
            this.lbServces.SelectedIndexChanged += new System.EventHandler(this.lbServces_SelectedIndexChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(210, 19);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(150, 108);
            this.TextBox1.TabIndex = 13;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(11, 169);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(90, 40);
            this.btnStartServer.TabIndex = 14;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(420, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 40);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStopSelected
            // 
            this.btnStopSelected.Location = new System.Drawing.Point(210, 169);
            this.btnStopSelected.Name = "btnStopSelected";
            this.btnStopSelected.Size = new System.Drawing.Size(120, 40);
            this.btnStopSelected.TabIndex = 16;
            this.btnStopSelected.Text = "Stop Selected";
            this.btnStopSelected.UseVisualStyleBackColor = true;
            this.btnStopSelected.Click += new System.EventHandler(this.btnStopSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Port No.";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rbtnSoap);
            this.GroupBox2.Controls.Add(this.rbtnBinary);
            this.GroupBox2.Location = new System.Drawing.Point(306, 99);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(249, 80);
            this.GroupBox2.TabIndex = 18;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Formatter Sink Provider";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.rbtnWSingleCall);
            this.GroupBox3.Controls.Add(this.rbtnWSingleTon);
            this.GroupBox3.Controls.Add(this.rbtnCActivated);
            this.GroupBox3.Location = new System.Drawing.Point(39, 210);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(516, 81);
            this.GroupBox3.TabIndex = 19;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Service Type";
            // 
            // cbtnFullTrust
            // 
            this.cbtnFullTrust.AutoSize = true;
            this.cbtnFullTrust.Location = new System.Drawing.Point(486, 297);
            this.cbtnFullTrust.Name = "cbtnFullTrust";
            this.cbtnFullTrust.Size = new System.Drawing.Size(69, 17);
            this.cbtnFullTrust.TabIndex = 20;
            this.cbtnFullTrust.Text = "Full Trust";
            this.cbtnFullTrust.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStatusBar);
            this.groupBox4.Controls.Add(this.lbServces);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnStopSelected);
            this.groupBox4.Controls.Add(this.TextBox1);
            this.groupBox4.Controls.Add(this.btnStartServer);
            this.groupBox4.Location = new System.Drawing.Point(45, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 293);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control Panel";
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.Location = new System.Drawing.Point(11, 232);
            this.txtStatusBar.Multiline = true;
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.ReadOnly = true;
            this.txtStatusBar.Size = new System.Drawing.Size(349, 41);
            this.txtStatusBar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 645);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbtnFullTrust);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox2);
            this.Name = "Form1";
            this.Text = "Remoting Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.RadioButton rbtnBinary;
        private System.Windows.Forms.RadioButton rbtnSoap;
        private System.Windows.Forms.RadioButton rbtnTcpChannel;
        private System.Windows.Forms.RadioButton rbtnHttpChannel;
        private System.Windows.Forms.RadioButton rbtnWSingleCall;
        private System.Windows.Forms.RadioButton rbtnWSingleTon;
        private System.Windows.Forms.RadioButton rbtnCActivated;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ListBox lbServces;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStopSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.CheckBox cbtnFullTrust;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStatusBar;
    }
}

