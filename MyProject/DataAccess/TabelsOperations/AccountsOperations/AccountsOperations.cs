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
    public class AccountsOperations : IAccountsOperations
    {
        public void CreateAccount(UserModel userModel)
        {
            using (IDbConnection connection = GlobalConfig.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@UserId", userModel.Id);
                p.Add("@Email", userModel.Email);
                connection.Execute("dbo.spAccounts_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public AccountModel GetAccountByUserId(int? userId)
        {
            using (IDbConnection connection = GlobalConfig.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@UserId", userId);
                p.Add("@FirstName", "", dbType: DbType.String, direction: ParameterDirection.Output);
                p.Add("@LastName", "", dbType: DbType.String, direction: ParameterDirection.Output);
                p.Add("@Email", "", dbType: DbType.String, direction: ParameterDirection.Output);
                p.Add("@PhoneNumber", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAccounts_GetAccountByUserId", p, commandType: CommandType.StoredProcedure);

                AccountModel accountModel = new AccountModel();
                accountModel.Id = p.Get<int>("@id");
                accountModel.UserId = userId;
                accountModel.FirstName = p.Get<string>("@FirstName");
                accountModel.LastName = p.Get<string>("@LastName");
                accountModel.Email = p.Get<string>("@Email");
                accountModel.PhoneNumber = p.Get<int?>("@PhoneNumber");

                return accountModel;
            }
        }

        public void UpdateAccount(AccountModel accountModel)
        {
            using (IDbConnection connection = GlobalConfig.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@id", accountModel.Id);
                p.Add("@UserID", accountModel.UserId);
                p.Add("@FirstName", accountModel.FirstName);
                p.Add("@LastName", accountModel.LastName);
                p.Add("@Email", accountModel.Email);
                p.Add("@PhoneNumber", accountModel.PhoneNumber);

                connection.Execute("dbo.spAccounts_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
