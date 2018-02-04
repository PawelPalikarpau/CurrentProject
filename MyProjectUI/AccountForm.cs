using MyProjectLibrary;
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

        public AccountForm(ChangeAccount changeable)
        {
            InitializeComponent();
            this.IsAccountChanable = changeable;
            ConfigureForm();
        }

        private void ConfigureForm()
        {
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
