namespace BOOL
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
            this.BUTTON = new System.Windows.Forms.Button();
            this.TEXT = new System.Windows.Forms.Label();
            this.CAPTURAR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BUTTON
            // 
            this.BUTTON.Location = new System.Drawing.Point(520, 250);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(165, 84);
            this.BUTTON.TabIndex = 0;
            this.BUTTON.Text = "OPRIMIR";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            // 
            // TEXT
            // 
            this.TEXT.AutoSize = true;
            this.TEXT.Location = new System.Drawing.Point(527, 145);
            this.TEXT.Name = "TEXT";
            this.TEXT.Size = new System.Drawing.Size(113, 16);
            this.TEXT.TabIndex = 1;
            this.TEXT.Text = "Que edad tienes?";
            // 
            // CAPTURAR
            // 
            this.CAPTURAR.Location = new System.Drawing.Point(540, 204);
            this.CAPTURAR.Name = "CAPTURAR";
            this.CAPTURAR.Size = new System.Drawing.Size(100, 22);
            this.CAPTURAR.TabIndex = 2;
            this.CAPTURAR.TextChanged += new System.EventHandler(this.CAPTURAR_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.CAPTURAR);
            this.Controls.Add(this.TEXT);
            this.Controls.Add(this.BUTTON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.Label TEXT;
        private System.Windows.Forms.TextBox CAPTURAR;
    }
}

