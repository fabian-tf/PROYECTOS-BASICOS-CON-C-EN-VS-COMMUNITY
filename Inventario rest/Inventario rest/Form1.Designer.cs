namespace Inventario_rest
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
            GUARDAR = new Button();
            ACTUALIZAR = new Button();
            ELIMINAR = new Button();
            LIMPIAR = new Button();
            ATRAS = new Button();
            BUSCAR = new Button();
            CODIGO = new TextBox();
            NOMBRE = new TextBox();
            CANTIDAD_UND = new TextBox();
            CANTIDAD_KG = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ID = new TextBox();
            SuspendLayout();
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(46, 232);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(121, 65);
            GUARDAR.TabIndex = 0;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            GUARDAR.Click += GUARDAR_Click;
            // 
            // ACTUALIZAR
            // 
            ACTUALIZAR.Location = new Point(209, 232);
            ACTUALIZAR.Name = "ACTUALIZAR";
            ACTUALIZAR.Size = new Size(121, 65);
            ACTUALIZAR.TabIndex = 1;
            ACTUALIZAR.Text = "ACTUALIZAR";
            ACTUALIZAR.UseVisualStyleBackColor = true;
            ACTUALIZAR.Click += ACTUALIZAR_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.Location = new Point(387, 232);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(121, 65);
            ELIMINAR.TabIndex = 2;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = true;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(556, 232);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(121, 65);
            LIMPIAR.TabIndex = 3;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += LIMPIAR_Click;
            // 
            // ATRAS
            // 
            ATRAS.Location = new Point(556, 140);
            ATRAS.Name = "ATRAS";
            ATRAS.Size = new Size(121, 65);
            ATRAS.TabIndex = 4;
            ATRAS.Text = "ATRAS";
            ATRAS.UseVisualStyleBackColor = true;
            ATRAS.Click += ATRAS_Click;
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(556, 29);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(121, 65);
            BUSCAR.TabIndex = 5;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // CODIGO
            // 
            CODIGO.Location = new Point(289, 48);
            CODIGO.Name = "CODIGO";
            CODIGO.Size = new Size(128, 27);
            CODIGO.TabIndex = 6;
            CODIGO.TextChanged += textBox1_TextChanged;
            // 
            // NOMBRE
            // 
            NOMBRE.Location = new Point(289, 88);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(250, 27);
            NOMBRE.TabIndex = 7;
            // 
            // CANTIDAD_UND
            // 
            CANTIDAD_UND.Location = new Point(289, 140);
            CANTIDAD_UND.Name = "CANTIDAD_UND";
            CANTIDAD_UND.Size = new Size(128, 27);
            CANTIDAD_UND.TabIndex = 8;
            // 
            // CANTIDAD_KG
            // 
            CANTIDAD_KG.Location = new Point(289, 189);
            CANTIDAD_KG.Name = "CANTIDAD_KG";
            CANTIDAD_KG.Size = new Size(128, 27);
            CANTIDAD_KG.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 49);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 10;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 93);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 145);
            label3.Name = "label3";
            label3.Size = new Size(232, 22);
            label3.TabIndex = 12;
            label3.Text = "Cantidad en unidades";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 194);
            label4.Name = "label4";
            label4.Size = new Size(139, 22);
            label4.TabIndex = 13;
            label4.Text = "Cantidad KG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(-1, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 26);
            label5.TabIndex = 14;
            label5.Text = "INVENTARIO";
            // 
            // ID
            // 
            ID.Location = new Point(434, 140);
            ID.Name = "ID";
            ID.Size = new Size(105, 27);
            ID.TabIndex = 15;
            ID.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 327);
            Controls.Add(ID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CANTIDAD_KG);
            Controls.Add(CANTIDAD_UND);
            Controls.Add(NOMBRE);
            Controls.Add(CODIGO);
            Controls.Add(BUSCAR);
            Controls.Add(ATRAS);
            Controls.Add(LIMPIAR);
            Controls.Add(ELIMINAR);
            Controls.Add(ACTUALIZAR);
            Controls.Add(GUARDAR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GUARDAR;
        private Button ACTUALIZAR;
        private Button ELIMINAR;
        private Button LIMPIAR;
        private Button ATRAS;
        private Button BUSCAR;
        private TextBox CODIGO;
        private TextBox NOMBRE;
        private TextBox CANTIDAD_UND;
        private TextBox CANTIDAD_KG;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ID;
    }
}
