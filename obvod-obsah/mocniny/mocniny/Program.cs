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