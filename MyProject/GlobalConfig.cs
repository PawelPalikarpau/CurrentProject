using MyProjectLibrary.DataAccess;
using MyProjectLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections (DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                Connection = new SqlConnector();
            }            
            else if (db == DatabaseType.TextFile)
            {
                Connection = new TextConnector();
            }
        }

        public static IDbConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(CnnString("MyProjectDatabase"));
        }

        private static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
