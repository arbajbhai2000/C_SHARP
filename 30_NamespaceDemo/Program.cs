using System;   //to import namespace

class program
{
    static void Main()
    {
        Console.WriteLine("hello");

        silvercustomer sc=new silvercustomer();
        sc.details();

        savingscustomer sc1=new savingscustomer();
        sc1.details();
        Console.ReadLine();
    }
}
class silvercustomer
{
    public void details()
    {
        Console.WriteLine("silver customer");
    }
}
class savingscustomer
{
    public void details()
    {
        Console.WriteLine("savings customer");
    }
}