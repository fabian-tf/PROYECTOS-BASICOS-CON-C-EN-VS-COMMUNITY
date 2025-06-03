using MySql.Data.MySqlClient;

namespace Empleados_restaurant
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            string Apellido = APELLIDO.Text;
            int Cedula = int.Parse(CEDULA.Text);
            double Telefono = double.Parse(TELEFONO.Text);
            string Residencia = RESIDENCIA.Text;

            string Sql = "INSERT INTO empleados (Codigo, Nombre, Apellido, Cedula, Telefono, Residencia) VAlUES ('" + Codigo + "', '" + Nombre + "', '" + Apellido + "', '" + Cedula + "', '" + Telefono + "', '" + Residencia + "')";

            MySqlConnection ConexionBD = CONEXION_BD.conexion();

            ConexionBD.Open();
            try
            {
                MySqlCommand Comando = new MySqlCommand(Sql, ConexionBD);

                Comando.ExecuteNonQuery();

                MessageBox.Show("Registro guardado");

                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("El registro NO SE GUARDO" + ex.Message);
            }
            finally
            {
                ConexionBD.Close();
            }

        }

        private void ACTUALIZAR_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            string Apellido = APELLIDO.Text;
            int Cedula = int.Parse(CEDULA.Text);
            double Telefono = double.Parse(TELEFONO.Text);
            string Residencia = RESIDENCIA.Text;

            string sql = "UPDATE empleados SET Codigo = '" + Codigo + "', Nombre = '" + Nombre + "', Apellido = '" + Apellido + "', Cedula = '" + Cedula + "', Telefono = '" + Telefono + "',   Residencia = '" + Residencia + "' WHERE idEMPLEADOS = '" + id + "'";
            MySqlConnection ConexionBD = CONEXION_BD.conexion();

            ConexionBD.Open();
            try
            {
                MySqlCommand Comando = new MySqlCommand(sql, ConexionBD);

                Comando.ExecuteNonQuery();

                MessageBox.Show("Registro Actualizado");
                limpiar();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("El registro NO SE ACTUALIZO" + ex.Message);
            }
            finally
            {
                ConexionBD.Close();
            }

        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            string id = ID.Text;

            string sql = "DELETE FROM empleados WHERE idEMPLEADOS = '" + id + "'";

            MySqlConnection ConexionBD = CONEXION_BD.conexion();

            ConexionBD.Open();
            try
            {
                MySqlCommand Comando = new MySqlCommand(sql, ConexionBD);

                Comando.ExecuteNonQuery();

                MessageBox.Show("Registro ELIMINADO");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("El registro NO SE ELIMMINO" + ex.Message);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            ID.Text = "";
            CODIGO.Text = "";
            NOMBRE.Text = "";
            APELLIDO.Text = "";
            CEDULA.Text = "";
            TELEFONO.Text = "";
            RESIDENCIA.Text = "";

        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            MySqlDataReader Reader = null;

            string Sql = "SELECT idEMPLEADOS, Codigo, Nombre, Apellido, Cedula, Telefono, Residencia  FROM empleados WHERE Codigo LIKE '" + Codigo + "' LIMIT 1";
            MySqlConnection ConexionBD = CONEXION_BD.conexion();
            ConexionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(Sql, ConexionBD);
                Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    ID.Text = Reader[0].ToString();
                    NOMBRE.Text = Reader.GetString(2);
                    APELLIDO.Text = Reader.GetString(3);
                    CEDULA.Text = Reader[4].ToString();
                    TELEFONO.Text = Reader[5].ToString();
                    RESIDENCIA.Text = Reader.GetString(6);

                }
                else
                {
                    MessageBox.Show("No se encontraron registros en la BD");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                ConexionBD.Close();
            }

        }

        private void ATRAS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
