using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AREA_Y_PERIMETRO_TRIANGULO
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double CATETO1, CATETO2, Base, Area, Perimetro, Altura;

            string Tcateto1 = LADO1.Text;
            CATETO1= double.Parse(Tcateto1);

            string Tcateto2 = LADO2.Text;
            CATETO2 = double.Parse(Tcateto2);

            string Tcateto3 =  BASE.Text;
            Base = double.Parse(Tcateto3); 

            Perimetro = CATETO1 + CATETO2 + Base;

            Altura = Math.Sqrt(Math.Pow(CATETO1, 2) - Math.Pow(Base / 2, 2));

            Area = Base * Altura / 2;

            AREA.Text = "El area del triangulo es: " + Area;

            PERIMETRO.Text = "El perimetro es: " + Perimetro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double CATETO1, CATETO2, Base, Area, Perimetro, Altura;

            string Tcateto1 = LADO1.Text;
            CATETO1 = double.Parse(Tcateto1);

            string Tcateto2 = LADO2.Text;
            CATETO2 = double.Parse(Tcateto2);

            string Tcateto3 = BASE.Text;
            Base = double.Parse(Tcateto3);

            Perimetro = CATETO1 + CATETO2 + Base;

            Altura = Math.Sqrt(Math.Pow(CATETO1,2) - Math.Pow((Base / 2),2));

            Area = (Base * Altura) / 2;

            AREA.Text = "El area del triangulo es: " + Area;

            PERIMETRO.Text = "El perimetro del triangulo es: " + Perimetro;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double CATETO1, CATETO2, Base, Area, Perimetro, SemiP;

            string Tcateto1 = LADO1.Text;
            CATETO1 = double.Parse(Tcateto1);

            string Tcateto2 = LADO2.Text;
            CATETO2 = double.Parse(Tcateto2);

            string Tcateto3 = BASE.Text;
            Base = double.Parse(Tcateto3);

            Perimetro = CATETO1 + CATETO2 + Base;

            SemiP = (CATETO1 + CATETO2 + Base) / 2;

            Area = Math.Sqrt(SemiP*(SemiP-CATETO1)*(SemiP-CATETO2)*(SemiP-Base));

            AREA.Text = "El area del triangulo es: " + Area;

            PERIMETRO.Text = "El perimetro del triangulo es: " + Perimetro;

        }
    }
}
