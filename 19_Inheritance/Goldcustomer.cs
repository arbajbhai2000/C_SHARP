using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    internal class Goldcustomer :customer
    {

        //public int ticketamount;
        public Goldcustomer()
        {

            Console.WriteLine("goldcustomer() constructor called");
            ticketamount = 250;
        }

        //public void showstimings()
        //{
        //    Console.WriteLine("ALL SHOWES TIME");
        //}
        //public void getticketamount()
        //{
        //    Console.WriteLine($"gold ticket amount : {ticketamount}");
        //}

        public void printticket()
        {
            Console.WriteLine("gold ticket priented");
        }

    }
}
