namespace Empleados_restaurant
{
    partial class Empleados
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
            groupbox1 = new GroupBox();
            BUSCAR = new Button();
            ATRAS = new Button();
            LIMPIAR = new Button();
            ELIMINAR = new Button();
            ACTUALIZAR = new Button();
            GUARDAR = new Button();
            ID = new TextBox();
            RESIDENCIA = new TextBox();
            TELEFONO = new TextBox();
            CEDULA = new TextBox();
            APELLIDO = new TextBox();
            NOMBRE = new TextBox();
            CODIGO = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupbox1
            // 
            groupbox1.Controls.Add(BUSCAR);
            groupbox1.Controls.Add(ATRAS);
            groupbox1.Controls.Add(LIMPIAR);
            groupbox1.Controls.Add(ELIMINAR);
            groupbox1.Controls.Add(ACTUALIZAR);
            groupbox1.Controls.Add(GUARDAR);
            groupbox1.Controls.Add(ID);
            groupbox1.Controls.Add(RESIDENCIA);
            groupbox1.Controls.Add(TELEFONO);
            groupbox1.Controls.Add(CEDULA);
            groupbox1.Controls.Add(APELLIDO);
            groupbox1.Controls.Add(NOMBRE);
            groupbox1.Controls.Add(CODIGO);
            groupbox1.Controls.Add(label6);
            groupbox1.Controls.Add(label5);
            groupbox1.Controls.Add(label4);
            groupbox1.Controls.Add(label3);
            groupbox1.Controls.Add(label2);
            groupbox1.Controls.Add(label1);
            groupbox1.Location = new Point(3, 3);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(564, 396);
            groupbox1.TabIndex = 0;
            groupbox1.TabStop = false;
            groupbox1.Text = "EMPLEADOS DEL RESTAURANT";
            groupbox1.Enter += groupBox1_Enter;
            // 
            // BUSCAR
            // 
            BUSCAR.Location = new Point(415, 153);
            BUSCAR.Name = "BUSCAR";
            BUSCAR.Size = new Size(130, 60);
            BUSCAR.TabIndex = 18;
            BUSCAR.Text = "BUSCAR";
            BUSCAR.UseVisualStyleBackColor = true;
            BUSCAR.Click += BUSCAR_Click;
            // 
            // ATRAS
            // 
            ATRAS.Location = new Point(415, 73);
            ATRAS.Name = "ATRAS";
            ATRAS.Size = new Size(130, 60);
            ATRAS.TabIndex = 17;
            ATRAS.Text = "ATRAS";
            ATRAS.UseVisualStyleBackColor = true;
            ATRAS.Click += ATRAS_Click;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(415, 241);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(130, 60);
            LIMPIAR.TabIndex = 16;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += LIMPIAR_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.Location = new Point(415, 317);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(130, 60);
            ELIMINAR.TabIndex = 15;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = true;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // ACTUALIZAR
            // 
            ACTUALIZAR.Location = new Point(234, 317);
            ACTUALIZAR.Name = "ACTUALIZAR";
            ACTUALIZAR.Size = new Size(130, 60);
            ACTUALIZAR.TabIndex = 14;
            ACTUALIZAR.Text = "ACTUALIZAR";
            ACTUALIZAR.UseVisualStyleBackColor = true;
            ACTUALIZAR.Click += ACTUALIZAR_Click;
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(28, 317);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(130, 60);
            GUARDAR.TabIndex = 13;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            GUARDAR.Click += GUARDAR_Click;
            // 
            // ID
            // 
            ID.Location = new Point(420, 35);
            ID.Name = "ID";
            ID.Size = new Size(125, 27);
            ID.TabIndex = 12;
            ID.Visible = false;
            // 
            // RESIDENCIA
            // 
            RESIDENCIA.Location = new Point(212, 258);
            RESIDENCIA.Name = "RESIDENCIA";
            RESIDENCIA.Size = new Size(184, 27);
            RESIDENCIA.TabIndex = 11;
            // 
            // TELEFONO
            // 
            TELEFONO.Location = new Point(212, 217);
            TELEFONO.Name = "TELEFONO";
            TELEFONO.Size = new Size(184, 27);
            TELEFONO.TabIndex = 10;
            // 
            // CEDULA
            // 
            CEDULA.Location = new Point(212, 166);
            CEDULA.Name = "CEDULA";
            CEDULA.Size = new Size(184, 27);
            CEDULA.TabIndex = 9;
            // 
            // APELLIDO
            // 
            APELLIDO.Location = new Point(212, 120);
            APELLIDO.Name = "APELLIDO";
            APELLIDO.Size = new Size(184, 27);
            APELLIDO.TabIndex = 8;
            // 
            // NOMBRE
            // 
            NOMBRE.Location = new Point(212, 73);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(184, 27);
            NOMBRE.TabIndex = 7;
            // 
            // CODIGO
            // 
            CODIGO.Location = new Point(212, 35);
            CODIGO.Name = "CODIGO";
            CODIGO.Size = new Size(184, 27);
            CODIGO.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 263);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 5;
            label6.Text = "Residencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 222);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 171);
            label4.Name = "label4";
            label4.Size = new Size(84, 22);
            label4.TabIndex = 3;
            label4.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 125);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 407);
            Controls.Add(groupbox1);
            Name = "Empleados";
            Text = "Form1";
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupbox1;
        private Label label1;
        private TextBox ID;
        private TextBox RESIDENCIA;
        private TextBox TELEFONO;
        private TextBox CEDULA;
        private TextBox APELLIDO;
        private TextBox NOMBRE;
        private TextBox CODIGO;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BUSCAR;
        private Button ATRAS;
        private Button LIMPIAR;
        private Button ELIMINAR;
        private Button ACTUALIZAR;
        private Button GUARDAR;
    }
}
