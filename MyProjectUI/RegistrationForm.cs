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

namespace MyProjectUI
{
    public partial class RegistrationForm : Form
    {
        RegistrationFormValidator validator = new RegistrationFormValidator();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string firstPassword = firstPasswordTextBox.Text;
            string secondPassword = secondPasswordTextBox.Text;

            UserModel userModel = validator.ValidateForm(email, firstPassword, secondPassword);

            if (userModel != null)
            {
                AccountModel accountModel = GlobalConfig.Connection.CreateAccount(new AccountModel());
                userModel.AccountId = accountModel.Id;
                userModel = GlobalConfig.Connection.CreateUser(userModel);
            }
        }
    }
}
