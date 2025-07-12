using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Ejercicios
{
    public partial class FrmGrafoPrim : Form
    {
        Clases.GrafoPrim g;
        public FrmGrafoPrim()
        {
            InitializeComponent();
        }

        private void btnVertices_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtVertices.Text, out int vert) && vert > 0)
            {
                g = new Clases.GrafoPrim(vert);
                MessageBox.Show("Número de vertices: " + vert);
                lstBox.Items.Clear();
                lstBox2.Items.Clear();
                richTextBox1.Clear();
            }
            else
                MessageBox.Show("Ingrese números mayores a 0");
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            int o = int.Parse(txtOrigen.Text);
            int d = int.Parse(txtDestino.Text);
            int c = int.Parse(txtCosto.Text);

            g.insertar(o, d, c);
            g.imprimirArista(o, d, c, lstBox);
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.imprimirMatriz(richTextBox1);
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            lstBox2.Items.Clear();
            g.prim(lstBox2);
        }
    }
}
