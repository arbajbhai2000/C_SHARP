using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
    public class customer
    {
        public void print()
        {
            Console.WriteLine($"customer print() method called");
        }

        public void printA()
        {
            Console.WriteLine($"customer printA() method called");
        }
    }

    public class silvercustomer :customer 
    {
        new public void print()   //use new for new method
        {
            Console.WriteLine($"silvercustomer print() method called");
        }

        public void printB()
        {
            Console.WriteLine($"silvercustomer printB() method called");
        }
    }
}
