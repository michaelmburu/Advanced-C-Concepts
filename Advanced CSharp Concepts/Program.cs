using System;

namespace Advanced_CSharp_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
            Console.ReadLine();
        }
    }
}
