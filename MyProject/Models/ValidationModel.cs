using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.Models
{
    public class ValidationModel
    {
        // Email
        public Boolean IsEmailEmpty { get; set; } = false;
        public Boolean IsInvaildEmail { get; set; } = false;
        public Boolean IsEmailExists { get; set; } = false;
        public Boolean IsEmailDoesNotExists { get; set; } = false;

        // First Password
        public Boolean IsFirstPasswordEmpty { get; set; } = false;
        public Boolean IsShortPassword { get; set; } = false;

        // Second Password
        public Boolean IsSecondPasswordEmpty { get; set; } = false;
        public Boolean IsPasswordsMatch { get; set; } = false;

        // First Name
        public Boolean IsFirstNameEmpty { get; set; } = false;
        public Boolean IsFirstNameShort { get; set; } = false;

        // Last Name
        public Boolean IsLastNameEmpty { get; set; } = false;
        public Boolean IsLastNameShort { get; set; } = false;

        // Phone
        public Boolean IsPhoneNumberEmpty { get; set; } = false;
        public Boolean IsPhoneNumberNumeric { get; set; } = false;
    }
}
