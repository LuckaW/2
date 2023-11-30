// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;

string[] možnost = new string[] { "čtverec", "obdélník", "trojúelník", "kruh", "pětiuhhelník", "šestiuhelník", "krychle", "kvádr","kužel", "koule" };

static void urcimoznost ( int možnost)
{
    switch (možnost)
    {
        case 0:
            {
              //  printctverec();
                break;
            }

        case 1:
            {
               // printobdelnik();
                break;
            }
        case 2:
            {
              //  printtrojuhelnik();
                break;
            }
        case 3:
            {
                //printkruh();
                break;
            }
        case 4:
            {
               // printpetiuhelnik();
                break;
            }
        case 5:
            {
               // printsestiuhelnik();
                break;
            }
        case 6:
            {
               // printkrychle();
                break;
            }
        case 7:
            {
                //printkvadr();
                break;
            }
        case 8:
            {
                //printkuzel();
                break;
            }
        case 9:
            {
               // printkoule();
                break;
            }
        default: 
            {
                Console.WriteLine("Zvolil sis špatně. Čti co píšu. možnost je 1-9!");
                break;
            }
    }
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




