// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tady se řeší kvadratická rovnice.");

float a, b, c;
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


