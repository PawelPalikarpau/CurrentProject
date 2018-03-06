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

namespace MyProjectUI.Forms
{
    public partial class RegistrationForm : Form
    {
        RegistrationFormValidator validator = new RegistrationFormValidator();
        public string EmailText { get; set; }
        public string PasswordText { get; set; }
        private bool isAlreadyLaunched = false;

        public RegistrationForm()
        {
            InitializeComponent();
            xButton.Location = new Point(Location.X + Size.Width - xButton.Size.Width, Location.Y);
            RefreshTextControls(null);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string email = emailTextControl.InputText;
            string firstPassword = passwordTextControl.InputText;
            string secondPassword = confirmPasswrodTextControl.InputText;

            Dictionary<string, string> errors = new Dictionary<string, string>();
            errors = validator.ValidateForm(email, firstPassword, secondPassword);
            
            if (errors.Count == 0)
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
            emailTextControl.ErrorLabelText = "";
            passwordTextControl.ErrorLabelText = "";
            confirmPasswrodTextControl.ErrorLabelText = "";

            if (isAlreadyLaunched)
            {
                if (errors.ContainsKey("email")) emailTextControl.ErrorLabelText = errors["email"];
                if (errors.ContainsKey("firstPassword")) passwordTextControl.ErrorLabelText = errors["firstPassword"];
                if (errors.ContainsKey("secondPassword")) confirmPasswrodTextControl.ErrorLabelText = errors["secondPassword"];

                if (emailTextControl.ErrorLabelText != "") emailTextControl.ErrorType = ErrorMessageType.Error;
                else emailTextControl.ErrorType = ErrorMessageType.OK;

                if (passwordTextControl.ErrorLabelText != "") passwordTextControl.ErrorType = ErrorMessageType.Error;
                else passwordTextControl.ErrorType = ErrorMessageType.OK;

                if (confirmPasswrodTextControl.ErrorLabelText != "") confirmPasswrodTextControl.ErrorType = ErrorMessageType.Error;
                else confirmPasswrodTextControl.ErrorType = ErrorMessageType.OK;

            }

            isAlreadyLaunched = true;

            emailTextControl.Refresh();
            passwordTextControl.Refresh();
            confirmPasswrodTextControl.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
