using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args) //calling method
        {
            //int a = 10;
            //PrintA(a);
            //Console.WriteLine(a);


            //int a = 10;
            //PrintB(ref a);
            //Console.WriteLine(a);

            //int a = 10;
            //PrintC(out a);
            //Console.WriteLine(a);

            //int a = 10;
            //int b =20;
            //int  add, sub, mul, div;
            //PrintD(a, b, out add, out sub, out mul, out div);

            //Console.WriteLine($"ADDTITION :{a} + {b} = {add}");
            //Console.WriteLine($"SUBSTRATION :{a} - {b} = {sub}");
            //Console.WriteLine($"MULTIPLICATION :{a} * {b} = {mul}");
            //Console.WriteLine($"DIVISION :{a} / {b} = {div}");

            int[] number3 = new int[] { 20, 30 };
            PrintE(number3);
            //Console.WriteLine(number);
            Console.ReadLine();

        }
        static void PrintA(int a) //called method
        {
            a = 100;
        }

        static void PrintB(ref int b)
        {
            b = 100;
        }

        static void PrintC(out int a)
        {
            a = 100;
        }

        static void PrintD(int a, int b, out int add,out int  sub, out int mul,out int div)
        {
            Console.WriteLine($"enter the number to {a} and {b}");
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }

        static void PrintE(int[] numbers)
        {
            if (numbers !=null && numbers.Length > 0)
            {
                int sum = 0;
                for(int i=0; i<numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($" sum of array :{sum}");
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }

    }
}
 