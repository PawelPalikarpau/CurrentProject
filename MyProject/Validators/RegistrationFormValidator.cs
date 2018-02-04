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

        public UserModel ValidateForm(String email, String firstPassword, String secondPassword)
        {
            validationModel = new ValidationModel();
            validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
            validationModel.IsFirstPasswordEmpty = fieldValidator.IsFieldEmpty(firstPassword);
            validationModel.IsSecondPasswordEmpty = fieldValidator.IsFieldEmpty(secondPassword);

            if (errorsValidator.AreErrors(validationModel)) return null;

            validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);
            validationModel.IsShortPassword = fieldValidator.IsFieldShort(firstPassword);

            if (errorsValidator.AreErrors(validationModel)) return null;

            validationModel.IsPasswordNotConfirm = fieldValidator.IsPasswrodConfirm(firstPassword, secondPassword);

            if (errorsValidator.AreErrors(validationModel)) return null;

            if (IsEmailExists(email)) return null;

            return new UserModel(email, firstPassword, "User");
        }

        private bool IsEmailExists(string email)
        {
            UserModel userModel = GlobalConfig.Connection.GetUserByEmail(email);

            validationModel = new ValidationModel();
            validationModel.IsEmailExists = userModel.Password != null;

            if (errorsValidator.AreErrors(validationModel)) return true;

            return false;
        }
    }
}
