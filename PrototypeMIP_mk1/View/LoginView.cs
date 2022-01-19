using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototypeMIP_mk1.Controller;

namespace PrototypeMIP_mk1.View
{
    public partial class LoginForm : Form
    {
        LoginController controller = new LoginController();
        string username;
        string password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnFolSel_Click(object sender, EventArgs e)
        {
            controller.OpenFolder();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (TextBox_Update())
            {
                controller.CheckAuth(username, password);
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
    }
}
