namespace Zapateria
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
            DatosDelProducto = new GroupBox();
            PRECIO_PUBLICO = new TextBox();
            textBoxID = new TextBox();
            LIMPIAR = new Button();
            GUARDAR = new Button();
            ACTUALIZAR = new Button();
            ELIMINAR = new Button();
            BUSCAR = new Button();
            NOMBRE = new TextBox();
            EXISTENCIA = new TextBox();
            CODIGO = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DESCRPCION = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            DatosDelProducto.SuspendLayout();
            SuspendLayout();
            // 
            // DatosDelProducto
            // 
            DatosDelProducto.Controls.Add(PRECIO_PUBLICO);
            DatosDelProducto.Controls.Add(textBoxID);
            DatosDelProducto.Controls.Add(LIMPIAR);
            DatosDelProducto.Controls.Add(GUARDAR);
            DatosDelProducto.Controls.Add(ACTUALIZAR);
            DatosDelProducto.Controls.Add(ELIMINAR);
            DatosDelProducto.Controls.Add(BUSCAR);
            DatosDelProducto.Controls.Add(NOMBRE);
            DatosDelProducto.Controls.Add(DESCRPCION);
            DatosDelProducto.Controls.Add(EXISTENCIA);
            DatosDelProducto.Controls.Add(CODIGO);
            DatosDelProducto.Controls.Add(label5);
            DatosDelProducto.Controls.Add(label4);
            DatosDelProducto.Controls.Add(label3);
            DatosDelProducto.Controls.Add(label2);
            DatosDelProducto.Controls.Add(label1);
            DatosDelProducto.Location = new Point(42, 41);
            DatosDelProducto.Name = "DatosDelProducto";
            DatosDelProducto.Size = new Size(631, 376);
            DatosDelProducto.TabIndex = 0;
            DatosDelProducto.TabStop = false;
            DatosDelProducto.Text = "Datos de los productos";
            DatosDelProducto.Enter += DatosDelProducto_Enter;
            // 
            // PRECIO_PUBLICO
            // 
            PRECIO_PUBLICO.Location = new Point(168, 244);
            PRECIO_PUBLICO.Name = "PRECIO_PUBLICO";
            PRECIO_PUBLICO.Size = new Size(125, 27);
            PRECIO_PUBLICO.TabIndex = 16;
            PRECIO_PUBLICO.TextChanged += textBox1_TextChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(338, 244);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 15;
            textBoxID.Visible = false;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(425, 325);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(94, 29);
            LIMPIAR.TabIndex = 14;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += button5_Click;
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(11, 325);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(94, 29);
            GUARDAR.TabIndex = 13;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            GUARDAR.Click += button4_Click;
            // 
            // ACTUALIZAR
            // 
            ACTUALIZAR.Location = new Point(153, 325);
            ACTUALIZAR.Name = "ACTUALIZAR";
            ACTUALIZAR.Size = new Size(112, 29);
            ACTUALIZAR.TabIndex = 12;
            ACTUALIZAR.Text = "ACTUALIZAR";
            ACTUALIZAR.UseVisualStyleBackColor = true;
            ACTUALIZAR.Click += button3_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.Location = new Point(307, 325);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(94, 29);
            ELIMINAR.TabIndex = 11;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = true;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(338, 52);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(94, 29);
            BUSCAR.TabIndex = 10;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // NOMBRE
            // 
            NOMBRE.Location = new Point(168, 87);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(295, 27);
            NOMBRE.TabIndex = 9;
            // 
            // EXISTENCIA
            // 
            EXISTENCIA.Location = new Point(168, 280);
            EXISTENCIA.Name = "EXISTENCIA";
            EXISTENCIA.Size = new Size(125, 27);
            EXISTENCIA.TabIndex = 6;
            // 
            // CODIGO
            // 
            CODIGO.Location = new Point(168, 53);
            CODIGO.Name = "CODIGO";
            CODIGO.Size = new Size(125, 27);
            CODIGO.TabIndex = 5;
            CODIGO.TextChanged += CODIGO_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 287);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Existencias";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 251);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio Publico ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 132);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 93);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 53);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo ";
            // 
            // DESCRPCION
            // 
            DESCRPCION.Location = new Point(168, 125);
            DESCRPCION.Multiline = true;
            DESCRPCION.Name = "DESCRPCION";
            DESCRPCION.Size = new Size(295, 113);
            DESCRPCION.TabIndex = 7;
            DESCRPCION.TextChanged += DESCRPCION_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 599);
            Controls.Add(DatosDelProducto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DatosDelProducto.ResumeLayout(false);
            DatosDelProducto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DatosDelProducto;
        private TextBox NOMBRE;
        private TextBox EXISTENCIA;
        private TextBox CODIGO;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button GUARDAR;
        private Button ACTUALIZAR;
        private Button ELIMINAR;
        private Button BUSCAR;
        private Button LIMPIAR;
        private TextBox textBoxID;
        private TextBox PRECIO_PUBLICO;
        private TextBox DESCRPCION;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
