public class MojeNode
{
    public string Value = "bla bla"; //obsah
   
    public MojeNode Next; //posouvání na další

    //konstriktor - funkce ve třídě která se volá, když ji vytvořím
    public MojeNode(string value)
    {
        Value = value; //tímto měním obsah Nodeu
    }
}
//konec o LinkListu
