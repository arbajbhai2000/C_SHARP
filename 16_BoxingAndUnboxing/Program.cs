using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine($"i :{i}");
            object o = i;//int ->object  value type to reference type =boxing
            Console.WriteLine($" o : {o}");

            int j = (int)o; //object -> int reference type -> value type = unboxing 
            Console.WriteLine($" j : {i}");




            Console.ReadLine();
        }
    }
}
