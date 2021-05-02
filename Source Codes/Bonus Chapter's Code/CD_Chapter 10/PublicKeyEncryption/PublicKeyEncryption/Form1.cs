using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PublicKeyEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }
        string publicKey, privateKey;
        byte[] EncryptedStrAsByt;

        private void button1_Click(object sender, EventArgs e)
        {
            CspParameters cspParam = new CspParameters();
            cspParam.Flags = CspProviderFlags.UseMachineKeyStore;
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(cspParam);
            publicKey = RSA.ToXmlString(false); // gets the public key
            privateKey = RSA.ToXmlString(true); // gets the private key
            textBox2.Text = publicKey.ToString();
            textBox3.Text = privateKey.ToString();
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            RSACryptoServiceProvider RSA2 = new RSACryptoServiceProvider();
            // Load the public key to Encrypt Data
            RSA2.FromXmlString(publicKey);
            //Start Encrypting Data
            EncryptedStrAsByt = RSA2.Encrypt(Encoding.UTF8.GetBytes(str), false);
            object EncryptedStrAsString = Encoding.UTF8.GetString(EncryptedStrAsByt);
            //Display Encrypted Data
            textBox4.Text = EncryptedStrAsString.ToString();
            button3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Start Decrypting Data
            RSACryptoServiceProvider RSA3 = new RSACryptoServiceProvider();
            RSA3.FromXmlString(privateKey);
            byte[] DecryptedStrAsByt = RSA3.Decrypt(EncryptedStrAsByt, false);
            object DecryptedStrAsString = Encoding.UTF8.GetString(DecryptedStrAsByt);
            //Display Decrypted Data
            textBox5.Text = DecryptedStrAsString.ToString();        

        }
    }
}
