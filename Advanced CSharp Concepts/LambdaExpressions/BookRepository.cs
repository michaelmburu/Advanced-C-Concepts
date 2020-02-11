using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title = "1", Price=2},
                new Book{Title = "2", Price=3},
                new Book{Title = "3", Price=4}
            }; 
        }
    }
}
