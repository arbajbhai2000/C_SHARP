using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MultipleClassInheritenceproblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.print();

            B b1 = new B();
            b1.print();

            C c1 = new C();
            c1.print();

            Console.ReadLine();
        }
    }
}
