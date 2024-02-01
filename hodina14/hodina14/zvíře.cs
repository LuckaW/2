

public class animal
{
    public string Name;
    public string Type;
    
    public void pozdrav()
    {
        Console.WriteLine("Hellooo " + Name);
    }
   /* public void promluv()
    {
        Console.WriteLine("Co chceš, aby " + Name + " řekl?");
        string blabla = Console.ReadLine();
        Console.WriteLine(Name + ": " + blabla);
    }*/
   
    public void mluv()
    {
       
        if (Type == "pes")
        {
            Console.WriteLine("Haf haf");
        }
        if (Type == "kocka")
        {
            Console.WriteLine("Mňaaauuuu");
        }
    }
    public animal (string jmeno, string typ)
    {
        Name = jmeno;
        Type = typ;
    }
    
}

public class bird : animal
{
    public bird(string jmeno, string typ) : base(jmeno, typ)
    {
        
    }
    public void mluv()
    {
        Console.WriteLine("Píp píp");
    }
}
