using PrototypeMIP_mk1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PrototypeMIP_mk1.Controller
{
    public class EditorController
    {
        EncryptionModule encryption = new EncryptionModule();
        LoginModule lg = new LoginModule();
        public string OpenFile(string path, string access)
        {
            string text = File.ReadAllText(path);
            Tuple<string, string> t = lg.GetKey(access);
            string decryped_text = encryption.Decrypt(new Tuple<string, string, string>(text, t.Item1, t.Item2));
            return decryped_text;
        }
        public void SaveFile(string text, string path, string access)
        {
            Tuple<string, string> t = lg.GetKey(access);
            string encrypted_text = encryption.Encrypt(new Tuple<string, string, string>(text, t.Item1, t.Item2));
            File.WriteAllText(path, encrypted_text);
        }

    }
}
