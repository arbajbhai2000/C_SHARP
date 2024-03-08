using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Arbaj";
            Console.WriteLine(name);

            name = "    arbaj";
            Console.WriteLine(name);

            name = "    arbaj    ";
            Console.WriteLine(name.Trim());

            name = "novfil";
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());

            name = "\"arbaj\"";
            Console.WriteLine(name);

            name = "\'arbaj\'";
            Console.WriteLine(name);

            name = "arbaj mujawar";
            Console.WriteLine(name);

            Console.WriteLine("arbaj\nmujawar");
            Console.WriteLine("arbaj\tmujawar");

            string path = @"C:\DOT NET\C# lect\github code\B22CSharpDemos-master";
            Console.WriteLine(path);

            string firstname = "arbaj";
            string lastname = "mujawar";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);

            fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);

            fullname = string.Concat(firstname, " ", lastname);
            Console.WriteLine(fullname);

            string middlename = "jalaluddin";
            Console.WriteLine(middlename);

            fullname = string.Concat(firstname," ", middlename," ", lastname);
            Console.WriteLine(fullname);

            Console.WriteLine(fullname.ToUpper());

            fullname = string.Join(" ", firstname, middlename, lastname);
            Console.WriteLine(fullname);

            fullname = string.Format("fullname:{0} {1} {2}", firstname, middlename, lastname);
            Console.WriteLine(fullname);

            fullname = $"fullname : {firstname} {middlename} {lastname}";
            Console.WriteLine(fullname);

            fullname=$"surname : {lastname}";
            Console.WriteLine(fullname);

            Console.ReadLine();






        }
    }
}
