using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class Platinumcustomer :customer
    {
        public Platinumcustomer()
        {

            Console.WriteLine("platinumcustomer() constructor called");
            ticketamount = 400;
        }

        public void printticket()
        {
            Console.WriteLine("platinum ticket priented");
        }

    }
}
