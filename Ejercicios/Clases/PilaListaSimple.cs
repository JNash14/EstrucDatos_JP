using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Ejercicios.Clases
{
    internal class PilaListaSimple
    {
        Pila p = new Pila(); //se necesitara para poder utilizar todos lo metodos de la clasePila como el peek, pop,etc
        
        public int obtenerPrioridad(string operador)
        {
            if (operador == "*" | operador == "/")            
                return 2;
            if (operador == "+" | operador == "-")
                return 1;
            return 0;
        }

        public bool EsOperador (String c) //para poder eliminar de la pila al utilizarlo
        {
            return c == "+" || c == "-" || c == "*" || c == "/"; 
        }

        //estos dos metodos nos va servir para la conversion de prefija y postfija


        public string infijaAprefija(string infija)
        {
             //cuando la variable tiene demasiados cambios al momento de realizar una funsion, lo mas recomendable es utilizar una variable StringBuilder.
             StringBuilder prefija = new StringBuilder();  // el stringBuilder tiene unos metodos que nos va ayudar agregar al inicio y al final para no estar haciendo incrementos y decrementos
           
            for (int i = infija.Length - 1; i >= 0; i--) //se recorre del final es por eso que se usa un for
            {
                string c = infija[i].ToString(); //almacenar ese caracter que esta recorriendo en c

                if (char.IsLetterOrDigit(infija[i]))
                {
                    prefija.Insert(0, c);
                }else if (c == ")")
                {
                    p.Push(c);
                }
                else if (c == "(")
                {
                    while (!p.EstaVacio() && p.Peek() != ")")
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Pop();    //Desapilar el ")"
                }
                else if (EsOperador(c))
                {
                    while (!p.EstaVacio() && obtenerPrioridad(c) < obtenerPrioridad(p.Peek()))
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Push(c);
                }
            }

            while (!p.EstaVacio()) //si es que contiene informacion
            {
                prefija.Insert(0, p.Pop());
            }

            return prefija.ToString();
        }


        public string infijaApostfija(string infija)
        {
            //cuando la variable tiene demasiados cambios al momento de realizar una funsion, lo mas recomendable es utilizar una variable StringBuilder.
            StringBuilder postfija = new StringBuilder();  // el stringBuilder tiene unos metodos que nos va ayudar agregar al inicio y al final para no estar haciendo incrementos y decrementos

            for (int i = 0; i < infija.Length; i++) //se recorre del final es por eso que se usa un for
            {
                string c = infija[i].ToString(); //almacenar ese caracter que esta recorriendo en c

                if (char.IsLetterOrDigit(infija[i]))
                {
                    postfija.Append(c); //Append -> al final
                }
                else if (c == "(")
                {
                    p.Push(c);
                }
                else if (c == ")")
                {
                    while (!p.EstaVacio() && p.Peek() != "(")
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Pop();
                }
                else if (EsOperador(c))
                {
                    while (!p.EstaVacio() && obtenerPrioridad(c) < obtenerPrioridad(p.Peek()))
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Push(c);
                }
            }

            while (!p.EstaVacio()) //si es que contiene informacion
            {
                postfija.Append(p.Pop());
            }
            return postfija.ToString();

        }

        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar (string infija, string prefija, string postfija)
        {
            Nodo nuevo = new Nodo();
            nuevo.Infija = infija;
            nuevo.Prefija = prefija;
            nuevo.Postfija = postfija;

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
        }

        public void mostrar (ListView list)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Infija);
                item.SubItems.Add(actual.Prefija);
                item.SubItems.Add (actual.Postfija);
                list.Items.Add(item);
                actual = actual.Siguiente;
            }
        }

    }
}
