using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLayer.Models
{
    public class CdDisplayModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime DateReleased { get; set; }
        public List<SongModel> Songs { get; set; }
    }
}