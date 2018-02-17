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
        // Email
        const string isEmailEmpty = "IsEmailEmpty";
        const string isVaildEmail = "IsVaildEmail";
        const string isEmailExists = "IsEmailExists";
        const string isEmailDoesNotExists = "IsEmailDoesNotExists";

        // First Password
        const string isFirstPasswordEmpty = "IsFirstPasswordEmpty";
        const string isShortPassword = "IsShortPassword";

        const string isSecondPasswordEmpty = "IsSecondPasswordEmpty";
        const string isPasswordsMatch = "IsPasswordsMatch";

        // First Name
        const string isFirstNameEmpty = "IsFirstNameEmpty";
        const string isFirstNameShort = "IsFirstNameShort";

        // Last Name
        const string isLastNameEmpty = "IsLastNameEmpty";
        const string isLastNameShort = "IsLastNameShort";

        // Phone
        const string isPhoneNumberEmpty = "IsPhoneNumberEmpty";
        const string isPhoneNumberNumeric = "IsPhoneNumberNumeric";

        private Dictionary<String, String> errorsDictionary = new Dictionary<String, String>();

        public ErrorsValidator()
        {
            // Email
            this.errorsDictionary.Add(isEmailEmpty, "You must fill E-mail address");
            this.errorsDictionary.Add(isVaildEmail, "You must fill correct E-mail");
            this.errorsDictionary.Add(isEmailExists, "User with such E-mail already exists");
            this.errorsDictionary.Add(isEmailDoesNotExists, "User with such E-mail does not exists");

            // First Password
            this.errorsDictionary.Add(isFirstPasswordEmpty, "You must fill password field");
            this.errorsDictionary.Add(isShortPassword, "The password is too short");

            // Second Password
            this.errorsDictionary.Add(isSecondPasswordEmpty, "You must fill confirm password field");
            this.errorsDictionary.Add(isPasswordsMatch, "The password is inccorect");
            
            // First Name
            this.errorsDictionary.Add(isFirstNameEmpty, "You must fill the first name");
            this.errorsDictionary.Add(isFirstNameShort, "The first name is too short");

            // Last Name
            this.errorsDictionary.Add(isLastNameEmpty, "You must fill the last name");
            this.errorsDictionary.Add(isLastNameShort, "The last name is too short");

            // Phone
            this.errorsDictionary.Add(isPhoneNumberEmpty, "You must fill phone number");
            this.errorsDictionary.Add(isPhoneNumberNumeric, "The Phone number must contain only numbers");
        }

        public Dictionary<String, string> AreErrors(ValidationModel validationModel)
        {
            Dictionary<string, string> errors = new Dictionary<string, string>();

            // Email
            if (validationModel.IsEmailEmpty && !errors.ContainsKey("email"))
                errors.Add("email", errorsDictionary[isEmailEmpty]);
            if (validationModel.IsInvaildEmail && !errors.ContainsKey("email"))
                errors.Add("email", errorsDictionary[isVaildEmail]);
            if (validationModel.IsEmailExists && !errors.ContainsKey("email"))
                errors.Add("email", errorsDictionary[isEmailExists]);
            if (validationModel.IsEmailDoesNotExists && !errors.ContainsKey("email"))
                errors.Add("email", errorsDictionary[isEmailDoesNotExists]);

            // First Password
            if (validationModel.IsFirstPasswordEmpty && !errors.ContainsKey("firstPassword"))
                errors.Add("firstPassword", errorsDictionary[isFirstPasswordEmpty]);
            if (validationModel.IsShortPassword && !errors.ContainsKey("firstPassword"))
                errors.Add("firstPassword", errorsDictionary[isShortPassword]);

            // Second Password
            if (validationModel.IsSecondPasswordEmpty && !errors.ContainsKey("secondPassword"))
                errors.Add("secondPassword", errorsDictionary[isSecondPasswordEmpty]);
            if (validationModel.IsPasswordsMatch && !errors.ContainsKey("secondPassword"))
                errors.Add("secondPassword", errorsDictionary[isPasswordsMatch]);

            // First Name
            if (validationModel.IsFirstNameEmpty && !errors.ContainsKey("firstName"))
                errors.Add("firstName", errorsDictionary[isFirstNameEmpty]);
            if (validationModel.IsFirstNameShort && !errors.ContainsKey("firstName"))
                errors.Add("firstName", errorsDictionary[isFirstNameShort]);

            // Second Name
            if (validationModel.IsLastNameEmpty && !errors.ContainsKey("lastName"))
                errors.Add("lastName", errorsDictionary[isLastNameEmpty]);
            if (validationModel.IsLastNameShort && !errors.ContainsKey("lastName"))
                errors.Add("lastName", errorsDictionary[isLastNameShort]);

            // Phone
            if (validationModel.IsPhoneNumberEmpty && !errors.ContainsKey("phone"))
                errors.Add("phone", errorsDictionary[isPhoneNumberEmpty]);
            if (validationModel.IsPhoneNumberNumeric && !errors.ContainsKey("phone"))
                errors.Add("phone", errorsDictionary[isPhoneNumberNumeric]);

            return errors;
        }
    }
}
