using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary
{
    public class TextConnector : IDataConnection
    {
        public UserModel CreatePerson(UserModel userModel)
        {
            userModel.Id = 1;

            return userModel;
        }
    }
}
