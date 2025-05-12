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
    public partial class FrmCola : Form
    {
        Clases.Cola co = new Clases.Cola();
        public FrmCola()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (co.Buscar(textNombre.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Dato ya existente");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textNombre.Text))
                    MessageBox.Show("No se permiten valores nulos");
                else
                {
                    listDatos.Items.Clear();
                    co.Enqueue(textNombre.Text.Trim().ToUpper());
                    co.mostrar(listDatos);
                    textNombre.Clear();
                    textNombre.Focus();
                }
            }                            
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            string nom = co.Dequeue();

            if (nom != null)
            {
                MessageBox.Show(nom + " Desencolado");
                listDatos.Items.Clear();
                co.mostrar(listDatos);
            }
            else MessageBox.Show("Cola vacía");
        }

        private void bntVistazo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primer dato: "+co.Peek());
        }

        private void btnElementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: " + co.Count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            co.Clear();
            MessageBox.Show("Datos eliminados");
            listDatos.Items.Clear();
            co.mostrar(listDatos);
        }
    }
}
