public class kniha : Produkt
{
    public string autor;
    public void ZobrazInfo()
    {
        Console.WriteLine(Jméno);
        Console.WriteLine(Cena);
        Console.WriteLine(autor);
    }
}