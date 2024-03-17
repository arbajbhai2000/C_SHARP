using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollnumber=1;
            string name = "arbaj";
            string city = "barshi";

            Console.WriteLine($"rollnumber :{rollnumber}\n" +
                $"name :{name}\n" +
                $"city :{city}");

            student s1 = new student();
            s1.rollnumber = 10;
            s1.name = "novfil";
            s1.city = "pune";

            student s2 = new student();
            s2.rollnumber = 20;
            s2.name = "suraj";
            s2.city = "barshi";
                //Console.WriteLine($"rollnumber :{s1.rollnumber} name :{s1.name}  city :{s1.city}");
            s1.details();
            s2.details();

            Circle c1 = new Circle();
            c1.radius = 4;
            c1.pi = 3.14f;
            c1.area();
                
             Console.ReadLine();
        }
    }
    class student
    {
        public int rollnumber;
        public string name;
        public string city;

        //using the method we dont need to write a object instead we write details or any
        public void details()
        {
            Console.WriteLine($"rollnumber : {rollnumber} name : {name} city :{city}");
        }
    }
}


