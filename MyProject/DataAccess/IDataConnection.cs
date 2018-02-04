using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.DataAccess
{
    public interface IDataConnection
    {
        UserModel CreateUser(UserModel userModel);
        string GetUserPasswordByEmail(string email);

        void CreateAccount(UserModel userModel);
    }
}
