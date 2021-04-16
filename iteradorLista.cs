using System;

public class Class1
{

    private Nodo actual;

    public IteradorLista(clsListaDoble id)
    {
        actual = id.cabeza;
    }

    public Nodo siguiente()
    {
        Nodo a;
        a = actual;
        if (actual != null)
        {
            actual = actual.adelante;
        }
        return a;
    }

}
