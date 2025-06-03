using MySql.Data.MySqlClient;

namespace Conexion_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Servidor = SERVIDOR.Text;
            string Puerto = PUERTO.Text;
            string Usuario = USUARIO.Text;
            string Password = PASSWORD.Text;
            string Datos = "As cerrado sesión satisfactoriamente.";

            string CadenaConexion = "Server =" + Servidor + "; Port =" + Puerto + "; User ID ="+ Usuario + "; Password =" + Password + "; DataBase=Mysql;";


            MySqlConnection ConecctionBD = new MySqlConnection (CadenaConexion);

            try
            {
                ConecctionBD.Open ();
                this.Hide ();
                INICIO.Form1 Entrar = new INICIO.Form1();
                Entrar.ShowDialog();
                this.Show ();

            }

            catch (MySqlException exc)
            {
                MessageBox.Show (exc.ToString ());

            }
            MessageBox.Show(Datos);

        }
    }
}
