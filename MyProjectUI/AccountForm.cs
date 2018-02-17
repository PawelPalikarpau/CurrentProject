using MyProjectLibrary;
using MyProjectLibrary.Enums;
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
        private ChangeAccount isAccountChanable = ChangeAccount.No;
        private Boolean isValidForm = false;
        private bool isAlreadyLaunched = false;
        Dictionary<string, string> errors = new Dictionary<string, string>();

        public AccountModel AccountModel { get; private set; }

        public AccountForm(AccountModel accountModel)
        {
            InitializeComponent();
            this.AccountModel = accountModel;
            ConfigureForm();
            RefreshTextControls();
            isAlreadyLaunched = false;
        }

        private void ConfigureForm()
        {
            firstNameTextControl.InputText = this.AccountModel.FirstName;
            lastNameTextControl.InputText = this.AccountModel.LastName;
            emailTextControl.InputText = this.AccountModel.Email;
            phoneTextControl.InputText = this.AccountModel.PhoneNumber.ToString();

            if (isValidForm == false)
                exitButton.ForeColor = Color.Red;
            else
                exitButton.ForeColor = Color.FromArgb(62, 120, 138);

            exitButton.Enabled = isValidForm;

            if (isAccountChanable == ChangeAccount.Yes)
            {
                firstNameTextControl.readOnly = false;
                lastNameTextControl.readOnly = false;
                emailTextControl.readOnly = false;
                phoneTextControl.readOnly = false;

                changeApplayButton.Text = "Apply Changes";
            }
            else if (isAccountChanable == ChangeAccount.No)
            {
                firstNameTextControl.readOnly = true;
                lastNameTextControl.readOnly = true;
                emailTextControl.readOnly = true;
                phoneTextControl.readOnly = true;

                changeApplayButton.Text = "Change Account";
            }
        }

        private void changeApplayButton_Click(object sender, EventArgs e)
        {
            if (isAccountChanable == ChangeAccount.Yes)
            {
                string firstName = firstNameTextControl.InputText;
                string lastName = lastNameTextControl.InputText;
                string email = emailTextControl.InputText;
                string phoneNumber = phoneTextControl.InputText;

                errors = new Dictionary<string, string>();
                errors = validator.ValidateForm(firstName, lastName, email, phoneNumber);

                if (errors.Count == 0)
                {
                    isAccountChanable = ChangeAccount.No;
                    isValidForm = true;

                    AccountModel accountModel = new AccountModel();
                    accountModel.Id = this.AccountModel.Id;
                    accountModel.UserId = this.AccountModel.UserId;
                    accountModel.FirstName = firstName;
                    accountModel.LastName = lastName;
                    accountModel.Email = email;
                    accountModel.PhoneNumber = Int32.Parse(phoneNumber);
                    this.AccountModel = accountModel;

                    GlobalConfig.Connection.AccountsOperations().UpdateAccount(this.AccountModel);

                    ConfigureForm();
                    RefreshTextControls();
                }
                else
                {
                    RefreshTextControls();
                }

                return;
            }
            else if (isAccountChanable == ChangeAccount.No)
            {
                isAccountChanable = ChangeAccount.Yes;
                isValidForm = false;
                ConfigureForm();
                RefreshTextControls();
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

        private void RefreshTextControls()
        {
            firstNameTextControl.ErrorLabelText = "";
            lastNameTextControl.ErrorLabelText = "";
            emailTextControl.ErrorLabelText = "";
            phoneTextControl.ErrorLabelText = "";

            if (isAlreadyLaunched)
            {
                if (errors.ContainsKey("firstName")) firstNameTextControl.ErrorLabelText = errors["firstName"];
                if (errors.ContainsKey("lastName")) lastNameTextControl.ErrorLabelText = errors["lastName"];
                if (errors.ContainsKey("email")) emailTextControl.ErrorLabelText = errors["email"];
                if (errors.ContainsKey("phone")) phoneTextControl.ErrorLabelText = errors["phone"];

                if (firstNameTextControl.ErrorLabelText != "") firstNameTextControl.ErrorType = ErrorMessageType.Error;
                else firstNameTextControl.ErrorType = ErrorMessageType.OK;

                if (lastNameTextControl.ErrorLabelText != "") lastNameTextControl.ErrorType = ErrorMessageType.Error;
                else lastNameTextControl.ErrorType = ErrorMessageType.OK;

                if (emailTextControl.ErrorLabelText != "") emailTextControl.ErrorType = ErrorMessageType.Error;
                else emailTextControl.ErrorType = ErrorMessageType.OK;

                if (phoneTextControl.ErrorLabelText != "") phoneTextControl.ErrorType = ErrorMessageType.Error;
                else phoneTextControl.ErrorType = ErrorMessageType.OK;
            }

            isAlreadyLaunched = true;

            firstNameTextControl.Refresh();
            lastNameTextControl.Refresh();
            emailTextControl.Refresh();
            phoneTextControl.Refresh();
        }
    }
}
