/*
Datové struktury
         pole - array
         spojový seznam - linked list
         strom - tree
         graf - graph
dnes   zásobník - stack, píše se: LIFO (last in first out)
            - funkce:
                add() - přidat
                set() - odebrat
                pop() - posunu
dnes   fronta - queue, píše se: FIFO (first in, first out)
           
*/

//udělat: stack - capacity + array + last + set() + add()
int neco;
Console.WriteLine("Něco přidej:");
string něco = Console.ReadLine();
int.TryParse(něco, out neco);

Stack zasobnik = new Stack (10);
zasobnik.Add(neco);
