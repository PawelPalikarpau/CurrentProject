using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.Validators
{
    public class LoginFormValidator
    {
        FieldValidator fieldValidator = new FieldValidator();
        ErrorsValidator errorsValidator = new ErrorsValidator();

        ValidationModel validationModel;
        Dictionary<string, string> errors;

        public Dictionary<string, string> ValidateForm(string email, string password)
        {
            validationModel = new ValidationModel();
            validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
            validationModel.IsFirstPasswordEmpty = fieldValidator.IsFieldEmpty(password);

            errors = errorsValidator.AreErrors(validationModel);
            if (errors != null) return errors;

            validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);

            errors = errorsValidator.AreErrors(validationModel);
            if (errors != null) return errors;

            UserModel userModel = GlobalConfig.Connection.UsersOperations().GetUserByEmail(email);
            validationModel.IsEmailDoesNotExists = userModel.Password == null;

            errors = errorsValidator.AreErrors(validationModel);
            if (errors != null)
            {
                validationModel.IsPasswordsMatch = fieldValidator.IsPasswrodConfirm(password, userModel.Password);

                errors = errorsValidator.AreErrors(validationModel);
                if (errors != null) return errors;
            }

            return null;
        }
    }
}
