using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    internal class Cola
    {
        private Nodo primero = null;
        private Nodo ultimo = null;
        private int cant = 0;

        public void Enqueue(string nom) //Encolar
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            cant++;
        }

        public void mostrar(ListBox list) //mostrar
        {
            Nodo actual = primero;
            while (actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string Dequeue() //Desencolar
        {
            if (primero == null) return null;
            else
            {
                string nom = primero.Nombre;
                primero = primero.Siguiente;
                cant--;
                return nom;               
            }
        }

        public string Peek() //Vistazo de el dato que esta en el primero d ela cola
        {
            if (primero == null) return null;
            return primero.Nombre;
        }

        public int Count() //Contar la cantidad de elementos de la cola
        {
            return cant;
        }

        public void Clear() //limpiar todos lo valores que existe en la cola
        {
            primero = null;
            ultimo = null;
            cant = 0;
        }

        public bool Buscar(string nom)
        {
            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.Nombre == nom)
                    return true;
                actual = actual.Siguiente;
            }
            return false;
        }
    }
}
