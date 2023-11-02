// See https://aka.ms/new-console-template for more information

//Console.ForegroundColor = ConsoleColor.Magenta;
//Console.WriteLine("Tvá osobní kalkulačka :)))");


//Console.ForegroundColor = ConsoleColor.Cyan;
//string pokracovat = "ano";
//while (pokracovat == "ano")
//{

//    int cislo1 = 1;
//    int cislo2 = 1;

//    bool bool1 = false;
//    bool bool2 = false;


//    do
//    {
//        Console.WriteLine("Zadej číslo: ");

//        string nazev1 = Console.ReadLine();
//        bool1 = int.TryParse(nazev1, out cislo1);
//        if (bool1 == false)
//        {
//            Console.Write("!!!!!! ");
//        }


//    } while (!bool1);


//    do
//    {
//        Console.WriteLine("Zadej 2. číslo: ");
//        string nazev2 = Console.ReadLine();
//        bool2 = int.TryParse(nazev2, out cislo2);
//        if (bool2 == false)
//        {
//            Console.Write("!!!!!!! ");
//        }
//    } while (!bool2);

//    string prikaz = "ano";
//    while (prikaz == "ano")
//    {
//        Console.Write("Napiš jakou operaci chceš s čísly provést:");
//        string znamenko = Console.ReadLine();

//        if (znamenko == "+")
//        {
//            Console.WriteLine(cislo1 + cislo2);
//        }
//        else if (znamenko == "-")
//        {
//            Console.WriteLine(cislo1 - cislo2);
//        }
//        else if (znamenko == "*")
//        {
//            Console.WriteLine(cislo1 * cislo2);
//        }
//        else if (znamenko == "/")
//        {
//            Console.WriteLine(cislo1 / cislo2);
//        }
//        else if (znamenko == "^")
//        {
//            Console.WriteLine(cislo1 ^ cislo2);
//        }
//        else if (znamenko == "%")
//        {
//            Console.WriteLine(cislo1 % cislo2);
//        }

//        else

//            Console.WriteLine("Tuhle operaci neznám:((");

//        Console.WriteLine("Chceš provést další operaci s těmito čísly? [ano/ne] ");
//        prikaz = Console.ReadLine();

//    }

//    Console.WriteLine("Přejete si zadat další příklad? [ano/ne]");
//    pokracovat = Console.ReadLine();
//}
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine("Pro dnešek už bylo matiky dost.:)))");





Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Tvá osobní kalkulačka :)))");

int cislo1 = 0;
int cislo2 = 0;

bool bool1 = true;
bool bool2 = false;

while (true)
{
    do
    {
        Console.WriteLine("Zadej číslo: ");

        string nazev1 = Console.ReadLine();
        bool1 = int.TryParse(nazev1, out cislo1);
        if (bool1 == false)
        {
            Console.Write("!!!!!! ");
        }


    } while (!bool1);


    do
    {
        Console.WriteLine("Zadej 2. číslo: ");
        string nazev2 = Console.ReadLine();
        bool2 = int.TryParse(nazev2, out cislo2);
        if (bool2 == false)
        {
            Console.Write("!!!!!!! ");
        }
    } while (!bool2);


    Console.Write("Napiš jakou operaci chceš s čísly provést:");
    string znamenko = Console.ReadLine();

    switch (znamenko)
    {
        case "+":
            Console.WriteLine(cislo1 + cislo2);
            break;
        case "-":
            Console.WriteLine(cislo1 - cislo2);
            break;
        case "*":
            Console.WriteLine(cislo1 * cislo2);
            break;
        case "/":
            Console.WriteLine(cislo1 / cislo2);
            break;
    }


    Console.WriteLine("Chceš zadat nová čísla? [ano/ne] ");
    string volba = Console.ReadLine();
    if (volba == "ne")
    {
        break;
    }

}


//ctrl kd - zarovnávání






////switch (j1)
////{
////    case "+":
////        Console.WriteLine("scitani");
////        break;
////    case
////}


//int hledanysoucet = 100;

//int soucet = 0;

//int cislo = 1;

////for (int i = 0; i < 15; i++)
////{
////    soucet += i;

////}

//while (soucet < hledanysoucet)
//{
//    soucet++;
//    if (soucet >= hledanysoucet)
//    {

//    }

//}
//Console.WriteLine(soucet);
