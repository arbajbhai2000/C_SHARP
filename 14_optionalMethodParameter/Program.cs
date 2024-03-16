using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_optionalMethodParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           add(10, 20);

            //add(20);

            //add();

            add(b: 20);//named paramter


            Console.ReadLine(); 
        }

        //static void add(int a, int b)
        //{
        //    Console.WriteLine($"addition {a} + {b}= {a + b}");
        //}

        //static void add(int a = 20,int b =40)
        //{
        //    Console.WriteLine($"addition {a} + {b} = {a + b}");
        //}

        //static void add(int a , [Optional] int b) //for default value use optional 
        //{
        // Console.WriteLine($"addition {a} + {b} = {a + b}");  //default value it takes 0
        //}

        static void add([Optional]int a,  int b)
        {
            Console.WriteLine($"addition {a} + {b} = {a + b}");  
        }

    }
}
