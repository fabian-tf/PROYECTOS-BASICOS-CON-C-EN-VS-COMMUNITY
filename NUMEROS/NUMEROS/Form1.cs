using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUMEROS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BOTTON_Click(object sender, EventArgs e)
        {
            int numero = 123;
            double numeroConComas = 60000.33;
            string prueba = "El numero es " + numeroConComas + " , " + numero;
            string prueba2 = numeroConComas + numero + "el numero es";
            TEXT.Text = prueba;
        }
    }
}
