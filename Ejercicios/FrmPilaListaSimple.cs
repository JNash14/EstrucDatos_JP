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
    public partial class FrmPilaListaSimple : Form
    {
        Clases.PilaListaSimple p = new Clases.PilaListaSimple();

        public FrmPilaListaSimple()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string i = textInfija.Text;
            p.insertar(i, p.infijaAprefija(i), p.infijaApostfija(i));
            p.mostrar(listView1);
            textInfija.Clear();
        }
    }
}
