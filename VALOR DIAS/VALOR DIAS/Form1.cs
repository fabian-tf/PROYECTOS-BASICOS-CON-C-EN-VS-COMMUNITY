using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VALOR_DIAS
{
    public partial class Form1 : Form
    {
        private double ingresos;

        public Form1()
        {
            InitializeComponent();
        }

        private void DIA30_Click(object sender, EventArgs e)
        {
            double sueldo;
            string tDinero = DINERO.Text;
            double ingresos = double.Parse(tDinero);

            sueldo = ingresos * 30;

            GANANCIA.Text = "Su ganancia en 8 dias es " + sueldo;
        }

        private void DIA8_Click(object sender, EventArgs e)
        {
            double sueldo;
            string tDinero = DINERO.Text;
            double ingresos = double.Parse(tDinero);

            sueldo = ingresos * 8;

            GANANCIA.Text = "Su ganancia en 8 dias es " + sueldo;


        }

        private void DIA15_Click(object sender, EventArgs e)
        {
            double sueldo;
            string tDinero = DINERO.Text;
            double ingresos = double.Parse(tDinero);

            sueldo = ingresos * 15;

            GANANCIA.Text = "Su ganancia en 8 dias es " + sueldo;






        }
    }
}
