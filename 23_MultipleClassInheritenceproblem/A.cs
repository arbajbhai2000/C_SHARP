using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MultipleClassInheritenceproblem
{
    public class A
    {
         public virtual void print()
        {
            Console.WriteLine("A");
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

    }
}
