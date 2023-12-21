//Algoritmus řazení

int[] nevybrané = new int[] { 1, 6, 2, 0, 8 };

for (int i = 0; i < nevybrané.Length; i++)
{
    for(int j = 0; j < nevybrané.Length - 1; j++)
    {
        int levá = nevybrané[j]; //číslo na levo
        int pravá = nevybrané[j + 1];  //číslo na pravo
        if (pravá < levá)  //stačí nám jen toto if. v druhém případě chceme nechat čísla tak, jak jsou
        {
            //prohození čísel, aby se nám oba napsali
            nevybrané[j] = pravá;
            nevybrané[j + 1] = levá;
        }
      

    }
}
for(int i = 0; i < nevybrané.Length; i++)
{
    Console.WriteLine(nevybrané[i]);
}
//až pocaď je vše potřeba takhle napsat k řazení

// Super. :) / trošku se musíš učit, takhle tu zkoušku nedáš...


//práce se soubory:

File.WriteAllText("soubor.txt", "Ahoj");
// soubor txt = soubor v počítači (aka. mimo program) - můžeme si ho dokonce dát na plochu
//"ahoj" = text, který je v tom souboru co jsme si vytvořili

string message = File.ReadAllText("soubor.txt"); 
//přečte to všechno v tom souboru. i kdybychom změnili mimo tento program, co je napsané v souboru, furt nám to po spuštění programu ukáže novou verzi

Console.WriteLine("zpráva ze souboru:");
Console.WriteLine(message);

StreamWriter file = new StreamWriter("soubor.txt");
file.WriteLine("Teď mohu napsat cokoliv a bude to v tom souboru");
file.WriteLine("Toto tam bude taky");
file.WriteLine("můžu tvořit nové texty jak dlouho se mi chce. :)");
file.Close();
StreamReader file2 = new StreamReader("soubor.txt");
string line1 = file2.ReadLine();
string line2 = file2.ReadLine();
file2.Close();

//11. hodina

Console.WriteLine("11. hodina");
Console.WriteLine();

//nacist vše - nehodí se u velkých souborů - zabírá moc místa a vždy vyjede vše

string[] pokemoni = File.ReadAllLines("pokedex.txt"); //otevře to tu složku do programu
foreach (string pokemon in pokemoni)
{
    Console.WriteLine(pokemon);
}

//nacist postupně - hodí se, když chce člověk vybrat jen jednu věc z celého seznamu - třeba řádek 126

StreamReader reader = new StreamReader("pokedex.txt");
while (!reader.EndOfStream)
{
    string line = reader.ReadLine();
    Console.WriteLine(line);
}

reader.Close(); //zavřeli jsme složku - explicitně jsme to tomu programu museli říct

using (StreamReader using_reader = new StreamReader ("pokedex.txt")) //zavřela se složka - program ji sám zavírá
{
    while (!using_reader.EndOfStream)
    {
        string line = using_reader.ReadLine();
        Console.WriteLine(line);
    }
}

//prvně jsme programovaly odstavec pod tímto odstavcem

if (File.Exists("favorite.txt"))
{
    string minulypokemon = File.ReadAllText("favorite.txt"); // toto napíše minulé rozhodnutí u programu
    Console.WriteLine("Tvůj minulý oblíbený pokémon byl:");
    Console.WriteLine(minulypokemon);
}
else
{
    Console.WriteLine("Nevím tvého oblíbeného pokémona...");
}
Console.WriteLine("What's your favorite pokemon?"); // zatím neřešíme jestli ten pokemon je v souboru nebo ne, věříme že je
string favorite = Console.ReadLine();
File.WriteAllText("favorite.txt", favorite); //tímto odpověd uživatele změníme v novou samostatnou složku

string nejdelsijmeno = ""; // pro vyběr nejdelšího jména

string[] pokemonStats = File.ReadAllLines("pokedexnovy.txt");
foreach (string pokemon in pokemonStats)
{
    string[] parts = pokemon.Split(','); // toto rozděluje slova mezi čarkama na kusy
    Console.WriteLine("jméno pokémona:"  + parts[1]);
    Console.WriteLine("první rozdělovací typ:" + parts[2]);
    Console.WriteLine("druhý rozdělovací typ:" + parts[3]);
    Console.WriteLine("celkový počet bodů:" + parts[4]);
    Console.WriteLine("HP:" + parts[5]);
    Console.WriteLine("útok:" + parts[6]);
    Console.WriteLine("obrana:" + parts[7]);
    Console.WriteLine("speciální útok:" + parts[8]);
    Console.WriteLine("speciální obrana:" + parts[9]);
    Console.WriteLine("rychlost:" + parts[10]);
    Console.WriteLine("Generace:" + parts[11]);
    Console.WriteLine("Je legendární?:" + parts[12]);
    Console.WriteLine();
    if (parts[1].Length > nejdelsijmeno.Length)
    {
        nejdelsijmeno = parts[1];
    }
}

Console.WriteLine("Nejdelší jméno pokémona je: " + nejdelsijmeno);
// .txt - text, .png - obrázek, .docx - word, .csd - comma separated values = slova oddělená čárkou
