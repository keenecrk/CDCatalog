using DataManager.Models;
using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.DataAccess
{
    public static class SongData
    {
        public static int SaveSong(SongModel song)
        {
            SongDBModel songDB = new SongDBModel
            {
                Title = song.Title,
                CdId = song.CdId
            };

            return SQLDataAccess.SaveData("dbo.spSong_Insert", songDB);
        }

        public static List<SongDetailModel> GetSongs()
        {
            return SQLDataAccess.LoadData<SongDetailModel, dynamic>("dbo.spSong_GetAll", new { });
        }

        public static List<SongModel> GetSongsByCdId(int cdId)
        {
            return SQLDataAccess.LoadData<SongModel, dynamic>("dbo.spSong_GetAllByCdId", new { CdId = cdId });
        }
    }
}
