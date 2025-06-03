using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_y_perimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
            //declarar variables
            double lado, Area, Perimetro;

            //declarar variables de texto

            string tArea = "El valor del area es: ";
            string tPerimetro = "El valor del perimetro es: ";

            //capturar variable con la caja de texto

            string tLado = BOX.Text;

            //convertir texto a numero

            lado = double.Parse(tLado);
            Area = lado * lado;
            
            Perimetro = lado * 4;

            //mostrar resultado

            TEXarea.Text = tArea + Area;

            TEXperimetro.Text = tPerimetro + Perimetro;

        }
    }
}
