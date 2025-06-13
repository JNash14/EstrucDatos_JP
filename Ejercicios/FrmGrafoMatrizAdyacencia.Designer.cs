namespace Ejercicios
{
    partial class FrmGrafoMatrizAdyacencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertarRaiz = new System.Windows.Forms.Button();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.btnMatrizAdyacencia = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtAmplitud = new System.Windows.Forms.TextBox();
            this.txtProfundidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRAFO DIRIGIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destino:";
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(30, 147);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(120, 28);
            this.btnInsertarRaiz.TabIndex = 2;
            this.btnInsertarRaiz.Text = "Insertar";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnInsertarRaiz_Click);
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfundidad.Location = new System.Drawing.Point(192, 370);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(98, 28);
            this.btnProfundidad.TabIndex = 2;
            this.btnProfundidad.Text = "Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmplitud.Location = new System.Drawing.Point(192, 326);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(98, 29);
            this.btnAmplitud.TabIndex = 2;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // btnMatrizAdyacencia
            // 
            this.btnMatrizAdyacencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrizAdyacencia.Location = new System.Drawing.Point(192, 71);
            this.btnMatrizAdyacencia.Name = "btnMatrizAdyacencia";
            this.btnMatrizAdyacencia.Size = new System.Drawing.Size(418, 37);
            this.btnMatrizAdyacencia.TabIndex = 2;
            this.btnMatrizAdyacencia.Text = "Matriz Adyacencia";
            this.btnMatrizAdyacencia.UseVisualStyleBackColor = true;
            this.btnMatrizAdyacencia.Click += new System.EventHandler(this.btnMatrizAdyacencia_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(38, 186);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(104, 199);
            this.lstBox.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(192, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 192);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(83, 89);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(67, 20);
            this.txtOrigen.TabIndex = 5;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(83, 118);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(67, 20);
            this.txtDestino.TabIndex = 5;
            // 
            // txtAmplitud
            // 
            this.txtAmplitud.Location = new System.Drawing.Point(306, 331);
            this.txtAmplitud.Name = "txtAmplitud";
            this.txtAmplitud.Size = new System.Drawing.Size(304, 20);
            this.txtAmplitud.TabIndex = 5;
            // 
            // txtProfundidad
            // 
            this.txtProfundidad.Location = new System.Drawing.Point(306, 373);
            this.txtProfundidad.Name = "txtProfundidad";
            this.txtProfundidad.Size = new System.Drawing.Size(304, 20);
            this.txtProfundidad.TabIndex = 5;
            // 
            // FrmGrafoMatrizAdyacencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 426);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtProfundidad);
            this.Controls.Add(this.txtAmplitud);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnMatrizAdyacencia);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.btnProfundidad);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGrafoMatrizAdyacencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrafoMatrizAdyacencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Button btnMatrizAdyacencia;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtAmplitud;
        private System.Windows.Forms.TextBox txtProfundidad;
    }
}