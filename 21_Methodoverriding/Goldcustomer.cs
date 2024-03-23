using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _21_Methodoverriding
{
    public class Goldcustomer :customer
    {
        public Goldcustomer(string fn, string ln) : base (fn, ln)
        {      
        }
        public override void print()
        {
            Console.WriteLine($"{Firstname} {Lastname} : Gold customer");
        }
    }
}
