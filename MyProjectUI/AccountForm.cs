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
    public partial class AccountForm : Form
    {
        private ChangeAccount IsAccountChanable;
        private bool IsFormValid = false;

        public AccountModel AccountModel { get; private set; }

        public AccountForm(ChangeAccount changeable, AccountModel accountModel)
        {
            InitializeComponent();
            this.IsAccountChanable = changeable;
            this.AccountModel = accountModel;
            ConfigureForm(accountModel);
        }

        private void changeApplayButton_Click(object sender, EventArgs e)
        {
            if (IsAccountChanable == ChangeAccount.Yes)
            {
                IsAccountChanable = ChangeAccount.No;
                ConfigureForm(this.AccountModel);
                return;
            }
            else if (IsAccountChanable == ChangeAccount.No)
            {
                IsAccountChanable = ChangeAccount.Yes;
                ConfigureForm(this.AccountModel);
                return;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ConfigureForm(AccountModel accountModel)
        {
            firstNameTextBox.Text = accountModel.FirstName;
            lastNameTextBox.Text = accountModel.LastName;
            emailTextBox.Text = accountModel.Email;
            phoneNumberTextBox.Text = accountModel.PhoneNumber.ToString();

            if (IsAccountChanable == ChangeAccount.Yes)
            {
                firstNameTextBox.ReadOnly = false;
                lastNameTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                phoneNumberTextBox.ReadOnly = false;

                changeApplayButton.Text = "Apply Changes";
            }
            else if (IsAccountChanable == ChangeAccount.No)
            {
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                phoneNumberTextBox.ReadOnly = true;

                changeApplayButton.Text = "Change Account";
            }
        }
    }
}
