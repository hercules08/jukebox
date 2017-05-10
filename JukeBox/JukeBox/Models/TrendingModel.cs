using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JukeBox.Models
{
    public class TrendingModel:EntityBase
    {
        public string TrendStatus { get; set; }
        public Snippet Snippet { get; set; }
        public int PlayCount { get; set; }
        public int DownloadCount { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}