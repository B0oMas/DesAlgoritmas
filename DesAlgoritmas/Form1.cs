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
            // Isveda teksta
            txt_result.Text = des.EncryptionDESEcb(txt_text.Text, txt_key.Text);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            // Desifruoja texta is nurodyto failo, perraso Teksto lauka
            txt_decryptedText.Text = des.DecryptionDESEcb(@"C:\Users\Lukas\Desktop\DesAlgoritmas\DecryptedText.txt", txt_key.Text);
        }

        private void btn_encrypt1_Click(object sender, EventArgs e)
        {
            // Isveda teksta
            txt_result.Text = des.EncryptionDESCbc(txt_text.Text, txt_key.Text);
        }

        private void btn_decrypt1_Click(object sender, EventArgs e)
        {
            // Desifruoja texta is nurodyto failo, perraso Teksto lauka
            txt_decryptedText.Text = des.DecryptionDESCbc(@"C:\Users\Lukas\Desktop\DesAlgoritmas\DecryptedText.txt", txt_key.Text);
        }
    }
}
