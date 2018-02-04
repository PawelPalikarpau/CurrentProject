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
            throw new NotImplementedException();
        }
        public void CreateAccount(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public string GetUserPasswordByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
