namespace SUMA
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
            this.NUM1 = new System.Windows.Forms.TextBox();
            this.NUM2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BUTTON
            // 
            this.BUTTON.Location = new System.Drawing.Point(527, 299);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(103, 41);
            this.BUTTON.TabIndex = 0;
            this.BUTTON.Text = "SUMAR";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            // 
            // TEXT
            // 
            this.TEXT.AutoSize = true;
            this.TEXT.Location = new System.Drawing.Point(506, 222);
            this.TEXT.Name = "TEXT";
            this.TEXT.Size = new System.Drawing.Size(0, 16);
            this.TEXT.TabIndex = 1;
            // 
            // NUM1
            // 
            this.NUM1.Location = new System.Drawing.Point(411, 120);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(100, 22);
            this.NUM1.TabIndex = 2;
            // 
            // NUM2
            // 
            this.NUM2.Location = new System.Drawing.Point(753, 119);
            this.NUM2.Name = "NUM2";
            this.NUM2.Size = new System.Drawing.Size(100, 22);
            this.NUM2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 450);
            this.Controls.Add(this.NUM2);
            this.Controls.Add(this.NUM1);
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
        private System.Windows.Forms.TextBox NUM1;
        private System.Windows.Forms.TextBox NUM2;
    }
}

