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
    }
}
