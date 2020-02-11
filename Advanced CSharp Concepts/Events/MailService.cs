using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.Write($"MailService: Sending an email.... {e.Video.Title}");
            
        }
    }
}
