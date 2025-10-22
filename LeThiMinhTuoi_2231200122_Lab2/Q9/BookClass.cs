using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThiMinhTuoi_2231200122_Lab2.Q9
{
    internal class BookClass
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public BookClass(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }
    }
}
