namespace Indice_masa_corporal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lavel3 = new System.Windows.Forms.Label();
            this.lavel5 = new System.Windows.Forms.Label();
            this.lavel6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PESO = new System.Windows.Forms.TextBox();
            this.ALTURA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULADORA IMC";
            // 
            // lavel3
            // 
            this.lavel3.AutoSize = true;
            this.lavel3.Location = new System.Drawing.Point(566, 120);
            this.lavel3.Name = "lavel3";
            this.lavel3.Size = new System.Drawing.Size(90, 16);
            this.lavel3.TabIndex = 2;
            this.lavel3.Text = "Cuanto pesas";
            // 
            // lavel5
            // 
            this.lavel5.AutoSize = true;
            this.lavel5.Location = new System.Drawing.Point(565, 156);
            this.lavel5.Name = "lavel5";
            this.lavel5.Size = new System.Drawing.Size(89, 16);
            this.lavel5.TabIndex = 3;
            this.lavel5.Text = "Cuanto mides";
            // 
            // lavel6
            // 
            this.lavel6.AutoSize = true;
            this.lavel6.Location = new System.Drawing.Point(583, 350);
            this.lavel6.Name = "lavel6";
            this.lavel6.Size = new System.Drawing.Size(0, 16);
            this.lavel6.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PESO
            // 
            this.PESO.Location = new System.Drawing.Point(722, 114);
            this.PESO.Name = "PESO";
            this.PESO.Size = new System.Drawing.Size(100, 22);
            this.PESO.TabIndex = 6;
            // 
            // ALTURA
            // 
            this.ALTURA.Location = new System.Drawing.Point(722, 149);
            this.ALTURA.Name = "ALTURA";
            this.ALTURA.Size = new System.Drawing.Size(100, 22);
            this.ALTURA.TabIndex = 7;
            this.ALTURA.TextChanged += new System.EventHandler(this.ALTURA_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ALTURA);
            this.Controls.Add(this.PESO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lavel6);
            this.Controls.Add(this.lavel5);
            this.Controls.Add(this.lavel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lavel3;
        private System.Windows.Forms.Label lavel5;
        private System.Windows.Forms.Label lavel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PESO;
        private System.Windows.Forms.TextBox ALTURA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

