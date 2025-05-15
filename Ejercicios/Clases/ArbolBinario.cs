using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    class ArbolBinario
    {
        //se va utilizar recursividad
        public NodoAB insertar(NodoAB actual, int num)
        {
            NodoAB nuevo = new NodoAB();
            nuevo.Numero = num;
            if (actual == null)
                return nuevo;
            else if ((actual.Izquierda != null || actual.Derecha == null) && (actual.Derecha != null || actual.Izquierda == null))
                MessageBox.Show("Nodo ocupado");
            else if (actual.Izquierda == null)
                actual.Izquierda = nuevo;
            else
                actual.Derecha = nuevo;
            return actual;

        }

        public void mostrar(NodoAB actual, TreeView tree, TreeNode padre)
        {
            if (actual == null) 
                return;

            TreeNode nuevo = new TreeNode(actual.Numero.ToString());//para insertar solo la raíz
            nuevo.Tag = actual; //almacenamos la referencia

            if (padre == null) 
                tree.Nodes.Add(nuevo); //insertar los tallos
            else
                padre.Nodes.Add(nuevo); //insertar las hojas

            //Aqui se aplica la recursividad
            if (actual.Izquierda != null)
                mostrar(actual.Izquierda, tree, nuevo);
            if (actual.Derecha != null)
                mostrar(actual.Derecha, tree, nuevo);
        }



        //la altura mide los niveles del arbol
        public int altura(NodoAB actual)
        {
            if (actual == null)
                return 0;
            else
            {
                int altIzq = altura(actual.Izquierda);
                int altDer = altura(actual.Derecha);
                return Math.Max(altDer, altIzq) + 1; 
            }
        }
    }
}
