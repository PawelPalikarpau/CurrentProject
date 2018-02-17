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
        const string isEmailEmpty = "IsEmailEmpty";
        const string isFirstPasswordEmpty = "IsFirstPasswordEmpty";
        const string isSecondPasswordEmpty = "IsSecondPasswordEmpty";
        const string isVaildEmail = "IsVaildEmail";
        const string isShortPassword = "IsShortPassword";
        const string isPaswordConfirm = "IsPaswordConfirm";
        const string isEmailExists = "IsEmailExists";
        const string isEmailDoesNotExists = "IsEmailDoesNotExists";
        const string isPasswordsMatch = "IsPasswordsMatch";
        const string isFirstNameEmpty = "IsFirstNameEmpty";
        const string isLastNameEmpty = "IsLastNameEmpty";
        const string isPhoneNumberEmpty = "IsPhoneNumberEmpty";
        const string isFirstNameShort = "IsFirstNameShort";
        const string isLastNameShort = "IsLastNameShort";
        const string isPhoneNumberNumeric = "IsPhoneNumberNumeric";

        private Dictionary<String, String> errorsDictionary = new Dictionary<String, String>();

        public ErrorsValidator()
        {
            this.errorsDictionary.Add(isEmailEmpty, "You must fill E-mail address");
            this.errorsDictionary.Add(isFirstPasswordEmpty, "You must fill password field");
            this.errorsDictionary.Add(isSecondPasswordEmpty, "You must fill confirm password field");
            this.errorsDictionary.Add(isVaildEmail, "You must fill correct E-mail");
            this.errorsDictionary.Add(isShortPassword, "You must fill the same confirm password");
            this.errorsDictionary.Add(isPaswordConfirm, "The password must be at least of three characters");
            this.errorsDictionary.Add(isEmailExists, "User with such E-mail already exists");
            this.errorsDictionary.Add(isEmailDoesNotExists, "User with such E-mail does not exists");
            this.errorsDictionary.Add(isPasswordsMatch, "The password is inccorect. Please try again");
            this.errorsDictionary.Add(isFirstNameEmpty, "You must fill the first name");
            this.errorsDictionary.Add(isLastNameEmpty, "You must fill the last name");
            this.errorsDictionary.Add(isPhoneNumberEmpty, "You must fill phone number");
            this.errorsDictionary.Add(isFirstNameShort, "The first name must be at least of three characters");
            this.errorsDictionary.Add(isLastNameShort, "The last name must be at least of three characters");
            this.errorsDictionary.Add(isPhoneNumberNumeric, "The Phone number must consists only of numbers");
        }

        public Dictionary<String, string> AreErrors(ValidationModel validationModel)
        {
            Dictionary<string, string> errors = new Dictionary<string, string>();

            if (validationModel.IsEmailEmpty) errors.Add("email", errorsDictionary[isEmailEmpty]);
            if (validationModel.IsFirstPasswordEmpty) errors.Add("firstPassword", errorsDictionary[isFirstPasswordEmpty]);
            if (validationModel.IsSecondPasswordEmpty) errors.Add("secondPassword", errorsDictionary[isSecondPasswordEmpty]);
            if (validationModel.IsInvaildEmail) errors.Add("email", errorsDictionary[isVaildEmail]);
            if (validationModel.IsShortPassword) errors.Add("firstPassword", errorsDictionary[isShortPassword]);
            if (validationModel.IsPasswordNotConfirm) errors.Add("secondPassword", errorsDictionary[isPaswordConfirm]);
            if (validationModel.IsEmailExists) errors.Add("email", errorsDictionary[isEmailExists]);
            if (validationModel.IsEmailDoesNotExists) errors.Add("email", errorsDictionary[isEmailDoesNotExists]);
            if (validationModel.IsPasswordsMatch) errors.Add("secondPasswrod", errorsDictionary[isPasswordsMatch]);
            if (validationModel.IsFirstNameEmpty) errors.Add("firstName", errorsDictionary[isFirstNameEmpty]);
            if (validationModel.IsLastNameEmpty) errors.Add("lastName", errorsDictionary[isLastNameEmpty]);
            if (validationModel.IsPhoneNumberEmpty) errors.Add("phone", errorsDictionary[isPhoneNumberEmpty]);
            if (validationModel.IsFirstNameShort) errors.Add("firstName", errorsDictionary[isFirstNameShort]);
            if (validationModel.IsLastNameShort) errors.Add("lastName", errorsDictionary[isLastNameShort]);
            if (validationModel.IsPhoneNumberNumeric) errors.Add("phone", errorsDictionary[isPhoneNumberNumeric]);

            if (errors.Count != 0)
            {
                return errors;
            }

            return null;
        }
    }
}
