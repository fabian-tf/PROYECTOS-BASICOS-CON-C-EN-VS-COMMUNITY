using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gramos_a_libras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GR_Click(object sender, EventArgs e)
        {
            double Gramos,Libras, Kilos;

            if (double.TryParse(LIBRAS.Text, out Libras)) {
                if (Libras > 0)
                {

                    Gramos = Libras * 453.592;

                    RESULTADO2.Text = ("La conversion es: " + Gramos);
                } 
            }   

           if (double.TryParse (KILOS.Text, out Kilos)) {
                if (Kilos > 0)
                {

                    Gramos = Kilos * 1000;

                    RESULTADO2.Text = ("La conversion es: " + Gramos);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LB_Click(object sender, EventArgs e)
        {
            double Gramos, Libras, Kilos;

            if (double.TryParse(GRAMOS.Text, out Gramos))
            {
                if (Gramos > 0)
                {

                    Libras = Gramos  / 453.592;

                    RESULTADO2.Text = ("La conversion es: " + Libras);
                }
            }

            if (double.TryParse(KILOS.Text, out Kilos))
            {
                if (Kilos > 0)
                {

                    Libras = Kilos * 2.2046;

                    RESULTADO2.Text = ("La conversion es: " + Libras );
                }
            }
        }

        private void KG_Click(object sender, EventArgs e)
        {
            double Gramos, Libras, Kilos;

            if (double.TryParse(GRAMOS.Text, out Gramos))
            {
                if (Gramos > 0)
                {

                    Kilos = Gramos / 1000;

                    RESULTADO2.Text = ("La conversion es: " + Kilos);
                }
            }

            if (double.TryParse(LIBRAS.Text, out Libras))
            {
                if (Libras > 0)
                {

                    Kilos = Libras / 2.2046;

                    RESULTADO2.Text = ("La conversion es: " + Kilos);
                }
            }
        }
    }
}
