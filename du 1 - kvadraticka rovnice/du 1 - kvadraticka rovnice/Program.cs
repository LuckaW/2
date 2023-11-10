// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net.Security;

Console.WriteLine("Tady se řeší kvadratická rovnice.");

double a, b, c, i, y;
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


void prvnix(double a, double b, double c, double mocninab)
{
    for (double i = ((-b) - (Math.Sqrt(mocninab - 4 * a * c))) / (2 * a);;)
    {
        
        
     
    }
}



void druhyx( double a, double b, double c, double mocninab) 
{
    for (double y = ((-b) + Math.Sqrt(mocninab - 4 * a * c)) / (2 * a); ;)
    {
       
        

    }
}

Console.WriteLine($" x1 je {prvnix}. x2 je {druhyx}");
