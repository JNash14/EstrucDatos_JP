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



        //---------------------------------------------------- SEMANA 11 ------------------------------------------------

        public NodoAB minimo(NodoAB actual)
        {
            while (actual.Izquierda != null) // retorna el minimo valor que tenemos en el arbol
                actual = actual.Izquierda;
            return actual;
        }

        public NodoAB maximo(NodoAB actual)
        {
            while (actual.Derecha != null) // retorna el máximo valor que tenemos en el arbol
                actual = actual.Derecha;
            return actual;
        }

        public int balanceado(NodoAB actual)
        {
            if (actual == null) return 0;

            int alturaIzq = balanceado(actual.Izquierda);
            if (alturaIzq == -1) return -1;

            int alturaDer = balanceado(actual.Derecha);
            if (alturaDer == -1) return -1;

            if (Math.Abs(alturaIzq - alturaDer) > 1) return -1; //utilizar e valor absoluto para positivisar

            return Math.Max(alturaIzq, alturaIzq) + 1;
        }

        public int suma(NodoAB actual)
        {
            if (actual == null) return 0; //Si no hay nada retorna 0           
            if (actual.Derecha == null && actual.Izquierda == null) return actual.Numero; //Aqui nos damos cuenta que el nodo es una hoja

            //La recursividad funciona como un bucle que va encolando los valores
            return suma(actual.Izquierda) + suma(actual.Derecha); //utilizando recursividad para que el codigo n o sea muy extenso
        }
    }
}
