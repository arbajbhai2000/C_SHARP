using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.print();
            c1.printA();
            //c1.printB(); //not possible because it is a child class

            silvercustomer sc = new silvercustomer();
            sc.print();
            sc.printA();
            sc.printB();

            customer c2 = new silvercustomer();
            c2.print();
            c2.printA();
            //c2.printB();
            ((silvercustomer)c2).printB(); //use the type cast operator to get the print B output 

            //silvercustomer sc2= new customer();
            //sc2.print();

            Console.ReadLine();
        }
    }
}
