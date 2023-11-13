// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net.Security;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
Console.WriteLine("Tady se řeší kvadratická rovnice.");


//odtud počítání x
while (true)
{


    double a, b, c;
    bool success;
    Console.WriteLine(" rovnice je a * x^2 + b * x + c = 0: ");

    do
    {
        Console.WriteLine(" Zadej a: ");
        string A = Console.ReadLine();
        success = double.TryParse(A, out a);

    } while (!success);
    do
    {
        Console.WriteLine(" Zadej b: ");
        string B = Console.ReadLine();
        success = double.TryParse(B, out b);

    } while (!success);
    do
    {
        Console.WriteLine(" Zadej c: ");
        string C = Console.ReadLine();
        success = double.TryParse(C, out c);

    } while (!success);

    double mocninab = Math.Pow(b, 2);

   
    
        double D;

        double prvnix()
        {
            return ((-b) - Math.Sqrt(D)) / (2 * a);

        }

        double druhyx()
        {
            return ((-b) + Math.Sqrt(D)) / (2 * a);

        }



        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("x má nekonečně mnoho řešení.");
        }
        else
        {

            while (a == 0)
            {
                Console.WriteLine("'a' se nemůže rovnat nule přeci. Koukni jakou rovnici počítáš.");
                do
                {
                    Console.WriteLine(" Zadej a: ");
                    string A = Console.ReadLine();
                    success = double.TryParse(A, out a);

                } while (!success);
            }
            D = mocninab - 4 * a * c;
            if (D < 0)
                {
                    Console.WriteLine("Rovnice nemá řešení.");
                }
                else if (D == 0)
                {
                    Console.WriteLine("x = " + prvnix());
                }

                else
                {

                    Console.WriteLine($" x1 je {prvnix()}. x2 je {druhyx()}");
                }
            

        } 

    

    //odtud dosazování x
    double x;
    while (true)
    {
        Console.WriteLine("Pro parametr 'x' zadejte hodnotu, nebo napište 'stop' a ukončete počítání:");
        string odpoved = Console.ReadLine();

        if (odpoved == "stop")
        {
            break;
        }
        if (double.TryParse(odpoved, out x))
        {
            Console.WriteLine(a + x + "^2 + " + b + x + " + " + c + " = " + c);
        }
        else
        {
            Console.WriteLine("To fakt číslo není... zkus znova.");
        }
    }
    while (true)
    {
        Console.WriteLine("Chceš opakovat program? ano/ne");
        string finale = Console.ReadLine();
        if (finale == "ano")
        {
            break;
        }
        if (finale == "ne")
        {
            Environment.Exit(0);

        }
        Console.WriteLine("Nechceš napsat obyčejný ano/ne? Smůla. To ti nedovolím.");
        
    }

}