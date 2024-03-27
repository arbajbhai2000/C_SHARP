using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _25_Operatoroverloading
{
    public class student
    {
        public int rollnumber;
        public string firstname;
        public string lastname;

        public student(int rn, string fn, string ln)
        {
            rollnumber =  rn ;
            firstname = fn ;
            lastname = ln ;
        }
        
        public static bool operator==( student s1,student s2)
        {
            return s1.rollnumber == s2.rollnumber && s1.firstname == s2.firstname &&
                s1.lastname == s2.lastname;

        }

        public static bool operator !=(student s1, student s2)
        {
            return s1.rollnumber == s2.rollnumber && s1.firstname == s2.firstname &&
                s1.lastname == s2.lastname;

        }
        public static student operator +(student s1,student s2)
        {
            int rollnumber = s1.rollnumber + s2.rollnumber;
            string firstname = s1.firstname + "," + s2.firstname;
            string lastname = s1.lastname + "," + s2.lastname;
            return new student(rollnumber, firstname, lastname);
        }


    }
}
