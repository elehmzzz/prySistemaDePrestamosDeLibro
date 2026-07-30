using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsPrestamo
    {
        private int Prestamo;
        private DateTime Fecha_Prestamo;
        private DateTime Fecha_Limite;
        private DateTime Fecha_Devolucion;
        private string Estado="";
        private int IdLector;
        private interface IdEmpleado;



        private MySqlConnection EstableceConexion()
        {
            ClsConexion conexion = new();
            return conexion.ObtenerConexion();
        }

        public DataTable ObtenerPrestamos()
        {
            MySqlConnection con = EstableceConexion();
            DataTable dt = new();
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_get_prestamos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
