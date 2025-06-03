using MySql.Data.MySqlClient;

namespace Inventario_rest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            double Unidades = double.Parse(CANTIDAD_KG.Text);
            double Kilos = double.Parse(CANTIDAD_UND.Text);

            string sql = "INSERT INTO inventario (Codigo, Nombre, Cantidad_UND, Cantidad_KG) VALUES ('" + Codigo + "', '" + Nombre + "', '" + Unidades + "', '" + Kilos + "')";

            MySqlConnection ConexionBD = CONEXION_BD.conexion();

            ConexionBD.Open();
            try
            {
                MySqlCommand Comando = new MySqlCommand(sql, ConexionBD);

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
            double Unidades = double.Parse(CANTIDAD_KG.Text);
            double Kilos = double.Parse(CANTIDAD_UND.Text);

            string sql = "UPDATE inventario SET Codigo = '" + Codigo + "', Nombre = '" + Nombre + "', Cantidad_UND = '" + Unidades + "', Cantidad_KG = '" + Kilos + "' WHERE idinventario = '" + id + "'";
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

            string sql = "DELETE FROM inventario WHERE idinventario = '" + id + "'";
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
            CANTIDAD_KG.Text = "";
            CANTIDAD_UND.Text = "";


        }

        private void ATRAS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {

            string Codigo = CODIGO.Text;
            MySqlDataReader Reader = null;

            string Sql = "SELECT idinventario, Codigo, Nombre, Cantidad_UND, Cantidad_KG FROM inventario WHERE Codigo LIKE '" + Codigo + "' LIMIT 1";
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
                    CANTIDAD_UND.Text = Reader[3].ToString();
                    CANTIDAD_KG.Text = Reader[4].ToString();
                   

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
    }
}
