using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Advanced_CSharp_Concepts.Events
{
    public class VideoEncoder
    {

        //1. Define a delegate.
        //2. Define an event based on the delegate.
        //3. Raise the event.

        //1.
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //EventHandler
        //EventHandler<TEventArgs>
        //2.
        //public event VideoEncodedEventHandler VideoEncoded;

        //OR
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.Write("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        //3.
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() {Video = video});
            //OR
            //VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
