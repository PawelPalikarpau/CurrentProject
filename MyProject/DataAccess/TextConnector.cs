using MyProjectLibrary.DataAccess.TabelsOperations;
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
        public AccountsOperations AccountsOperations()
        {
            throw new NotImplementedException();
        }

        public UsersOperations UsersOperations()
        {
            throw new NotImplementedException();
        }
    }
}
