using JukeBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JukeBox.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class JukeBoxController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetTrending(int? returnFail)
        {
            List<TrendingModel> trendStatus = new List<TrendingModel>()
            {
                new TrendingModel(){ TrendStatus = "Down",
                Snippet = new Snippet()
                {
                    Track = "Bad Blood",
                    Artist = "Taylor Swift",
                    Snip = "|’Cause baby, now we've got bad blood|You know it used to be mad love|So take a look what you've done|’Cause baby, now we've got bad blood, hey!|Now we've got problems|And I don't think we can solve 'em|You made a really deep cut|And baby, now we've got bad blood, hey!|",
                    Duration = 15,
                    StartTime = 30.5F,
                    TrackUrl = "http://cloudinary.com/swyftstudios/taylor-swift-bad-blood.mp3" }
                }
                , new TrendingModel(){ TrendStatus = "Up",
                    Snippet  = new Snippet {Track = "Started From the Bottom", Artist = "Drake", Snip = "Started from the bottom, now we're here,Started from the bottom, now my whole team fuckin' here", Duration = 15, StartTime = 30.5F, TrackUrl = "http://cloudinary.com/" } }
                , new TrendingModel(){ TrendStatus = "Down",
                    Snippet = new Snippet {Track = "Just Dance", Artist = "Lady Gaga", Snip = "Just Dance", Duration = 15, StartTime = 30.5F, TrackUrl = "http://cloudinary.com/"  } }
                , new TrendingModel(){ TrendStatus = "Up",
                    Snippet = new Snippet { Track = "Bad and Boujee", Artist = "Migos", Snip = "Bad and Boujee", Duration = 15, StartTime = 30.5F, TrackUrl = "http://cloudinary.com/" } }
                , new TrendingModel(){ TrendStatus = "Down",
                Snippet = new Snippet { Track = "All Falls Down", Artist = "Kayne West", Snip = "All Falls Down", Duration = 15, StartTime = 30.5F, TrackUrl = "http://cloudinary.com/"  } }
                , new TrendingModel(){ TrendStatus = "Up",
                    Snippet = new Snippet {Track = "Crazy In Love", Artist = "Beyonce", Snip = "Crazy In Love", Duration = 15, StartTime = 30.5F, TrackUrl = "http://cloudinary.com/"  } }
                , new TrendingModel(){ TrendStatus = "Down", Snippet = new Snippet {Track = "We Gon Be Alright!", Artist = "Kendrick Lamar", Snip = "We Gon Be Alright!", Duration = 15, StartTime = 30.5F, TrackUrl = "http://cloudinary.com/" } }

            };

            if (returnFail != null && returnFail == 1)
            {
                return BadRequest("Unable to retrieve trending at the moment");
            }

            return Ok(new SuccessResponse()
            {
                Success = true,
                ApiStatus = "successfully_retrieved_trending",
                Message = "Successfully retrieved the trending items.",
                Model = trendStatus
            });
        }

        public class SuccessResponse : FailResponse
        {

            public object Model { get; set; }
        }

        public class FailResponse
        {
            public bool Success { get; set; }
            public string ApiStatus { get; set; }
            public string Message { get; set; }
        }

        public class TrendingModel
        {
            public string TrendStatus { get; set; }
            public Snippet Snippet { get; set; }
            public int PlayCount { get; set; }
            public int DownloadCount { get; set; }
            public DateTime? LastUpdated { get; set; }
        }
    }
}
