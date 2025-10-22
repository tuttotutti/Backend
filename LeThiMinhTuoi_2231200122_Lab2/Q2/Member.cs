using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q1;
using LeThiMinhTuoi_2231200122_Lab2.Q5;

namespace LeThiMinhTuoi_2231200122_Lab2.Q2
{
    abstract class Member: IPrintable, IMemberActions
    {
        private string memberID;
        public string MemberID { get => memberID; set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("MemberID cannot be null or empty.");
                }
                memberID = value;
            } 
        }
        private string name;
        public string Name
        {
            get => name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                name = value;
            }
        }
        private string email;
        public string Email
        {
            get => email; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be null or empty.");
                }
                email = value;
            }
        }
        public int MaxBooksAllowed;
        public List<Book> BorrowBooks = new List<Book>();

        public virtual void DisplayInfo()
        {
            Console.WriteLine(
                $"Member Info:  ID: {MemberID}; Name: {Name}, Email: {Email}, Max Books Allowed: {MaxBooksAllowed}, Borrowed Books: {BorrowBooks.Count}"
            );
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Member Info: ID={MemberID}, Name={Name}, Email={Email}, MaxBooks={MaxBooksAllowed}, BorrowedBooks={BorrowBooks.Count}");

            if (BorrowBooks.Count > 0)
            {
                Console.WriteLine("Books Borrowed:");
                foreach (var book in BorrowBooks)
                {
                    Console.WriteLine($"{book.Title},");
                }
            }
        }

        public virtual void BorrowBook(Book book)
        {
            if (book.CopiesAvailable <= 0)
            {
                Console.WriteLine($"{book.Title} is out of stock.");
                return;
            }

            if (BorrowBooks.Count >= MaxBooksAllowed)
            {
                Console.WriteLine($"{Name} has reached the borrowing maximum, {MaxBooksAllowed}.");
                return;
            }

            BorrowBooks.Add(book);
            book.CopiesAvailable--;
            Console.WriteLine($"{Name} successfully borrowed {book.Title}.");
        }

        public virtual void ReturnBook(Book book)
        {
            if (!BorrowBooks.Contains(book))
            {
                Console.WriteLine($"{Name} did not borrow {book.Title}");
                return;
            }

            BorrowBooks.Remove(book);
            book.CopiesAvailable++;
            Console.WriteLine($"{Name} successfully returned {book.Title}");
        }

        protected Member(string memberID, string name, string email)
        {
            MemberID = memberID;
            Name = name;
            Email = email;
            MaxBooksAllowed = 3;
        }
    }
}
