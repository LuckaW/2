// See https://aka.ms/new-console-template for more information
using System.Net.Security;

Console.WriteLine("Hello, World!");

 // pprocento je "modulo"
for (int  x = 0; x <= 20; x++)

{
    Console.Write(x);
    Console.Write(" ");
    Console.WriteLine(x % 3);

}

Console.WriteLine(" ");

for (int i = 1; i <= 20; i++)
{
    if (i % 4 == 0) 
    {
        Console.WriteLine("StrawBerry");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 2 == 0)
    {
        Console.WriteLine("Berry");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine(" ");
int sum = 0;
for (int v = 1; v <= 20; v++)
{
    sum = sum + v;
}
Console.WriteLine(" ");

int c = 0;
int c0 = 0;

Console.WriteLine(" Zdej první celé číslo: ");
string cislo1uzivatel = Console.ReadLine();
int.TryParse(cislo1uzivatel, out c);

Console.WriteLine("Zadej druhé celé číslo: ");
string cislo2uzivatel = Console.ReadLine();
int.TryParse(cislo2uzivatel, out c0);

Console.WriteLine("");

Console.WriteLine("Zvol Operaci +,- nebo *,/");

string vyber = Console.ReadLine();

if (vyber == "+")
{
    Console.WriteLine("{0} + {1} = {2}", c,c0, c + c0);
}
else if (vyber == "-")
{
    Console.WriteLine("{0} - {1} = {2}",c, c0, c - c0);
}
else if (vyber == "*")
{
    Console.WriteLine("{0} * {1} = {2}", c, c0, c * c0);
}
else if (vyber == "/")
{
    Console.WriteLine("{0} / {1} = {2}", c, c0, c / c0);
}
