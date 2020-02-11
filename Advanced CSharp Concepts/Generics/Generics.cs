using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.Generics
{
    //Five types of generic constraints
    //1. Where T : IComparable (Interface)
    //2. Where T : Product (Product)
    //3. Where T : Struct (value type)
    //3. Where T : Class (Class)
    //4. Where T : new() (Default Constructor)

    //1. Constraint to  an interface
    public class Utilities<T> where T : IComparable, new ()
    {


        //Return greater number
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //4. Where T : new() (Default Constructor)
        public void DoSomething(T value)
        {
            var obj = new T();
        }

        //Return greater number using an interface
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    //2. Constriant to a class
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    //3. Constraint to a value type
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }

  

}


