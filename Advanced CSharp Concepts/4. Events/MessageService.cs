using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.Write($"MessageService: Sending a new message...... {args.Video.Title}");
        }
    }
}
