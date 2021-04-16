using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductoMP3Lista.ListaDoble
{
    public class Nodo
    {

        public string dato;
        public Nodo adelante;
        public Nodo atras;

        //Funcion para que nos devuelva el dato
        public string getDato()
        {
            return dato;
        }

        //Constructor
        public Nodo(String entrada)
        {
            dato = entrada;
            adelante = atras = null;
        }

    }
}
