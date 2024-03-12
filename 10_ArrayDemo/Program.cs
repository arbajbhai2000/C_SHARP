using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //i = 10;
            //j = 20;

            int[] fees = new int[4];

            fees[0] = 1000;
            fees[1] = 500;
            fees[2] = 200;
            fees[3] = 10000;
           

            Console.WriteLine($"enter new item: {fees.Length }");
           
            for(int i=0; i<fees.Length; i++)
            {
                Console.Write($"{fees[i]}\n" );
            }

            string[] names = new string[] { "arbaj novfil suraj swapnil" };
            for (int i=0; i < names.Length; i++)
            {
                Console.Write($"enter names : {names[i]}");
            }

            string[] name = new string[]  { "arbaj"," novfil", "suraj"," sohel" };
            Console.WriteLine($"number of name :{name.Length}");
            Console.WriteLine("\n reverse array");
            for ( int i=name.Length-1; i >=0; i--)
            {
                Console.Write($" {name[i]}\n");
            }
            int[] number1 = new int[] { 6,3,4,2,1  };
            Console.WriteLine("\n reverse array");
            for (int i = number1.Length - 1; i>= 0; i--)
            {
                Console.Write($"{number1[i]}");
            }

            //highest number

            //number = new int[] { 10, 20, 30 };
            int highest=0 ;
            int[] number= new int[] { 10,20,30,222,12,65,60,222 };
            
            for (int i = 0; i < number.Length; i++)
            {
                //highest = number[i];
               for(int j = 0; j < number.Length; j++)
                {
                    if (number[j] > highest)
                    {
                        highest= number[j];
                    }
                }
            }
            Console.WriteLine($"\nhighest number : {highest} ");

            //reverse input string 
            Console.WriteLine("enter the name");
            string name1=Console.ReadLine();
            string reversename = string.Empty;
            for(int i =name1.Length-1;i>=0; i--)
            {
                reversename += name1[i];
            }
            Console.WriteLine($"enter name :{name1} reverse name :{reversename}");

            //reverse the scentence
            Console.WriteLine("enter the scentence");
            string scentence=Console.ReadLine();
            string [] words=scentence.Split(new char[] { ' '});
            Console.WriteLine("output : \n");
            for(int i =words.Length-1; i>=0; i--)
            {
                Console.Write($"{words[i]} ");
            }
            
            Console.ReadLine();

        }
    }
}
