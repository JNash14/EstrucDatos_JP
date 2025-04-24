namespace Ejercicios
{
    partial class FrmPila
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnElementos = new System.Windows.Forms.Button();
            this.bntVista = new System.Windows.Forms.Button();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnApilar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(78, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 26);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnElementos
            // 
            this.btnElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElementos.Location = new System.Drawing.Point(78, 313);
            this.btnElementos.Name = "btnElementos";
            this.btnElementos.Size = new System.Drawing.Size(90, 26);
            this.btnElementos.TabIndex = 21;
            this.btnElementos.Text = "# Elementos";
            this.btnElementos.UseVisualStyleBackColor = true;
            this.btnElementos.Click += new System.EventHandler(this.btnElementos_Click);
            // 
            // bntVista
            // 
            this.bntVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVista.Location = new System.Drawing.Point(78, 271);
            this.bntVista.Name = "bntVista";
            this.bntVista.Size = new System.Drawing.Size(90, 26);
            this.bntVista.TabIndex = 22;
            this.bntVista.Text = "Vistazo";
            this.bntVista.UseVisualStyleBackColor = true;
            this.bntVista.Click += new System.EventHandler(this.bntVista_Click);
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.Location = new System.Drawing.Point(199, 171);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(165, 251);
            this.listDatos.TabIndex = 19;
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesapilar.Location = new System.Drawing.Point(78, 228);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(90, 27);
            this.btnDesapilar.TabIndex = 17;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnApilar
            // 
            this.btnApilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApilar.Location = new System.Drawing.Point(78, 184);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(90, 28);
            this.btnApilar.TabIndex = 18;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(199, 109);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(165, 20);
            this.textNombre.TabIndex = 16;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "PILA (STACK) - LIFO";
            // 
            // FrmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 459);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnElementos);
            this.Controls.Add(this.bntVista);
            this.Controls.Add(this.listDatos);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnElementos;
        private System.Windows.Forms.Button bntVista;
        private System.Windows.Forms.ListBox listDatos;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}