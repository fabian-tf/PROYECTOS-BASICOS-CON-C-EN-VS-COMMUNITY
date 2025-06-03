using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valor_pesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pesos, Dolar;

            if (double.TryParse(PESOS.Text, out Pesos))
            {
                if (Pesos > 0)
                {
                    Dolar = Pesos / 4123;

                    RESULTADO.Text = "La conversión es: " + Dolar;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Pesos, Euro;

            if (double.TryParse(PESOS.Text, out Pesos))
            {
                if (Pesos > 0)
                {
                    Euro = Pesos / 4467;

                    RESULTADO.Text = "La conversión es: " + Euro;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Pesos, Lex;

            if (double.TryParse(PESOS.Text, out Pesos))
            {
                if (Pesos > 0)
                {
                    Lex = Pesos / 5204;

                    RESULTADO.Text = "La conversión es: " + Lex;
                }
            }
        }
    }
}
