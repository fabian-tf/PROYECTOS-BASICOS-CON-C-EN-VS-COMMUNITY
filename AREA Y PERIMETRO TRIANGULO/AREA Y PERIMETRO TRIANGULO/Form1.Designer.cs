namespace AREA_Y_PERIMETRO_TRIANGULO
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LADO2 = new System.Windows.Forms.TextBox();
            this.BASE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PERIMETRO = new System.Windows.Forms.Label();
            this.LADO1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AREA = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERIMETRO Y AREA DE UN TRIANGULO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "TRIANGULO ISOSCELES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LADO2
            // 
            this.LADO2.Location = new System.Drawing.Point(652, 124);
            this.LADO2.Name = "LADO2";
            this.LADO2.Size = new System.Drawing.Size(100, 22);
            this.LADO2.TabIndex = 2;
            // 
            // BASE
            // 
            this.BASE.Location = new System.Drawing.Point(652, 161);
            this.BASE.Name = "BASE";
            this.BASE.Size = new System.Drawing.Size(100, 22);
            this.BASE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "LADO 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "BASE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "LADO 2";
            // 
            // PERIMETRO
            // 
            this.PERIMETRO.AutoSize = true;
            this.PERIMETRO.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERIMETRO.Location = new System.Drawing.Point(549, 396);
            this.PERIMETRO.Name = "PERIMETRO";
            this.PERIMETRO.Size = new System.Drawing.Size(113, 30);
            this.PERIMETRO.TabIndex = 7;
            this.PERIMETRO.Text = "Perimetro";
            this.PERIMETRO.Click += new System.EventHandler(this.label5_Click);
            // 
            // LADO1
            // 
            this.LADO1.Location = new System.Drawing.Point(652, 81);
            this.LADO1.Name = "LADO1";
            this.LADO1.Size = new System.Drawing.Size(100, 22);
            this.LADO1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AREA
            // 
            this.AREA.AutoSize = true;
            this.AREA.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AREA.Location = new System.Drawing.Point(552, 360);
            this.AREA.Name = "AREA";
            this.AREA.Size = new System.Drawing.Size(60, 30);
            this.AREA.TabIndex = 10;
            this.AREA.Text = "Area";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 72);
            this.button2.TabIndex = 11;
            this.button2.Text = "TRIANGULO EQUILATERO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 72);
            this.button3.TabIndex = 12;
            this.button3.Text = "TRIANGULO ESCALENO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 467);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AREA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LADO1);
            this.Controls.Add(this.PERIMETRO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BASE);
            this.Controls.Add(this.LADO2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LADO2;
        private System.Windows.Forms.TextBox BASE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PERIMETRO;
        private System.Windows.Forms.TextBox LADO1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AREA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

