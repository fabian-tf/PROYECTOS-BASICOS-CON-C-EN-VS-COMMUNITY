namespace APRENDIZAJE
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
            this.BTNCAMBIAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXT
            // 
            this.TEXT.AutoSize = true;
            this.TEXT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TEXT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TEXT.Location = new System.Drawing.Point(609, 266);
            this.TEXT.Name = "TEXT";
            this.TEXT.Size = new System.Drawing.Size(97, 16);
            this.TEXT.TabIndex = 0;
            this.TEXT.Text = "HOLA MUNDO";
            // 
            // BTNCAMBIAR
            // 
            this.BTNCAMBIAR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNCAMBIAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNCAMBIAR.Location = new System.Drawing.Point(349, 218);
            this.BTNCAMBIAR.Name = "BTNCAMBIAR";
            this.BTNCAMBIAR.Size = new System.Drawing.Size(134, 90);
            this.BTNCAMBIAR.TabIndex = 1;
            this.BTNCAMBIAR.Text = "ENTRAR";
            this.BTNCAMBIAR.UseVisualStyleBackColor = false;
            this.BTNCAMBIAR.Click += new System.EventHandler(this.BTNCAMBIAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 530);
            this.Controls.Add(this.BTNCAMBIAR);
            this.Controls.Add(this.TEXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TEXT;
        private System.Windows.Forms.Button BTNCAMBIAR;
    }
}

