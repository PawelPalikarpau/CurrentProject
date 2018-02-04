using MyProjectLibrary;
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
        public AccountModel AccountModel { get; set; }

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
                loginForm.Show();
            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = (LoginForm)sender;
            this.UserModel = loginForm.UserModel;
            this.AccountModel = loginForm.AccountModel;

            if (AccountModel.FirstName == null)
                ShowAccountForm(ChangeAccount.Yes);
            else            
                this.Enabled = true;
        }

        private void ShowAccountForm(ChangeAccount changeable)
        {
            AccountForm accountForm = new AccountForm(changeable);
            accountForm.FormClosed += new FormClosedEventHandler(accountForm_FormClosed);
            accountForm.Show();
        }

        private void accountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
