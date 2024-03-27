using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Operatoroverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int type == operator
            //int i = 10;
            //int j = 10;
            //if (i == j)
            //{
            //    Console.WriteLine("i & j are equal");
            //}
            //else
            //{
            //    Console.WriteLine("i & j are not equal");
            //}
            #endregion int type == operator

            #region string type == operator
            //string s1 = "arbaj";
            //string s2 = s1;
            //if(s1 == s2)
            //{
            //    Console.WriteLine("s1 & s2 are equal");
            //}
            //else
            //{
            //    Console.WriteLine("s1 & s2 are not equal");
            //}
            #endregion string type == operator

            #region student
            //student s1 = new student(1, "arbaj", "mujawar");

            ////student s2 = s1;
            //student s2 = new student(1, "arbaj", "mujawar");
            //if (s1== s2)
            //{
            //    Console.WriteLine("s1 & s2 are equal");
            //}
            //else
            //{
            //    Console.WriteLine("s1 & s2 are not equal");
            //}
            #endregion student

            student s1 = new student(1,"arbaj","mujawar");

            student s2 = new student(3, "suraj", "pathan");

            student s3 = s1 + s2;

            Console.WriteLine($"{s3.rollnumber}: {s3.firstname}: {s3.lastname}");


            Console.ReadLine();
        }
    }
}
