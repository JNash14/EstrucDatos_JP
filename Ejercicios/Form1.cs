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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaSimple fls = new FrmListaSimple();
            fls.ShowDialog(this); //this es para que cuando apertura el nuevo formulario pase adelante
        }

        private void listaEnlazadaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aqui se esta llamando a otro formulario
            FrmListaCircular flc = new FrmListaCircular();
            flc.ShowDialog(this);
        }

        private void listaEnlazadaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaDoble fld = new FrmListaDoble();
            fld.ShowDialog(this);
        }

        private void listaEnlazadaDobleAnálisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaDobleAnalisis flda = new FrmListaDobleAnalisis();
            flda.ShowDialog(this);
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPila fp = new FrmPila();
            fp.ShowDialog(this);
        }

        private void pilaYListaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPilaListaSimple fpl = new FrmPilaListaSimple();
            fpl.ShowDialog(this);
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola fcl = new FrmCola();
            fcl.ShowDialog(this);
        }
    }
}
