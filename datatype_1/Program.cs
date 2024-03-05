using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 = true;
            Console.WriteLine(b1);
            Console.WriteLine();
            

            byte b2 = 10;
            Console.WriteLine(b2);
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);


            short s1 = 10;
            Console.WriteLine($"{s1} : {sizeof(short)} : {short.MinValue} :{short.MaxValue} ");

            int i1 = 10;
            Console.WriteLine($"{i1} :{sizeof(int)} : {int.MinValue} : {int.MaxValue}");

            long l1 = 10;
            Console.WriteLine($"{l1} : {sizeof(long)} : {long.MinValue} : {long.MaxValue}");

            float f1 = 10.5f;
            Console.WriteLine($"{f1} : {sizeof(float)} : {float.MinValue} : {float.MaxValue} ");

            double d2 = 10.5;
            Console.WriteLine($"{d2} : {sizeof(double)} : {double.MinValue} : {double.MaxValue}");

            decimal d3 = 31223585237012451245645653m;
            Console.WriteLine($"{d3} : {sizeof(decimal)} : {decimal.MinValue} : {decimal.MaxValue}");

            char div = '$'; 
            Console.WriteLine(div);
            Console.WriteLine(sizeof(char));

            string name = "arbaj";
            Console.WriteLine(name);
            

            Console.ReadLine();





        }
    }
}
