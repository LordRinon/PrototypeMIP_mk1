using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

// Encryption Module
// Methods:
// Encrypt(List<string>) -> Tuple<List<string>, string, string> | Sends *text* -> sends back *encrypted text*, *key* and *IV*
// Encrypt(Tuple<List<string>, string, string>) -> List<string> | Sends *text*, *key* and *IV* -> sends back *encrypted text*
// Decrypt(Tuple<List<string>, string, string>) -> List<string> | Sends *encrypted text*, *key* and *IV* -> sends back *text*
// Hash(string) -> string                                       | Sends *text* -> sends back *hashed text*
// GenString()  -> string                                       | Generates a random string

namespace PrototypeMIP_mk1
{
    public class EncryptionModule
    {
        private AesCryptoServiceProvider aes;

        // Encrypt - Returns encrypted Text + Key + IV | No key & IV Provided
        public Tuple<string, string, string> Encrypt(string param)
        {
            List<byte[]> encryptedbytes = new List<byte[]>();
            StringBuilder sb = new StringBuilder();

            byte[] clearbytes = Encoding.UTF8.GetBytes(param);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearbytes, 0, clearbytes.Length);
                    cs.Close();
                }
                encryptedbytes.Add(ms.ToArray());
            }
            foreach (var item in encryptedbytes)
            {
                sb.Append(Convert.ToBase64String(item));
            }


            
            return new Tuple<string, string, string>(sb.ToString(), Convert.ToBase64String(aes.Key), Convert.ToBase64String(aes.IV));
        }

        // Encrypt - Returns encrypted Text | Key & IV Provided
        public string Encrypt(Tuple<string, string, string> param)
        {
            List<byte[]> encryptedbytes = new List<byte[]>();
            StringBuilder sb = new StringBuilder();
            aes = new AesCryptoServiceProvider();
            aes.Key = Convert.FromBase64String(param.Item2);
            aes.IV = Convert.FromBase64String(param.Item3);


            byte[] clearbytes = Encoding.UTF8.GetBytes(param.Item1);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearbytes, 0, clearbytes.Length);
                    cs.Close();
                }
                encryptedbytes.Add(ms.ToArray());
            }
            foreach (var item in encryptedbytes)
            {
                sb.Append(Convert.ToBase64String(item));
            }
            return sb.ToString();
        }


        // Decrypt - Returns decrypted Text | Key & IV Provided
        public string Decrypt(Tuple<string, string, string> param)
        {
            StringBuilder sb = new StringBuilder();
            aes = new AesCryptoServiceProvider();
            aes.Key = Convert.FromBase64String(param.Item2);
            aes.IV = Convert.FromBase64String(param.Item3);

            List<byte[]> clearbytes = new List<byte[]>();

            byte[] encryptedbytes = Convert.FromBase64String(param.Item1);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms,
                    aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(encryptedbytes, 0, encryptedbytes.Length);
                    cs.Close();
                }
                clearbytes.Add(ms.ToArray());
            }
            foreach (var item in clearbytes)
            {
                sb.Append(Encoding.UTF8.GetString(item));
            }
            return sb.ToString();

        }

        // Returns a string's hashed value
        public string Hash(string value)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes;
                bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(value.ToString()));

                StringBuilder s = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    s.Append(bytes[i].ToString("x2"));
                }
                return s.ToString();
            }
        }

        // Generates a random string
        public string GenString()
        {
            int length = 8;
            StringBuilder s = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                s.Append(letter);
            }
            return s.ToString();
        }

        public Tuple<string, string> NewKey()
        {
            aes = new AesCryptoServiceProvider();
            aes.KeySize = 256;
            aes.CreateEncryptor();
            return new Tuple<string, string>(Convert.ToBase64String(aes.Key), Convert.ToBase64String(aes.IV));
        }
    }
}

    

