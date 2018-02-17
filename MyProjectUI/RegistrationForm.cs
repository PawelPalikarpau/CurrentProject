using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProjectLibrary;
using MyProjectLibrary.Models;
using MyProjectLibrary.Validators;
using MyProjectLibrary.Enums;

namespace MyProjectUI
{
    public partial class RegistrationForm : Form
    {
        RegistrationFormValidator validator = new RegistrationFormValidator();
        public string EmailText { get; set; }
        public string PasswordText { get; set; }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string email = emailTextControl.InputText;
            string firstPassword = paswordTextControl.InputText;
            string secondPassword = confirmPasswrodTextControl.InputText;

            Dictionary<string, string> errors = validator.ValidateForm(email, firstPassword, secondPassword);
            
            if (errors.Count == 0 || errors == null)
            {
                UserModel userModel = new UserModel();
                userModel.Email = email;
                userModel.Password = firstPassword;
                userModel.Role = "User";

                userModel = GlobalConfig.Connection.UsersOperations().CreateUser(userModel);
                GlobalConfig.Connection.AccountsOperations().CreateAccount(userModel);
                this.EmailText = email;
                this.Close();
            } 
            else
            {
                RefreshTextControls(errors);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.EmailText = null;
            this.PasswordText = null;
            this.Close();
        }

        private void RefreshTextControls(Dictionary<string, string> errors)
        {
            emailTextControl.ErrorLabelText = errors["email"];
            paswordTextControl.ErrorLabelText = errors["firstPassword"];
            confirmPasswrodTextControl.ErrorLabelText = errors["secondPassword"];

            if (emailTextControl.ErrorLabelText != "") emailTextControl.errorType = ErrorMessageType.Error;
            if (paswordTextControl.ErrorLabelText != "") paswordTextControl.errorType = ErrorMessageType.Error;
            if (confirmPasswrodTextControl.ErrorLabelText != "") confirmPasswrodTextControl.errorType = ErrorMessageType.Error;

            emailTextControl.Parent.Refresh();
            paswordTextControl.Parent.Refresh();
            confirmPasswrodTextControl.Parent.Refresh();
        }
    }
}
