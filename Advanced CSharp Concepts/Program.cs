using Advanced_CSharp_Concepts._7._ExceptionHandling;
using Advanced_CSharp_Concepts.Delegates;
using Advanced_CSharp_Concepts.Events;
using Advanced_CSharp_Concepts.ExtensionMethods;
using Advanced_CSharp_Concepts.LambdaExpressions;
using Advanced_CSharp_Concepts.LINQ;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_CSharp_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Generics
            //var number = new Nullable<int>();
            //Console.WriteLine("Has value ? " + number.HasValue);
            //Console.WriteLine("Value: " + number.GetValueOrDefault());
            //Console.ReadLine();
            #endregion

            #region 2.Delegates
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

            #region 3.Lambda
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

            //var books = new BookRepository().GetBooks();
            //var cheapbooks = books.FindAll(IsCheaperThan10Dollars);
            //bool IsCheaperThan10Dollars(Book book)
            //{
            //    return book.Price < 10;
            //}

            //OR With Lambda Expression
            //var cheapbooks = books.FindAll(book => book.Price <10);

            //foreach (var book in cheapbooks)
            //{
            //    Console.WriteLine(book.Title);
            //    Console.Read();
            //}
            #endregion

            #region 4.Events
            //var video = new Video() { Title = "Video 1" };
            //var videoEncoder = new VideoEncoder(); // publisher
            //var mailService = new MailService(); //subscriber
            //var messageService = new MessageService(); //subscriber

            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            //videoEncoder.Encode(video);

            #endregion

            #region 5.ExtensionMethods
            //string post = "This is supposed to be a very long blog post";
            //var shortenPost = post.Shorten(5);
            //           Console.WriteLine(shortenPost);
            //Console.ReadLine();
            #endregion

            #region 6.LINQ
            var books = new LinqBookRepository().GetBooks();

            //LINQ Query Operators
            //var cheaperbooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b;


            //LINQ Extension Methods

            //Get All Books
            //var cheapbooks = books.Where(b => b.Price < 10).OrderBy(b => b.Price);
            //foreach(var book in cheapbooks)
            //Console.WriteLine("Title: " + book.Title);
            //Console.ReadLine();

            //Get a Single book
            //var book = books.SingleOrDefault(b => b.Title == "C#");
            //Console.WriteLine("Title: " + book.Title);
            //Console.ReadLine();

            //Get First Book
            //////var book = books.First(b => b.Title == "C# 1");
            //////Console.WriteLine("Title: " + book.Title +" " + "Price: " + book.Price);
            //////Console.ReadLine();

            //Skip and Take
            //var pageBooks = books.Skip(2).Take(3);
            //foreach(var book in pageBooks)
            //{
            //    Console.WriteLine("Title: " + book.Title + " " + "Price: " + book.Price);
            //}
            //Console.ReadLine();
            #endregion

            #region 7.NullableTypes
            //Nullable<DateTime> time = null;
            ////OR
            //DateTime? date = null;
            //Console.WriteLine("GetValueOrDefault()" + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);
            #endregion

            #region 8.Dynamic
            object obj = "Mock";

            //Reflection
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //Dynamic
            //dynamic excellObject = "t.xls";
            //excellObject.Optimize();

            //Casting
            //int i = 5;
            //dynamic d = i;
            //long l = d;

            #endregion

            #region ExceptionHandling
            //Exception ordering
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(3, 0);
            }
            catch(DivideByZeroException ex)
            {

            }
            catch(ArithmeticException ex)
            {

            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.ReadLine();
            }
         
          
            #endregion





        }


    }
}
