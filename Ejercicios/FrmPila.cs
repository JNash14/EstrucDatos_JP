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
    public partial class FrmPila: Form
    {
        Clases.Pila p = new Clases.Pila();
        public FrmPila()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            p.Push(textNombre.Text);
            listDatos.Items.Clear();
            p.mostrar(listDatos);
            textNombre.Clear();
            textNombre.Focus();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            string nom = p.Pop();
            if (nom != null)
            {
                MessageBox.Show($"'{nom}' desapilado correctamente");
                listDatos.Items.Clear();
                p.mostrar(listDatos);
            }
            else            
                MessageBox.Show("Pila vacía");                            
        }

        private void bntVista_Click(object sender, EventArgs e)
        {
            string nom = p.Peek();
            if (nom != null)
            {
                MessageBox.Show($"Cima: "+nom);                
            }
            else
                MessageBox.Show("Pila vacía");
        }

        private void btnElementos_Click(object sender, EventArgs e)
        {                      
            MessageBox.Show($"Cantidad: " + p.Count());            
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnApilar_Click(sender, e);
                e.Handled = true; //silenciar el pitido que sale
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p.limpiar();
            listDatos.Items.Clear();
            p.mostrar(listDatos);
        }
    }
}
