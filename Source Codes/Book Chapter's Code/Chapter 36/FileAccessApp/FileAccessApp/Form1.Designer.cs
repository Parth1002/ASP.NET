namespace FileAccessApp
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(186, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "File Contents Accessed Through App:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 175);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(181, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "File Contents Accessed Through Lib:";
            // 
            // StatusBar1
            // 
            this.StatusBar1.Location = new System.Drawing.Point(0, 294);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Size = new System.Drawing.Size(337, 22);
            this.StatusBar1.TabIndex = 15;
            this.StatusBar1.Text = "Click the button to access c:\\file.txt";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(22, 191);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(256, 80);
            this.TextBox2.TabIndex = 14;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(16, 79);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(256, 80);
            this.TextBox1.TabIndex = 13;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(42, 9);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(224, 40);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "Write and read file";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 316);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.StatusBar StatusBar1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Button1;
    }
}

