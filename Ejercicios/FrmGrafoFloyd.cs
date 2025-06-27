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
    public partial class FrmGrafoFloyd: Form
    {
        Clases.GrafoFloyd g;
        public FrmGrafoFloyd()
        {
            InitializeComponent();
        }

        private void btnVertices_Click(object sender, EventArgs e)
        {
            int vert = int.Parse(txtVertices.Text);

            g = new Clases.GrafoFloyd(vert);
            MessageBox.Show("Número de vertices: " + vert);
            lstBox.Items.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            int o = int.Parse(txtOrigen.Text);
            int d = int.Parse(txtDestino.Text);
            int c = int.Parse(txtCosto.Text);

            g.insertarArista(o, d, c);
            g.imprimirArista(o, d, c, lstBox);
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.imprimirMatriz(richTextBox1);
        }

        private void btnFloyd_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            g.floyd(richTextBox2);
        }
    }
}
