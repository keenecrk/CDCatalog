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
        public static void SaveSong(SongModel song)
        {
            SongDBModel songDB = new SongDBModel
            {
                Title = song.Title,
                CdId = song.CdId
            };

            SQLDataAccess.SaveData("dbo.spSong_Insert", songDB);
        }
    }
}
