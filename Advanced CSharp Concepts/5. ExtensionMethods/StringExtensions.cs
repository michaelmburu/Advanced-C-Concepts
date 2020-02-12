using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced_CSharp_Concepts.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords == 0)
                throw new ArgumentNullException("number of words should be greater then or equal to zero");

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ",words.Take(numberOfWords));

        }
    }
}
