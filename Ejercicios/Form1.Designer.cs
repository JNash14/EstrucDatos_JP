﻿namespace Ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaCircularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaDobleAnálisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaYListaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaEnlazadaSimpleToolStripMenuItem,
            this.listaEnlazadaCircularToolStripMenuItem,
            this.listaEnlazadaDobleToolStripMenuItem,
            this.listaEnlazadaDobleAnálisisToolStripMenuItem,
            this.pilasToolStripMenuItem,
            this.pilaYListaSimpleToolStripMenuItem,
            this.colasToolStripMenuItem});
            this.operacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // listaEnlazadaSimpleToolStripMenuItem
            // 
            this.listaEnlazadaSimpleToolStripMenuItem.Name = "listaEnlazadaSimpleToolStripMenuItem";
            this.listaEnlazadaSimpleToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.listaEnlazadaSimpleToolStripMenuItem.Text = "Lista Enlazada Simple";
            this.listaEnlazadaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaSimpleToolStripMenuItem_Click);
            // 
            // listaEnlazadaCircularToolStripMenuItem
            // 
            this.listaEnlazadaCircularToolStripMenuItem.Name = "listaEnlazadaCircularToolStripMenuItem";
            this.listaEnlazadaCircularToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.listaEnlazadaCircularToolStripMenuItem.Text = "Lista Enlazada Circular";
            this.listaEnlazadaCircularToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaCircularToolStripMenuItem_Click);
            // 
            // listaEnlazadaDobleToolStripMenuItem
            // 
            this.listaEnlazadaDobleToolStripMenuItem.Name = "listaEnlazadaDobleToolStripMenuItem";
            this.listaEnlazadaDobleToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.listaEnlazadaDobleToolStripMenuItem.Text = "Lista Enlazada Doble";
            this.listaEnlazadaDobleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaDobleToolStripMenuItem_Click);
            // 
            // listaEnlazadaDobleAnálisisToolStripMenuItem
            // 
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Name = "listaEnlazadaDobleAnálisisToolStripMenuItem";
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Text = "Lista Enlazada Doble Análisis";
            this.listaEnlazadaDobleAnálisisToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaDobleAnálisisToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // pilaYListaSimpleToolStripMenuItem
            // 
            this.pilaYListaSimpleToolStripMenuItem.Name = "pilaYListaSimpleToolStripMenuItem";
            this.pilaYListaSimpleToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pilaYListaSimpleToolStripMenuItem.Text = "Pila y Lista Simple";
            this.pilaYListaSimpleToolStripMenuItem.Click += new System.EventHandler(this.pilaYListaSimpleToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 387);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaCircularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaDobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaDobleAnálisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaYListaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
    }
}

