using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PrototypeMIP_mk1.Model;
using PrototypeMIP_mk1.View;

namespace PrototypeMIP_mk1.Controller
{
    public class LoginController
    {
        FileManagerModule file = new FileManagerModule();
        DirectoryInfo di;
        //TracerModule tracer = new TracerModule();
        Tuple<string, string> t;

        public void OpenEditor() { }

        public string OpenFolder() {
            // t.item1 contains the path to folder
            // t.item2 contains the name of the folder
            t = file.OpenFolder();
            string fName = t.Item2;
            di = new DirectoryInfo(t.Item1);
            //tracer.TraceWrite("Folder selected");
            return fName;
        }
        public bool CheckAuth(string username, string password) { 
            
            EncryptionModule en = new EncryptionModule();
            LoginModule lg = new LoginModule();
            string hashed = en.Hash(password);
            string msg;
            string access = lg.Login(username, hashed);
            if(access != null)
            {
                AlphaEditor editor = new AlphaEditor(t, di, access);
                editor.Show();
                //tracer.TraceWrite("Auth successful");
                return true;
            }
            //tracer.TraceWrite("Auth unsuccessful");
            return false; 
        }
        public bool CreateAcc(string username, string password) {
            EncryptionModule en = new EncryptionModule();
            LoginModule lg = new LoginModule();
            string hashed = en.Hash(password);
           //if (!lg.isAdded(username))
           // {
                lg.Create(username, hashed, en.Hash(en.GenString()));
           // }
            //tracer.TraceWrite("New account created");
            return true;
        }
        public void OpenAccCreation()
        {
            CreateAccView create = new CreateAccView();
            create.Show();
            //tracer.TraceWrite("Opened account creation menu");
        }
    }
}