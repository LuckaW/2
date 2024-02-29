using System.ComponentModel;
using System.IO.Pipes;

public class MyLinkedList
{
    public MojeNode Start;
    public MojeNode End;
    public int Lenght;

    public void AsstoEnd(string value)
    {
        MojeNode node = new MojeNode(value);

        if (End != null)
        {
            End.Next(node);
            End = node;
        }
        else
        {
            Start = node;
            End = node;
        }
        
    }
    

}
//konec o LinkListu
// rozhraní/interface - určuje se v něm, co daný Linklist umí
// Parent john = new Parent();
// john.SayHello()`
// Parebnt[] parents = new Parent [3]
// parents[0] = john;