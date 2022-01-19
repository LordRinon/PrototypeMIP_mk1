using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeMIP_mk1.Model;

namespace PrototypeMIP_mk1.Controller
{
    public class LoginController
    {
        FileManagerModule file = new FileManagerModule();
        DirectoryInfo di;
        public void OpenEditor() { }

        public string OpenFolder() {
            Tuple<string, string> t = file.OpenFolder();
            string fName = t.Item2;
            di = new DirectoryInfo(t.Item1);
            return fName; 
        }
        public bool CheckAuth(string username, string password) { return true; }
    }
}