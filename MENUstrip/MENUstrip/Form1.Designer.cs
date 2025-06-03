namespace MENUstrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPERACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mULTIPLICACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIVISIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NUM1 = new System.Windows.Forms.TextBox();
            this.NUM2 = new System.Windows.Forms.TextBox();
            this.RESULTADO = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.oPERACIONESToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // oPERACIONESToolStripMenuItem
            // 
            this.oPERACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUMAToolStripMenuItem,
            this.rESTAToolStripMenuItem,
            this.mULTIPLICACIÓNToolStripMenuItem,
            this.dIVISIÓNToolStripMenuItem,
            this.toolStripSeparator1,
            this.restoToolStripMenuItem});
            this.oPERACIONESToolStripMenuItem.Name = "oPERACIONESToolStripMenuItem";
            this.oPERACIONESToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.oPERACIONESToolStripMenuItem.Text = "OPERACIONES";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCERCADEToolStripMenuItem});
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.AutoToolTip = true;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.ToolTipText = "CERRAR SESION";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // sUMAToolStripMenuItem
            // 
            this.sUMAToolStripMenuItem.Name = "sUMAToolStripMenuItem";
            this.sUMAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.sUMAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sUMAToolStripMenuItem.Text = "SUMA";
            this.sUMAToolStripMenuItem.Click += new System.EventHandler(this.sUMAToolStripMenuItem_Click);
            // 
            // rESTAToolStripMenuItem
            // 
            this.rESTAToolStripMenuItem.Name = "rESTAToolStripMenuItem";
            this.rESTAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rESTAToolStripMenuItem.Text = "RESTA";
            this.rESTAToolStripMenuItem.Click += new System.EventHandler(this.rESTAToolStripMenuItem_Click);
            // 
            // mULTIPLICACIÓNToolStripMenuItem
            // 
            this.mULTIPLICACIÓNToolStripMenuItem.Name = "mULTIPLICACIÓNToolStripMenuItem";
            this.mULTIPLICACIÓNToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mULTIPLICACIÓNToolStripMenuItem.Text = "MULTIPLICACIÓN";
            this.mULTIPLICACIÓNToolStripMenuItem.Click += new System.EventHandler(this.mULTIPLICACIÓNToolStripMenuItem_Click);
            // 
            // dIVISIÓNToolStripMenuItem
            // 
            this.dIVISIÓNToolStripMenuItem.Name = "dIVISIÓNToolStripMenuItem";
            this.dIVISIÓNToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dIVISIÓNToolStripMenuItem.Text = "DIVISIÓN";
            this.dIVISIÓNToolStripMenuItem.Click += new System.EventHandler(this.dIVISIÓNToolStripMenuItem_Click);
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE";
            this.aCERCADEToolStripMenuItem.Click += new System.EventHandler(this.aCERCADEToolStripMenuItem_Click);
            // 
            // NUM1
            // 
            this.NUM1.Location = new System.Drawing.Point(379, 99);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(100, 22);
            this.NUM1.TabIndex = 1;
            this.NUM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NUM2
            // 
            this.NUM2.Location = new System.Drawing.Point(379, 178);
            this.NUM2.Name = "NUM2";
            this.NUM2.Size = new System.Drawing.Size(100, 22);
            this.NUM2.TabIndex = 2;
            this.NUM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM2.TextChanged += new System.EventHandler(this.NUM2_TextChanged);
            // 
            // RESULTADO
            // 
            this.RESULTADO.AutoSize = true;
            this.RESULTADO.Location = new System.Drawing.Point(571, 137);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(44, 16);
            this.RESULTADO.TabIndex = 3;
            this.RESULTADO.Text = "label1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // restoToolStripMenuItem
            // 
            this.restoToolStripMenuItem.Name = "restoToolStripMenuItem";
            this.restoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.restoToolStripMenuItem.Text = "resto";
            this.restoToolStripMenuItem.Click += new System.EventHandler(this.restoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.NUM2);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPERACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mULTIPLICACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIVISIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
        private System.Windows.Forms.TextBox NUM1;
        private System.Windows.Forms.TextBox NUM2;
        private System.Windows.Forms.Label RESULTADO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem restoToolStripMenuItem;
    }
}

