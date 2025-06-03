using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventario_restaurant
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            string Ingredientes = INGREDIENTES.Text;
            double Costos = double.Parse(COSTOS.Text);
            double Precio = double.Parse(PRECIO.Text);

            string Sql = "INSERT INTO menu (Codigo, Nombre, Ingredientes, Costos, Precio_Publico) VALUES ('" + Codigo + "','" + Nombre + "', '" + Ingredientes + "', '" + Costos + "', '" + Precio + "') ";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACTUALIZAR_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            string Ingredientes = INGREDIENTES.Text;
            double Costos = double.Parse(COSTOS.Text);
            double Precio = double.Parse(PRECIO.Text);

            string sql = "UPDATE menu SET Codigo = '" + Codigo + "', Nombre = '" + Nombre + "', Ingredientes = '" + Ingredientes + "', Costos = '" + Costos + "', Precio_Publico = '" + Precio + "' WHERE idMENU = '" + id + "'";
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

            string sql = "DELETE FROM menu WHERE idMENU = '" + id + "'";

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
            INGREDIENTES.Text = "";
            COSTOS.Text = "";
            PRECIO.Text = "";
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            MySqlDataReader Reader = null;

            string Sql = "SELECT idMENU, Nombre, Codigo, Ingredientes, Costos, Precio_Publico  FROM menu WHERE Codigo LIKE '" + Codigo + "' LIMIT 1";
            MySqlConnection ConexionBD = CONEXION_BD.conexion();
            ConexionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(Sql, ConexionBD);
                Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    ID.Text = Reader[0].ToString();
                    NOMBRE.Text = Reader.GetString(1);
                    INGREDIENTES.Text = Reader.GetString(3);
                    COSTOS.Text = Reader[4].ToString();
                    PRECIO.Text = Reader[5].ToString();

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

