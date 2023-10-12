// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// toto je můj komentář a ne část kódu. Sem si můžu napsat jakoukoliv kravinu chci.
int x; //toto je integer, což je pro CELÉ číslo
x = 2;
int y;
y = 3;
double procento = 0.42; //double je pro číslo s desetinou čárkou. to procento je jako v minulém případě "X" nebo "Y"

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(procento);
/*
 * Toto je víceřádkový komentář. Dobrý jo znát. Pozor ať ho nezapomeneš ukončit
 */
string name = "Lucka"; //pro psání textu je "string name".
Console.WriteLine(name);
Console.WriteLine("Hallo" + name);
Console.WriteLine("Hallo, {0}", name);   // tu divnou závorku uděláš pravým alt a pak G a N

int number1 = 42; 
int number2 = 24;

Console.WriteLine(number1 + number2);   //toto ti nakonec zobrazí jen výsledek
Console.WriteLine(number1 - number2);
Console.WriteLine(number1 * number2);
Console.WriteLine(number1 / number2);


Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2); // s tímhle se při zpuštění ukáže celý příklad
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 / number2);

//a teď lehčí možnost jak udělat výpočet, kde se ukáže celý příklad
// dolar: altrGr + ů

Console.WriteLine($"{number1} / {number2} = {number1 / number2}");

//přidat výsledek do proměnné je:
int result = number1 + number2;

// když si to zobrazíme, vidíme, že 42/24 nám výjde , protože tomu nedovolujeme desetinné čásrky. Proto místo intelu pouijeme double...
// lépe. dáme výsledek do doubleu
//když to měníme, musí mít result jiné číslo, aby se to nepletlo s tím minulím resultem
double result2 = number1 / number2;
  
// desetinné číslo
double number3 = 42;
double number4 = 24;

// z doubleu do intelu
double result3 = number3 / number4;
Console.WriteLine(result3);

//explicitní přetypování proměnné
int result3Int = (int)result3;
Console.WriteLine(result3Int);

//implicitní přetypování proměnné

/*a jde se na výroky... ty opisovat nemusím, budou v disc
 * || se udělá levým shift a ihned znaku vedle něj (v pravém horním rohu to má hvězdičku)
 * & vznikne altGr + c
 * # vznikne altGr + x
 * == je porovnání
*/
bool bool1 = true;
bool bool2 = false;

Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);
Console.WriteLine("{0} || {1} = {2}", bool1, bool2, bool1 || bool2);
Console.WriteLine("{0} = {1}", bool1, bool2);

int cislo = 7;
Console.WriteLine("{0} == 7 -> {1}", cislo, cislo == 7);
bool isCisloCisloSeven = cislo == 7;
Console.WriteLine(isCisloCisloSeven);


Console.WriteLine("What's your name?");
string jmeno = Console.ReadLine();
Console.WriteLine($"Hello, {jmeno}!");

string cisloOdUzivatele = Console.ReadLine();
int cisloProcessed;
bool succes = int.TryParse(cisloOdUzivatele, out cisloProcessed);

Console.WriteLine($"succes = {succes}.");
Console.WriteLine(cisloProcessed + 3);
if (succes == true)
{ 
    Console.WriteLine("spravne cislo");
}
else
{
    Console.WriteLine("Toto není správné číslo");
}


