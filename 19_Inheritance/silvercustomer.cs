using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class silvercustomer :customer //class
    {
        //public int ticketamount; //field
        public string name = "silver customer";
        public silvercustomer()  //constructor
        {

            Console.WriteLine("silvercustomer() constructor called");
            Console.WriteLine($"name from this clss :{this.name}");
            Console.WriteLine($"name from base class : {base.name}");
            ticketamount = 150;
        }

        //public void showtimigs()
        //{
        //    Console.WriteLine("ALL SHOWS TIMIES");
        //}

        //public void getticketamount()
        //{
        //    Console.WriteLine($"silver ticket amount : {ticketamount}");
        //}

        public void printticket()
        {
            Console.WriteLine("silver ticket priented");
        }

         
    }

         


}

