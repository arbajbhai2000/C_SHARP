using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _27_Abstractkeyword
{
    public class Silvercustomer:customer
    {
        public override void ticketprint()
        {
            Console.WriteLine("silver ticket print");
        }
         
    }
}
