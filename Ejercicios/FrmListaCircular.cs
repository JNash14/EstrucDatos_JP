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
    public partial class FrmListaCircular : Form
    {
        Clases.ListaCircular lc = new Clases.ListaCircular();
        public FrmListaCircular()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
            lc.insertar(int.Parse(textNumero.Text));
            lc.mostrar(listNumeros);
            textNumero.Clear();
            textNumero.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lc.eliminar(int.Parse(textNumero.Text));
            listNumeros.Items.Clear();
            lc.mostrar(listNumeros);
            textNumero.Clear();
        }
    }
}
