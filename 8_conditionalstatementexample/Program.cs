using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_conditionalstatementexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter first number");
            //int first = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number");
            //int second=int.Parse(Console.ReadLine());

            //Console.WriteLine("enter third number");
            //int third = int.Parse(Console.ReadLine());

            //Console.WriteLine($"entered number : {first} {second}");

            //Console.WriteLine($" addition : {first + second}");

            #region nested if else
            //if (first > second)
            //{
            //    if(first > third)
            //    {
            //        Console.WriteLine($" {first} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}
            //else if(second > third)
            //{
            //    if (second > third)
            //    {
            //        Console.WriteLine($"{first} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {third} is greater number");
            //    }
            //}
            //else
            //{
            //    if(first > third)
            //    {
            //        Console.WriteLine($"{first} ,{second} is greater number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greater number");
            //    }
            //}
            #endregion nested if else

            #region nested ternary operator 
            //int number = (first > second) ? 
            //    ((first >third)  ? first : third) :
            //    ((second >third) ? second : third);
            //Console.WriteLine($"{number} is greater ");
            #endregion nested ternary operator


            #region divisible by 3 and 5
            //Console.WriteLine("please enter number");
            //int num=int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("divisible three and five");
            //}
            //else if (num %3 ==0)
            //{
            //    Console.WriteLine("three");
            //}
            //else if (num %5 == 0)
            //{
            //    Console.WriteLine("five");
            //}
            #endregion divisible by 3 and 5

            #region even and odd

            //Console.WriteLine("enter  number");
            //int num = int.Parse(Console.ReadLine());

            //string result = (num % 2 == 0) ? "even" : "odd";
            //Console.WriteLine(result);
            #endregion even and odd

            #region grade

            //Console.WriteLine("grade");
            //char grade =char.Parse(Console.ReadLine().ToUpper());

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine($"{grade}: destinction");
            //        break;

            //    case 'B':
            //        Console.WriteLine($"{grade} :first class");
            //        break;
            //    case 'c':
            //        Console.WriteLine($"{grade}: second class");
            //        break;
            //    case 'F':
            //        Console.WriteLine($"{grade} : fail");
            //        break;
            //}
            #endregion grade






            Console.ReadLine();
        }
    }
}
