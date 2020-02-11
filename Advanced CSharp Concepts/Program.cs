using Advanced_CSharp_Concepts.Delegates;
using Advanced_CSharp_Concepts.LambdaExpressions;
using System;

namespace Advanced_CSharp_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics
            //var number = new Nullable<int>();
            //Console.WriteLine("Has value ? " + number.HasValue);
            //Console.WriteLine("Value: " + number.GetValueOrDefault());
            //Console.ReadLine();
            #endregion

            #region Delegates
            //Without Delegate
            //PhotoProcessor photoProcessor = new PhotoProcessor();
            //photoProcessor.NonDelegateProcess("");

            //With Delegate
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            //GenericDelegate
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //Using Action
            //Action<Photo> filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast;
            //filterHandler += RemoveRedEyeFilter;
            //processor.DelegateProcess("", filterHandler);
            //void RemoveRedEyeFilter(Photo photo)
            //{
            //    Console.WriteLine("Apply Remove Red Eye");
            //    Console.ReadLine();
            //}
            #endregion

            #region Lambda
            //Old Method way
            //var num = Lambda.Square(5);
            //Console.WriteLine("Via Static Methods: " + num);

            //Lambda Way
            // args => expression
            // * () => ...
            //(x,y,z) => ...
            //Func<int, int> Square = number => number * number;
            //Console.WriteLine("Via Lambda: "+ Square(5));
            //Console.ReadLine();

            var books = new BookRepository().GetBooks();
            var cheapbooks = books.FindAll(IsCheaperThan10Dollars);
            bool IsCheaperThan10Dollars(Book book)
            {
                return book.Price < 10;
            }

            //OR With Lambda Expression
            //var cheapbooks = books.FindAll(book => book.Price <10);

            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.Title);
                Console.Read();
            }
            #endregion

        }


        
    }
}
