using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesAlgoritmas
{
    public partial class Form1 : Form
    {
        DES des = new DES();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            txt_result.Text = des.EncryptionDES(txt_text.Text, txt_key.Text);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            txt_decryptedText.Text = des.DecryptionDES(txt_text.Text, txt_key.Text);
        }
    }
}
