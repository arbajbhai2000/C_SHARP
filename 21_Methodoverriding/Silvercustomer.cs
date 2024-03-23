using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Methodoverriding
{
    public class Silvercustomer :customer
    {
        public Silvercustomer(string fn, string ln) : base(fn, ln)
        {

        }
        // public override void print()
        //{
        //    Console.WriteLine($"{Firstname} {Lastname} : silver customer");
        //}

        public override void print()
        {
            Console.WriteLine($"{Firstname} {Lastname} : silver customer");
        }
        public class advancedsilvercustomer : Silvercustomer
        {
            public advancedsilvercustomer(string fn,string ln) : base(fn, ln) { }
            public override void print()
            {
                Console.WriteLine($"{Firstname} {Lastname} : advanced silver customer");
            }
        }
         

    }
}
