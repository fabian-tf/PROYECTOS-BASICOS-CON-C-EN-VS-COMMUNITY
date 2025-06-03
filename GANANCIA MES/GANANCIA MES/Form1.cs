using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GANANCIA_MES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DIA1_Click(object sender, EventArgs e)
        {
            double sueldo;
            string tDinero = GANANCIAS.Text;
            double ingresos = double.Parse(tDinero);

            sueldo = ingresos / 30;

            RESULTADO.Text = "Su ganancia diaria es: " + sueldo;

        }

        private void SEMANA_Click(object sender, EventArgs e)
        {
            int sueldo;
            string tDinero = GANANCIAS.Text;
            int ingresos = Int32.Parse(tDinero);

            sueldo = ingresos / 7;

            RESULTADO.Text = "Su ganancia diaria es: " + sueldo;

        }

        private void QUINCENA_Click(object sender, EventArgs e)
        {
            double sueldo;
            string tDinero = GANANCIAS.Text;
            double ingresos = double.Parse(tDinero);

            sueldo = ingresos / 15;

            RESULTADO.Text = "Su ganancia diaria es: " + sueldo;

        }
    }
}
