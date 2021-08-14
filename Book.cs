using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class Book
    {
        public Book(string cBookName, int cBookDamage)
        {
            bookName = cBookName;
            bookDamage = cBookDamage;
        }

        public string bookName;
        public int bookDamage;
    }
}
