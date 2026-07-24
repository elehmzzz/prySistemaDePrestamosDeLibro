using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsSeleccionLector
    {
        public DataTable ObtenerLectoresCombo()
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                string consulta = @"SELECT 
                                    Id_Lector,
                                    CONCAT(Nombres,' ',
                                    Apellido_Paterno,' ',
                                    Apellido_Materno) AS NombreCompleto
                                    FROM lector";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);
                adapter.Fill(dt);
                con.Close();

                MessageBox.Show("Lectores encontrados: " + dt.Rows.Count); // DEBUG
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dt;
        }

        // ✅ AQUÍ VA, DENTRO DE LA CLASE
        public DataRow ObtenerLectorPorId(int idLector)
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                string consulta = @"SELECT 
                                    Id_Lector,
                                    Nombres,
                                    Apellido_Paterno,
                                    Apellido_Materno,
                                    Telefono,
                                    Direccion
                                    FROM lector
                                    WHERE Id_Lector = @Id";

                MySqlCommand cmd = new MySqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@Id", idLector);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }
    }
}