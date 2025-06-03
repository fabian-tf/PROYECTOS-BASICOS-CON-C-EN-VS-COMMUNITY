namespace GANANCIA_MES
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
            this.label1 = new System.Windows.Forms.Label();
            this.GANANCIAS = new System.Windows.Forms.TextBox();
            this.DIA1 = new System.Windows.Forms.Button();
            this.SEMANA = new System.Windows.Forms.Button();
            this.QUINCENA = new System.Windows.Forms.Button();
            this.RESULTADO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUANTO GANAS POR MES";
            // 
            // GANANCIAS
            // 
            this.GANANCIAS.Location = new System.Drawing.Point(320, 64);
            this.GANANCIAS.Name = "GANANCIAS";
            this.GANANCIAS.Size = new System.Drawing.Size(100, 22);
            this.GANANCIAS.TabIndex = 1;
            // 
            // DIA1
            // 
            this.DIA1.Location = new System.Drawing.Point(70, 174);
            this.DIA1.Name = "DIA1";
            this.DIA1.Size = new System.Drawing.Size(122, 63);
            this.DIA1.TabIndex = 2;
            this.DIA1.Text = "DIA 1";
            this.DIA1.UseVisualStyleBackColor = true;
            this.DIA1.Click += new System.EventHandler(this.DIA1_Click);
            // 
            // SEMANA
            // 
            this.SEMANA.Location = new System.Drawing.Point(244, 173);
            this.SEMANA.Name = "SEMANA";
            this.SEMANA.Size = new System.Drawing.Size(109, 64);
            this.SEMANA.TabIndex = 3;
            this.SEMANA.Text = "SEMANAL";
            this.SEMANA.UseVisualStyleBackColor = true;
            this.SEMANA.Click += new System.EventHandler(this.SEMANA_Click);
            // 
            // QUINCENA
            // 
            this.QUINCENA.Location = new System.Drawing.Point(390, 174);
            this.QUINCENA.Name = "QUINCENA";
            this.QUINCENA.Size = new System.Drawing.Size(131, 64);
            this.QUINCENA.TabIndex = 4;
            this.QUINCENA.Text = "QUINCENAL";
            this.QUINCENA.UseVisualStyleBackColor = true;
            this.QUINCENA.Click += new System.EventHandler(this.QUINCENA_Click);
            // 
            // RESULTADO
            // 
            this.RESULTADO.AutoSize = true;
            this.RESULTADO.Location = new System.Drawing.Point(215, 291);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(85, 16);
            this.RESULTADO.TabIndex = 5;
            this.RESULTADO.Text = "GANANCIAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.QUINCENA);
            this.Controls.Add(this.SEMANA);
            this.Controls.Add(this.DIA1);
            this.Controls.Add(this.GANANCIAS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GANANCIAS;
        private System.Windows.Forms.Button DIA1;
        private System.Windows.Forms.Button SEMANA;
        private System.Windows.Forms.Button QUINCENA;
        private System.Windows.Forms.Label RESULTADO;
    }
}

