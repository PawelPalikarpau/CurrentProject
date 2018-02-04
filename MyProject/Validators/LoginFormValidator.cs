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

        public UserModel ValidateForm(string email, string password)
        {
            validationModel = new ValidationModel();
            validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
            validationModel.IsFirstPasswordEmpty = fieldValidator.IsFieldEmpty(password);

            if (errorsValidator.AreErrors(validationModel)) return null;

            validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);

            if (errorsValidator.AreErrors(validationModel)) return null;

            UserModel userModel = IsEmailExists(email);
            if (userModel != null)
            {
                validationModel.IsPasswordsMatch = fieldValidator.IsPasswrodConfirm(password, userModel.Password);
                if (errorsValidator.AreErrors(validationModel)) return null;
                return userModel;
            }

            return null;
        }

        private UserModel IsEmailExists(string email)
        {
            UserModel userModel = GlobalConfig.Connection.UsersOperations().GetUserByEmail(email);

            validationModel = new ValidationModel();
            validationModel.IsEmailDoesNotExists = userModel.Password == null;

            if (errorsValidator.AreErrors(validationModel)) return null;

            return userModel;
        }
    }
}
