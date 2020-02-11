using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public Photo Save()
        {
            return new Photo();
        }
    }
}
