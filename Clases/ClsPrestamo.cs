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

        // INSERTA EN TABLA PRESTAMO Y DEVUELVE EL ID GENERADO
        public int InsertarPrestamo(int idLector, int idLibro, int idBibliotecario)
        {
            int idPrestamo = 0;

            MySqlConnection con = EstableceConexion();

            try
            {
                string sql = @"INSERT INTO Prestamo (Id_Bibliotecario, Id_Lector, Id_Libro) VALUES (@bibliotecario, @lector, @libro); SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@bibliotecario", idBibliotecario);
                cmd.Parameters.AddWithValue("@lector", idLector);
                cmd.Parameters.AddWithValue("@libro", idLibro);


                idPrestamo = Convert.ToInt32(cmd.ExecuteScalar());

                return idPrestamo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar préstamo: " + ex.Message);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
             
    }
}
