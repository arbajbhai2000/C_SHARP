using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int y=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** Before Swapping ***");
            Console.WriteLine($"(x) => {x} And (y) => { y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("*** After Swapping ***");
            Console.WriteLine($"(x)->{x} And (y)->{y}");

            Console.ReadLine();
        }
    }
}
