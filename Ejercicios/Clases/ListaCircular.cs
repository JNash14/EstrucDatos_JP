using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    internal class ListaCircular
    {
        //---------------------------------------- SEMANA 3 ----------------------------------------------
        private Nodo primero = null; //punteros o banderas que indica el primer elemento de tu nodo
        private Nodo ultimo = null; //indica el ultimo elemento de tu nodo

        public void insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if (primero == null)
            {
                //si la lista esta vacia
                primero = nuevo;
                nuevo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
            }
        }


        public void mostrar(ListBox list)
        {
            if (primero == null) //para evitar el error de cuando elimines el ultimo valor
                return;

            Nodo actual = primero;

            do
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
            while (actual != primero);
        }


        public void eliminar(int num)
        {
            if (primero == null)//para evitar el error de cuando elimines el ultimo valor
                return;

            Nodo actual = primero;
            Nodo anterior = null;

            do
            {
                if (actual.Numero == num)
                {
                    if (actual == primero & actual == ultimo)
                    {
                        primero = null; ultimo = null;
                    }
                    else if (actual == primero) //si es que actual es igual al primero
                    {
                        primero = primero.Siguiente;
                        ultimo.Siguiente = primero;
                    }
                    else if (actual == ultimo)
                    {
                        anterior.Siguiente = primero;
                        ultimo = anterior;
                    }
                    else // cuando esta entre el primero y el ultimo
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }
            while (actual != primero);
        }
    }
}
