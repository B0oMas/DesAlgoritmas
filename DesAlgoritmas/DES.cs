﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using DesAlgoritmas;

namespace DesAlgoritmas
{
    class DES
    {
        public string EncryptionDESEcb(string strText, string strKey)
        {
            byte[] bykey = { };
            byte[] iv = { 0x01, 0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 };
            
            try
            {
                bykey = Encoding.UTF8.GetBytes(strKey);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                des.Mode = CipherMode.ECB;
                byte[] input = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(bykey, iv), CryptoStreamMode.Write);
                cs.Write(input, 0, input.Length);
                cs.FlushFinalBlock();
                File.WriteAllText(@"C:\Users\Lukas\Desktop\DesAlgoritmas\EncryptedText.txt", Convert.ToBase64String(ms.ToArray()));
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex) { }
            return null;
        }

        public string EncryptionDESCbc(string strText, string strKey)
        {
            byte[] bykey = { };
            byte[] iv = { 0x01, 0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 };

            try
            {
                bykey = Encoding.UTF8.GetBytes(strKey);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                des.Mode = CipherMode.CBC;
                byte[] input = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(bykey, iv), CryptoStreamMode.Write);
                cs.Write(input, 0, input.Length);
                cs.FlushFinalBlock();
                File.WriteAllText(@"C:\Users\Lukas\Desktop\DesAlgoritmas\EncryptedText.txt", Convert.ToBase64String(ms.ToArray()));
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex) { }
            return null;
        }

        public string DecryptionDESEcb(string strText, string strKey)
        {
            string deFile = System.IO.File.ReadAllText(@"C:\Users\Lukas\Desktop\DesAlgoritmas\EncryptedText.txt");
            byte[] bykey = { };
            byte[] iv = { 0x01, 0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 };
            byte[] input = new byte[deFile.Length];
            try
            {
                bykey = Encoding.UTF8.GetBytes(strKey);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                des.Mode = CipherMode.ECB;
                input = Convert.FromBase64String(deFile);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(bykey, iv), CryptoStreamMode.Write);
                cs.Write(input, 0, input.Length);
                cs.FlushFinalBlock();
                Encoding en = Encoding.UTF8;
                File.WriteAllText(@"C:\Users\Lukas\Desktop\DesAlgoritmas\DecryptedText.txt", en.GetString(ms.ToArray()));
                return en.GetString(ms.ToArray());
            }
            catch (Exception ex) { }
            return null;
        }

        public string DecryptionDESCbc(string strText, string strKey)
        {
            string deFile = System.IO.File.ReadAllText(@"C:\Users\Lukas\Desktop\DesAlgoritmas\EncryptedText.txt");
            byte[] bykey = { };
            byte[] iv = { 0x01, 0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 };
            byte[] input = new byte[deFile.Length];
            try
            {
                bykey = Encoding.UTF8.GetBytes(strKey);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                des.Mode = CipherMode.CBC;
                input = Convert.FromBase64String(deFile);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(bykey, iv), CryptoStreamMode.Write);
                cs.Write(input, 0, input.Length);
                cs.FlushFinalBlock();
                Encoding en = Encoding.UTF8;
                File.WriteAllText(@"C:\Users\Lukas\Desktop\DesAlgoritmas\DecryptedText.txt", en.GetString(ms.ToArray()));
                return en.GetString(ms.ToArray());
            }
            catch (Exception ex) { }
            return null;
        }
    }
}
