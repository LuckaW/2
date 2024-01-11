using System.ComponentModel.Design;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Kvíz z otázek do autoškoly:");
string odpoved()
{
    return Console.ReadLine().ToUpper().Trim(); //ToLower = písmena udělá automaticky malá, Trim = odendavá mezery ze začátku a z konce
}

while (true)
{
    
    string[] seznamek = File.ReadAllLines("questions_small.data");


    for (int bob = 0; bob < seznamek.Length; bob++)
    {

        string[] cast = seznamek[bob].Split('|');
        Console.WriteLine(cast[0]);
        Console.WriteLine("A " + cast[2]);
        Console.WriteLine("B " + cast[3]);
        Console.WriteLine("C " + cast[4]);
        Console.WriteLine("Napiste písmeno správné odpovědi:");

        string pismeno;
        while (true)
        {
            pismeno = odpoved();
            if (pismeno == "A" || pismeno == "B" || pismeno == "C")
            {
                break;
            }
            else
            {
                Console.WriteLine("To fakt není A/B/C... zkus znova.");
            }
        }

        if (cast[1] == pismeno)
        {
            Console.WriteLine("Spravna odpověď. Bravo. :D");
        }
        else
        {
            Console.WriteLine("Špatná odpověď. Smůla... :(");
        }
        Console.WriteLine();
    }


    Console.WriteLine("Konec kvízu.");
    while (true)
    {
        Console.WriteLine("Pokud nechceš opakovat program, napiš 'q':");
        string odpoved007 = odpoved();

       
        if (odpoved007 == "Q")
        {
            Environment.Exit(0);
        }

        else
        {
            break;
        }
    }
}