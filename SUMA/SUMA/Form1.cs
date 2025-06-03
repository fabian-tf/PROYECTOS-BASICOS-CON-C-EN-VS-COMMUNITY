using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUTTON_Click(object sender, EventArgs e)
        {

            string numero1 = NUM1.Text;
            int sumatemp1 = Int32.Parse(numero1);


            string numero2 = NUM2.Text;
            int sumatemp2 = Int32.Parse(numero2);

            TEXT.Text = "La suma es " + (sumatemp1+sumatemp2);
        }
    }
}
