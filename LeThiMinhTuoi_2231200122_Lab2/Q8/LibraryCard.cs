using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q2;

namespace LeThiMinhTuoi_2231200122_Lab2.Q8
{
    internal class LibraryCard
    {
        public string CardNumber { get; init; }
        public Member Owner { get; set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public bool IsActive => !isDeactivated && DateTime.Now < ExpiryDate;
        // because we cannot set the isActive, so we have to add isDeactivated
        private bool isDeactivated;
        public LibraryCard(string cardNumber, Member owner)
        {
            if (string.IsNullOrEmpty(cardNumber))
                throw new ArgumentException("Card number cannot be null or empty.");

            CardNumber = cardNumber;
            if (owner == null)
            {
                throw new ArgumentNullException(nameof(owner));
            }
            else
            {
                Owner = owner;
            }
            IssueDate = DateTime.Now;
            ExpiryDate = CalExpiryDate(owner);
            isDeactivated = false;
        }

        private DateTime CalExpiryDate(Member member)
        {
            if (member is PremiumMember)
            {
                return IssueDate.AddYears(2); 
            }
            else
            {
                return IssueDate.AddYears(1); 
            }
        }

        public void RenewCard()
        {
            IssueDate = DateTime.Now;
            ExpiryDate = CalExpiryDate(Owner);
            isDeactivated = false;
            Console.WriteLine($"Card {CardNumber} is renewed successfully!");
        }

        public void DeactivateCard()
        {
            isDeactivated = true;
            Console.WriteLine($"Card {CardNumber} is deactivated.");
        }

        public void DisplayCardInfo()
        {
            Console.WriteLine($"Card Number: {CardNumber}, Owner: {Owner.Name}, Issue Date: {IssueDate},Expiry Date: {ExpiryDate}, Status: {(IsActive ? "Active" : "Inactive")}");
        }
    }
}
