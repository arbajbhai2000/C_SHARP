using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine(i);

            i = 10;
            Console.WriteLine(i);

            int a = i + j;
            Console.WriteLine(a);

            int b = i / j;
            Console.WriteLine(b);

            int c = i % j;
            Console.WriteLine(c);

            i++;
            Console.WriteLine(i);

            ++i;
            Console.WriteLine(i);

            i += 5;
            Console.WriteLine(i);

             i *= 2;
            Console.WriteLine(i);

            i %=5;
            Console.WriteLine(i);


            i = 10;
            bool result = i == j;
            Console.WriteLine(result);

            i++;
            bool result1 = i != j;
            Console.WriteLine(result1);

            result = i <=j;
            Console.WriteLine(result);

            int K= 30;
            result = i >= j && K >= j;
            Console.WriteLine(result);

            result = i <= j || j >= K;
            Console.WriteLine(result);




            Console.ReadLine();
          


        }
    }
}
