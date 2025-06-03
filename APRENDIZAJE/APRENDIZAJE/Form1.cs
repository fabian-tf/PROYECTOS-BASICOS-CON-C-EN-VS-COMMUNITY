using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APRENDIZAJE
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

        private void BTNCAMBIAR_Click(object sender, EventArgs e)
        {
            string prueba = "Texto Cambiado";
            string prueba2 = "Prueba " + "de" + " concatenación " + prueba;
            prueba2 = "otro";
            prueba2 = "otro  texto";
            TEXT.Text = prueba2;

        }
    }
}
