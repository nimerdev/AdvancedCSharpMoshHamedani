using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending email that video {e.Video.Title} is encoded...");
            Thread.Sleep(1000);
            Console.WriteLine("MailService: Email sent.");
        }
    }
}
