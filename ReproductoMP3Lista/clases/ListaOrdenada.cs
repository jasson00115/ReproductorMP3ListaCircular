using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReproductoMP3Lista.clases
{
    public class ListaOrdenada : Lista
    {
        //constructor
        public ListaOrdenada() : base()
        {

        }

        public ListaOrdenada insertaOrden(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (primero == null)
            {
                primero = nuevo;
            }
            else if (entrada.CompareTo(primero.getDato())<0)
            {
                nuevo.setEnlace(primero);
                primero = nuevo;
            }
            else
            {
                //Busqueda del nodo anterior, a partir de aqui se hara la insercion
                Nodo anterior, p;
                anterior = p = primero;
                while ((p.getEnlace() != null) && (entrada.CompareTo(p.getDato()))>0)
                {
                    anterior = p;
                    p = p.getEnlace();
                }
                if (entrada.CompareTo(p.getDato())>0)//se inserta despues del ultimo nodo
                {
                    anterior = p;
                }
                nuevo.setEnlace(anterior.getEnlace());
                anterior.setEnlace(nuevo);

            }
            return this;

        }

        //Buscar Lista
        //public ListaOrdenada BuscarLista(int entreda)
        //{
        //    return ;
        //}
        //METODOS PENDIENTES DE LA LISTA ORDENADA
        //ELIMINAR
        //BUSCARLISTA

        public Nodo search(int index)// nos retorna el nodo que estamos buscando
        {

            if (index < 0)
            {
                return null;
            }

            int n = 0;
            Nodo aux = primero;
            while (n != index)
            {
                aux = aux.enlace;
                n++;
            }

            return aux;
        }

        public void eliminar(int entrada)
        {
            Nodo actual, anterior;
            bool encontrado;
            //inicializa los apuntadores
            Nodo dato = search(entrada);
            actual = primero;
            anterior = null;
            encontrado = false;

            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.enlace == dato.enlace);


                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }//end while

            //enlace del nodo anteior con el siguiente
            if (actual != null)
            {
                //distinguir si es el nodo inicial a cabeza
                //es cualquiera otro nodo de la lista
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
            }
        }//end metodo

    }
}
