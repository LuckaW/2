int n;
bool success;
do
{
    Console.WriteLine(" Zadej číslo Fiboracciho funkce: ");
    string A = Console.ReadLine();
    success = int.TryParse(A, out n);

} while (!success);
int Fiboracci ( int n) // uděláto, že Funkce 3 bude mít číslo vycházejících z Funkcí F1 + F2, F8 bude z F7 + F6
{
    if (n == 1)
    {
        return 1; //toto máme, aby nám funkce nejela do mínusu a znala hranici
    }
    if (n == 0)
    {
        return 0; //toto samé tady. musíme dát první dvě čísla co jsou "akceptovatelnáů. 
    }
    int x = Fiboracci(n - 1); //schválně zadáváme funkci do funkce
    int y = Fiboracci(n - 2);
    return x + y;
}
Console.WriteLine("Výsledek je: " + Fiboracci(n));

long f;
do
{
    Console.WriteLine("Zadej Faktoriál: ");
    string B = Console.ReadLine();
    success = long.TryParse(B, out f);

} while (!success);

long faktorial (long f)
{
    if (f == 1)  // tady stačí mít jen tu podmínku s jedničkou, ale pro sychr si tam te´d nechám nulu (pokud to ale použiju v budoucnu v úkolu, nulu odendat
    {
        return 1;
    }
    if (f == 0)
    {
        return 0;
    }
    long previous = faktorial(f-1);
    return f * previous;
}
Console.WriteLine("Výsledek je: " + faktorial(f));

for (long i = 1; i < 16; i++)      //toto je ukázka toho faktoriálu, aby to bylo co nejpřesnější, používá se u faktoriálnu "long" a ne "int"
{
    Console.WriteLine( i + ": " + faktorial(i));
}
int[]  numbers = new int[] { 5, 6, 88, 0, -1 }; // int[] = pole s jedním polem. vypisuje to jeden údaj
int[,] tictactoe = new int[,] { {1,0,2},
                                {2,5,7},
                                {8,10,-4} };             // int [,] = pole s dvěma poli (tzv. pole v poli). vypisuje to dva údaje
//Jak to funguje:

Console.WriteLine(tictactoe[0, 0]); // první ukazuje řádek - v tomto případě řádek: 1 0 2, druhý ukazuje číslo v řádku - v tomto případě číslo:1
Console.WriteLine(tictactoe[0, 1]); // rádek: 1 0 2, číslo:0
Console.WriteLine(tictactoe[0, 2]); // rádek: 1 0 2, číslo:2
Console.WriteLine(tictactoe[1, 0]); // řádek: 2 5 7, číslo:2
Console.WriteLine(tictactoe[1, 1]); // řádek: 2 5 7, číslo:5
Console.WriteLine(tictactoe[1, 2]); // řádek: 2 5 7, číslo:7
Console.WriteLine(tictactoe[2, 0]); // řádek: 8 10 -4, číslo:8
Console.WriteLine(tictactoe[2, 1]); // řádek: 8 10 -4, číslo:10
Console.WriteLine(tictactoe[2, 2]); // řádek: 8 10 -4, číslo:-4

// toto je zápis ve funkci toho obřího výpisu nad tímto textem:
for (int i = 0; i < tictactoe.GetLength(0); i++)
{
    for (int j = 0; j < tictactoe.GetLength(1); j++)
        Console.WriteLine(tictactoe[i, j]);
}

int[][] insanetictactoe = new int[][] { new[] {1,0,2},   //toto není pole na čtverec či obdélník. Toto pole je cokoliv co my si rozhodnem, že bude. tzv pole polí
                                        new[] {2},
                                        new[] {8,10},
                                        new[] {9,-10,74,18}};

Console.WriteLine("Počet polí v insanetictactoe:");
Console.WriteLine(insanetictactoe.Length);

Console.WriteLine("Počet čísel v poli 0:");
Console.WriteLine(insanetictactoe[0].Length);

//VYGENEROVÁNÍ NÁHODNÝCH ČÍSEL
Random rand = new Random(); // když sem napíšeme nějaké číslo, automaticky se nám to náhodné šíslo bude zobrazovat pořád stejně a nebude se měnit při každým zpuštění programu
int nahoda = rand.Next(100); //číslo, které dáš do závorky k Next ti dá maximální číslo náhody

Console.WriteLine("nahodne čslo:");
Console.WriteLine(nahoda);
Console.WriteLine();

int nahodaSMinimemAMaximem = rand.Next(int.MinValue,int.MaxValue);

//výpis random čísel:

int[] neseřazené = new int[10]; //deset čísel pod sebe

for (int i = 0; i < neseřazené.Length;i++) //dává nám to náhodná čísla
{
    neseřazené[i] = rand.Next(100);
}

Array.Sort(neseřazené); //Array.Sort řadí ty náhodná čísla od nejmenšího po největší

for (int i = 0; i < neseřazené.Length; i++) //musím celé znova přepsat
{
    Console.WriteLine(neseřazené[i]); //tady mi je to vypíše
}