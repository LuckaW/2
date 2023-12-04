
using System;


int x;
Console.WriteLine("Co si myslím za číslo?(1-100)");


int nejnizsi = 1;
int nejvyssi = 100;
Random cislo = new Random();
int n = cislo.Next(nejnizsi, nejvyssi);
do
{
    string X = Console.ReadLine();
    int.TryParse(X, out x);
    if (n < x)
    {
        Console.WriteLine("Číslo je nižší.");

    }
    else if (n > x)
    {
        Console.WriteLine("Číslo je vyšší.");
    }
    else
    {
        break;
    }
} while (x!=n);
Console.WriteLine("Ano! Číslo je " + n);
