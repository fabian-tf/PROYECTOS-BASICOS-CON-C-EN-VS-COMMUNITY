namespace Tiempo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SEGUNDOS = new System.Windows.Forms.TextBox();
            this.HORAS = new System.Windows.Forms.TextBox();
            this.DIAS = new System.Windows.Forms.TextBox();
            this.AÑOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RESULTADO = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MINUTOS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Segundos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(201, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Horas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(383, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dias";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(559, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Años";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SEGUNDOS
            // 
            this.SEGUNDOS.Location = new System.Drawing.Point(162, 80);
            this.SEGUNDOS.Name = "SEGUNDOS";
            this.SEGUNDOS.Size = new System.Drawing.Size(100, 22);
            this.SEGUNDOS.TabIndex = 4;
            // 
            // HORAS
            // 
            this.HORAS.Location = new System.Drawing.Point(784, 83);
            this.HORAS.Name = "HORAS";
            this.HORAS.Size = new System.Drawing.Size(100, 22);
            this.HORAS.TabIndex = 5;
            // 
            // DIAS
            // 
            this.DIAS.Location = new System.Drawing.Point(162, 156);
            this.DIAS.Name = "DIAS";
            this.DIAS.Size = new System.Drawing.Size(100, 22);
            this.DIAS.TabIndex = 6;
            // 
            // AÑOS
            // 
            this.AÑOS.Location = new System.Drawing.Point(434, 159);
            this.AÑOS.Name = "AÑOS";
            this.AÑOS.Size = new System.Drawing.Size(100, 22);
            this.AÑOS.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Segundos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Años";
            // 
            // RESULTADO
            // 
            this.RESULTADO.AutoSize = true;
            this.RESULTADO.Location = new System.Drawing.Point(366, 394);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(112, 16);
            this.RESULTADO.TabIndex = 12;
            this.RESULTADO.Text = "La conversion es:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(760, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 53);
            this.button5.TabIndex = 13;
            this.button5.Text = "Minutos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Minutos";
            // 
            // MINUTOS
            // 
            this.MINUTOS.Location = new System.Drawing.Point(434, 86);
            this.MINUTOS.Name = "MINUTOS";
            this.MINUTOS.Size = new System.Drawing.Size(100, 22);
            this.MINUTOS.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 517);
            this.Controls.Add(this.MINUTOS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AÑOS);
            this.Controls.Add(this.DIAS);
            this.Controls.Add(this.HORAS);
            this.Controls.Add(this.SEGUNDOS);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SEGUNDOS;
        private System.Windows.Forms.TextBox HORAS;
        private System.Windows.Forms.TextBox DIAS;
        private System.Windows.Forms.TextBox AÑOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RESULTADO;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MINUTOS;
    }
}

