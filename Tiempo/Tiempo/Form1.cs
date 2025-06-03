using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Segundos, Minutos, Horas, Dias, Años;

            if (double.TryParse(MINUTOS.Text, out Minutos))
            {
                if (Minutos > 0)
                {

                    Segundos = Minutos * 60;

                    RESULTADO.Text = "La conversión es: " + Segundos;

                }
            }
            if (double.TryParse(HORAS.Text, out Horas))
            {
                if (Horas > 0)
                {
                    Minutos = Horas * 60;

                    Segundos = Horas * 60;

                    RESULTADO.Text = "La conversión es: " + Segundos;

                }
            }
            if (double.TryParse(DIAS.Text, out Dias))
            {
                if (Dias > 0)
                {

                    Segundos = Dias / 60;

                    RESULTADO.Text = "La conversión es: " + Segundos;
                }
            }
            if (double.TryParse(AÑOS.Text, out Años)) 
            {

                if (Años > 0)
                {

                    Segundos = Años / 60;

                    RESULTADO.Text = "La conversión es: " + Segundos;
                }
            }
        
    }
}
