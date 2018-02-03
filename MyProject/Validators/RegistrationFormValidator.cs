using System;
using MyProjectLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectLibrary.Validators
{
    public class RegistrationFormValidator
    {
        private FieldValidator fieldValidator = new FieldValidator();
        private ErrorsValidator errorsValidator = new ErrorsValidator();

        public UserModel ValidateForm(String email, String firstPassword, String secondPassword)
        {
            ValidationModel validationModel = new ValidationModel();
            String errors = "Not Valid";

            while (errors != "")
            {
                validationModel.IsEmailEmpty = fieldValidator.IsFieldEmpty(email);
                validationModel.IsFirstPasswordEmpty = fieldValidator.IsFieldEmpty(firstPassword);
                validationModel.IsSecondPasswordEmpty = fieldValidator.IsFieldEmpty(secondPassword);

                errors = errorsValidator.GetErrors(validationModel);

                if (errors != "")
                {
                    MessageBox.Show(errors);
                    return null;
                }

                validationModel.IsInvaildEmail = fieldValidator.IsValidEmail(email);
                validationModel.IsShortPassword = fieldValidator.IsFieldShort(firstPassword);

                errors = errorsValidator.GetErrors(validationModel);

                if (errors != "")
                {
                    MessageBox.Show(errors);
                    return null;
                }

                validationModel.IsPasswordNotConfirm = fieldValidator.IsPasswrodConfirm(firstPassword, secondPassword);

                errors = errorsValidator.GetErrors(validationModel);

                if (errors != "")
                {
                    MessageBox.Show(errors);
                    return null;
                }
            }

            return new UserModel(email, firstPassword, "User");
        }
    }
}
