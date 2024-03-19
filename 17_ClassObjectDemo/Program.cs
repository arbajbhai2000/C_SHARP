using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17_ClassObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0;//i is a varible of type int

            //student s1;//s1 is varible of type student
            //s1 is reference varible

            student s1 = new student();
            s1.rollnumber = 1;
            s1.name = "arbaj";
            s1.city = "barshi";
            student.coursename = "dot net";
            s1.Print();

            student s2 = new  student();
            s2.create(2, "novfil", "pune");
            //s2.create(3, "suraj", "solapur");
            s2.Print();

            //student.coursename

            student s3 = new student();
            s3.create(3, "swapnil", "latur");
            student.coursename = "c#";
            s3.Print();

            //world w1= new world();//error occur if you are creating the static class

            //world w2 = new world();

            Console.WriteLine($"{world.numberofcountries}");//you dont need to create object use static name



            Console.ReadLine();
        }
    }
    class student
    {
        public int rollnumber;
        public string name;
        public string city;
        public static string coursename ="Dot Net";

        //public int Rollnumber;
        //public string Name;
        //public string City;
        //public static string coursename ="c#";

        //public int Rollnumber { get; private set; }
        //public string Name { get; private set; }
        //public string City { get; private set; }

        //public void Print()
        //{
        //    Console.WriteLine($"rollnumber :{Rollnumber} name :{Name} city : {City} coursename :{Coursename}");
        //}

        public void Print()
        {
            Console.WriteLine($"rollnumber :{rollnumber} name :{name} city : {city} coursename : {coursename}");

            PrintA();
        }

        public void create(int rollnumber , string name, string city)
        {

            this.rollnumber = rollnumber;
            this.name = name;
            this.city = city;
        }

        public static void PrintA()
        {
            Console.WriteLine("static PrintA() called");
            //Console.WriteLine($"rollnumber :{rollnumber} name :{name} city : {city} coursename : {coursename}");
            
            //student s = new student();
            //s.create(4,"suraj","satara");//
            // to access instance member from static method we need to create object
        }


    }

    static class world
    {
        public static int numberofcountries = 290;

        public static int numberofcontinents = 7;
    }
         
}
