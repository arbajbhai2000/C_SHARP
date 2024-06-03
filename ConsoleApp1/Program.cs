public interface Iarbaj
{
    public void print();
    public void printA()
    {
        Console.WriteLine("hey");
    }
}

public abstract class Akash
{
    public void A()
    {
        Console.WriteLine("Hello boys");
    }

    public abstract void B();
    public void C()
    {
        Console.WriteLine( "From C");
    }

    //public void D() 
    //{

    //    Console.WriteLine("From class Akash D method");
    //}

}


class Ade : Akash
{
   

    public override void B()
    {
        Console.WriteLine("Hello Arbaj");
    }

    public  void Ab()
    {
        Console.WriteLine("From Ade class A method");
    }

    //public void D()
    //{ Console.WriteLine("From ade class Method D"); }
}

class program 
{
    public static void Main(string[] args)
    {
        Akash a = new Ade();  
        //a.C();
        //a.B();
        a.A();

        Console.ReadLine();
    }

    public void print()
    {
        Console.WriteLine("from interface");
    }
}
