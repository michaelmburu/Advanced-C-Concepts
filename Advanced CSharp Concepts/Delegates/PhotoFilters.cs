using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying Contrast");
        }

        public void ResizePhoto(Photo photo)
        {
            Console.WriteLine("Resizing Photo");
            Console.ReadLine();
        }

    }
}
