using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _21_Methodoverriding.Silvercustomer;

namespace _21_Methodoverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //customer c1= new customer("arbaj" , "mujawar");
            //c1.print();

            //Silvercustomer sc1 = new Silvercustomer("suraj","pathan");
            //sc1.print();

            //customer c2 = new Silvercustomer("swapnil", "kolhe");
            //c2.print();

            //customer c3 = new Goldcustomer("jishan", "kazi");
            //c3.print();

            //customer c = new customer("abc", "bcd");
            //c = new Silvercustomer("a", "b");
            //c = new Goldcustomer("c", "d");

            customer[] customers = new customer[]
            {
                new customer("arbaj","mujawar"),
                new Silvercustomer("a","b"),
                new Goldcustomer("c","d"),
                new  advancedsilvercustomer("e","f")
            };
            for(int i=0;i<customers.Length;i++)
            {
                customers[i].print();
            }



            Console.ReadLine();
        }
    }
}
