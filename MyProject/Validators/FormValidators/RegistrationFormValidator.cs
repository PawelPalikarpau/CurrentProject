using System;
using MyProjectLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Dapper;

namespace MyProjectLibrary.Validators
{
    public class RegistrationFormValidator
    {
        private FieldValidator fieldValidator = new FieldValidator();
        private ErrorsValidator errorsValidator = new ErrorsValidator();

        private ValidationModel validationModel;

        public Dictionary<string, string> ValidateForm(String email, String firstPassword, String secondPassword)
        {
            Dictionary<string, string> errors;
            validationModel = new ValidationModel();
            validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
            validationModel.IsFirstPasswordEmpty = fieldValidator.IsFieldEmpty(firstPassword);
            validationModel.IsSecondPasswordEmpty = fieldValidator.IsFieldEmpty(secondPassword);

            errors = errorsValidator.AreErrors(validationModel);
            if (errors != null) return errors;

            validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);
            validationModel.IsShortPassword = fieldValidator.IsFieldShort(firstPassword);

            errors = errorsValidator.AreErrors(validationModel);
            if (errors != null) return errors;

            validationModel.IsPasswordNotConfirm = fieldValidator.IsPasswrodConfirm(firstPassword, secondPassword);

            errors = errorsValidator.AreErrors(validationModel);
            if (errors != null) return errors;

            return IsEmailExists(email);
        }

        private Dictionary<string, string> IsEmailExists(string email)
        {
            UserModel userModel = GlobalConfig.Connection.UsersOperations().GetUserByEmail(email);

            validationModel = new ValidationModel();
            validationModel.IsEmailExists = userModel.Password != null;

            return errorsValidator.AreErrors(validationModel);
        }
    }
}
