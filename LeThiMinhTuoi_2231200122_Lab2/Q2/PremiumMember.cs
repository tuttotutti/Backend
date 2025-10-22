using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q1;

namespace LeThiMinhTuoi_2231200122_Lab2.Q2
{
    internal class PremiumMember : Member
    {
        public DateTime MembershipExpiry;

        public PremiumMember(string memberID, string name, string email, DateTime expiry)
            : base(memberID, name, email)   
        {
            MaxBooksAllowed = 10;
            MembershipExpiry = expiry;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine($"Membership Expiry: {MembershipExpiry:dd/MM/yyyy}");
        }

        public override void BorrowBook(Book book)
        {
            if (DateTime.Now > MembershipExpiry)
            {
                Console.WriteLine($"{Name}'s membership has expired on {MembershipExpiry:dd/MM/yyyy}.");
                return;
            }

            if (BorrowBooks.Count >= MaxBooksAllowed)
            {
                Console.WriteLine($"{Name} has already borrowed the maximum: {MaxBooksAllowed}");
                return;
            }

            // Special privilege
            Console.WriteLine($"Enjoy your premium access!");

            base.BorrowBook(book);
        }
    }
}
