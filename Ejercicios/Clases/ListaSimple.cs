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


        //-----------------------------------------------------SEMANA 2----------------------------------------------
        public void eliminar(int num)
        {
            Nodo actual = primero; //creamos el nodo actual
            Nodo anterior = null; //creamos otro nodo que va servir para que acompañe al actual

            while (actual != null) //va recorrer el listado para encontrar el dato
            {
                if (actual.Numero == num)
                {
                    if (actual == primero)
                    {
                        primero = primero.Siguiente;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
        }

        public void ordenar()
        {
            Nodo actual = primero;

            while (actual != null)
            {
                Nodo sig = actual.Siguiente; //este nodo va recorrer el siguiente

                while (sig != null)
                {
                    if (actual.Numero > sig.Numero) //si queremos ordenar de forma descendente entonces cambiar el > por <
                    {
                        int temp = actual.Numero; //cramos una variable temporal donde almacenara actual.num
                        actual.Numero = sig.Numero;
                        sig.Numero = temp;
                    }
                    sig = sig.Siguiente;
                }
                actual = actual.Siguiente;
            }
        }

        public bool buscar(int num)
        {
            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.Numero == num)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        //INVESTIGAR el algoritmo Shuffle para hacer el metodo mezclar
    }
}
