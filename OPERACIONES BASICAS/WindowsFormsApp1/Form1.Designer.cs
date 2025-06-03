namespace WindowsFormsApp1
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
            this.REST = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.SUM = new System.Windows.Forms.Button();
            this.MULT = new System.Windows.Forms.Button();
            this.TEXT = new System.Windows.Forms.Label();
            this.NUM1 = new System.Windows.Forms.TextBox();
            this.NUM2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPERACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIGURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mULTIPLICACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIVISIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUADRADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECTANGULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRIANGULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOMBOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // REST
            // 
            this.REST.BackColor = System.Drawing.SystemColors.Highlight;
            this.REST.ForeColor = System.Drawing.SystemColors.Menu;
            this.REST.Location = new System.Drawing.Point(596, 292);
            this.REST.Name = "REST";
            this.REST.Size = new System.Drawing.Size(189, 106);
            this.REST.TabIndex = 0;
            this.REST.Text = "RESTAR";
            this.REST.UseVisualStyleBackColor = false;
            this.REST.Click += new System.EventHandler(this.REST_Click);
            // 
            // DIV
            // 
            this.DIV.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DIV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DIV.Location = new System.Drawing.Point(315, 292);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(189, 106);
            this.DIV.TabIndex = 1;
            this.DIV.Text = "DIVIDIR";
            this.DIV.UseVisualStyleBackColor = false;
            this.DIV.Click += new System.EventHandler(this.DIV_Click);
            // 
            // SUM
            // 
            this.SUM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SUM.Location = new System.Drawing.Point(51, 292);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(189, 106);
            this.SUM.TabIndex = 2;
            this.SUM.Text = "SUMAR";
            this.SUM.UseVisualStyleBackColor = false;
            this.SUM.Click += new System.EventHandler(this.SUM_Click);
            // 
            // MULT
            // 
            this.MULT.BackColor = System.Drawing.SystemColors.GrayText;
            this.MULT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MULT.Location = new System.Drawing.Point(891, 292);
            this.MULT.Name = "MULT";
            this.MULT.Size = new System.Drawing.Size(189, 106);
            this.MULT.TabIndex = 3;
            this.MULT.Text = "MULTIPLICAR";
            this.MULT.UseVisualStyleBackColor = false;
            this.MULT.Click += new System.EventHandler(this.MULT_Click);
            // 
            // TEXT
            // 
            this.TEXT.AutoSize = true;
            this.TEXT.Location = new System.Drawing.Point(407, 86);
            this.TEXT.Name = "TEXT";
            this.TEXT.Size = new System.Drawing.Size(233, 16);
            this.TEXT.TabIndex = 4;
            this.TEXT.Text = "Ingrese su numero y elija la operación";
            // 
            // NUM1
            // 
            this.NUM1.Location = new System.Drawing.Point(241, 175);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(130, 22);
            this.NUM1.TabIndex = 5;
            // 
            // NUM2
            // 
            this.NUM2.Location = new System.Drawing.Point(702, 175);
            this.NUM2.Name = "NUM2";
            this.NUM2.Size = new System.Drawing.Size(134, 22);
            this.NUM2.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.oPERACIONESToolStripMenuItem,
            this.fIGURASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPERACIONESToolStripMenuItem
            // 
            this.oPERACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUMASToolStripMenuItem,
            this.rESTASToolStripMenuItem,
            this.mULTIPLICACIONESToolStripMenuItem,
            this.dIVISIONESToolStripMenuItem});
            this.oPERACIONESToolStripMenuItem.Name = "oPERACIONESToolStripMenuItem";
            this.oPERACIONESToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.oPERACIONESToolStripMenuItem.Text = "OPERACIONES";
            // 
            // fIGURASToolStripMenuItem
            // 
            this.fIGURASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUADRADOToolStripMenuItem,
            this.rECTANGULOToolStripMenuItem,
            this.tRIANGULOToolStripMenuItem,
            this.rOMBOToolStripMenuItem,
            this.cONOToolStripMenuItem});
            this.fIGURASToolStripMenuItem.Name = "fIGURASToolStripMenuItem";
            this.fIGURASToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.fIGURASToolStripMenuItem.Text = "FIGURAS";
            // 
            // sUMASToolStripMenuItem
            // 
            this.sUMASToolStripMenuItem.Name = "sUMASToolStripMenuItem";
            this.sUMASToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sUMASToolStripMenuItem.Text = "SUMAS ";
            // 
            // rESTASToolStripMenuItem
            // 
            this.rESTASToolStripMenuItem.Name = "rESTASToolStripMenuItem";
            this.rESTASToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.rESTASToolStripMenuItem.Text = "RESTAS";
            // 
            // mULTIPLICACIONESToolStripMenuItem
            // 
            this.mULTIPLICACIONESToolStripMenuItem.Name = "mULTIPLICACIONESToolStripMenuItem";
            this.mULTIPLICACIONESToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.mULTIPLICACIONESToolStripMenuItem.Text = "MULTIPLICACIONES ";
            // 
            // dIVISIONESToolStripMenuItem
            // 
            this.dIVISIONESToolStripMenuItem.Name = "dIVISIONESToolStripMenuItem";
            this.dIVISIONESToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.dIVISIONESToolStripMenuItem.Text = "DIVISIONES";
            // 
            // cUADRADOToolStripMenuItem
            // 
            this.cUADRADOToolStripMenuItem.Name = "cUADRADOToolStripMenuItem";
            this.cUADRADOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cUADRADOToolStripMenuItem.Text = "CUADRADO";
            // 
            // rECTANGULOToolStripMenuItem
            // 
            this.rECTANGULOToolStripMenuItem.Name = "rECTANGULOToolStripMenuItem";
            this.rECTANGULOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rECTANGULOToolStripMenuItem.Text = "RECTANGULO";
            // 
            // tRIANGULOToolStripMenuItem
            // 
            this.tRIANGULOToolStripMenuItem.Name = "tRIANGULOToolStripMenuItem";
            this.tRIANGULOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tRIANGULOToolStripMenuItem.Text = "TRIANGULO";
            // 
            // rOMBOToolStripMenuItem
            // 
            this.rOMBOToolStripMenuItem.Name = "rOMBOToolStripMenuItem";
            this.rOMBOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rOMBOToolStripMenuItem.Text = "ROMBO ";
            // 
            // cONOToolStripMenuItem
            // 
            this.cONOToolStripMenuItem.Name = "cONOToolStripMenuItem";
            this.cONOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cONOToolStripMenuItem.Text = "CONO";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 422);
            this.Controls.Add(this.NUM2);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.TEXT);
            this.Controls.Add(this.MULT);
            this.Controls.Add(this.SUM);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.REST);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "c";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button REST;
        private System.Windows.Forms.Button DIV;
        private System.Windows.Forms.Button SUM;
        private System.Windows.Forms.Button MULT;
        private System.Windows.Forms.Label TEXT;
        private System.Windows.Forms.TextBox NUM1;
        private System.Windows.Forms.TextBox NUM2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPERACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIGURASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUMASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mULTIPLICACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIVISIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUADRADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECTANGULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRIANGULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOMBOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONOToolStripMenuItem;
    }
}

