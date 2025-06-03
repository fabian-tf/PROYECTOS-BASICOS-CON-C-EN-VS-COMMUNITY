namespace area_y_perimetro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TEX1 = new System.Windows.Forms.Label();
            this.BUTTON = new System.Windows.Forms.Button();
            this.BOX = new System.Windows.Forms.TextBox();
            this.TEXarea = new System.Windows.Forms.Label();
            this.TEXperimetro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TEX1
            // 
            this.TEX1.AutoSize = true;
            this.TEX1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEX1.Location = new System.Drawing.Point(743, 169);
            this.TEX1.Name = "TEX1";
            this.TEX1.Size = new System.Drawing.Size(194, 23);
            this.TEX1.TabIndex = 0;
            this.TEX1.Text = "Cuanto mide cada lado";
            // 
            // BUTTON
            // 
            this.BUTTON.Location = new System.Drawing.Point(836, 227);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(152, 71);
            this.BUTTON.TabIndex = 1;
            this.BUTTON.Text = "CALCULAR";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            // 
            // BOX
            // 
            this.BOX.Location = new System.Drawing.Point(974, 169);
            this.BOX.Name = "BOX";
            this.BOX.Size = new System.Drawing.Size(100, 22);
            this.BOX.TabIndex = 2;
            // 
            // TEXarea
            // 
            this.TEXarea.AutoSize = true;
            this.TEXarea.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXarea.Location = new System.Drawing.Point(758, 337);
            this.TEXarea.Name = "TEXarea";
            this.TEXarea.Size = new System.Drawing.Size(46, 23);
            this.TEXarea.TabIndex = 3;
            this.TEXarea.Text = "Area";
            // 
            // TEXperimetro
            // 
            this.TEXperimetro.AutoSize = true;
            this.TEXperimetro.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXperimetro.Location = new System.Drawing.Point(758, 385);
            this.TEXperimetro.Name = "TEXperimetro";
            this.TEXperimetro.Size = new System.Drawing.Size(87, 23);
            this.TEXperimetro.TabIndex = 4;
            this.TEXperimetro.Text = "Perimetro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "AREA Y PERIMETRO DEL CUADRADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TEXperimetro);
            this.Controls.Add(this.TEXarea);
            this.Controls.Add(this.BOX);
            this.Controls.Add(this.BUTTON);
            this.Controls.Add(this.TEX1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TEX1;
        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.TextBox BOX;
        private System.Windows.Forms.Label TEXarea;
        private System.Windows.Forms.Label TEXperimetro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

