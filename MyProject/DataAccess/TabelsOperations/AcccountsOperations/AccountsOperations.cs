using Dapper;
using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary.DataAccess.TabelsOperations
{
    public class AccountsOperations : IAccountsoperations
    {
        public void CreateAccount(UserModel userModel)
        {
            using (IDbConnection connection = GlobalConfig.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("UserId", userModel.Id);
                connection.Execute("dbo.spAccounts_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
