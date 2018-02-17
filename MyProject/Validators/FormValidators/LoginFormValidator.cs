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

        public Dictionary<string, string> ValidateForm(string email, string password)
        {
            ValidationModel validationModel = new ValidationModel();

            validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
            validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);

            validationModel.IsFirstPasswordEmpty = fieldValidator.IsFieldEmpty(password);

            UserModel userModel = GlobalConfig.Connection.UsersOperations().GetUserByEmail(email);
            validationModel.IsEmailDoesNotExists = userModel.Password == null;

            validationModel.IsDatabasePasswordMatch = fieldValidator.IsPasswrodConfirm(password, userModel.Password);

            return errorsValidator.AreErrors(validationModel);
        }
    }
}
