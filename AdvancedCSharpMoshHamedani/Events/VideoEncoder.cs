using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdvancedCSharp.Library;

namespace Events
{
    public class VideoEncoder
    {
        // 1 - define a delegate = agreement between the publisher and the subscriber
        //public delegate void VideoEncodedEventHandler(object sender, EventArgs e); //out of the box event args
        public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs e);
        // 2 - define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;
        // 3 - raise the event


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(1000);
            Console.WriteLine("Video encoded.");

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video});
        }
    }
}
