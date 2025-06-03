using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_y_perimetro_de_un_rectangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Base, Altura, Area, Perimetro;

            string Tbase = BASE.Text;
            Base = double.Parse(Tbase);

            string Taltura = ALTURA.Text;
            Altura = double.Parse(Taltura);

            Area = Base * Altura;

            Perimetro = Base + Base + Altura + Altura;

            label4.Text = "El area del rectangulo es " + Area;

            label5.Text = "El perimetro del rectangulo es " + Perimetro;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
