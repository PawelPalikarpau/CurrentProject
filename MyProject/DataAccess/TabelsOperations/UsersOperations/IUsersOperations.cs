using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.DataAccess.TabelsOperations
{
    public interface IUsersOperations
    {
        UserModel CreateUser(UserModel userModel);
        UserModel GetUserByEmail(string email);
    }
}
