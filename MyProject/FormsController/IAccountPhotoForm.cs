using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectUI.Forms
{
    public interface IAccountPhotoForm
    {
        void InitializeForm(AccountModel accountModel, Form form);
    }
}
