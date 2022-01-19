using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeMIP_mk1.Model
{
    public class FileManagerModule
    {
        public Tuple<string, string> OpenFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                Tuple<string, string> t = new Tuple<string, string>(fbd.SelectedPath, Path.GetFileName(fbd.SelectedPath));
                return t;
            }
            else return null;
        }
    }
}
