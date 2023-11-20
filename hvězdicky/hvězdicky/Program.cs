// See https://aka.ms/new-console-template for more information

    int a;
    int b;
    bool success;

    do 
    { 
        Console.WriteLine("Napiš, kolik chceš SLOUPCŮ hvězdiček:");
        string A = Console.ReadLine();
        success = int.TryParse(A, out a);
    } while (!success);

    do
    {
        Console.WriteLine("Napiš, kolik chceš ŘÁDKŮ hvězdiček:");
        string B = Console.ReadLine();
        success = int.TryParse(B, out b);
    } while (!success);

for (int i = 0; i < b; i++)
{

    Console.Write("*");

    for (int y = 1; y < a; y++)
    {
        Console.Write("*");

    }
    Console.WriteLine();
}
