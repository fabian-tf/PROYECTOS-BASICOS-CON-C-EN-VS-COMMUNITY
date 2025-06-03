namespace VALOR_DIAS
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
            this.DIA8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GANANCIA = new System.Windows.Forms.Label();
            this.DINERO = new System.Windows.Forms.TextBox();
            this.DIA15 = new System.Windows.Forms.Button();
            this.DIA30 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DIA8
            // 
            this.DIA8.Location = new System.Drawing.Point(242, 214);
            this.DIA8.Name = "DIA8";
            this.DIA8.Size = new System.Drawing.Size(156, 78);
            this.DIA8.TabIndex = 0;
            this.DIA8.Text = "8 DIA";
            this.DIA8.UseVisualStyleBackColor = true;
            this.DIA8.Click += new System.EventHandler(this.DIA8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuanto ganas por dia";
            // 
            // GANANCIA
            // 
            this.GANANCIA.AutoSize = true;
            this.GANANCIA.Location = new System.Drawing.Point(507, 365);
            this.GANANCIA.Name = "GANANCIA";
            this.GANANCIA.Size = new System.Drawing.Size(85, 16);
            this.GANANCIA.TabIndex = 2;
            this.GANANCIA.Text = "GANANCIAS";
            // 
            // DINERO
            // 
            this.DINERO.Location = new System.Drawing.Point(585, 108);
            this.DINERO.Name = "DINERO";
            this.DINERO.Size = new System.Drawing.Size(100, 22);
            this.DINERO.TabIndex = 3;
            // 
            // DIA15
            // 
            this.DIA15.Location = new System.Drawing.Point(478, 214);
            this.DIA15.Name = "DIA15";
            this.DIA15.Size = new System.Drawing.Size(156, 78);
            this.DIA15.TabIndex = 4;
            this.DIA15.Text = "15 DIA";
            this.DIA15.UseVisualStyleBackColor = true;
            this.DIA15.Click += new System.EventHandler(this.DIA15_Click);
            // 
            // DIA30
            // 
            this.DIA30.Location = new System.Drawing.Point(680, 214);
            this.DIA30.Name = "DIA30";
            this.DIA30.Size = new System.Drawing.Size(156, 78);
            this.DIA30.TabIndex = 5;
            this.DIA30.Text = "30 DIA";
            this.DIA30.UseVisualStyleBackColor = true;
            this.DIA30.Click += new System.EventHandler(this.DIA30_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 552);
            this.Controls.Add(this.DIA30);
            this.Controls.Add(this.DIA15);
            this.Controls.Add(this.DINERO);
            this.Controls.Add(this.GANANCIA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DIA8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DIA8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GANANCIA;
        private System.Windows.Forms.TextBox DINERO;
        private System.Windows.Forms.Button DIA15;
        private System.Windows.Forms.Button DIA30;
    }
}

