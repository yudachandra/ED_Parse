using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox_output.Text = FNG_Encrypt(txtBox_input.Text.Trim());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox_output.Text = FNG_Decrypt(txtBox_input.Text.Trim());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        protected string FNG_Encrypt(string value)
        {
            string keyString = clsCrypt.Get(txt_key_string.Text.Trim());
            string ivString = keyString.Substring(0, 16);
            clsCrypt.EncryptString(value, keyString, ivString);

            return clsCrypt.EncryptString(value, keyString, ivString);
        }

        protected string FNG_Decrypt(string value)
        {
            string keyString = clsCrypt.Get(txt_key_string.Text.Trim());
            string ivString = keyString.Substring(0, 16);
            clsCrypt.EncryptString(value, keyString, ivString);

            return clsCrypt.DecryptString(value, keyString, ivString);
        }
    }
}
