using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q1;
using LeThiMinhTuoi_2231200122_Lab2.Q2;

namespace LeThiMinhTuoi_2231200122_Lab2.Q3
{
    internal class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }

        public BorrowTransaction(string transactionID, DateTime transactionDate, Member member, Book book)
            : base(transactionID, member)
        {
            BookBorrowed = book;
        }

        public override void Execute()
        {
            // Check if book is available
            if (BookBorrowed.CopiesAvailable <= 0)
            {
                Console.WriteLine($"Book '{BookBorrowed.Title}' is not available.");
                return;
            }

            // Check if member can borrow more books
            if (Member.BorrowBooks.Count >= Member.MaxBooksAllowed)
            {
                Console.WriteLine($"Member '{Member.Name}' has reached the borrowing maximum ({Member.MaxBooksAllowed}).");
                return;
            }

            // Decrease book copies
            BookBorrowed.CopiesAvailable--;

            // Add book to member's BorrowedBooks list
            Member.BorrowBooks.Add(BookBorrowed);

            // Display info
            Console.WriteLine($"Borrowing succeeded: Member={Member.Name}, Book={BookBorrowed.Title}");
        }
    }
}
