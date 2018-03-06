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

namespace MyProjectUI.Forms
{
    public partial class LoginForm : Form, ILoginForm
    {
        public UserModel UserModel { get; private set; }
        public AccountModel AccountModel { get; private set; }
        private MainForm mainForm;

        private LoginFormValidator validator = new LoginFormValidator();
        private bool isAlreadyLaunched = false;

        public void InitializeForm(Form form)
        {
            this.mainForm = form as MainForm;
            InitializeComponent();
            xButton.Location = new Point(Location.X + Size.Width - xButton.Size.Width, Location.Y);
            this.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
            RefreshTextControls(null);
            emailTextControl.InputText = "olek@gmail.com";
            passwordTextControl.InputText = "qwer";
            this.Show();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(5);
            list.Add(5);
            
            List<int> newList = list.Where(item => item.Equals(5)).ToList();
            string ab = "a";
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

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.UserModel == null)
                Application.Exit();
            else if (AccountModel.FirstName == null)
            {
                IAccountForm accountForm = new AccountForm();
                accountForm.InitializeForm(AccountModel, mainForm, this.Name);
                mainForm.UserModel = UserModel;
            }
            else
            {
                mainForm.UserModel = UserModel;
                mainForm.AccountModel = AccountModel;
                mainForm.Enabled = true;
            }
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        public Form GetLoginForm()
        {
            return new LoginForm();
        }
    }
}
