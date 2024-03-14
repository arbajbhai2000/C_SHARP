using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_Method_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintA();

            PrintB("ARBAJ");
            string name = "NOVFIL";
            PrintB(name);

            PrintC("ARBAJ", "MUJAWAR");
            string firstname = "NOVFIL", lastname = "MUJAWAR";
            PrintC(firstname, lastname);

            string output = PrintD("SWAPNIL", "KOLHE");
            Console.WriteLine($"PrintD fullname :{output}");

            PrintE(true);
            PrintE(false);

            PrintF(null);
            int[] number = new int[] { 10, 30, 4, 50 };
            PrintF(number);



            Console.ReadLine();
        }

        //without return without parameter 
        static void PrintA()
        {
            Console.WriteLine($"method called PrintA");
        }
        //with paramter 
        static void PrintB(string name)
        {
            Console.WriteLine($"PrintB : Hello {name}");
        }
        //with multiple parameter
        static void PrintC(string fn, string ln)
        {
            Console.WriteLine($"PrintC fullname :{fn} {ln}");
        }

        //PARAMETER
        static string PrintD(string fn, string ln)
        {
            return (fn + " " + ln);
        }

        //return statement 
        static void PrintE(bool isconfirmed)
        {
            if (!isconfirmed)
            {
                return;
            }
            Console.WriteLine("session allow");
        }

        //sum of array element

        static void PrintF(int[] number)
        {
            if(number !=null &&  number.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < number.Length; i++) 
                {

                    sum += number[i];
                }
                Console.WriteLine($"enter number sum : {sum}");
            }
            else
            {
                Console.WriteLine("no number to add");
            }
        }
        


    }
}
