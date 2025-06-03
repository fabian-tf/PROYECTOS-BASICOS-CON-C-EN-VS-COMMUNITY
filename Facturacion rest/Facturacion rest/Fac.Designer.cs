namespace Facturacion_rest
{
    partial class Fac
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CODIGO = new TextBox();
            NOMBRE = new TextBox();
            PRECIO = new TextBox();
            CANTIDAD = new TextBox();
            RESULTADO = new TextBox();
            BUSCAR = new Button();
            ENTER = new Button();
            GUARDAR = new Button();
            FACTURAS = new Button();
            LIMPIAR = new Button();
            ATRAS = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 44);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 80);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 161);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 118);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 209);
            label5.Name = "label5";
            label5.Size = new Size(166, 22);
            label5.TabIndex = 4;
            label5.Text = "Total a pagar";
            // 
            // CODIGO
            // 
            CODIGO.Location = new Point(221, 39);
            CODIGO.Name = "CODIGO";
            CODIGO.Size = new Size(125, 27);
            CODIGO.TabIndex = 5;
            // 
            // NOMBRE
            // 
            NOMBRE.Location = new Point(221, 75);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(125, 27);
            NOMBRE.TabIndex = 6;
            // 
            // PRECIO
            // 
            PRECIO.Location = new Point(221, 113);
            PRECIO.Name = "PRECIO";
            PRECIO.Size = new Size(125, 27);
            PRECIO.TabIndex = 7;
            // 
            // CANTIDAD
            // 
            CANTIDAD.Location = new Point(221, 156);
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Size = new Size(125, 27);
            CANTIDAD.TabIndex = 8;
            // 
            // RESULTADO
            // 
            RESULTADO.Location = new Point(221, 204);
            RESULTADO.Name = "RESULTADO";
            RESULTADO.Size = new Size(125, 27);
            RESULTADO.TabIndex = 9;
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(49, 244);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(113, 55);
            BUSCAR.TabIndex = 11;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // ENTER
            // 
            ENTER.Location = new Point(221, 244);
            ENTER.Name = "ENTER";
            ENTER.Size = new Size(113, 55);
            ENTER.TabIndex = 12;
            ENTER.Text = "ENTER";
            ENTER.UseVisualStyleBackColor = true;
            ENTER.Click += ENTER_Click;
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(378, 244);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(113, 55);
            GUARDAR.TabIndex = 13;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            GUARDAR.Click += GUARDAR_Click;
            // 
            // FACTURAS
            // 
            FACTURAS.Location = new Point(378, 176);
            FACTURAS.Name = "FACTURAS";
            FACTURAS.Size = new Size(113, 55);
            FACTURAS.TabIndex = 14;
            FACTURAS.Text = "FACTURAS";
            FACTURAS.UseVisualStyleBackColor = true;
            FACTURAS.Click += FACTURAS_Click;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(378, 99);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(113, 55);
            LIMPIAR.TabIndex = 16;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += LIMPIAR_Click;
            // 
            // ATRAS
            // 
            ATRAS.Location = new Point(378, 25);
            ATRAS.Name = "ATRAS";
            ATRAS.Size = new Size(113, 55);
            ATRAS.TabIndex = 17;
            ATRAS.Text = "ATRAS";
            ATRAS.UseVisualStyleBackColor = true;
            ATRAS.Click += ATRAS_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(176, 32);
            label6.TabIndex = 18;
            label6.Text = "FACTURACION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 312);
            Controls.Add(label6);
            Controls.Add(ATRAS);
            Controls.Add(LIMPIAR);
            Controls.Add(FACTURAS);
            Controls.Add(GUARDAR);
            Controls.Add(ENTER);
            Controls.Add(BUSCAR);
            Controls.Add(RESULTADO);
            Controls.Add(CANTIDAD);
            Controls.Add(PRECIO);
            Controls.Add(NOMBRE);
            Controls.Add(CODIGO);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox CODIGO;
        private TextBox NOMBRE;
        private TextBox PRECIO;
        private TextBox CANTIDAD;
        private TextBox RESULTADO;
        private Button BUSCAR;
        private Button ENTER;
        private Button GUARDAR;
        private Button FACTURAS;
        private Button LIMPIAR;
        private Button ATRAS;
        private Label label6;
    }
}
