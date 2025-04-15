using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    internal class Nodo //este nodo va servir para la lista enlazada simple y para la lista circular
    {
        private int numero;
        private Nodo siguiente;

        //aqui se encapsula el numero y el nodo para que en el proyecto se utilicen estos
        public int Numero { get => numero; set => numero = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
