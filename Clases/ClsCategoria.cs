using MySql.Data.MySqlClient;
using System.Data;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsCategoria
    {
        private int IdCategoria;
        private string Nombre = "";

        public int getIdCategoria()
        {
            return IdCategoria;
        }
        public void setIdCategoria(int id)
        {
            IdCategoria = id;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        private MySqlConnection EstableceConexion()
        {
            ClsConexion conexion = new();
            return conexion.ObtenerConexion();
        }
        public DataTable ObtenerCategorias()
        {
            MySqlConnection con = EstableceConexion();
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_categoria id, nombre_categoria nombre FROM categoria", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error: " + ex.Message);
            }

            return dt;
        }
        public bool GuardarCategoria()
        {
            MySqlConnection con = EstableceConexion();
            try {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO categoria (nombre_categoria) VALUES (@nombre)", con);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            } catch(Exception ex) {
               MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool ActualizarCategoria()
        {
            MySqlConnection con = EstableceConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE categoria set nombre_categoria=@nombre WHERE id_categoria=@id" , con);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@id", IdCategoria);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool BorrarCategoria()
        {
            MySqlConnection con = EstableceConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM categoria WHERE id_categoria=@id", con);
                cmd.Parameters.AddWithValue("@id", IdCategoria);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
