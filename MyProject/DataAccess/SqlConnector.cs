using Dapper;
using MyProjectLibrary.DataAccess.TabelsOperations;
using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public AccountsOperations AccountsOperations()
        {
            return new AccountsOperations();
        }

        public UsersOperations UsersOperations()
        {
            return new UsersOperations();
        }
    }
}
