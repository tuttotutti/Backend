using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeThiMinhTuoi_2231200122_Lab2.Q2;

namespace LeThiMinhTuoi_2231200122_Lab2.Q4
{
    internal class RegularMember: Member
    {
        public RegularMember(string memberID, string name, string email)
            : base(memberID, name, email)
        {
            MaxBooksAllowed = 3; 
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
