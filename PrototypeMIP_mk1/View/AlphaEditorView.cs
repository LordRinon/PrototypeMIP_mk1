using PrototypeMIP_mk1.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeMIP_mk1
{
    public partial class AlphaEditor : Form
    {
        Tuple<string, string> t;
        DirectoryInfo di;
        string access;
        string selectedFile;
        EditorController ec = new EditorController();

        public AlphaEditor(Tuple<string, string> t, DirectoryInfo di, string access)
        {
            this.t = t;
            this.di = di;
            this.access = access;
            InitializeComponent();
            LoadDirectory(t.Item1);
            this.Text = t.Item2;
        }

        public EditorController EditorController
        {
            get => default;
            set
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            treeV.Nodes.Clear();
            LoadDirectory(t.Item1);
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            ec.SaveFile(richtxtBox.Text, selectedFile, access);
        }

        private void richtxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void treeV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode treeNode = this.treeV.SelectedNode;
            string path = treeNode.FullPath;
            StringBuilder sb = new StringBuilder();
            sb.Append(t.Item1);
            int offset = t.Item2.Length;
            sb.Remove((sb.Length-offset), offset);
            sb.Append(path);
            selectedFile = sb.ToString();
            //richtxtBox.Text = sb.ToString();
            richtxtBox.Text = ec.OpenFile(sb.ToString(), access);
        }














        private void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeV.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }
        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;

            }
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
            }
        }

        private void treeV_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode theNode = this.treeV.GetNodeAt(e.X, e.Y);
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.  
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeV))
                    this.toolTip1.SetToolTip(this.treeV, theNode.Tag.ToString());

            }
            else     // Pointer is not over a node so clear the ToolTip.  
            {
                this.toolTip1.SetToolTip(this.treeV, "");
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

    }
}
