using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q1;
using LeThiMinhTuoi_2231200122_Lab2.Q2;

namespace LeThiMinhTuoi_2231200122_Lab2.Q3
{
    internal class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }

        public ReturnTransaction(string transactionID, DateTime transactionDate, Member member, Book book)
            : base(transactionID, member)
        {
            BookReturned = book;
        }

        public override void Execute()
        {
            // Check if member actually borrowed this book (em comment nha thay)
            if (!Member.BorrowBooks.Contains(BookReturned))
            {
                Console.WriteLine($"Member {Member.Name} does not borrow {BookReturned.Title}");
                return;
            }

            // Remove book from member's BorrowedBooks list
            Member.BorrowBooks.Remove(BookReturned);

            // Increase CopiesAvailable
            BookReturned.CopiesAvailable++;

            // Display return info
            Console.WriteLine($"Returning succeeded: Member={Member.Name}, Book={BookReturned.Title}");
        }
    }
}
