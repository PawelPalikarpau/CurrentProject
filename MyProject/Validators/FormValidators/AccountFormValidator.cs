﻿using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.Validators
{
    public class AccountFormValidator
    {
        private FieldValidator fieldValidator = new FieldValidator();
        private ErrorsValidator errorsValidator = new ErrorsValidator();

        private ValidationModel validationModel;
        Dictionary<string, string> errors;

        public Dictionary<string, string> ValidateForm (string firstName, string lastName, string email, string phoneNumber)
        {
            validationModel = new ValidationModel();
            validationModel.IsFirstNameEmpty = fieldValidator.IsFieldEmpty(firstName);
            validationModel.IsLastNameEmpty = fieldValidator.IsFieldEmpty(lastName);
            validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
            validationModel.IsPhoneNumberEmpty = fieldValidator.IsFieldEmpty(phoneNumber);

            errors = errorsValidator.AreErrors(validationModel);
            if (errors != null) return errors;

            validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);
            validationModel.IsFirstNameShort = fieldValidator.IsFieldShort(firstName);
            validationModel.IsLastNameShort = fieldValidator.IsFieldShort(lastName);
            validationModel.IsPhoneNumberNumeric = fieldValidator.IsNumeric(phoneNumber);

            return errorsValidator.AreErrors(validationModel);
        }
    }
}