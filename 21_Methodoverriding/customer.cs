using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Methodoverriding
{
    public class customer
    {
        public string Firstname;
        public string Lastname;

        public customer(string  fn, string ln)
        {
            Firstname = fn;
            Lastname = ln;
        }

        public virtual void print()  //customer is base class//virtual//abstract//override
        {
            Console.WriteLine($"{Firstname} {Lastname} :normal customer");
        }
         
    }
}
