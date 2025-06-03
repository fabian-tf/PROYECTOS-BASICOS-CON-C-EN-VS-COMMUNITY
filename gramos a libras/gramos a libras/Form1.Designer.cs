namespace gramos_a_libras
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
            this.GR = new System.Windows.Forms.Button();
            this.LB = new System.Windows.Forms.Button();
            this.KG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RESULTADO = new System.Windows.Forms.Label();
            this.GRAMOS = new System.Windows.Forms.TextBox();
            this.LIBRAS = new System.Windows.Forms.TextBox();
            this.KILOS = new System.Windows.Forms.TextBox();
            this.RESULTADO2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GR
            // 
            this.GR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GR.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GR.Location = new System.Drawing.Point(63, 157);
            this.GR.Name = "GR";
            this.GR.Size = new System.Drawing.Size(168, 72);
            this.GR.TabIndex = 0;
            this.GR.Text = "GRAMOS";
            this.GR.UseVisualStyleBackColor = false;
            this.GR.Click += new System.EventHandler(this.GR_Click);
            // 
            // LB
            // 
            this.LB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LB.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.Location = new System.Drawing.Point(364, 157);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(168, 72);
            this.LB.TabIndex = 1;
            this.LB.Text = "LIBRAS";
            this.LB.UseVisualStyleBackColor = false;
            this.LB.Click += new System.EventHandler(this.LB_Click);
            // 
            // KG
            // 
            this.KG.BackColor = System.Drawing.Color.RosyBrown;
            this.KG.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KG.Location = new System.Drawing.Point(617, 157);
            this.KG.Name = "KG";
            this.KG.Size = new System.Drawing.Size(168, 72);
            this.KG.TabIndex = 2;
            this.KG.Text = "KILOS";
            this.KG.UseVisualStyleBackColor = false;
            this.KG.Click += new System.EventHandler(this.KG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los gramos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese las libras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese los kilos";
            // 
            // RESULTADO
            // 
            this.RESULTADO.AutoSize = true;
            this.RESULTADO.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTADO.Location = new System.Drawing.Point(323, 315);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(0, 26);
            this.RESULTADO.TabIndex = 7;
            // 
            // GRAMOS
            // 
            this.GRAMOS.Location = new System.Drawing.Point(206, 44);
            this.GRAMOS.Name = "GRAMOS";
            this.GRAMOS.Size = new System.Drawing.Size(100, 22);
            this.GRAMOS.TabIndex = 8;
            // 
            // LIBRAS
            // 
            this.LIBRAS.Location = new System.Drawing.Point(518, 49);
            this.LIBRAS.Name = "LIBRAS";
            this.LIBRAS.Size = new System.Drawing.Size(100, 22);
            this.LIBRAS.TabIndex = 9;
            // 
            // KILOS
            // 
            this.KILOS.Location = new System.Drawing.Point(858, 47);
            this.KILOS.Name = "KILOS";
            this.KILOS.Size = new System.Drawing.Size(100, 22);
            this.KILOS.TabIndex = 10;
            // 
            // RESULTADO2
            // 
            this.RESULTADO2.AutoSize = true;
            this.RESULTADO2.Location = new System.Drawing.Point(373, 315);
            this.RESULTADO2.Name = "RESULTADO2";
            this.RESULTADO2.Size = new System.Drawing.Size(112, 16);
            this.RESULTADO2.TabIndex = 11;
            this.RESULTADO2.Text = "La conversion es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.RESULTADO2);
            this.Controls.Add(this.KILOS);
            this.Controls.Add(this.LIBRAS);
            this.Controls.Add(this.GRAMOS);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KG);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.GR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GR;
        private System.Windows.Forms.Button LB;
        private System.Windows.Forms.Button KG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RESULTADO;
        private System.Windows.Forms.TextBox GRAMOS;
        private System.Windows.Forms.TextBox LIBRAS;
        private System.Windows.Forms.TextBox KILOS;
        private System.Windows.Forms.Label RESULTADO2;
    }
}

