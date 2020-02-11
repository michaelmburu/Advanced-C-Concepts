using Advanced_CSharp_Concepts.Delegates;
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
            //PhotoProcessor photoProcessor = new PhotoProcessor();
            //Without Delegate
            //photoProcessor.NonDelegateProcess("");

            //With Delegate
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            //GenericDelegate
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //Using Action
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            processor.DelegateProcess("", filterHandler);
            #endregion

        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply Remove Red Eye");
            Console.ReadLine();
        }
    }
}
