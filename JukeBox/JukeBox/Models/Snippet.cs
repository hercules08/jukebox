using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JukeBox.Models
{
    public class Snippet:EntityBase
    {
        public string Artist { get; set; }
        public string Track { get; set; }
        public float StartTime { get; set; }
        public float Duration { get; set; }
        public string TrackUrl { get; set; }
        public string AlbumImage { get; set; }
        public string Snip { get; set; }
    }
}