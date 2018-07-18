using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending message that video {e.Video.Title} is encoded...");
            Thread.Sleep(1000);
            Console.WriteLine("MessageService: Message sent.");
        }
    }
}
