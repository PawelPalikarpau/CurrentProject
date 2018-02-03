using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public UserModel CreateUser(UserModel userModel)
        {
            userModel.Id = 1;

            return userModel;
        }

        public AccountModel CreateAccount(AccountModel accountModel)
        {
            accountModel.Id = 1;

            return accountModel;
        }

        public string GetUserPasswordByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
