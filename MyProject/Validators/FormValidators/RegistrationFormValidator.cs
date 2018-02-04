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
        private FieldValidator FieldValidator = new FieldValidator();
        private ErrorsValidator ErrorsValidator = new ErrorsValidator();

        private ValidationModel validationModel;

        public UserModel ValidateForm(String email, String firstPassword, String secondPassword)
        {
            validationModel = new ValidationModel();
            validationModel.IsEmailEmpty = FieldValidator.IsFieldEmpty(email);
            validationModel.IsFirstPasswordEmpty = FieldValidator.IsFieldEmpty(firstPassword);
            validationModel.IsSecondPasswordEmpty = FieldValidator.IsFieldEmpty(secondPassword);

            if (ErrorsValidator.AreErrors(validationModel)) return null;

            validationModel.IsInvaildEmail = FieldValidator.IsValidEmail(email);
            validationModel.IsShortPassword = FieldValidator.IsFieldShort(firstPassword);

            if (ErrorsValidator.AreErrors(validationModel)) return null;

            validationModel.IsPasswordNotConfirm = FieldValidator.IsPasswrodConfirm(firstPassword, secondPassword);

            if (ErrorsValidator.AreErrors(validationModel)) return null;

            if (IsEmailExists(email)) return null;

            UserModel userModel = new UserModel();
            userModel.Email = email;
            userModel.Password = firstPassword;
            userModel.Role = "User";
            return userModel;
        }

        private bool IsEmailExists(string email)
        {
            UserModel userModel = GlobalConfig.Connection.UsersOperations().GetUserByEmail(email);

            validationModel = new ValidationModel();
            validationModel.IsEmailExists = userModel.Password != null;

            if (ErrorsValidator.AreErrors(validationModel)) return true;

            return false;
        }
    }
}
