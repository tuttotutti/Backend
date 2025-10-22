using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using LeThiMinhTuoi_2231200122_Lab2.Q2;

namespace LeThiMinhTuoi_2231200122_Lab2.Q3
{
    abstract class Transaction
    {
        private string transactionID;
        public string TransactionID { get => transactionID; set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("TransactionID cannot be null");
                }
                transactionID = value;
            } 
        }
        public DateTime TransactionDate { get; set; }
        public Member Member { get; set; }

        protected Transaction(string transactionID, Member member)
        {
            TransactionID = transactionID;
            TransactionDate = DateTime.Now;
            Member = member;
        }


        public abstract void Execute();
    }
}
