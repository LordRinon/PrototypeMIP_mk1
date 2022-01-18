using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace PrototypeMIP_mk1
{
    public class Encryption
    {
        private AesCryptoServiceProvider aes;
         
        public void Encrypt()
        {
            OpenFileDialog ofd = new OpenFileDialog();  
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileText = File.ReadAllText(ofd.FileName);  

                byte[] clearbytes = Encoding.UTF8.GetBytes(fileText);
                byte[] encryptedbytes;

               
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearbytes, 0, clearbytes.Length);
                        cs.Close();
                    }
                    encryptedbytes = ms.ToArray();
                }
                
                File.WriteAllText("encrypted.txt", Convert.ToBase64String(encryptedbytes));

                File.WriteAllText("key.txt", Convert.ToBase64String(aes.Key));
                File.WriteAllText("iv.txt", Convert.ToBase64String(aes.IV));
            }
        }

        public List<String> Decrypt()
        {
            List<string> text = new List<string>();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var encryptedText = File.ReadAllText(ofd.FileName);

                byte[] encryptedbytes = Convert.FromBase64String(encryptedText);
                byte[] clearbytes;

                byte[] key = Convert.FromBase64String(File.ReadAllText("key.txt"));
                byte[] iv = Convert.FromBase64String(File.ReadAllText("iv.txt"));

                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms,
                        aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedbytes, 0, encryptedbytes.Length);
                        cs.Close();
                    }
                    clearbytes = ms.ToArray();
                }

                
                text.Add(Encoding.UTF8.GetString(clearbytes));
            }
            return text;

        }
    }
}

    

