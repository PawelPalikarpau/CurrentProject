using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.Validators
{
    public class ErrorsValidator
    {
        private Dictionary<String, String> errorsDictionary = new Dictionary<String, String>();

        public ErrorsValidator()
        {
            this.errorsDictionary.Add("IsEmailEmpty", "You must fill E-mail address." + Environment.NewLine);
            this.errorsDictionary.Add("IsFirstPasswordEmpty", "You must fill password field." + Environment.NewLine);
            this.errorsDictionary.Add("IsSecondPasswordEmpty", "You must fill confirm password field." + Environment.NewLine);
            this.errorsDictionary.Add("IsVaildEmail", "You must fill correct E-mail." + Environment.NewLine);
            this.errorsDictionary.Add("IsPaswordConfirm", "You must fill the same confirm password." + Environment.NewLine);
            this.errorsDictionary.Add("IsShortPassword", "The password must bea least of three characters." + Environment.NewLine);
        }

        public String GetErrors(ValidationModel validationModel)
        {
            StringBuilder errors = new StringBuilder();

            if (validationModel.IsEmailEmpty)  errors.Append(errorsDictionary["IsEmailEmpty"]);
            if (validationModel.IsFirstPasswordEmpty)  errors.Append(errorsDictionary["IsFirstPasswordEmpty"]);
            if (validationModel.IsSecondPasswordEmpty)  errors.Append(errorsDictionary["IsSecondPasswordEmpty"]);

            if (errors.ToString() != "") return errors.ToString();

            if (validationModel.IsInvaildEmail) errors.Append(errorsDictionary["IsVaildEmail"]);
            if (validationModel.IsShortPassword) errors.Append(errorsDictionary["IsShortPassword"]);

            if (errors.ToString() != "") return errors.ToString();
            
            if (validationModel.IsPasswordNotConfirm) errors.Append(errorsDictionary["IsPaswordConfirm"]);

            return errors.ToString();
        }
    }
}
