// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

Console.WriteLine("Tady se řeší kvadratická rovnice.");

float a, b, c, i, y;
bool success;


Console.WriteLine(" rovnice je a * x^2 + b * x + c = 0: ");

do
{
    Console.WriteLine(" Zadej a: ");
    string A = Console.ReadLine();
    success = float.TryParse(A, out a);
    
} while (!success);
do
{
    Console.WriteLine(" Zadej b: ");
    string B = Console.ReadLine();
    success = float.TryParse(B, out b);

} while (!success);
do
{
    Console.WriteLine(" Zadej c: ");
    string C = Console.ReadLine();
    success = float.TryParse(C, out c);

} while (!success);

float mocninab = Math.Pow(b, 2);


float prvnix()
{
    for (float i = ((-b) - (Math.Sqrt(mocninab - 4 * a * c))) / (2 * a)) 
    {
        if (i = 0) 
        {
                          Console.WriteLine("Rovnice nemá řešení.")
        }
    }

}



float druhyx() 
{
    for (float y = ((-b) + (Math.Sqrt(mocninab - 4 * a * c))) / (2 * a)) 
    {
        if (y = 0) 
        {
                           Console.WriteLine("Rovnice nemá řešení.");
        }

    }

}

Console.WriteLine(" x1 je " + i ". x2 je " + y);