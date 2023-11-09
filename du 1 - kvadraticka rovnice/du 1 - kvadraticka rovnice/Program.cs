// See https://aka.ms/new-console-template for more information
using System;

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

float Sqrt(4 * a * c)
{


  
    void prvnikrok(float[] a, float[] b, float[] c)
    {
        for (float i = ((-b) * Sqrt) / 2 * a)
        {
            prvnikrok([i]);
        }

    }


    
    void druhykrok(float[] a, float[] b, float[] c)
    {
        for (float y = ((b) * Sqrt) / 2 * a)
        {
            druhykrok([y]);
        }

    }
}
Console.WriteLine(" x1 je " + i ". x2 je " + y);