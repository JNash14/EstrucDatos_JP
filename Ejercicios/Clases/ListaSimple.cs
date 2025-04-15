using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    internal class ListaSimple
    {
        private Nodo primero = null;

        public void insertar(int num)
        {
            Nodo nuevo = new Nodo(); // instanciamos el nuevo nodo 
            nuevo.Numero = num; //almacenamos el dato que va contener

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null; //ahora ya no es necesario porque es redundante
            }

            else
            {
                Nodo actual = primero; //este nodo se va encargar de recorrer tu lista

                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevo;
                nuevo.Siguiente = null; //ahora ya no es necesario porque es redundante
            }

        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }
    }
}
