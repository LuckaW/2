
int kg;
bool success;
do
{
    Console.WriteLine("Napište, kolik kilogramů jablek můžeme prodat:");
    string KG = Console.ReadLine();
    success = int.TryParse(KG, out kg);
} while (!success);

int vysledek;
int jablko;
do
{
    
    do
    {
        Console.WriteLine("kolik kg si koupil zákazník?:");
        string JABLKO = Console.ReadLine();
        success = int.TryParse(JABLKO, out jablko);
    } while (!success);
   
    if (kg > jablko)
    {
        kg = kg - jablko;
        Console.WriteLine("Prodal/a/s mu jablka.");
        Console.WriteLine("Přichází další zákazník...");
    }
    

} while (kg !>= jablko);

Console.WriteLine("Máš už jen " + kg + " kg jablek a zákazník chce " + jablko +  " kg jablek. Smůla.");