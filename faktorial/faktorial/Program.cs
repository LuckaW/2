using System;

Console.WriteLine("Tady se počítají faktorialy:");
bool success;
int x;
while (true)
{
    do
    {
        Console.WriteLine("zadej číslem velikost faktorialu, který chceš:");
        string A = Console.ReadLine();
        success = int.TryParse(A, out x);

    } while (!success);


    int n = x;
    for (int i = n - 1; i > 0; i--)
    {
        n *= i;
    }
    Console.WriteLine(x + "! = " + n);


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