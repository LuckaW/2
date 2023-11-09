// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;


//int a = 8;
//int b = 6;
//int c = sum(a, b);


int sum (ref int a, int b, ref int c)
{
    a = 7;
    c = a - b;
    return a + b;
}


Console.WriteLine();

int a = 8;
int b = 6;
int c = 0;
Console.WriteLine(a);
Console.WriteLine(c);
int d = sum(ref a, b, ref c);
Console.WriteLine(a);
Console.WriteLine(c);

Console.WriteLine();



// eri/pole - pro proměnné - použij na ukol ke kvadratičce, eri = []
int[] cisla = { 1, 2, 3 };
//int[] cislo2 = new int[] { 1, 2, 3 }; 
//int[] cislo3 = new int[10];

float[] floats = new float[10];

Console.WriteLine(cisla[1]); //počítače číslují od nuly, takže při spuštění se ukáže dvojka - u int cisla je totiž podle počítače na prvním místě

//udělát funkci PrintArray (jen nazev) která bude vypisovat všechna čisla
// void - nutí funkci nic nevracet

Console.WriteLine();



void PrintArray(int[] array)
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write(array[i]);
    }
}
Console.WriteLine();
int[] numbers = { 1, 2, 3, 4 }; // program to vypíše do trojky, i když máme ve funkci zapsané pod trojku, protože nepočíta od jedničky ale od nuly, takže nula je 1, jedna je 2, dva je 3



Console.WriteLine();


void PA (int[] array2)
{
    for (int i = 0;i < array2.Length;i++) 
    {
        Console.Write(array2[i]);
    }
}
Console.WriteLine();
int[] numb = { 1, 2, 3, 4 };



Console.WriteLine();

//logika vypisovaní neznamich
int j = 4;
int q = j;
j = 6;
//tady se ukaže, co se objevy prvni za ciso
Console.WriteLine(j);
Console.WriteLine(q);

Console.WriteLine();


int[] numbers2 = numbers;
PrintArray(numbers);
PrintArray(numbers2);



PrintArray(numbers);
numbers[0] = 6;
PrintArray(numbers);





void ChangeFirst(int[] array, int newValue)
{
    array[0]  = newValue;
}

PrintArray(numbers);
PrintArray(numbers2);
//ukázka array na mem papíře

void PPolynomial(int[] coefficient)
{
    //6x^5 + 4x^4 + 48x^3...
    for (int i = 0; i < coefficient.Length; i++)
    {
        Console.Write(coefficient[i] + " x ^ " + (coefficient.Length - i - 1) + " + " );
    }
}
int[] coefficient = new int[] { 6, 4, 48, -4, 4, -1 };
Console.WriteLine();
PPolynomial(coefficient);
//Console.Write(coefficient[0] + "x^5" + coefficient[1] + "x^4" + coefficient[2] + "x^3" + coefficient[3] + "x^2" + coefficient[4] + "x" + coefficient[5]);