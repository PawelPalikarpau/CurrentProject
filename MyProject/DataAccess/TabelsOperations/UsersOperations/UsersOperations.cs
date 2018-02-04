using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MyProjectLibrary.Models;

namespace MyProjectLibrary.DataAccess.TabelsOperations
{
    public class UsersOperations : IUsersOperations
    {
        public UserModel CreateUser(UserModel userModel)
        {
            using (IDbConnection connection = GlobalConfig.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@Email", userModel.Email);
                p.Add("@Password", userModel.Password);
                p.Add("@Role", "User");
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", p, commandType: CommandType.StoredProcedure);

                userModel.Id = p.Get<int>("@id");

                return userModel;
            }
        }

        public UserModel GetUserByEmail(string email)
        {
            using (IDbConnection connection = GlobalConfig.GetConnection())
            {
                var p = new DynamicParameters();
                p.Add("@Email", email);
                p.Add("@Password", "", dbType: DbType.String, direction: ParameterDirection.Output);
                p.Add("@Role", "", dbType: DbType.String, direction: ParameterDirection.Output);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_GetUserByEmail", p, commandType: CommandType.StoredProcedure);

                UserModel userModel = new UserModel();
                userModel.Id = p.Get<int?>("@id");
                userModel.Email = email;
                userModel.Password = p.Get<string>("@Password");
                userModel.Role = p.Get<string>("@Role");

                return userModel;
            }
        }
    }
}
