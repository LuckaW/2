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
    float skóre = 0;

    string[] seznamek = File.ReadAllLines("questions.data");

    string[] dvojnik = { };

    while (dvojnik.Length < seznamek.Length)
    {
        int nahoda = new Random().Next(seznamek.Length);
        if (!dvojnik.Contains(seznamek[nahoda]))
        {
            Array.Resize(ref dvojnik, dvojnik.Length +1);
            dvojnik[dvojnik.Length - 1] = seznamek[nahoda];
        }
    }
    seznamek = dvojnik; 

    for (int bob = 0; bob < seznamek.Length; bob++)
    {
        
        string[] cast = seznamek[bob].Split('|');
        Console.WriteLine(cast[0]);

        string[] okodpoved = {"A","B"};

        for (int bobek = 2; bobek < cast.Length; bobek++)
        {
           
            switch (bobek)
            {
                case 2:
                    Console.WriteLine("A " + cast[2]);

                    break;
                case 3:
                    Console.WriteLine("B " + cast[3]);
                    break;
                case 4:
                    Console.WriteLine("C " + cast[4]);
                    Array.Resize(ref okodpoved, okodpoved.Length + 1);
                    okodpoved[okodpoved.Length - 1] += "C";
                    break;

            }
        }
        Console.WriteLine("Napiste písmeno správné odpovědi:");

        string pismeno;
        while (true)
        {
            pismeno = odpoved();
            if (okodpoved.Contains(pismeno))
            {
                
                break;
            }
            else
            {
                Console.WriteLine("To fakt není písmeno odpovědi... zkus znova.");
            }
        }

        if (cast[1] == pismeno)
        {
            Console.WriteLine("Spravna odpověď. Bravo. :D");
            skóre ++;
        }
        else
        {
            Console.WriteLine("Špatná odpověď. Smůla... :(, Správná odpověď je " + cast[1]);
        }
        Console.WriteLine();
    }


    Console.WriteLine("Konec kvízu. Tvoje skóre bylo " + MathF.Round(skóre / seznamek.Length * 100 ) + "%.");

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