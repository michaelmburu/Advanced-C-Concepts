using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
