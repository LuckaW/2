// See https://aka.ms/new-console-template for more information
Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine("Enter password.");



string password = Console.ReadLine();

if (password == "1234")  //po if se NIKDY NEPÍŠE STŘEDNÍK
{

    Console.WriteLine("You suck at imagination -_-");
}
else
{

    Console.WriteLine("Wrong password. Be better.");
}

Console.WriteLine("welp... could you at least tell me your name?");
string name = Console.ReadLine();
Console.WriteLine("Sup " + name); Console.WriteLine("Now I'm goona count how many braincells you have. :)");

//toto je pro postupné psaní. kdybych napsala místo "i" slovo "text" (v tom Console.WriteLine), hodí mi to desetkrát pod sebou slovo text
for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Ups... can't find more.");

Console.WriteLine("And now something hard for you. Counting +4.");

int number = 0;
while (number < 43)
{

    Console.WriteLine(number);
    //všechno jsou to identické zápisy
    number = number + 2;
    number += 1;
    number++;
}

//cyklus while je stejné jako for, ale do a while má dohromady kontrolu podmínky až na konci a proto to funguje jinak
Console.WriteLine("From now on, ignore me. You will not understand it.");

Console.WriteLine("Cyklus do a while:");
int otherNumber = 0;
do
{
    //cyklus vždy proběhne alespoň jednou
    Console.WriteLine(otherNumber);
    otherNumber = otherNumber + 1;

    //podmínka se kontroluje až teď

} while (otherNumber < 5);

Console.WriteLine("You know what? Come back and enter here some number.");

string numInterationsString = Console.ReadLine();

int numInteractions = 0;
//převedu string na speciální funkci / + poku dchci podmínku přidám bool succes =
bool succes = int.TryParse(numInterationsString, out numInteractions);
//převedené číslo mohu použít / + pokud chci udělat podmínku přidam Writeline suceces = succes
Console.WriteLine("Look! For once you made it right! You've gotten " + succes);
for (int i = 0; i < numInteractions; i = i + 1)
{
    Console.WriteLine(i);
     
}


do
{
    Console.WriteLine("Okey... time for bonding moment. What is your favorite number?");
   
    string numinteractionsString = Console.ReadLine();
    int numinteractions;
    bool ok = int.TryParse(numinteractionsString, out numinteractions);
    Console.WriteLine("Sorry I don't want this to be " + ok);



} while (false);

do
{
    Console.WriteLine("Choose 21!");
    string randomcisloString = Console.ReadLine();
    int randomcislo;
    bool nechtenecislo = int.TryParse(randomcisloString, out randomcislo);
    Console.WriteLine("Finally...");

} while (false);