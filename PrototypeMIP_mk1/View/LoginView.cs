using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototypeMIP_mk1.Controller;

namespace PrototypeMIP_mk1.View
{
    public partial class LoginView : Form
    {
        LoginController controller = new LoginController();
        string username;
        string password;
        bool folderSelected = false;

        public LoginView()
        {
            InitializeComponent();
        }

        public LoginController LoginController
        {
            get => default;
            set
            {
            }
        }

        private void btnFolSel_Click(object sender, EventArgs e)
        {
            OpenFolder_Update(controller.OpenFolder());
            folderSelected = true;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (TextBox_Update() && folderSelected)
            {
                if(controller.CheckAuth(username, password))
                {
                    this.Hide();
                }
            }
            // Throw pop-up
        }

        // Check if any of the textboxes is empty
        private bool TextBox_Empty()
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // Update username & password parameters
        private bool TextBox_Update()
        {
            if (!TextBox_Empty())
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                return true;
            }
            else return false;
        }

        // Updates Open Folder button to selected folder
        private void OpenFolder_Update(string folName)
        {
            btnFolSel.Text = folName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            controller.OpenAccCreation();
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void romanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
