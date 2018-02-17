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
        public UserModel UserModel { get; private set; }
        public AccountModel AccountModel { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            this.Show();
            if (UserModel == null) ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
            this.Enabled = false;
            loginForm.Show();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = (LoginForm)sender;
            this.UserModel = loginForm.UserModel;
            this.AccountModel = loginForm.AccountModel;

            //if (UserModel == null)
                //Application.Exit();
            //else if (AccountModel.FirstName == null)
                //ShowAccountForm(this.AccountModel);
            //else
                this.Enabled = true;
        }

        private void ShowAccountForm(AccountModel accountModel)
        {
            AccountForm accountForm = new AccountForm( accountModel);
            accountForm.FormClosed += new FormClosedEventHandler(accountForm_FormClosed);
            accountForm.Show();
        }

        private void accountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccountForm accountForm = (AccountForm)sender;
            if (accountForm.DialogResult != DialogResult.OK)
                ShowLoginForm();
            else
                this.Enabled = true;
        }
    }
}
