using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductoMP3Lista.clases
{
    public class Lista
    {
       

            public Nodo primero;
            public Nodo ultimo;

            //Constructor
            public Lista()
            {
                primero = null;

            }


        public Lista crearLista(string cancion)
        {
            string x;
            primero = null; 

            do
            {
                x = cancion; //Para que nos lea Entero
                if (x != null)
                {
                    primero = new Nodo(x, primero);
                }

            } while (x != null);

            return this;
        }
        ////nuevos metodos

        //BUSCAR POSICION
        public Nodo buscarPosicion(int posicion)
            {
                Nodo indice;
                int i;
                if (posicion < 0)
                {
                    return null;
                }
                indice = primero;
                for (i = 1; (i < posicion) && (indice != null); i++)
                { //Hace que se repita va a ir incrementando i va a ir haciendo la iteracion hasta que lo encuentre
                    indice = indice.enlace;
                }
                return indice;
            }

            //INSERTAR DE ULTIMO
            public Lista insertarUltimo(Nodo ultimo, string entrada)
            { //Mandamos como referencia el ultimo nodo y su valor
                ultimo.enlace = new Nodo(entrada); //Agarramos el nodo ultimo y tomo el enlace y el nuevo enlace va a ser igual a la entrada
                ultimo = ultimo.enlace;
                return this;
            }

            public Lista insertarCabeza(Nodo cabeza, string valor)
            {
                cabeza.enlace = new Nodo(valor);
                cabeza = cabeza.enlace;
                return this;
            }

            //BUSCAR ELEMENTO DE LA LISTA
            public Nodo buscarLista(string destino)
            {
                Nodo indice; //va a tomar el indice que necesiktamos ver
                for (indice = primero; indice != null; indice = indice.enlace)
                { //Hacemos la interacion
                    if (destino == indice.dato)
                    {//Hacemos la evaluacion 
                        return indice;
                    }
                }
                return null;
            }

            //ELIMINAR ELEMENTO DE LA LISTA
            public void eliminar(string entrada)
            {
                Nodo actual, anterior;
                //inicializa los apuntadores
                bool encontrado;
                //inicializa los apuntadores de memoria
                actual = primero;
                anterior = null;
                encontrado = false;
                //busqueda del nodo anterior
                while ((actual != null) && (!encontrado))
                {
                    encontrado = (actual.dato == entrada);

                    if (!encontrado)
                    {
                        anterior = actual;
                        actual = actual.enlace;
                    }
                }//end while

                //enlace del nodo anterior con el siguiente
                if (actual != null)
                {
                    //distinguir si es el nodo inicial o cabezaa
                    //o si es cualquier otro nodo de la lista
                    if (actual == primero)
                    {
                        primero = actual.enlace;
                    }
                    else
                    {
                        anterior.enlace = actual;
                    }
                    actual = null;
                }
            }

            public Lista insertarLista(string testigo, string entrada)
            {
                Nodo nuevo, anterior;
                anterior = buscarLista(testigo);

                if (anterior != null)
                {
                    nuevo = new Nodo(entrada);
                    nuevo.enlace = anterior.enlace;
                    anterior.enlace = nuevo;
                }
                return this;
            }

            public void visualizar()
            {
                Nodo n;
                int k = 0;
                n = primero;
                while (n != null)
                {
                    Console.WriteLine(n.dato + " ");
                    n = n.enlace;
                    k++;
                    Console.WriteLine((k % 15 != 0 ? " " : "\\n"));
                }
            }
        }
    
}
