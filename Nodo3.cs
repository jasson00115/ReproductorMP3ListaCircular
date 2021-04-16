using System;

public class Class1
{

    int dato;
    Nodo adelante;
    Nodo atras;

    //Funcion para que nos devuelva el dato
    public int getDato()
    {
        return dato;
    }

    //Constructor
    public Nodo(int entrada)
    {
        dato = entrada;
        adelante = atras = null;
    }

}
