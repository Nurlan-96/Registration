using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Domain
{
    public class Student : User
    {
        public int Point { get; set; }


        public Student(int point, string fullname,string email,string password):base(fullname,email,password)
        {
            Point = point;
        }

        public override string UserInfo()
        {
            return (Id + " " + Fullname + " " + Email + " " + Point);
        }

    }
}
