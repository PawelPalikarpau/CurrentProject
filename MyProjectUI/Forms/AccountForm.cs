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
    public partial class AccountForm : Form, IAccountForm
    {
        private MainForm mainForm;
        private string formCaller;

        private ChangeAccount isAccountChanable = ChangeAccount.No;
        private Boolean isValidForm = false;
        private bool isAlreadyLaunched = false;
        private Point defaultLocation = new Point(13, 36);

        Dictionary<string, string> errors = new Dictionary<string, string>();
        private AccountFormValidator validator = new AccountFormValidator();
        public AccountModel AccountModel { get; private set; }

        public void InitializeForm(AccountModel accountModel, Form form, string formCaller)
        {
            InitializeComponent();
            InitializeStartData(accountModel, form, formCaller);
            ConfigureForm();
            RefreshTextControls();
            isAlreadyLaunched = false;
            this.Show();
        }

        private void InitializeStartData(AccountModel accountModel, Form form, string formCaller)
        {
            this.mainForm = form as MainForm;
            this.formCaller = formCaller;
            if (formCaller == "MainForm") isValidForm = true;
            xButton.Location = new Point(Location.X + Size.Width - xButton.Size.Width, Location.Y);
            this.FormClosed += new FormClosedEventHandler(accountForm_FormClosed);
            this.AccountModel = accountModel;
        }

        private void ConfigureForm()
        {
            firstNameTextControl.InputText = this.AccountModel.FirstName;
            lastNameTextControl.InputText = this.AccountModel.LastName;
            emailTextControl.InputText = this.AccountModel.Email;
            phoneTextControl.InputText = this.AccountModel.PhoneNumber.ToString();

            if (isAccountChanable == ChangeAccount.Yes)
            {
                firstNameTextControl.readOnly = false;
                lastNameTextControl.readOnly = false;
                emailTextControl.readOnly = false;
                phoneTextControl.readOnly = false;

                List<int> list = new List<int>();
                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(4);
                list.Add(5);
                list.Add(5);
                list.Add(5);

                List<int> newList = (List<int>) list.Where(item => item.Equals(5));

                isInfoVisible(false);

                backButton.Text = "Log out";
                changeApplayButton.Text = "Apply Changes";
            }
            else if (isAccountChanable == ChangeAccount.No)
            {
                firstNameTextControl.readOnly = true;
                lastNameTextControl.readOnly = true;
                emailTextControl.readOnly = true;
                phoneTextControl.readOnly = true;

                isInfoVisible(true);

                backButton.Text = "Back";
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

        private void isInfoVisible (bool changeTo)
        {
            this.topInfoLabel.Visible = changeTo;
            this.downInfoLabel.Visible = changeTo;
            this.middleInfoLabel.Visible = changeTo;
            this.endInfoLabel.Visible = changeTo;
            
            if (changeTo == false)
            {
                this.Size = new Size(502, 336);
                defaultLocation = new Point(13, 35);
            }
            else
            {
                this.Size = new Size(502, 384);
                defaultLocation = new Point(13, 81);
            }

            int change = 58;
            firstNameTextControl.Location = new Point(firstNameTextControl.Location.X, defaultLocation.Y);
            lastNameTextControl.Location = new Point(lastNameTextControl.Location.X, firstNameTextControl.Location.Y + change);
            emailTextControl.Location = new Point(emailTextControl.Location.X, lastNameTextControl.Location.Y + change);
            phoneTextControl.Location = new Point(phoneTextControl.Location.X, emailTextControl.Location.Y + change);
            changeApplayButton.Location = new Point(changeApplayButton.Location.X, phoneTextControl.Location.Y + change);
            backButton.Location = new Point(backButton.Location.X, phoneTextControl.Location.Y + change);
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void accountForm_FormClosed(object sender, EventArgs e)
        {
            if (formCaller == "MainForm" && isValidForm)
                DialogResult = DialogResult.OK;

            if (DialogResult == DialogResult.Abort)
            {
                ILoginForm loginForm = new LoginForm();
                loginForm.InitializeForm(mainForm);
            }
            else
            {
                mainForm.AccountModel = AccountModel;
                mainForm.Enabled = true;
            }
        }
    }
}
