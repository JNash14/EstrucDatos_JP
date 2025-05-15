namespace Ejercicios
{
    partial class FrmArbol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntAltura = new System.Windows.Forms.Button();
            this.btnInsertarRamas = new System.Windows.Forms.Button();
            this.btnInsertarRaiz = new System.Windows.Forms.Button();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioIzquierda = new System.Windows.Forms.RadioButton();
            this.radioDerecha = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // bntAltura
            // 
            this.bntAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAltura.Location = new System.Drawing.Point(51, 360);
            this.bntAltura.Name = "bntAltura";
            this.bntAltura.Size = new System.Drawing.Size(108, 26);
            this.bntAltura.TabIndex = 31;
            this.bntAltura.Text = "Altura";
            this.bntAltura.UseVisualStyleBackColor = true;
            this.bntAltura.Click += new System.EventHandler(this.bntAltura_Click);
            // 
            // btnInsertarRamas
            // 
            this.btnInsertarRamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRamas.Location = new System.Drawing.Point(47, 183);
            this.btnInsertarRamas.Name = "btnInsertarRamas";
            this.btnInsertarRamas.Size = new System.Drawing.Size(112, 32);
            this.btnInsertarRamas.TabIndex = 26;
            this.btnInsertarRamas.Text = "Insertar Ramas";
            this.btnInsertarRamas.UseVisualStyleBackColor = true;
            this.btnInsertarRamas.Click += new System.EventHandler(this.btnInsertarRamas_Click);
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(47, 143);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(112, 28);
            this.btnInsertarRaiz.TabIndex = 27;
            this.btnInsertarRaiz.Text = "Insertar Raíz";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnInsertarRaiz_Click);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(194, 93);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(171, 20);
            this.textNumero.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ingrese número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "ARBOL BINARIO";
            // 
            // radioIzquierda
            // 
            this.radioIzquierda.AutoSize = true;
            this.radioIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIzquierda.Location = new System.Drawing.Point(73, 232);
            this.radioIzquierda.Name = "radioIzquierda";
            this.radioIzquierda.Size = new System.Drawing.Size(80, 20);
            this.radioIzquierda.TabIndex = 32;
            this.radioIzquierda.TabStop = true;
            this.radioIzquierda.Text = "Izquierda";
            this.radioIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioDerecha
            // 
            this.radioDerecha.AutoSize = true;
            this.radioDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDerecha.Location = new System.Drawing.Point(73, 265);
            this.radioDerecha.Name = "radioDerecha";
            this.radioDerecha.Size = new System.Drawing.Size(77, 20);
            this.radioDerecha.TabIndex = 32;
            this.radioDerecha.TabStop = true;
            this.radioDerecha.Text = "Derecha";
            this.radioDerecha.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(195, 143);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(170, 271);
            this.treeView1.TabIndex = 33;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 460);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.radioDerecha);
            this.Controls.Add(this.radioIzquierda);
            this.Controls.Add(this.bntAltura);
            this.Controls.Add(this.btnInsertarRamas);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntAltura;
        private System.Windows.Forms.Button btnInsertarRamas;
        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioIzquierda;
        private System.Windows.Forms.RadioButton radioDerecha;
        private System.Windows.Forms.TreeView treeView1;
    }
}