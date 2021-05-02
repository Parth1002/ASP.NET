using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace SecretKeyFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  Call this function to remove the key from memory after use 
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (button3.Enabled == false)
                toolStripStatusLabel1.Text = "Please specify an input file to encrypt.";
            else
                toolStripStatusLabel1.Text = "Please specify an input file to decrypt.";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (button3.Enabled == false)
                toolStripStatusLabel1.Text = "Output file path specified. Press the Encrypt File button for encrypting the file.";
            else
                toolStripStatusLabel1.Text = "Output file path specified. Press the Decrypt File button for decrypting the file.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName.ToString();
                toolStripStatusLabel1.Text = "Input file selected.Specify the path for the output file.";
            }
        }

        // Method to generate a 64-bit secret key for the DES algorithm
        static string GenerateSecretKey()
        {
            // Create an object of the symmetric algorithm. A default secret key and IV are generated.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Return the default key 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MySecretKey;
            // Get the secret key for encryption 
            MySecretKey = GenerateSecretKey();
            label4.Text = MySecretKey;
            // For additional security, pin the key
            GCHandle gch = GCHandle.Alloc(MySecretKey, GCHandleType.Pinned);
            // Encrypt the input file with the default secret key         
            EncryptFile(@textBox1.Text, @textBox2.Text, MySecretKey);
            button3.Enabled = true;
            toolStripStatusLabel1.Text = "Specify the input file to be decrypted.";
        }

        static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            //Open the input file
            FileStream FileStreamInputContainer = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            //Start encrypting the file
            FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //A 64-bit key and IV are required for the DES algorithm
            //Set secret key for the DES algorithm
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set the IV for the DES algorithm 
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[FileStreamInputContainer.Length];
            FileStreamInputContainer.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            FileStreamInputContainer.Close();
            fsEncrypted.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MySecretKey;
            // Get the secret key for decrypting the file 
            MySecretKey = label4.Text;
            DecryptFile(@textBox1.Text, @textBox2.Text, MySecretKey);
        }

        static void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            //Create a file stream to read the decrypted file
            FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            //Create a DES decryptor object for the current DES object
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //Create a crypto stream to read and do a 
            //DES decryption transform on incoming bytes
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
            //Store the decrypted data in the given output file
            StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
