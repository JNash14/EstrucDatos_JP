using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    class ArbolBinarioBusqueda
    {
        public NodoAB insertar(NodoAB actual, int num)
        {
            NodoAB nuevo = new NodoAB();
            nuevo.Numero = num;

            if (actual == null)
                return nuevo;

            //Se va utilizar RECURSIVIDAD para evitar el while y que el codigo sea extienda mas
            if (num < actual.Numero)
                actual.Izquierda = insertar(actual.Izquierda, num);
            else if (num > actual.Numero)
                actual.Derecha = insertar(actual.Derecha, num);
            else
                MessageBox.Show("No duplicados");

            return actual;
        }

        public void mostrar(NodoAB actual, TreeView tree, TreeNode tallo) 
        {
            if (actual == null)
                return;

            TreeNode cabeRaiz = new TreeNode(actual.Numero.ToString()); //se arma la estructura de la raiz

            if (tallo == null)
                tree.Nodes.Add(cabeRaiz); //Este nuevo tallo que estamos armando viene a ser hijo de la raiz
            else
                tallo.Nodes.Add(cabeRaiz);

            mostrar(actual.Izquierda, tree, cabeRaiz);
            mostrar(actual.Derecha, tree, cabeRaiz);
        }

        public void preorden(NodoAB actual, TextBox text)
        {
            if (actual == null)
                return;

            text.Text += actual.Numero.ToString() + "-";  //Raiz 
            //+= te va devolver el ultimo valor rgistrado      
            preorden(actual.Izquierda, text); //Izquierda
            preorden(actual.Derecha, text); //Derecha
        }
        public void Inorden(NodoAB actual, TextBox text)
        {
            if (actual == null)
                return;
                            
            Inorden(actual.Izquierda, text); //Izquierda
            text.Text += actual.Numero.ToString() + "-";  //Raiz 
            Inorden(actual.Derecha, text); //Derecha
        }

        public void Postorden(NodoAB actual, TextBox text)
        {
            if (actual == null)
                return;
              
            Postorden(actual.Izquierda, text); //Izquierda
            Postorden(actual.Derecha, text); //Derecha
            text.Text += actual.Numero.ToString() + "-";  //Raiz 
            
        }


        //--------------------------------------------------------- SEMANA 10 ------------------------------------------------------
        public NodoAB buscar(NodoAB actual, int num)
        {
            if (actual == null) return null; // si el arbol esta vacio retornamos null

            if (num == actual.Numero) return actual;
            else if (num < actual.Numero) return buscar(actual.Izquierda, num);
            else return buscar(actual.Derecha, num);
        }

        public NodoAB eliminar(NodoAB actual, int num)
        {
            if (actual == null) return null;

            if (num < actual.Numero) actual.Izquierda = eliminar(actual.Izquierda, num);
            else if (num > actual.Numero) actual.Derecha = eliminar(actual.Derecha, num);
            else
            {
                if (actual.Izquierda == null) return actual.Derecha;
                if (actual.Derecha == null) return actual.Izquierda;               

                NodoAB sucesor = minimo(actual.Derecha);

                actual.Numero = sucesor.Numero;
                actual.Derecha = eliminar(actual.Derecha, sucesor.Numero);
            }
            return actual;
        }

        public NodoAB minimo(NodoAB actual)
        {
            while (actual.Izquierda != null) // retorna el minimo valor que tenemos
                actual = actual.Izquierda;
            return actual;
        }
    }
}
