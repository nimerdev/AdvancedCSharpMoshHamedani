using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Library;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access Youtube web service
                //Read the data
                //Create a list of Video objects

                throw new Exception("Oops, some low level Youtube exception");
            }
            catch (Exception ex)
            {

                throw new YoutubeException("Could not fetch the videos from Youtube", ex);
            }

            return new List<Video>();
        }
    }
}
