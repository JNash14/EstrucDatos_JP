using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    internal class ListaDoble
    {
        //--------------------------------------------SEMANA 3--------------------------------------
        private NodoDoble primero = null;
        private NodoDoble ultimo = null;

        public void insertar(int num)
        {
            NodoDoble nuevo = new NodoDoble();
            nuevo.Numero = num;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }


        public void mostrar(ListBox list)
        {
            NodoDoble actual = primero;

            while (actual != null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }


        public void eliminar(int num)
        {
            NodoDoble actual = primero;

            while (actual != null)
            {
                if (actual.Numero == num)
                {
                    if (actual == primero)
                    {
                        primero = primero.Siguiente;

                        if (primero != null)
                        {
                            primero.Anterior = null;
                        }
                    }
                    else if (actual == ultimo)
                    {
                        ultimo = ultimo.Anterior;

                        if (ultimo != null)
                        {
                            ultimo.Siguiente = null;
                        }
                    }
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = actual.Anterior;
                    }
                    return;
                }
                actual = actual.Siguiente;
            }
        }
    }
}
