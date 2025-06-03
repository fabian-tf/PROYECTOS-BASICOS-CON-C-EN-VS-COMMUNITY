namespace Patillos
{
    partial class Form1
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
            label7 = new Label();
            ATRAS = new Button();
            BUSCAR = new Button();
            LIMPIAR = new Button();
            ELIMINAR = new Button();
            ACTUALIZAR = new Button();
            GUARDAR = new Button();
            ID = new TextBox();
            PRECIO = new TextBox();
            COSTOS = new TextBox();
            INGREDIENTES = new TextBox();
            NOMBRE = new TextBox();
            CODIGO = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stylus BT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 12);
            label7.Name = "label7";
            label7.Size = new Size(57, 24);
            label7.TabIndex = 37;
            label7.Text = "Menu";
            // 
            // ATRAS
            // 
            ATRAS.Location = new Point(432, 150);
            ATRAS.Name = "ATRAS";
            ATRAS.Size = new Size(119, 60);
            ATRAS.TabIndex = 36;
            ATRAS.Text = "ATRAS";
            ATRAS.UseVisualStyleBackColor = true;
            ATRAS.Click += ATRAS_Click;
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(432, 32);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(119, 60);
            BUSCAR.TabIndex = 35;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(289, 287);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(119, 60);
            LIMPIAR.TabIndex = 34;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += LIMPIAR_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.Location = new Point(432, 287);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(119, 60);
            ELIMINAR.TabIndex = 33;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = true;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // ACTUALIZAR
            // 
            ACTUALIZAR.Location = new Point(156, 287);
            ACTUALIZAR.Name = "ACTUALIZAR";
            ACTUALIZAR.Size = new Size(119, 60);
            ACTUALIZAR.TabIndex = 32;
            ACTUALIZAR.Text = "ACTUALIZAR";
            ACTUALIZAR.UseVisualStyleBackColor = true;
            ACTUALIZAR.Click += ACTUALIZAR_Click;
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(18, 287);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(119, 60);
            GUARDAR.TabIndex = 31;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            GUARDAR.Click += GUARDAR_Click;
            // 
            // ID
            // 
            ID.Location = new Point(301, 196);
            ID.Name = "ID";
            ID.Size = new Size(125, 27);
            ID.TabIndex = 30;
            ID.Visible = false;
            // 
            // PRECIO
            // 
            PRECIO.Location = new Point(168, 252);
            PRECIO.Name = "PRECIO";
            PRECIO.Size = new Size(125, 27);
            PRECIO.TabIndex = 29;
            // 
            // COSTOS
            // 
            COSTOS.Location = new Point(168, 196);
            COSTOS.Name = "COSTOS";
            COSTOS.Size = new Size(125, 27);
            COSTOS.TabIndex = 28;
            // 
            // INGREDIENTES
            // 
            INGREDIENTES.Location = new Point(168, 105);
            INGREDIENTES.Multiline = true;
            INGREDIENTES.Name = "INGREDIENTES";
            INGREDIENTES.Size = new Size(258, 85);
            INGREDIENTES.TabIndex = 27;
            // 
            // NOMBRE
            // 
            NOMBRE.Location = new Point(168, 72);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(193, 27);
            NOMBRE.TabIndex = 26;
            // 
            // CODIGO
            // 
            CODIGO.Location = new Point(168, 39);
            CODIGO.Name = "CODIGO";
            CODIGO.Size = new Size(125, 27);
            CODIGO.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 226);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 259);
            label5.Name = "label5";
            label5.Size = new Size(77, 22);
            label5.TabIndex = 23;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 203);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 22;
            label4.Text = "Costos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 112);
            label3.Name = "label3";
            label3.Size = new Size(144, 22);
            label3.TabIndex = 21;
            label3.Text = "Ingredientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 79);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 19;
            label1.Text = "Codigo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 363);
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button ATRAS;
        private Button BUSCAR;
        private Button LIMPIAR;
        private Button ELIMINAR;
        private Button ACTUALIZAR;
        private Button GUARDAR;
        private TextBox ID;
        private TextBox PRECIO;
        private TextBox COSTOS;
        private TextBox INGREDIENTES;
        private TextBox NOMBRE;
        private TextBox CODIGO;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
