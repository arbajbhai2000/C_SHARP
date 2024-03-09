using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_conditionalstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            if (i == 10) 
            {
               
                Console.WriteLine($"{i} TEN");

            }

            i = 20;

            if(i==15)
            {
                Console.WriteLine($"{i} : TWENTY");
            }

            else
            {
                Console.WriteLine($"{i} : NOT TWENTY");
            }

            //TERNARY OPERATOR
            i = 2;
            string result = (i == 2) ? "two" : "not two";
            Console.WriteLine(result);
            Console.WriteLine($"{i} : {result}");

            i = 3;
            string result1 = (i != 4) ? "three" : "not three";
            Console.WriteLine($"{i} : {result1}");

            //co
            i = 7;
            if (i == 5) ;
            {
                Console.WriteLine($"{i} : five");
            }
            if (i == 6)
            {
                Console.WriteLine($"{6} : six");
            }
            if(i==7)
            {
                Console.WriteLine($"{7} : seven");
            }

            //if-else-if
            i = 40;
            if (i == 10) 
            {
                Console.WriteLine($"{i} : TEN");
            }
            else if (i == 20)
            {
                Console.WriteLine($"{i} : TWENTY");
            }
            else if (i == 30)
            {
                Console.WriteLine($"{i} : THIRTY");
            }
            else
            {
                Console.WriteLine($"{i} : Not 10,20 or 30");
            }

            //switch
            i = 50;
            switch(i)
            {
                case 10:
                    Console.WriteLine($"{i} : TEN");
                    break;

                case 20:
                    Console.WriteLine($"{i} : twenty");
                    break;

                case 30:
                    Console.WriteLine($"{i} : thirty");
                    break;

                default:
                    Console.WriteLine($"{i} : not 10,20 or 30");
                    break;


            }

            //eg
            int a=20 ,b = 20;
            if (a > b) 
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else if (b>a)
                    {
                Console.WriteLine($"{b} is greater than {a}");
            }
            else
            {
                Console.WriteLine($"{a} and {b} is equal");
            }









            Console.ReadLine();





        }
    }
}
