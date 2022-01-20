using PrototypeMIP_mk1.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeMIP_mk1
{
    public partial class AlphaEditor : Form
    {
        Tuple<string, string> t;
        DirectoryInfo di;
        EditorController ec = new EditorController();
        public AlphaEditor(Tuple<string, string> t, DirectoryInfo di)
        {
            this.t = t;
            this.di = di;
            InitializeComponent();

        }

        public string text {
            get { return richtxtBox.Text; }
            set { richtxtBox.Text = value; }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void richtxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task WaitTimer()
        {
            await Task.Run(() =>
            {
                ec.Text_Update();
            });
        }
    }
}
