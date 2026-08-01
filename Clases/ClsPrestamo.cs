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

        //==================== PARA FECHAS DE PRESTAMO ====================
        public DateTime getFechaPrestamo()
        {
            return Fecha_Prestamo;
        }

        public void setFechaPrestamo(DateTime fechaPrestamo)
        {
            Fecha_Prestamo = fechaPrestamo;
        }

        public DateTime getFechaDevolucion()
        {
            return Fecha_Devolucion;
        }

        public void setFechaDevolucion(DateTime fechaDevolucion)
        {
            Fecha_Devolucion = fechaDevolucion;
        }
        public DataTable RellenarFechasPrestamo(int idPrestamo)
        {
            MySqlConnection con = EstableceConexion();
            DataTable dt = new();

            try
            {
                string consulta = @"SELECT Fecha_Prestamo, Fecha_Devolucion 
                            FROM Detalle_Prestamo 
                            WHERE Id_Prestamo = @IdPrestamo";

                MySqlCommand cmd = new MySqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las fechas: " + ex.Message);
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
        //==================== FIN PASE PARA FECHAS DE PRESTAMO ====================
    }
}
