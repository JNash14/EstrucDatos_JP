using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios.Clases;

namespace Ejercicios
{
    public partial class FrmListaDobleAnalisis : Form
    {
        Clases.ListaDobleAnalisis lda = new Clases.ListaDobleAnalisis();

        public FrmListaDobleAnalisis()
        {
            InitializeComponent();
        }

        private void FrmListaDobleAnalisis_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("No se admiten valores vacíos!");
            }
            else
            {
                if (byte.TryParse(textEdad.Text, out byte ed) && ed<=150) //si es que es correcto se va almacenar en la variable ed
                {
                    listView1.Items.Clear();
                    lda.insertar(textNombre.Text.Trim(), ed); //trim quita los espacios al principio y final
                    lda.mostrar(listView1);
                    textNombre.Clear();
                    textEdad.Clear();
                }
                else
                {
                    MessageBox.Show("No se admiten edades negativos ni mayores a 150");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("No se admiten buscar valores vacíos!");
            }
            else
            {
                NodoDoble buscado = lda.buscar(textNombre.Text.Trim());

                if (buscado != null)
                {
                    MessageBox.Show($"Nombre: {buscado.Nombre}\nEdad: {buscado.Edad}");
                }
                else
                {
                    MessageBox.Show("No existe el nombre buscado en la lista.");
                }
            }
        }
    }
}
