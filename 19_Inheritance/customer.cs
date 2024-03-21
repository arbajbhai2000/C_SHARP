using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class customer
    {
        public customer()
        {
            Console.WriteLine("customer() constructor called");
        }


        public int ticketamount;

        public string name = "customer";

        public void showstimings()
        {
            Console.WriteLine("ALL SHOWES TIME");
        }
        public void getticketamount()
        {
            Console.WriteLine($"gold ticket amount : {ticketamount}");
        }


    }
}
