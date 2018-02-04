using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.Validators
{
    public class AccountFormValidator
    {
        private FieldValidator FieldValidator = new FieldValidator();
        private ErrorsValidator ErrorsValidator = new ErrorsValidator();

        private ValidationModel validationModel;

        public AccountModel ValidateForm (string firstName, string lastName, string email, string phoneNumber)
        {
            validationModel = new ValidationModel();
            validationModel.IsFirstNameEmpty = FieldValidator.IsFieldEmpty(firstName);
            validationModel.IsLastNameEmpty = FieldValidator.IsFieldEmpty(lastName);
            validationModel.IsEmailEmpty = FieldValidator.IsFieldEmpty(email);
            validationModel.IsPhoneNumberEmpty = FieldValidator.IsFieldEmpty(phoneNumber);

            if (ErrorsValidator.AreErrors(validationModel)) return null;

            validationModel.IsInvaildEmail = FieldValidator.IsValidEmail(email);
            validationModel.IsFirstNameShort = FieldValidator.IsFieldShort(firstName);
            validationModel.IsLastNameShort = FieldValidator.IsFieldShort(lastName);
            validationModel.IsPhoneNumberNumeric = FieldValidator.IsNumeric(phoneNumber);

            if (ErrorsValidator.AreErrors(validationModel)) return null;

            AccountModel accountModel = new AccountModel();
            accountModel.FirstName = firstName;
            accountModel.LastName = lastName;
            accountModel.Email = email;
            accountModel.PhoneNumber = Int32.Parse(phoneNumber);
            return accountModel;
        }
    }
}
