using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Array_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array example
            //Console.WriteLine("enter comma seperated values");
            //string input = Console.ReadLine();

            //string[] number = input.Split(',');

            //int counter = 0;
            //for(int i=0;i<number.Length; i++)
            //{
            //    if (int.Parse(number[i]) % 2 == 0)
            //    {
            //        Console.Write($"{ number[i]}");
            //             counter++;
            //    }
            //    //Console.Write($" {number[i]}");
            //}
            //Console.WriteLine($"\nnumber of even number {counter}");
            #endregion array example

            #region target even number
            //Console.WriteLine("enter the target number to find the even number");
            //int target=int.Parse(Console.ReadLine());
            //int c = 0;
            //int[] evens = new int[c];
            //for (int i = 0; i <= target; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i}");

            //    }
            //}
            #endregion target even number

            //multidimensional array
            int[,] numbers = new int[3 , 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{i}{j} ");
                    }
                    //Console.Write($"{i}{j} ");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }



                Console.ReadLine();
        }
    }
}
