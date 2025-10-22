using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThiMinhTuoi_2231200122_Lab2.Q9
{
    internal record BookRecord
    {
        public string ISBN { get; init; }
        public string Title { get; init; }
        public string Author { get; init; }

        public BookRecord(string iSBN, string title, string author)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
        }
    }
}
