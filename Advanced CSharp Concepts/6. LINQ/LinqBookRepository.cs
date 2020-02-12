using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.LINQ
{
    public class LinqBookRepository
    {
        public IEnumerable<LinqBook> GetBooks()
        {
            return new List<LinqBook>
            {
                new LinqBook{Title = "ADO NET", Price=25},
                new LinqBook{Title = "C# 1", Price=9},
                new LinqBook{Title = "C# 1", Price=10},
                new LinqBook{Title = "ASP NET", Price=6},
                new LinqBook{Title = "ASP Core", Price=35}
            }; 
        }
    }
}
