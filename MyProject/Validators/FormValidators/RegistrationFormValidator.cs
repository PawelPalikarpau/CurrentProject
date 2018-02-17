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

        public Dictionary<string, string> ValidateForm(String email, String firstPassword, String secondPassword)
        {
            ValidationModel validationModel = new ValidationModel();

            validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
            validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);

            validationModel.IsFirstPasswordEmpty = fieldValidator.IsFieldEmpty(firstPassword);
            validationModel.IsShortPassword = fieldValidator.IsFieldShort(firstPassword);

            validationModel.IsSecondPasswordEmpty = fieldValidator.IsFieldEmpty(secondPassword);
            validationModel.IsPasswordsMatch = fieldValidator.IsPasswrodConfirm(firstPassword, secondPassword);

            UserModel userModel = GlobalConfig.Connection.UsersOperations().GetUserByEmail(email);
            validationModel.IsEmailExists = userModel.Password != null;

            return errorsValidator.AreErrors(validationModel);
        }
    }
}
