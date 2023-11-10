// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net.Security;

Console.WriteLine("Tady se řeší kvadratická rovnice.");

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

if (a == 0)
{
    Console.WriteLine("Rovnice nemá řešení.");

}
else if (b == 0 && c == 0)
{
    Console.WriteLine("Rovnice má nekonečno řešení.");
}
else  
{
    double D = mocninab - 4 * a * c;

    double prvnix()
    {
        return (-b) - Math.Sqrt(D) / (2 * a);

    }



    double druhyx()
    {
        return (-b) + Math.Sqrt(D) / (2 * a);

    }
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