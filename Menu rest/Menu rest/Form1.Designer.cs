namespace Inventario_restaurant
{
    partial class Inventario
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
            label6 = new Label();
            CODIGO = new TextBox();
            NOMBRE = new TextBox();
            INGREDIENTES = new TextBox();
            COSTOS = new TextBox();
            PRECIO = new TextBox();
            ID = new TextBox();
            GUARDAR = new Button();
            ACTUALIZAR = new Button();
            ELIMINAR = new Button();
            LIMPIAR = new Button();
            BUSCAR = new Button();
            ATRAS = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 76);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 109);
            label3.Name = "label3";
            label3.Size = new Size(144, 22);
            label3.TabIndex = 2;
            label3.Text = "Ingredientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 200);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 3;
            label4.Text = "Costos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 256);
            label5.Name = "label5";
            label5.Size = new Size(77, 22);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 223);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // CODIGO
            // 
            CODIGO.Location = new Point(168, 36);
            CODIGO.Name = "CODIGO";
            CODIGO.Size = new Size(125, 27);
            CODIGO.TabIndex = 6;
            CODIGO.TextChanged += textBox1_TextChanged;
            // 
            // NOMBRE
            // 
            NOMBRE.Location = new Point(168, 69);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(193, 27);
            NOMBRE.TabIndex = 7;
            // 
            // INGREDIENTES
            // 
            INGREDIENTES.Location = new Point(168, 102);
            INGREDIENTES.Multiline = true;
            INGREDIENTES.Name = "INGREDIENTES";
            INGREDIENTES.Size = new Size(258, 85);
            INGREDIENTES.TabIndex = 8;
            // 
            // COSTOS
            // 
            COSTOS.Location = new Point(168, 193);
            COSTOS.Name = "COSTOS";
            COSTOS.Size = new Size(125, 27);
            COSTOS.TabIndex = 9;
            // 
            // PRECIO
            // 
            PRECIO.Location = new Point(168, 249);
            PRECIO.Name = "PRECIO";
            PRECIO.Size = new Size(125, 27);
            PRECIO.TabIndex = 10;
            // 
            // ID
            // 
            ID.Location = new Point(301, 193);
            ID.Name = "ID";
            ID.Size = new Size(125, 27);
            ID.TabIndex = 11;
            ID.Visible = false;
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(18, 284);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(119, 60);
            GUARDAR.TabIndex = 12;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            GUARDAR.Click += button1_Click;
            // 
            // ACTUALIZAR
            // 
            ACTUALIZAR.Location = new Point(156, 284);
            ACTUALIZAR.Name = "ACTUALIZAR";
            ACTUALIZAR.Size = new Size(119, 60);
            ACTUALIZAR.TabIndex = 13;
            ACTUALIZAR.Text = "ACTUALIZAR";
            ACTUALIZAR.UseVisualStyleBackColor = true;
            ACTUALIZAR.Click += ACTUALIZAR_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.Location = new Point(432, 284);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(119, 60);
            ELIMINAR.TabIndex = 14;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = true;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(289, 284);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(119, 60);
            LIMPIAR.TabIndex = 15;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += LIMPIAR_Click;
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(432, 29);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(119, 60);
            BUSCAR.TabIndex = 16;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // ATRAS
            // 
            ATRAS.Location = new Point(432, 147);
            ATRAS.Name = "ATRAS";
            ATRAS.Size = new Size(119, 60);
            ATRAS.TabIndex = 17;
            ATRAS.Text = "ATRAS";
            ATRAS.UseVisualStyleBackColor = true;
            ATRAS.Click += ATRAS_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stylus BT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(57, 24);
            label7.TabIndex = 18;
            label7.Text = "Menu";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 369);
            Controls.Add(label7);
            Controls.Add(ATRAS);
            Controls.Add(BUSCAR);
            Controls.Add(LIMPIAR);
            Controls.Add(ELIMINAR);
            Controls.Add(ACTUALIZAR);
            Controls.Add(GUARDAR);
            Controls.Add(ID);
            Controls.Add(PRECIO);
            Controls.Add(COSTOS);
            Controls.Add(INGREDIENTES);
            Controls.Add(NOMBRE);
            Controls.Add(CODIGO);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inventario";
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
        private Label label6;
        private TextBox CODIGO;
        private TextBox NOMBRE;
        private TextBox INGREDIENTES;
        private TextBox COSTOS;
        private TextBox PRECIO;
        private TextBox ID;
        private Button GUARDAR;
        private Button ACTUALIZAR;
        private Button ELIMINAR;
        private Button LIMPIAR;
        private Button BUSCAR;
        private Button ATRAS;
        private Label label7;
    }
}
