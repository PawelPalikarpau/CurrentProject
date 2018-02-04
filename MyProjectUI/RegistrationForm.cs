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
        public string EmailText { get; set; }

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

            if (userModel != null && !validator.IsEmailExists(email))
            {
                userModel = GlobalConfig.Connection.CreateUser(userModel);
                GlobalConfig.Connection.CreateAccount(userModel);
                this.EmailText = email;
                this.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
