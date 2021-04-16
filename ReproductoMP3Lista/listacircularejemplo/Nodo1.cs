using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductoMP3Lista.listacircularejemplo
{
    public class Nodo1
    {

        public String dato;
        public Nodo1 enlace;

        public Nodo1(String entrada)
        {
            dato = entrada;
            enlace = this; // se apunta asímismo

        }

    }
}
