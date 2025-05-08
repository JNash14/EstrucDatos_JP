using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    internal class Nodo //este nodo va servir para la lista enlazada simple y para la lista circular
    {
        private int numero;         // para la lista enlazada simple
        private string nombre;      // este dato se utiliza para la pila           //tambien para la cola (SEM7)

        private string infija;          //para pila y lista simple (Sem6)
        private string prefija;         //para pila y lista simple (Sem6)
        private string postfija;        //para pila y lista simple (Sem6)

        private Nodo siguiente;

        //aqui se encapsula el numero y el nodo para que en el proyecto se utilicen estos
        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Infija { get => infija; set => infija = value; }
        public string Prefija { get => prefija; set => prefija = value; }
        public string Postfija { get => postfija; set => postfija = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
