using Dapper;
using DataManager.Models;
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
            CdDBModel cdDB = new CdDBModel
            {
                Title = cd.Title,
                Artist = cd.Artist,
                DateReleased = cd.DateReleased
            };

            return SQLDataAccess.SaveData("dbo.spCd_Insert", cdDB);
        }

        public static List<CdModel> GetCds()
        {
            return SQLDataAccess.LoadData<CdModel, dynamic>("dbo.spCd_GetAll", new { });
        }

        public static CdModel GetCdById(int id)
        {
            return SQLDataAccess.LoadData<CdModel, dynamic>("dbo.spCd_GetById", new { Id = id }).FirstOrDefault();
        }
    }
}
