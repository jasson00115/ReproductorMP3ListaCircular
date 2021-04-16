using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductoMP3Lista.CircularDeDifinicion
{
    public class Nodo
    {

        public int dato;
        public Nodo enlace;

        public Nodo(int entrada)
        {
            dato = entrada;
            enlace = this;
        }

    }
}
