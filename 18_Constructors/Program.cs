using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {


            student s1 = new student();  //object creation
            s1.details();

            //student s2 = new student();
            //s2.rollnumber = 1;          //dot operator
            //s2.firstname = "arbaj";
            //s2.lastname = "mujawar";
            //s2.details();

            ////object initiallizer syntax
            //student s3 = new student()
            //{
            //    rollnumber = 2,
            //    firstname = "novfil",
            //    lastname = "mujawar"
            //};
            //s3.details();

            //student s4 = new student();
            //s4.initialize(3,"suraj","pathan");
            //s4.details();

            //student s5 = new student();
            //s5.details();

            //student s6 = new student(6,"jishan","kazi");
            //s6.details();

            //student s7 = new student();
            //student s8 = new student(8,"a" ,"b");

            //student s9 = new student(9,"sohel","mukeri");
            //s9.details();

            //student s10 = s9;
            //s10.details();

            //student s11 = new student();
            //s11.rollnumber = s9.rollnumber;
            //s11.firstname= s9.firstname;
            //s11.lastname= s9.lastname;
            //s11.details();

            //student s12 = new student(s11);
            //s12.details();

            //student s13 = new student();
            //s13.details();
            //student s14 = new student();
            //s14.details();
            //student s15 = new student();
            //s15.details();

            //student s16 = new student();

            //student s17 = new student();

            Console.WriteLine($"course name :{student.coursename}");

            student s18 = new student();
            Console.WriteLine($"coursename :{student.coursename}");


            Console.ReadLine();
        }
    }
}
