
MojeNode strat = new MojeNode("Ahoj");
MojeNode prubeh = new MojeNode("Jak se vede?");

Start.Next = prubeh;

MojeNote prubeh2 = new MojeNote("U mě vše ok");

prubeh.Next = prubeh2;

MojeNode ukazat = Start;
while (true)
{
    Console.WriteLine(ukazat.Vlaue);
    ukazat = ukazat.Next;
    if (ukazat == null)
    {
        break;
    }
}

//konec o LinkListu