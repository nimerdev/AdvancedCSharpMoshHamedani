using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdvancedCSharp.Library;

namespace Events
{
    public class VideoEncoderDotNetDelegate
    {
        // 1 - define a delegate = agreement between the publisher and the subscriber
        // use .net EventHandler<TEventArgs>
        // 2 - define an event based on that delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;
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
