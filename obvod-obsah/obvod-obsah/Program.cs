// See https://aka.ms/new-console-template for more information


using System;
using System.Security.Cryptography.X509Certificates;
while (true)
{
    string[] možnost = new string[] { "čtverec", "obdélník", "trojúelník", "kruh", "pětiuhhelník (pravidelný)", "šestiuhelník (pravidelný)","n - úhelník", "krychle", "kvádr", "kužel", "koule" };

    void urcimoznost(int možnost)
    {
        switch (možnost)
        {
            case 0:
                {
                    printctverec();
                    break;
                }

            case 1:
                {
                    printobdelnik();
                    break;
                }
            case 2:
                {
                    printtrojuhelnik();
                    break;
                }
            case 3:
                {
                    printkruh();
                    break;
                }
            case 4:
                {
                    printpetiuhelnik();
                    break;
                }
            case 5:
                {
                    printsestiuhelnik();
                    break;
                }
            case 6:
                {
                    printnuhelnik();
                    break;
                }
            case 7:
                {
                    printkrychle();
                    break;
                }
            case 8:
                {
                    printkvadr();
                    break;
                }
            case 9:
                {
                    printkuzel();
                    break;
                }
            case 10:
                {
                    printkoule();
                    break;
                }
            default:
                {
                    Console.WriteLine("Zvolil sis špatně. Čti co píšu. možnost je 1-10!");
                    break;
                }
        }
    }
   
    Console.WriteLine("Vyber si obrazec a napiš jeho číslo:");
    for (int i = 0; i < možnost.Length; i++)
    {
        Console.Write(i + " ");
        string obrazec = možnost[i];
        Console.WriteLine(obrazec);
    }

    int vybralsi()
    {
        bool success;
        int x;
        do
        {
            success = int.TryParse(Console.ReadLine(), out x);
        } while (!success);
        return x;
    }
    urcimoznost(vybralsi());
    double zadejcislo()
    {
        for (; ; )
        {
            Console.WriteLine("Zadej kladné číslo:");

            if (int.TryParse(Console.ReadLine(), out int cislo))
            {
                if (cislo > 0)
                {
                    return cislo;
                }
            }
        }
    }


    double a;
    void printctverec()
    {
        Console.WriteLine("Zvolil jsi si čtverec.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        double obvod = a * 4;
        double obsah = a * a;
        Console.WriteLine("Obvod: " + obvod + " cm");
        Console.WriteLine("Obsah: " + obsah + " cm2");

    }
    double b;
    void printobdelnik()
    {
        Console.WriteLine("Zvolil jsi si obdélnik.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Zadej délku strany 'b' v cm:");
        double.TryParse(Console.ReadLine(), out b);
        double obvod = (2 * a) + (2 * b);
        double obsah = a * b;
        Console.WriteLine("Obvod: " + obvod + " cm");
        Console.WriteLine("Obsah: " + obsah + " cm2");
    }
    double c;
    void printtrojuhelnik()
    {
        Console.WriteLine("Zvolil jsi si trojúhelník.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Zadej délku strany 'b' v cm:");
        double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine("Zadej délku strany 'c' v cm:");
        double.TryParse(Console.ReadLine(), out c);
        double obvod = a + b + c;
        double obsah = (a * b) / 2;
        Console.WriteLine("Obvod: " + obvod + " cm");
        Console.WriteLine("Obsah: " + obsah + " cm2");
    }
    double r;
    void printkruh()
    {
        Console.WriteLine("Zvolil jste si kruh.");
        Console.WriteLine("Zadej poloměr kruhu 'r' v cm:");
        double.TryParse(Console.ReadLine(), out r);
        double obvod = 2 * r * Math.PI;
        double obsah = Math.Pow(r, 2) * Math.PI;
        Console.WriteLine("Obvod: " + obvod + " cm");
        Console.WriteLine("Obsah: " + obsah + " cm2");
    }
    void printpetiuhelnik()
    {
        Console.WriteLine("Zvolil jste si pětiúhelník.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        double obvod = 5 * a;
        double obsah = (5 * Math.Pow(a, 2) / 4) * 1 / Math.Atan(Math.PI / 5);
        Console.WriteLine("Obvod: " + obvod + " cm");
        Console.WriteLine("Obsah: " + obsah + " cm2");
    }
    void printsestiuhelnik()
    {
        Console.WriteLine("Zvolil jste si šestiúhelník.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        double obvod = 6 * a;
        double obsah = ((6 * Math.Pow(a, 2)) / 4) * 1 / Math.Atan(Math.PI / 6);
        Console.WriteLine("Obvod: " + obvod + " cm");
        Console.WriteLine("Obsah: " + obsah + " cm2");
    }
    void printkrychle()
    {
        Console.WriteLine("Zvolil jste si krychli.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        double povrch = 6 * Math.Pow(a, 2);
        double objem = Math.Pow(a, 3);
        Console.WriteLine("Objem: " + objem + " cm3");
        Console.WriteLine("Povrch: " + povrch + " cm2");
    }
    void printkvadr()
    {
        Console.WriteLine("Zvolil jste si kvádr.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Zadej délku strany 'b' v cm:");
        double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine("Zadej délku strany 'c' v cm:");
        double.TryParse(Console.ReadLine(), out c);
        double povrch = (2 * a * b) + (2 * b * c) + (2 * a * c);
        double objem = a * b * c;
        Console.WriteLine("Objem: " + objem + " cm3");
        Console.WriteLine("Povrch: " + povrch + " cm2");
    }
    double d;
    double h;
    void printkuzel()
    {
        Console.WriteLine("Zvolil jste si kužel.");
        Console.WriteLine("Zadej průměr kruhu 'd' v cm:");
        double.TryParse(Console.ReadLine(), out d);
        Console.WriteLine("Zadej výšku kuželu 'h' v cm:");
        double.TryParse(Console.ReadLine(), out h);
        double p = Math.Sqrt((Math.Pow(d, 2) / 4) + Math.Pow(h, 2));
        double povrch = (Math.PI * d / 4) * (d + (2 * p));
        double objem = (Math.PI * Math.Pow(d, 2) * h) / 12;
        Console.WriteLine("Objem: " + objem + " cm3");
        Console.WriteLine("Povrch: " + povrch + " cm2");
    }
    void printkoule()
    {
        Console.WriteLine("Zvolil jste si kouli.");
        Console.WriteLine("Zadej poloměr kruhu 'r' v cm:");
        double.TryParse(Console.ReadLine(), out r);
        double povrch = 4 * Math.PI * Math.Pow(r, 2);
        double objem = (4 * Math.PI * Math.Pow(r, 3)) / 3;
        Console.WriteLine("Objem: " + objem + " cm3");
        Console.WriteLine("Povrch: " + povrch + " cm2");
    }
    int n;
    void printnuhelnik()
    {
        Console.WriteLine("Zvolil jste si n-úhelník.");
        Console.WriteLine("Zadej délku strany 'a' v cm:");
        double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Zadej počet stran 'n':");
        int.TryParse(Console.ReadLine(), out n);
        double obvod = n * a;
        double obsah = (n * Math.Pow(a, 2) / 4) * 1 / Math.Atan(Math.PI / n);
        Console.WriteLine("Obvod: " + obvod + " cm");
        Console.WriteLine("Obsah: " + obsah + " cm2");
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

