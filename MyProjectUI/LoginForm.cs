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
    public partial class LoginForm : Form
    {
        public UserModel UserModel { get; private set; }
        public AccountModel AccountModel { get; private set; }

        private LoginFormValidator validator = new LoginFormValidator();
        private bool isAlreadyLaunched = false;

        public LoginForm()
        {
            InitializeComponent();
            RefreshTextControls(null);
            emailTextControl.InputText = "marta@gmail.com";
            passwordTextControl.InputText = "qwer";
        }

        void registrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistrationForm registrationForm = (RegistrationForm)sender;
            emailTextControl.InputText = registrationForm.EmailText;
            passwordTextControl.InputText = registrationForm.PasswordText;
            
            this.Visible = true;
            this.Enabled = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Yellow;
            string email = emailTextControl.InputText;
            string password = passwordTextControl.InputText;

            Dictionary<string, string> errors = new Dictionary<string, string>();
            errors = validator.ValidateForm(email, password);

            if (errors.Count == 0)
            {
                this.UserModel = GlobalConfig.Connection.UsersOperations().GetUserByEmail(email);
                this.AccountModel = GlobalConfig.Connection.AccountsOperations().GetAccountByUserId(this.UserModel.Id);
                this.Close();
            }
            else
            {
                RefreshTextControls(errors);
            }
        }

        private void registrateButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.FormClosed += new FormClosedEventHandler(registrationForm_FormClosed);
            this.Enabled = false;
            this.Visible = false;
            registrationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshTextControls(Dictionary<string, string> errors)
        {
            emailTextControl.ErrorLabelText = "";
            passwordTextControl.ErrorLabelText = "";

            if (isAlreadyLaunched)
            {
                if (errors.ContainsKey("email")) emailTextControl.ErrorLabelText = errors["email"];
                if (errors.ContainsKey("firstPassword")) passwordTextControl.ErrorLabelText = errors["firstPassword"];

                if (emailTextControl.ErrorLabelText != "") emailTextControl.ErrorType = ErrorMessageType.Error;
                else emailTextControl.ErrorType = ErrorMessageType.OK;

                if (passwordTextControl.ErrorLabelText != "") passwordTextControl.ErrorType = ErrorMessageType.Error;
                else passwordTextControl.ErrorType = ErrorMessageType.OK;

            }

            isAlreadyLaunched = true;

            emailTextControl.Refresh();
            passwordTextControl.Refresh();
        }
    }
}
