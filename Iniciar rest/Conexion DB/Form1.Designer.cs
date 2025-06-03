namespace Conexion_DB
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SERVIDOR = new TextBox();
            PUERTO = new TextBox();
            USUARIO = new TextBox();
            PASSWORD = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Puerto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 143);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 201);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // SERVIDOR
            // 
            SERVIDOR.Location = new Point(149, 24);
            SERVIDOR.Name = "SERVIDOR";
            SERVIDOR.Size = new Size(125, 27);
            SERVIDOR.TabIndex = 5;
            // 
            // PUERTO
            // 
            PUERTO.Location = new Point(149, 78);
            PUERTO.Name = "PUERTO";
            PUERTO.Size = new Size(125, 27);
            PUERTO.TabIndex = 6;
            // 
            // USUARIO
            // 
            USUARIO.Location = new Point(149, 136);
            USUARIO.Name = "USUARIO";
            USUARIO.Size = new Size(125, 27);
            USUARIO.TabIndex = 7;
            // 
            // PASSWORD
            // 
            PASSWORD.Location = new Point(149, 194);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(125, 27);
            PASSWORD.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(99, 282);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 338);
            Controls.Add(button1);
            Controls.Add(PASSWORD);
            Controls.Add(USUARIO);
            Controls.Add(PUERTO);
            Controls.Add(SERVIDOR);
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
        private TextBox SERVIDOR;
        private TextBox PUERTO;
        private TextBox USUARIO;
        private TextBox PASSWORD;
        private Button button1;
    }
}
