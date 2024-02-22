using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stack
{
    int[] array;
    int posledni;
    
    public Stack(int capacity) 
    {
        array = new int[capacity];
    }
    public int Get()
    {
        int cistvalue = array[posledni];
        return cistvalue;
    }

    public int Add(int value)
    {
        array[posledni + 1] = value;
        posledni = posledni + 1;
        return posledni;
    }

}
