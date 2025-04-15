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
    public partial class FrmListaSimple : Form
    {
        //instanciar porque esta en otro formulario
        Clases.ListaSimple ls = new Clases.ListaSimple();

        public FrmListaSimple()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
            ls.insertar(int.Parse(textNumero.Text));
            ls.mostrar(listNumeros);
            textNumero.Clear();
            textNumero.Focus();
        }
    }
}
