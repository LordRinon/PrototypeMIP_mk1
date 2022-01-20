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
    public partial class CreateAccView : Form
    {
        string username;
        string password;
        public CreateAccView()
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            LoginController lg = new LoginController();
            if (TextBox_Update())
            {
                if (lg.CreateAcc(username,password))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                // Pop-up error
            }
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
