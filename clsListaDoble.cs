using System;

public class Class1
{

    protected Nodo cabeza; //es el nodo que se llama primero

    public clsListaDoble()
    {
        cabeza = null;
    }

    public clsListaDoble insertarCabezaLista(int entrada)
    {

        Nodo nuevo;
        nuevo = new Nodo(entrada);
        nuevo.adelante = cabeza;
        if (cabeza != null)
        {
            cabeza.atras = nuevo;
        }
        cabeza = nuevo;
        return this;
    }

    public clsListaDoble insertaDespues(Nodo anterior, int entrada)
    {
        Nodo nuevo;
        nuevo = new Nodo(entrada);
        nuevo.adelante = anterior.adelante;
        if (anterior.adelante != null)
        {
            anterior.adelante.atras = nuevo;

        }
        anterior.adelante = null;
        nuevo.atras = anterior;
        return this;
    }

    public void eliminar(int entrada)
    {
        Nodo actual;
        boolean encontrado = false;
        actual = cabeza;

        //blucle de busqueda
        while ((actual != null) && (!encontrado))
        {
            encontrado = (actual.dato == entrada);
            if (!encontrado)
            {
                actual = actual.adelante;

            }

        }

        //enlace del nodo anterior con el siguiente
        if (actual != null)
        {
            //disntinguir entre nodo cabecera del resto de la lista
            if (actual == cabeza)
            {
                cabeza = actual.adelante;
                if (actual.adelante != null)
                {
                    actual.adelante.atras = null;
                }
            }
            else if (actual.adelante != null)
            {//quiere decir que no es el ultimo nodo
                actual.atras.adelante = actual.adelante;
                actual.adelante.atras = actual.atras;
            }
            else
            {//ultimo nodo
                actual.atras.adelante = null;
            }
            actual = null;
        }

    }

    public void visualizar()
    {
        Nodo n;
        n = cabeza;
        while (n != null)
        {
            System.out.println(n.dato + "\n");
            n = n.adelante;

        }
    }

}
