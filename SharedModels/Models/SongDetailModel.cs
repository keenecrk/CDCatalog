using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class SongDetailModel
    {
        public string SongTitle { get; set; }
        public string CdTitle { get; set; }
        public string Artist { get; set; }
        public DateTime DateReleased { get; set; }
    }
}
