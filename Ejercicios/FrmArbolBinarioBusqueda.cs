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
    public partial class FrmArbolBinarioBusqueda : Form
    {
        Clases.ArbolBinarioBusqueda abb = new Clases.ArbolBinarioBusqueda();
        NodoAB raiz;
        public FrmArbolBinarioBusqueda()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (raiz == null)
                    raiz = abb.insertar(null, num);
                else
                    abb.insertar(raiz, num);

                //Mostramos el contenido insertado
                treeView1.Nodes.Clear();
                abb.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
                textNumero.Focus();
            }
            else
                MessageBox.Show("Solo se permiten números");
            
        }

        private void bntRecorrido_Click(object sender, EventArgs e)
        {
            textPre.Clear();
            textIn.Clear();
            textPost.Clear();
            abb.preorden(raiz, textPre);  //PreOrden
            abb.Inorden(raiz, textIn);    //Inorden
            abb.Postorden(raiz, textPost); //Postorden
            
        }
    }
}
