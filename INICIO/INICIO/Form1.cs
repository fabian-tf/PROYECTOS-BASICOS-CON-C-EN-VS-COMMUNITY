namespace INICIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion_rest.Fac ENTRAR = new Facturacion_rest.Fac();
            ENTRAR.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados_restaurant.Empleados Abrir = new Empleados_restaurant.Empleados();
            Abrir.ShowDialog();
            this.Show();
        }





        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario_rest.Form1 Abrir = new Inventario_rest.Form1();
            Abrir.ShowDialog();
            this.Show();
        }

        private void PLATILLOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario_restaurant.Inventario Abrir = new Inventario_restaurant.Inventario();
            Abrir.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
