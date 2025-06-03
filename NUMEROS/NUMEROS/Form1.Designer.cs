namespace NUMEROS
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
            this.TEXT = new System.Windows.Forms.Label();
            this.BOTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXT
            // 
            this.TEXT.AutoSize = true;
            this.TEXT.Location = new System.Drawing.Point(511, 95);
            this.TEXT.Name = "TEXT";
            this.TEXT.Size = new System.Drawing.Size(76, 16);
            this.TEXT.TabIndex = 0;
            this.TEXT.Text = "NUMEROS";
            // 
            // BOTTON
            // 
            this.BOTTON.Location = new System.Drawing.Point(480, 207);
            this.BOTTON.Name = "BOTTON";
            this.BOTTON.Size = new System.Drawing.Size(136, 74);
            this.BOTTON.TabIndex = 1;
            this.BOTTON.Text = "OPRIMIR";
            this.BOTTON.UseVisualStyleBackColor = true;
            this.BOTTON.Click += new System.EventHandler(this.BOTTON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 450);
            this.Controls.Add(this.BOTTON);
            this.Controls.Add(this.TEXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TEXT;
        private System.Windows.Forms.Button BOTTON;
    }
}

