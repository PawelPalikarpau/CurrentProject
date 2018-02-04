using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectUI
{
    public partial class MainForm : Form
    {
        public UserModel UserModel { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.Show();
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            if (UserModel == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
                this.Enabled = false;
                loginForm.Activate();
                loginForm.Show();
            }
        }

        void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = (LoginForm)sender;
            this.UserModel = loginForm.UserModel;

            this.DialogResult = DialogResult.Cancel;
            this.Enabled = true;
        }
    }
}
