using Dapper;
using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.DataAccess
{
    public static class CdData
    {
        public static int SaveCd(CdModel cd)
        {
            int savedId;
            string sql = @"INSERT INTO dbo.Cd (Title, Artist, DateReleased) " +
                "VALUES (@Title, @Artist, @DateReleased); " +
                "SELECT CAST(SCOPE_IDENTITY() AS int)";

            using (IDbConnection connection = new SqlConnection(SQLDataAccess.GetConnectionString()))
            {
                savedId = connection.Query<int>(sql,
                    new { cd.Title, cd.Artist, cd.DateReleased }).Single();
            }

            return savedId;
        }
    }
}
