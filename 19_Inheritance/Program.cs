using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //silvercustomer sc1 = new silvercustomer();
            //sc1.showstimings();
            //sc1.getticketamount();
            //sc1.printticket();

            //Goldcustomer gc1 = new Goldcustomer();
            //gc1.showstimings();
            //gc1.getticketamount();
            //gc1.printticket();

            //Platinumcustomer pc1= new Platinumcustomer();
            //pc1.showstimings();
            //pc1.getticketamount();
            //pc1.printticket();

            //object creation
            //customer c1= new customer();    
            ////c1 is Reference varible of type customer pointing customer type object 

            //silvercustomer sc1=new silvercustomer();
            ////sc1 is Reference varible of type silvercustomer pointing silvercustomer type object 

            //customer c2 = new silvercustomer();
            ////c2 is Reference varible of type customer pointing silvercustomer type object 

            //customer c1= new customer();

            customer c2= new silvercustomer();
            Console.ReadLine();

        }
    }
}
