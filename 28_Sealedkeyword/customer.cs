using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Sealedkeyword
{
    //public sealed class customer
    public class customer
    {
        public virtual void print()
        {
            Console.WriteLine("customer print");

        }
    }
    public class silvercustomer : customer
    {
        public sealed override void print()
        {
            Console.WriteLine("silver customer");
        }
    }
    public class advancedsilvercustomer : silvercustomer
    {
        public override void print()    //due to sealed advance class cannot override 
        {
            Console.WriteLine("advanced silver customer");
        }
    }
    // public class Student { } // normal class
    // public static class Student { } // static class
    // public abstract class Student { } // abstract class
    // public static abstract class Student { } // static & abstract at same time not possible
    // public sealed class Student { } // sealed class
    // public static sealed class Student { } // static & sealed at same time not possible
}
