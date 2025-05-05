using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    class Pila
    {
        private Nodo cima = null;
        private int cantidad = 0;

        public void Push(string nom) //Apilar
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            nuevo.Siguiente = cima;
            cima = nuevo;
            cantidad++;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = cima;

            while (actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string Pop() //Desapilar
        {
            if (cima != null)
            {
                string nom = cima.Nombre; //aqui se va almacenar y devuelve el dato que se va eliminar, esto sirve para cuando usemos infija y prefija
                cima = cima.Siguiente;
                cantidad--; //el contador de elementos tambien tiene que decrementar
                return nom;
            }
            return null;
        }

        public string Peek()
        {
            if (cima != null)
            {              
                return cima.Nombre;
            }
            return null;
        }

        public int Count() //Contar el numero de elementos que hay en la lista
        {
            return cantidad;
        }

        public void limpiar()
        {            
            while (cima != null)
            {
                cima = cima.Siguiente;
                cantidad--;
            }
            return;
        }

        public void clear()
        {
            cima = null;
            cantidad = 0;
        }


        //--------------------------------SEMANA 5-------------------------------------------
        public bool EstaVacio()
        {
            return cima == null;
        }

    }
}
