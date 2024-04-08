using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interfaces
{
    public interface Icustomer
    {
        void Showtimings();
    }

    public interface Icustomerv1: Icustomer
    {
        void printticket();
    }

    //public class silvercustomer : Icustomer , Icustomerv1
    public class silvercustomer :  Icustomerv1
    
    {
        public void printticket()
        {
            Console.WriteLine("silvercustomer : printticket");
        }
        public void Showtimings()
        {
            Console.WriteLine("silvercustomer :showtimings() method");
        }
    }

    // public class goldcustomer : Icustomer, Icustomerv1
    public class goldcustomer :  Icustomerv1
    {
        public void printticket()
        {
            Console.WriteLine("goldcustomer : printticket");
        }
        public void Showtimings()
        {
            Console.WriteLine("goldcustomer : showtimings() method");
        }
    }
}
