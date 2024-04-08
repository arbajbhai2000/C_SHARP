using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Icustomer c1 = new Icustomer();  //not possible

            //Icustomerv1 c1 = new silvercustomer();
            //c1.Showtimings();
            //c1.printticket();

            //c1=new goldcustomer();
            //c1.Showtimings();
            //c1.printticket();

            //silvercustomer sc = new silvercustomer();
            //sc.Showtimings();

            //goldcustomer gc = new goldcustomer();
            //gc.Showtimings();

            Icustomerv1[] customers = new Icustomerv1[2];
            customers[0] = new silvercustomer();
            customers[1] = new goldcustomer();

            for(int i = 0; i < customers.Length; i++)
            {
                customers[i].Showtimings();
                customers[i].printticket();
            }

            A a=new A();
            a.printA();
            a.printB();

            IA ia= new A(); 
            ia.printA();
            ia.print();

            IB ib=new A();
            ib.printB();
            ib.print();


            Console.ReadLine();
        }
    }
}
