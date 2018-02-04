using MyProjectLibrary;
using MyProjectLibrary.Models;
using MyProjectLibrary.Validators;
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
        private AccountFormValidator validator = new AccountFormValidator();
        private ChangeAccount IsAccountChanable = ChangeAccount.No;
        private Boolean IsValidForm = false;

        public AccountModel AccountModel { get; private set; }

        public AccountForm(AccountModel accountModel)
        {
            InitializeComponent();
            this.AccountModel = accountModel;
            ConfigureForm();
        }

        private void changeApplayButton_Click(object sender, EventArgs e)
        {
            if (IsAccountChanable == ChangeAccount.Yes)
            {
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string email = emailTextBox.Text;
                string phoneNumber = phoneNumberTextBox.Text;

                AccountModel accountModel = validator.ValidateForm(firstName, lastName, email, phoneNumber);
                
                if (accountModel != null)
                {
                    IsAccountChanable = ChangeAccount.No;
                    IsValidForm = true;

                    accountModel.Id = this.AccountModel.Id;
                    accountModel.UserId = this.AccountModel.UserId;
                    this.AccountModel = accountModel;

                    GlobalConfig.Connection.AccountsOperations().UpdateAccount(this.AccountModel);

                    ConfigureForm();
                }

                return;
            }
            else if (IsAccountChanable == ChangeAccount.No)
            {
                IsAccountChanable = ChangeAccount.Yes;
                IsValidForm = false;
                ConfigureForm();
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

        private void ConfigureForm()
        {
            firstNameTextBox.Text = this.AccountModel.FirstName;
            lastNameTextBox.Text = this.AccountModel.LastName;
            emailTextBox.Text = this.AccountModel.Email;
            phoneNumberTextBox.Text = this.AccountModel.PhoneNumber.ToString();

            exitButton.Enabled = IsValidForm;

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
