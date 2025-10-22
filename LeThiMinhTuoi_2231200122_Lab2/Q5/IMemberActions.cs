using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q1;

namespace LeThiMinhTuoi_2231200122_Lab2.Q5
{
    internal interface IMemberActions
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}
