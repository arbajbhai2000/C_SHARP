using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
    public class student
    {

        public int rollnumber;  //field
        public string firstname;
        public string lastname;
        public static string coursename;
        //default constructor or paramter less constructor
        public student()        //constructor syntax it not used return type or void
        {
            Console.WriteLine($"student() constructor called");
            rollnumber = 20 ;
            firstname = "jishan";
            lastname = "kazi";
           // coursename = "dot net";
        }

        //parameterized constructor
        public student(int rn, string fn, string ln)
        {
            Console.WriteLine("student (int rn ,string fn,string ln ) constructor called parameter");
            rollnumber = rn;
            firstname = fn;
            lastname = ln;
        }

        //copy constructor
        public student (student s)
        {
            this.rollnumber = s.rollnumber;
            this.firstname = s.firstname;
            this.lastname = s.lastname;
        }

        static student()
        {
            Console.WriteLine($"static student() constructor called");
            coursename = "dot net";
        }
         
        public void details()   //method
        {
            Console.WriteLine($"Rollnumber : {rollnumber} Fullname : {firstname} {lastname} coursename :{coursename}");
        }

        //public void initialize( int rn ,string fn ,string ln )
        //{
        //    rollnumber = rn;
        //    firstname = fn;
        //    lastname = ln;
        //} 
    }
}
