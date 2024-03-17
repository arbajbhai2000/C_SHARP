using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassDemo
{
    internal class Circle
    {
        public int radius;
        public float pi;

        public void area()
        {
            Console.WriteLine($"area of circle ={pi * radius * radius}");
        }

    }
}
