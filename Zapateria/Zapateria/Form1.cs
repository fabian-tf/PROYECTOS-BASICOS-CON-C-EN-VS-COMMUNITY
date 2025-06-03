using System.Linq.Expressions;
using MySql.Data.MySqlClient;

namespace Zapateria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            string Descripcion = DESCRPCION.Text;
            double Precio = double.Parse(PRECIO_PUBLICO.Text);
            int Existencia = int.Parse(EXISTENCIA.Text);

            string sql = "INSERT INTO producto (Codigo, Nombre, Descripcion, Precio_Publico, Existencia) VALUES ('" + Codigo + "', '" + Nombre + "', '" + Descripcion + "', '" + Precio + "', '" + Existencia + "')";

            MySqlConnection ConexionBD = Conexion.conexion();

            ConexionBD.Open();
            try
            {
                MySqlCommand Comando = new MySqlCommand(sql, ConexionBD);

                Comando.ExecuteNonQuery();

                MessageBox.Show("Registro guardado");
                Limpiar();
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

        private void DESCRPCION_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CODIGO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            string Descripcion = DESCRPCION.Text;
            double Precio = double.Parse(PRECIO_PUBLICO.Text);
            int Existencia = int.Parse(EXISTENCIA.Text);

            string sql = "UPDATE producto SET Codigo = '" + Codigo + "', Nombre = '" + Nombre + "', Descripcion = '" + Descripcion + "', Precio_Publico = '" + Precio + "', Existencia = '" + Existencia + "' WHERE idPRODUCTO = '" + id + "'";
            MySqlConnection ConexionBD = Conexion.conexion();

            ConexionBD.Open();
            try
            {
                MySqlCommand Comando = new MySqlCommand(sql, ConexionBD);

                Comando.ExecuteNonQuery();

                MessageBox.Show("Registro Actualizado");
                Limpiar();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            textBoxID.Text = "";
            CODIGO.Text = "";
            NOMBRE.Text = "";
            DESCRPCION.Text = "";
            PRECIO_PUBLICO.Text = "";
            EXISTENCIA.Text = "";
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;

            string sql = "DELETE FROM producto WHERE idPRODUCTO = '" + id + "'";

            MySqlConnection ConexionBD = Conexion.conexion();

            ConexionBD.Open();
            try
            {
                MySqlCommand Comando = new MySqlCommand(sql, ConexionBD);

                Comando.ExecuteNonQuery();

                MessageBox.Show("Registro ELIMINADO");
                Limpiar();
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

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            MySqlDataReader Reader = null;

            string Sql = "SELECT idPRODUCTO, Codigo, Nombre, Descripcion, Precio_Publico, Existencia FROM producto WHERE Codigo LIKE '" + Codigo + "' LIMIT 1";
            MySqlConnection ConexionBD = Conexion.conexion();
            ConexionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(Sql, ConexionBD);
                Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    textBoxID.Text = Reader[0].ToString();
                    NOMBRE.Text = Reader.GetString(2);
                    DESCRPCION.Text = Reader.GetString(3);
                    PRECIO_PUBLICO.Text = Reader[4].ToString();
                    EXISTENCIA.Text = Reader[5].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontraron registros de la BD");
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

        private void PRECIO_PUBLICO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosDelProducto_Enter(object sender, EventArgs e)
        {

        }
    }
}
