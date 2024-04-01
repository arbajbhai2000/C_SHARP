using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Sealedkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.print();

            customer c2 = new silvercustomer();
            c2.print();

            customer c3 = new advancedsilvercustomer();
            c3.print();




            Console.ReadLine();
        }
    }
}
