using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    class NodoAB
    {
        private int numero;
        private NodoAB izquierda;
        private NodoAB derecha;

        public int Numero { get => numero; set => numero = value; }
        internal NodoAB Izquierda { get => izquierda; set => izquierda = value; }
        internal NodoAB Derecha { get => derecha; set => derecha = value; }

        /*public NodoAB(int num) //se crea un constructor para que cada vez que insertamos un nodo nuevo va insertar izquiera y derecha con el valor null.
        {
            numero = num;
            izquierda = null;
            derecha = null;
        }*/
    }
}
