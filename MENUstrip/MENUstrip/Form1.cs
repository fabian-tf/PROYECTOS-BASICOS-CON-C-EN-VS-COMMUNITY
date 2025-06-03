using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENUstrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NUM2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diseñado por: FABIAN TORRES");
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(NUM1.Text);

            double numero2 = Convert.ToDouble(NUM2.Text);

            double suma = numero1 + numero2;

            RESULTADO.Text = suma.ToString();
        }

        private void rESTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(NUM1.Text);

            double numero2 = Convert.ToDouble(NUM2.Text);

            double resta = numero1 - numero2;

            RESULTADO.Text = resta.ToString();
        }

        private void mULTIPLICACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(NUM1.Text);

            double numero2 = Convert.ToDouble(NUM2.Text);

            double multiplicacion = numero1 * numero2;

            RESULTADO.Text = multiplicacion.ToString();
        }

        private void dIVISIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(NUM1.Text);

            double numero2 = Convert.ToDouble(NUM2.Text);

            double division = numero1 / numero2;

            RESULTADO.Text = division.ToString();
        }

        private void restoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double numero1= Convert.ToDouble(NUM1.Text);
            double numero2 = Convert.ToDouble(NUM2.Text);

            double resto = numero1 % numero2;
            MessageBox.Show(resto.ToString());

        }
    }
}
