using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Methodoverriding_questions
{
    public class A
    {
        public virtual void print()
        {
            Console.WriteLine("a");
        }
    }
    public class B:A
    {
        public override void print()
        {
            Console.WriteLine("B");
        } 
    }
    public class C:B
    {
        public override void print()
        {
            Console.WriteLine("C");
        }


    }
}
