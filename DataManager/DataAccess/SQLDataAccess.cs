using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.DataAccess
{
    internal static class SQLDataAccess
    {
        public static List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            return null;
        }

        public static void SaveData<T>(string storedProcedure, T parameters)
        {
            string connectionString = GetConnectionString();
            
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CDCatalogData"].ConnectionString;
        }
    }
}
