using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
            string Textoedad = CAPTURAR.Text;
            int edad = Int32.Parse(Textoedad);
            bool EresMayorDeEdad = edad >= 18;
            if (EresMayorDeEdad)
            {
                TEXT.Text = "Tu eres mayor de edad";
            }
            else
            {
                TEXT.Text = "Tu no eres mayor de edad";
            }
        
            
        }

        private void CAPTURAR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
