using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Abstractkeyword
{
    public class Goldcustomer:customer
    {
        public override void ticketprint()
        {
            Console.WriteLine("gold ticket print");
        }
    }
}
