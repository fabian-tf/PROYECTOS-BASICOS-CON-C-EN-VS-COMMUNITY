using MySql.Data.MySqlClient;

namespace Facturacion_rest
{
    public partial class Fac : Form
    {
        public Fac()
        {
            InitializeComponent();
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

                    NOMBRE.Text = Reader.GetString(1);
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

        private void ENTER_Click(object sender, EventArgs e)
        {
            double Total;
            double Precio = double.Parse(PRECIO.Text);
            double Cantidad = double.Parse(CANTIDAD.Text);
            Total = Precio * Cantidad;

            RESULTADO.Text = Total.ToString();

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            string Codigo = CODIGO.Text;
            string Nombre = NOMBRE.Text;
            double Precio = double.Parse(PRECIO.Text);
            double Cantidad = double.Parse(CANTIDAD.Text);
            double Resultado = double.Parse(RESULTADO.Text);


            string Sql = "INSERT INTO factura (Codigo, Nombre, Precio, Cantidad, Resultado ) VALUES ('" + Codigo + "', '" + Nombre + "', '" + Precio + "', '" + Cantidad + "', '" + Resultado + "') ";

            string SqlId = "SELECT LAST_INSERT_ID();";

            MySqlConnection ConexionBD = CONEXION_BD.conexion();


            ConexionBD.Open();
            try
            {
                MySqlCommand ComandoInsert = new MySqlCommand(Sql, ConexionBD);
                ComandoInsert.ExecuteNonQuery();

                MySqlCommand ComandoId = new MySqlCommand(SqlId, ConexionBD);
                object result = ComandoId.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int idFac))
                {
                    MessageBox.Show("Factura guardada satisfactoriamente con número de referencia: " + idFac);
                }
                else
                {
                    MessageBox.Show("Factura guardada, pero no se pudo obtener el ID.");
                }
                limpiar();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar la factura" + ex.Message);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {

        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            CODIGO.Text = "";
            NOMBRE.Text = "";
            PRECIO.Text = "";
            CANTIDAD.Text = "";
            RESULTADO.Text = "";

        }

        private void ATRAS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FACTURAS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturas.Form1 Abrir = new Facturas.Form1();
            Abrir.ShowDialog();
            this.Show();
            
        }
    }
}
