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
    public partial class FrmGrafoMatrizAdyacencia: Form
    {
        Clases.GrafoMatrizAdyacencia g = new Clases.GrafoMatrizAdyacencia(5); //Se pone el rango de aristas que se utilizara en el grafo
        public FrmGrafoMatrizAdyacencia()
        {
            InitializeComponent();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtOrigen.Text, out int origen) && int.TryParse(txtDestino.Text, out int destino))
            {
                g.insertar(origen, destino);
                g.imprimirArista(origen, destino, lstBox);
            }
            else
                MessageBox.Show("Solo se permiten números!");
            txtDestino.Clear();
            txtOrigen.Clear();
        }

        private void btnMatrizAdyacencia_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.imprimirMatriz(richTextBox1);
        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {
            txtAmplitud.Clear();
            g.amplitud(txtAmplitud);
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            txtProfundidad.Clear();
            g.profundidad(txtProfundidad);
        }
    }
}
