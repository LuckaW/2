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

File.WriteAllText("soubor txt", "Ahoj");
// soubor txt = soubor v počítači (aka. mimo program) - můžeme si ho dokonce dát na plochu
//"ahoj" = text, který je v tom souboru co jsme si vytvořili

string message = File.ReadAllText("soubor txt"); 
//přečte to všechno v tom souboru. i kdybychom změnili mimo tento program, co je napsané v souboru, furt nám to po spuštění programu ukáže novou verzi

Console.WriteLine("zpráva ze souboru:");
Console.WriteLine(message);

StreamWriter file = new StreamWriter("soubor txt");
file.WriteLine("Teď mohu napsat cokoliv a bude to v tom souboru");
file.WriteLine("Toto tam bude taky");
file.WriteLine("můžu tvořit nové texty jak dlouho se mi chce. :)");

StreamReader file2 = new StreamReader("soubor.txt");
string line1 = file2.ReadLine();
string line2 = file2.ReadLine();
file2.Close();