namespace GenericsSample
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
            this.Button4 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Enabled = false;
            this.Button4.Location = new System.Drawing.Point(163, 150);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(117, 27);
            this.Button4.TabIndex = 16;
            this.Button4.Text = "Search in Collection";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 142);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 13);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Addition Results";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Integer Collection";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(131, 108);
            this.listBox1.TabIndex = 16;
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Location = new System.Drawing.Point(163, 70);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(117, 27);
            this.Button2.TabIndex = 15;
            this.Button2.Text = "Add First Two";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Enabled = false;
            this.Button3.Location = new System.Drawing.Point(163, 109);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(117, 27);
            this.Button3.TabIndex = 13;
            this.Button3.Text = "Add All Selected";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(11, 160);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(131, 20);
            this.TextBox1.TabIndex = 6;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(163, 28);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(117, 27);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "Add Items";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 196);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Generics Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Button1;
    }
}

