using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductoMP3Lista.ListaDoble
{
    public class iteradorLista
    {

        public Nodo actual;

        public iteradorLista(clsListaDoble id)
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
}
