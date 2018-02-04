using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectLibrary.Validators
{
    public class ErrorsValidator
    {
        private Dictionary<String, String> errorsDictionary = new Dictionary<String, String>();

        public ErrorsValidator()
        {
            this.errorsDictionary.Add("IsEmailEmpty", "You must fill E-mail address." + Environment.NewLine);
            this.errorsDictionary.Add("IsFirstPasswordEmpty", "You must fill password field." + Environment.NewLine);
            this.errorsDictionary.Add("IsSecondPasswordEmpty", "You must fill confirm password field." + Environment.NewLine);
            this.errorsDictionary.Add("IsVaildEmail", "You must fill correct E-mail." + Environment.NewLine);
            this.errorsDictionary.Add("IsPaswordConfirm", "You must fill the same confirm password." + Environment.NewLine);
            this.errorsDictionary.Add("IsShortPassword", "The password must be at least of three characters." + Environment.NewLine);
            this.errorsDictionary.Add("IsEmailExists", "User with such E-mail already exists." + Environment.NewLine);
            this.errorsDictionary.Add("IsEmailDoesNotExists", "User with such E-mail does not exists." + Environment.NewLine);
            this.errorsDictionary.Add("IsPasswordsMatch", "The password is inccorect. Please try again." + Environment.NewLine);
            this.errorsDictionary.Add("IsFirstNameEmpty", "You must fill the first name." + Environment.NewLine);
            this.errorsDictionary.Add("IsLastNameEmpty", "You must fill the last name." + Environment.NewLine);
            this.errorsDictionary.Add("IsPhoneNumberEmpty", "You must fill phone number." + Environment.NewLine);
            this.errorsDictionary.Add("IsFirstNameShort", "The first name must be at least of three characters." + Environment.NewLine);
            this.errorsDictionary.Add("IsLastNameShort", "The last name must be at least of three characters." + Environment.NewLine);
            this.errorsDictionary.Add("IsPhoneNumberNumeric", "The Phone number must consists only of numbers." + Environment.NewLine);
        }

        public bool AreErrors(ValidationModel validationModel)
        {
            StringBuilder errors = new StringBuilder();

            if (validationModel.IsEmailEmpty)  errors.Append(errorsDictionary["IsEmailEmpty"]);
            if (validationModel.IsFirstPasswordEmpty)  errors.Append(errorsDictionary["IsFirstPasswordEmpty"]);
            if (validationModel.IsSecondPasswordEmpty)  errors.Append(errorsDictionary["IsSecondPasswordEmpty"]);
            if (validationModel.IsInvaildEmail) errors.Append(errorsDictionary["IsVaildEmail"]);
            if (validationModel.IsShortPassword) errors.Append(errorsDictionary["IsShortPassword"]);
            if (validationModel.IsPasswordNotConfirm) errors.Append(errorsDictionary["IsPaswordConfirm"]);
            if (validationModel.IsEmailExists) errors.Append(errorsDictionary["IsEmailExists"]);
            if (validationModel.IsEmailDoesNotExists) errors.Append(errorsDictionary["IsEmailDoesNotExists"]);
            if (validationModel.IsPasswordsMatch) errors.Append(errorsDictionary["IsPasswordsMatch"]);
            if (validationModel.IsFirstNameEmpty) errors.Append(errorsDictionary["IsFirstNameEmpty"]);
            if (validationModel.IsLastNameEmpty) errors.Append(errorsDictionary["IsLastNameEmpty"]);
            if (validationModel.IsPhoneNumberEmpty) errors.Append(errorsDictionary["IsPhoneNumberEmpty"]);
            if (validationModel.IsFirstNameShort) errors.Append(errorsDictionary["IsFirstNameShort"]);
            if (validationModel.IsLastNameShort) errors.Append(errorsDictionary["IsLastNameShort"]);
            if (validationModel.IsPhoneNumberNumeric) errors.Append(errorsDictionary["IsPhoneNumberNumeric"]);

            if (errors.ToString() != "")
            {
                MessageBox.Show(errors.ToString());
                return true;
            }

            return false;
        }
    }
}
