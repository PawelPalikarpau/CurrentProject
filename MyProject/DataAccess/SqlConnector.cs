using Dapper;
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
        public UserModel CreateUser(UserModel userModel)
        {
            using (IDbConnection connection = GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@Email", userModel.Email);
                p.Add("@Password", userModel.Password);
                p.Add("@Role", "User");
                p.Add("@AccountId", userModel.AccountId);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", p, commandType: CommandType.StoredProcedure);

                userModel.Id = p.Get<int>("@id");

                return userModel;
            }
        }

        public AccountModel CreateAccount(AccountModel accountModel)
        {
            using (IDbConnection connection = GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAccounts_Insert", p, commandType: CommandType.StoredProcedure);

                accountModel.Id = p.Get<int>("@id");

                return accountModel;
            }
        }

        private IDbConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MyProjectDatabase"));
        }
    }
}
