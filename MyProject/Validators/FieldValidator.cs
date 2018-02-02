using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyProjectLibrary.Validators
{
    public class FieldValidator
    {
        public Boolean IsFieldEmpty(String str)
        {
            if (str.Length < 1) return true;
            else return false;
        }

        public Boolean IsFieldeShort(String str)
        {
            if (str.Length < 3) return true;
            else return false;
        }

        public Boolean IsPasswrodConfirm(String pas1, String pas2)
        {
            return (pas1 == pas2);
        }

        public Boolean IsNumeric(String str)
        {
            return Int64.TryParse(str, out long number);
        }

        public Boolean IsDecimal(String str)
        {
            return Decimal.TryParse(str, out decimal number);
        }

        public Boolean IsValidEmail(String newEmail)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return regex.Match(newEmail).Success;
        }
    }
}
