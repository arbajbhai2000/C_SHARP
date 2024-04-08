using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interfaces
{
    public interface IA
    {
        void printA();
        void print();
    }

    public interface IB
    {
        void printB();
        void print();
    }
    public class A : IA, IB
    {
         void IA.print()
        {
            Console.WriteLine("IA :print()");
        }

         void IB.print()
        {
            Console.WriteLine("IB :print()");
        }

        public void printA()
        {
            Console.WriteLine("A:PrintA()");
        }

        public void printB()
        {
            Console.WriteLine("B:printB()");
        }
    }
}
