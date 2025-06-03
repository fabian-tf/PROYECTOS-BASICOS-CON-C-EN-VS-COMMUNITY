using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SUM_Click(object sender, EventArgs e)
        {
            string numero1= NUM1.Text;
            int sumnum1= Int32.Parse(numero1);    

            string numero2 = NUM2.Text;
            int sumnum2 = Int32.Parse(numero2);

            TEXT.Text = "La suma es "+ (sumnum1+sumnum2);

        }

        private void DIV_Click(object sender, EventArgs e)
        {
            string numero1 = NUM1.Text;
            double sumnum1 = double.Parse(numero1);

            string numero2 = NUM2.Text;
            double sumnum2 = double.Parse(numero2);

            double div= sumnum1/sumnum2;

       

            TEXT.Text = "La división es " + div;
        }

        private void REST_Click(object sender, EventArgs e)
        {
            string numero1 = NUM1.Text;
            int sumnum1 = Int32.Parse(numero1);

            string numero2 = NUM2.Text;
            int sumnum2 = Int32.Parse(numero2);

            TEXT.Text = "La resta es " + (sumnum1 - sumnum2);
        }

        private void MULT_Click(object sender, EventArgs e)
        {
            string numero1 = NUM1.Text;
            int sumnum1 = Int32.Parse(numero1);

            string numero2 = NUM2.Text;
            int sumnum2 = Int32.Parse(numero2);

            TEXT.Text = "La multiplicación es " + (sumnum1 * sumnum2);
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
