using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Methodoverloading_scenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a=new A();
            a.printA();

            B b=new B();
            b.printA(10);   
            b.printA();

            Console.ReadLine();
        }
    }
    class A
    {
        public void printA()
        {
            Console.WriteLine("A:printA()");
        }
    }
    class B:A
    {
        public void printA(int a)
        {
            Console.WriteLine("B: printB(int a)");
        }
    }
}
