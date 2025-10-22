using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q5;

namespace LeThiMinhTuoi_2231200122_Lab2.Q1
{
    internal class Book : IPrintable
    {
        [Required]
        // ISBN: International Standard Book Number
        private string isbn;
        public string ISBN { get => isbn;set
            {
                if(string.IsNullOrEmpty(value))
                {  throw new ArgumentNullException("ISBN cannot be null or empty."); }
                isbn = value;
            }
        }
        [Required]
        private string title;
        public string Title
        {
            get => title; set
            {
                if (string.IsNullOrEmpty(value))
                { throw new ArgumentNullException("Title cannot be null or empty."); }
                title = value;
            }
        }
        [Required]
        private string author;
        public string Author
        {
            get => author; set
            {
                if (string.IsNullOrEmpty(value))
                { throw new ArgumentNullException("Author cannot be null or empty."); }
                author = value;
            }
        }
        private int year;
        public int Year
        {
            get => year; set
            {
                if (value < 1000 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Year must be between 1000 and the current year.");
                }
                year = value;
            }
        }

        private int copiesAvailable;
        public int CopiesAvailable { get => copiesAvailable; set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Copies available cannot be less than 0.");
                }
                copiesAvailable = value;
            }
        }  
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Info: ISBN={ISBN}, Title={Title}, Author={Author}, Year={Year}, CopiesAvailable={CopiesAvailable}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Book Info: ISBN={ISBN}, Title={Title}, Author={Author}, Year={Year}, CopiesAvailable={CopiesAvailable}");
        }

        // constructor to test in Main() in Program.cs
        public Book(string iSBN, string title, string author, int year, int copiesAvailable)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Year = year;
            CopiesAvailable = copiesAvailable;
        }
    }
}
