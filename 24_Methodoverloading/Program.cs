using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Methodoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator c1 = new calculator();
            c1.print();

            c1.print(10);

            int i = 10;

            c1.print(ref i);

            c1.print(20,30);

            c1.print("arbaj");

            c1.print(1, "novfil");

            c1.print("novfil", 1);

            short s = 10;
            int i1 = 10;
            c1.print(10);
            c1.print(s);




            Console.ReadLine();
        }
    }
}
