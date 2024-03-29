using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Abstractkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Silvercustomer sc=new Silvercustomer();
            sc.showtimings();
            sc.ticketprint();

            Goldcustomer gc = new Goldcustomer();
            gc.showtimings();
            gc.ticketprint();

            //customer customer = new customer();//we will not able to create object in abstract class

            customer c1 = new Silvercustomer();
            c1.ticketprint();

            customer c2 = new Goldcustomer();
            c2.ticketprint();

            customer c3 = new Platinumcustomer();
            c3.ticketprint();


            Console.ReadLine();
        }
    }
}
