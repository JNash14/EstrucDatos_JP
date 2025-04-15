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


        //-----------------------------------------------SEMANA 2---------------------------------------------

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ls.eliminar(int.Parse(textNumero.Text)); //elimina el dato
            listNumeros.Items.Clear(); //Limpia la lista despues de eliminar
            ls.mostrar(listNumeros); //Lista los datos actualizando los ya eliminados
            textNumero.Clear();
            textNumero.Focus();
        }

        private void bntOrdenar_Click(object sender, EventArgs e)
        {
            ls.ordenar();
            listNumeros.Items.Clear();
            ls.mostrar(listNumeros);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textNumero.Text);

            if (ls.buscar(num) != false)
                MessageBox.Show($"El número {num} existe en la lista");
            else
                MessageBox.Show($"El número {num} no existe en la lista");
        }
    }
}
