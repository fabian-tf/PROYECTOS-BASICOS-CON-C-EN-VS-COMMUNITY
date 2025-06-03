namespace INICIO
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            PLATILLOS = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(146, 73);
            button1.Name = "button1";
            button1.Size = new Size(165, 113);
            button1.TabIndex = 0;
            button1.Text = "FACTURACION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(366, 73);
            button2.Name = "button2";
            button2.Size = new Size(164, 113);
            button2.TabIndex = 1;
            button2.Text = "CERRAR SESION";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(579, 73);
            button3.Name = "button3";
            button3.Size = new Size(164, 113);
            button3.TabIndex = 2;
            button3.Text = "EMPLEADOS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SaddleBrown;
            button5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(477, 221);
            button5.Name = "button5";
            button5.Size = new Size(164, 113);
            button5.TabIndex = 4;
            button5.Text = "INVENTARIO";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // PLATILLOS
            // 
            PLATILLOS.BackColor = Color.Gold;
            PLATILLOS.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PLATILLOS.Location = new Point(249, 221);
            PLATILLOS.Name = "PLATILLOS";
            PLATILLOS.Size = new Size(166, 113);
            PLATILLOS.TabIndex = 5;
            PLATILLOS.Text = "PLATILLOS";
            PLATILLOS.UseVisualStyleBackColor = false;
            PLATILLOS.Click += PLATILLOS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PLATILLOS);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button PLATILLOS;
    }
}
