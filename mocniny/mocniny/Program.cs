using System;

while (true)
{
    Console.WriteLine("Budeme počítat mocninu:");
    int z;
    bool success;
    do
    {
        Console.WriteLine("Zadej základ: ");
        string Z = Console.ReadLine();
        success = int.TryParse(Z, out z);
    } while (!success);
    int e;
    do
    {
        Console.WriteLine("Zadej exponent: ");
        string E = Console.ReadLine();
        success = int.TryParse(E, out e);

    } while (!success);

    Console.WriteLine(z + " na " + e + " je " + Math.Pow(z, e));
    int Od;
    do
    {
        Console.WriteLine("Teď se ukáží mocniny od čísla: ");
        string od = Console.ReadLine();
        success = int.TryParse(od, out Od);
    } while (!success);
    int Do;
  
    do
    {
        Console.WriteLine("Do čísla: ");
        string DO = Console.ReadLine();
        success = int.TryParse(DO, out Do);
    } while (!success);
    int ex;
    do
    {
        Console.WriteLine("Zadej exponent: ");
        string Ex = Console.ReadLine();
        success = int.TryParse(Ex, out ex);

    } while (!success);

    for (int i = Od; i <= Do; i++)
    {
        Console.WriteLine(i + " na " + ex + " = " + Math.Pow(i, ex));
    } 

    while (true)
    {
        Console.WriteLine("Chceš opakovat program? Napiš ano/ne:");
        string odpoved = Console.ReadLine();

        if (odpoved == "ano")
        {
            break;
        }
        if (odpoved == "ne")
        {
            Environment.Exit(0);
        }

        else
        {
            Console.WriteLine("To fakt není ano/ne... zkus znova.");
        }
    }
}

