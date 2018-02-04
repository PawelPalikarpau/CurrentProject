using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.Models
{
    public class ValidationModel
    {
        public Boolean IsEmailEmpty { get; set; } = false;
        public Boolean IsFirstPasswordEmpty { get; set; } = false;
        public Boolean IsSecondPasswordEmpty { get; set; } = false;

        public Boolean IsShortPassword { get; set; } = false;

        public Boolean IsInvaildEmail { get; set; } = false;
        public Boolean IsPasswordNotConfirm { get; set; } = false;

        public Boolean IsEmailExists { get; set; } = false;
        public Boolean IsEmailDoesNotExists { get; set; } = false;
        public Boolean IsPasswordsMatch { get; set; } = false;

        public Boolean IsFirstNameEmpty { get; set; } = false;
        public Boolean IsLastNameEmpty { get; set; } = false;
        public Boolean IsPhoneNumberEmpty { get; set; } = false;

        public Boolean IsFirstNameShort { get; set; } = false;
        public Boolean IsLastNameShort { get; set; } = false;
        public Boolean IsPhoneNumberNumeric { get; set; } = false;
    }
}
