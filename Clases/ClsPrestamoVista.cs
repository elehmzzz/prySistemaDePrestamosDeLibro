using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsPrestamoVista
    {
        public DataTable ObtenerPrestamos()
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                string query = @"
        SELECT 
            p.Id_Prestamo AS ID,
            CONCAT(l.Nombres,' ',l.Apellido_Paterno) AS Lector,
            li.Titulo AS Libro,
            dp.Fecha_Prestamo AS 'Fecha Préstamo',
            dp.Fecha_Devolucion AS 'Fecha Devolución'
        FROM prestamo p
        INNER JOIN lector l 
            ON p.Id_Lector = l.Id_Lector
        INNER JOIN ejemplar e 
            ON p.Id_Ejemplar = e.Id_Ejemplar
        INNER JOIN libro li 
            ON e.Id_Libro = li.Id_Libro
        INNER JOIN detalle_prestamo dp 
            ON p.Id_Prestamo = dp.Id_Prestamo;
        ";

                MySqlCommand cmd = new MySqlCommand(query, con);
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




        //para el buscador
        public DataTable BuscarLectores(string texto)
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                string query = @"
        SELECT 
            Id_Lector,
            CONCAT(Nombres, ' ', Apellido_Paterno) AS NombreCompleto
        FROM lector
        WHERE Nombres LIKE @texto OR Apellido_Paterno LIKE @texto
        ";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

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


    }
}

