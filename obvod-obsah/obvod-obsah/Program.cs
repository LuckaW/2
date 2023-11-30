// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;

string[] možnost = new string[] { "čtverec", "obdélník", "trojúelník", "kruh", "pětiuhhelník", "šestiuhelník", "krychle", "kvádr","kužel", "koule" };

static void urcimoznost ( int možnost)
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
                printkrychle();
                break;
            }
        case 7:
            {
                printkvadr();
                break;
            }
        case 8:
            {
                printkuzel();
                break;
            }
        case 9:
            {
                printkoule();
                break;
            }
        default: 
            {
                Console.WriteLine("Zvolil sis špatně. Čti co píšu. možnost je 1-9!");
                break;
            }
    }
}
int Index (string []moznost)
{ 

}
Console.WriteLine("Vyber si obrazec a napiš jeho číslo:");
foreach ( string obrazec in možnost) 
{
    Console.WriteLine( obrazec );
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
int zadejcislo()
{
    for (; ; )
    {
        Console.WriteLine("Zadej kladné číslo:");
        
        if(int.TryParse(string cislo = Console.ReadLine(),))
        {
            if (cislo > 0)
            {
                return cislo;
            }
        }
    }
}


/*int a;
int printctverec()
{
    Console.WriteLine("Zvolil jsi si čtverec.");
    Console.WriteLine("Zadej délku strany 'a':")
        int.TryParse(Console.ReadLine(), out a);
    int obvod = a * 4;
    int obsah = a * a;
    Console.WriteLine("Obvod: " + obvod);
    Console.WriteLine(¨"Obsah: " + obsah);

}
int b;
int printobdelnik()
{ 
    Console.WriteLine("Zvolil jsi si obdélnik.");
    Console.WriteLine("Zadej délku strany 'a':");
    int.TryParse(Console.ReadLine(), out a);
    Console.WriteLine("Zadej délku strany 'b':");
    int.TryParse(Console.ReadLine(), out b);
    int obvod = (2 * a) + (2 * b);
    int obsah = a * b;
    Console.WriteLine("Obvod: " + obvod);
    Console.WriteLine(¨"Obsah: " + obsah);
}
int c;
int printtrojuhelnik()
{
    Console.WriteLine("Zvolil jsi si trojúhelník.");
    Console.WriteLine("Zadej délku strany 'a':");
    int.TryParse(Console.ReadLine(), out a);
    Console.WriteLine("Zadej délku strany 'b':");
    int.TryParse(Console.ReadLine(), out b);
    Console.WriteLine("Zadej délku strany 'c':");
    int.TryParse(Console.ReadLine(), out c);
    int obvod = a + b + c;
    int obsah = (a * b) / 2;
    Console.WriteLine("Obvod: " + obvod);
    Console.WriteLine(¨"Obsah: " + obsah);
}  
int printkruh()
{
    Console.WriteLine("Zvolil jste si kruh.");
}
int printpetiuhelnik()
       {
    Console.WriteLine("Zvolil jste si pětiúhelník.");
       }
int printsestiuhelnik()
       {
        Console.WriteLine("Zvolil jste si šestiúhelník.");
       }
int printkrychle()
       {
        Console.WriteLine("Zvolil jste si krychli.");
       }
int printkvadr()
       {
        Console.WriteLine("Zvolil jste si kvádr.");
}
int printkuzel()
       {
        Console.WriteLine("Zvolil jste si kužel.");
       }
int printkoule()
       {
        Console.WriteLine("Zvolil jste si kouli.");
       }
*/


