// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;

float první(float x) //int pro celá čísla, float pro necelá čísla
{
    return x + 1;
}
Console.WriteLine("f = x + 1");

float x = 3;
Console.WriteLine(" Dej sem jakékoliv číslo pro x: ");
string cislo1uzivatel = Console.ReadLine();
float.TryParse(cislo1uzivatel, out x);

float y = první(x);

Console.WriteLine("y = " + y);


//float PrintNumber(float number) 
//{
// Console.WriteLine(number);
//  return number;
//}

//float x = 3.14f;

float druhý(float a) 
{
    return a + 1;
}

float a = 3;

float b = druhý(a);


float maximum(float a, float b)
{

    
    if (a>b)
    {
        
        Console.WriteLine("f = " + a);
        return a;
    }
   else if (b>a)
    {
        
        Console.WriteLine("f = " + b);
        return b;
    }
    else 

    {
       
        Console.WriteLine("f = " + b);
        return b;
    }
    
}

bool AreSame (float x, float y)
{
    if (x == y)
    {
        return true;
    }
    else
    {
        return false;

    }
}


Console.WriteLine("Napiš číslo a já ti ukážu jaký sis doopravdy myslel:");
Console.ReadLine();
float nemanavybranou()
{

    return 21;

}

float z = nemanavybranou();
Console.WriteLine("Je to " + z + ". tak to prostě je. Já tak rozhodl. To sis myslel. Smiř se s tím.");

string VstupOdUzivatele()
{
    Console.WriteLine("Jak jde život?");
    string imput = Console.ReadLine();
    return imput;
}
string vstup = VstupOdUzivatele();
Console.WriteLine(vstup);
