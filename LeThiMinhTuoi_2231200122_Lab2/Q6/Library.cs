using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using LeThiMinhTuoi_2231200122_Lab2.Q1;
using LeThiMinhTuoi_2231200122_Lab2.Q2;

namespace LeThiMinhTuoi_2231200122_Lab2.Q6
{
    internal class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Library()
        {
            LibraryName = "City Library";
            Books = new List<Book>();
            Members = new List<Member>();
            Transactions = new List<Transaction>();
        }

        public Library(string libraryName, List<Book> books)
        {
            if (string.IsNullOrEmpty(libraryName))
            {
                LibraryName = "City Library";
            }
            else
            {
                LibraryName = libraryName;
            }
            if (books == null)
            {
                Books = new List<Book>();
            }
            else
            {
                Books = books;
            }
            Members = new List<Member>();
            Transactions = new List<Transaction>();
        }

        public Library(Library lib)
        {
            if (lib == null)
            {
                LibraryName = "City Library";
                Books = new List<Book>();
                Members = new List<Member>();
                Transactions = new List<Transaction>();
                return;
            }

            if (string.IsNullOrEmpty(lib.LibraryName))
            {
                LibraryName = "City Library";
            }
            else
            {
                LibraryName = lib.LibraryName;
            }

            if (lib.Books == null)
            {
                Books = new List<Book>();
            }
            else
            {
                Books = new List<Book>(lib.Books);
            }

            if (lib.Members == null)
            {
                Members = new List<Member>();
            }
            else
            {
                Members = new List<Member>(lib.Members);
            }

            if (lib.Transactions == null)
            {
                Transactions = new List<Transaction>();
            }
            else
            {
                Transactions = new List<Transaction>(lib.Transactions);
            }
        }

        public void DisplayLibraryInfo()
        {
            int totalAvailableCopies = Books.Sum(b => b.CopiesAvailable);
            Console.WriteLine($"Library Name : {LibraryName}, Total Books: {Books.Count}, Total Available Copies: {totalAvailableCopies}, Number of Members: {Members.Count}, Total Transactions : {Transactions.Count}");
        }
    }
}
