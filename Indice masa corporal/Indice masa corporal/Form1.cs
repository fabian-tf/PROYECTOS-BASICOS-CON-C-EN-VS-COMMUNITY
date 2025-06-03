using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indice_masa_corporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tPeso= PESO.Text;
            double Peso= double.Parse(tPeso);
            //double Peso = tPeso;

            string tAltura= ALTURA.Text;
            double Altura = double.Parse(tAltura);

            //double Altura = tAltura;
            //double.parse() convierte el texto a decimal
            double IMC = Peso / (Altura * Altura);

            // ventana emergente

            MessageBox.Show("El IMC es:  " + IMC);
     


        }

        private void ALTURA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
