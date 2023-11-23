// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

int[] array = new int[] { 4, 18, 12, 6, -4, 5 };
//najít v tom maximum (maximum)
int FindMax(int[] array)
{
    int Max = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
       // toto bere postupně každé číslo v naší řadě a když to nové je větší, než to předchozí, vystřídá ho. pokud není, ignoruje ho a pokračuje. To je důvod, proč nám to vyhodí největší číslo.
        if (array[i] > Max) 
        {
            Max = array[i];
            
        }
    }
    return Max;
}
//tato druhá funkce je na index toho největšího čísla (maximumIndex)
int FindMaxIndex(int[] array)
{
    int Max = 0;
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] > Max)
        {
            Max = array[i];
            maxIndex = i;
        }
    }
    return maxIndex;
}

int maximum = FindMax(array);
int maximumIndex = FindMaxIndex(array);
//vypsání obou (maximum i maximumIndex)
Console.WriteLine("Maximum " + maximum + " má index " + maximumIndex);
// toto ti vypíše všechna čísla v dané funkci. pokud to chceš nějak omezit (větší než... menší než..) házíš to už do závorek ve foreach (ne na jeho začáteční Imperior závorku)
foreach (int num in array) //imerior závorka
{
    //toto je omezeni výpisu z dané funkce (v tomto případě vše co jevětší jak 10)
    if (num > 10)
    {
        Console.WriteLine(num);
    }
}


//uděláme funkci co pozdravý uživatele
Console.WriteLine("aké je tvoje jméno?");
string name = Console.ReadLine();
void Greetuser(string name)
{
    Console.WriteLine("Čuuuuus " + name + "!");
}

//když chceme nějak změnit jeho jméno? ASI?

void Greetuser2(string name = "default user");
{
    Console.WriteLine("Čuuuuus " + name +"!");
}

// jeden z různých měničů funkci = modyfierů
//static: - nebere výrazy odjinud, než jen ze své funkce, pokud by name bylo jinde, než v té funkci, tak funkce se static by ho nevzala

static void Geetuser3(string name = "default user");
{
    Console.WriteLine("Čuuuuus " + name + "!");
}


// K ÚKOLU = TOTO JE ZAČÁTEK ABYCHOM VŠE NEVYPISOVALI
string[] options = new string[] { "čtverec", "trojúelník" };
int vybralsi = Geselection(options);

switch (vybralsi)
{
    case 1:
        {
            printSquare();
            break;
        }

    case 2: 
        {
            printtriangle();
            break;
        }
}