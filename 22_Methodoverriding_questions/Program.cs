using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _22_Methodoverriding_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 =new A(); a1.print();
            A a2 =new B(); a2.print();
            A a3 =new C(); a3.print();
            B b1=new C(); b1.print();


            Console.ReadLine();
        }
    }
}
