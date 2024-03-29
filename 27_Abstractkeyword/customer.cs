using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Abstractkeyword
{
    public abstract class customer
    {
        public customer()//constructor
        {
            Console.WriteLine("customer() constructor called");
        }
        public void showtimings()
        {
            Console.WriteLine("** ALL TODAYS SHOW**");
        }

        public abstract void ticketprint();
         
    }

}
