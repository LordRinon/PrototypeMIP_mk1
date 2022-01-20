using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeMIP_mk1.Model;
using PrototypeMIP_mk1.View;

namespace PrototypeMIP_mk1.Controller
{
    public class LoginController
    {
        FileManagerModule file = new FileManagerModule();
        DirectoryInfo di;
        Tuple<string, string> t;
        public void OpenEditor() { }

        public string OpenFolder() {
            // t.item1 contains the path to folder
            // t.item2 contains the name of the folder
            t = file.OpenFolder();
            string fName = t.Item2;
            di = new DirectoryInfo(t.Item1);
            return fName;
        }
        public bool CheckAuth(string username, string password) { 
            
            Encryption en = new Encryption();
            LoginModule lg = new LoginModule();
            string hashed = en.Hash(password);

            string access = lg.Login(username, hashed);
            if(access != null)
            {
                AlphaEditor editor = new AlphaEditor(t, di);
                editor.Show();
                return true;
            }
            return false; 
        }
        public bool CreateAcc(string username, string password) {
            Encryption en = new Encryption();
            LoginModule lg = new LoginModule();
            string hashed = en.Hash(password);
           // if (!lg.isAdded(username))
           // {
                lg.Create(username, hashed, en.Hash(en.GenString()));
           // }
            return true;
        }
        public void OpenAccCreation()
        {
            CreateAccView create = new CreateAccView();
            create.Show();
        }
    }
}