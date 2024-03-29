﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Library;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            var videoEncoderDotNetDelegate = new VideoEncoderDotNetDelegate();
            videoEncoderDotNetDelegate.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoderDotNetDelegate.Encode(video);

            Console.ReadLine();
        }
    }
}
