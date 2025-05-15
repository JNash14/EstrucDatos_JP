using Ejercicios.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class FrmArbol: Form
    {
        Clases.ArbolBinario ab = new Clases.ArbolBinario();
        NodoAB raiz;
        NodoAB seleccionado; //este nodo va servir para almacenar el nodo en el que queremos insertar el dato si es a la izquierda o a la derecha
        public FrmArbol()
        {
            InitializeComponent();
            radioIzquierda.Checked = true; //validamos que el botonradio izquierda este seleccionado para evitar que sea muy largo la condicion
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num) && num >= 0)
            {
                //Aui validamos que se inserta la raiz y sus nodos izquierda y derecha en null.
                treeView1.Nodes.Clear();
                raiz = ab.insertar(null, num);
                ab.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();//es para que se agregue en automatico cada que insertas un nuevo numero
                textNumero.Clear();
                textNumero.Focus();
            }
            else
                MessageBox.Show("Solo se permiten números enteros mayores a cero!!!");
        }

        private void btnInsertarRamas_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num) && num >= 0)
            {
                if (seleccionado != null)
                {
                    if (radioDerecha.Checked == true)
                        seleccionado.Derecha = ab.insertar(seleccionado.Derecha, num);
                    if (radioIzquierda.Checked == true)
                        seleccionado.Izquierda = ab.insertar(seleccionado.Izquierda, num);

                    treeView1.Nodes.Clear();                    
                    ab.mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();//es para que se agregue en automatico cada que insertas un nuevo numero
                    textNumero.Clear();
                    textNumero.Focus();
                }
                else
                    MessageBox.Show("Selecciona un nodo!");
            }
            else
                MessageBox.Show("Solo se permiten números enteros mayores a cero!!!");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccionado = (NodoAB)e.Node.Tag; //vamos a almacenar la referencia aqui
        }

        private void bntAltura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La altura: "+ ab.altura(raiz));
        }
    }
}
