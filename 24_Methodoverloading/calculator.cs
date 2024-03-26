using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Methodoverloading
{
    public class calculator
    {
        public void print()
        {
            Console.WriteLine("print() called");
        }

        public void print(int num)
        {
            Console.WriteLine("print() int num called");
        }

        public void print(short num)
        {
            Console.WriteLine("print(short num) called");
        }

        public void print(ref int num)
        {
            Console.WriteLine("print(ref int num) called");
        }

        public void print(int num1 ,int num2)
        {
            Console.WriteLine("print() int num1,int num2");
        }

        public void print(string name)
        {
            Console.WriteLine("print() string name");
        }

        public void print(int num ,string name)
        {
            Console.WriteLine("print(int num ,string name) ");
        }

        public void print(string name,int num)
        {
            Console.WriteLine("print(string name,int num) ");
        }

        public void print(int[] num)
        {
            Console.WriteLine("print( int[] num) called");
        }
         
        //public void print(params int[] num)  //not possible to overloading
        //{
        //    Console.WriteLine("print( int[] num) called");
        //}
    }
}
