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
        private int IdPrestamo;
        private DateTime Fecha_Prestamo;
        private DateTime Fecha_Devolucion;
        private string Codigo = "";
        private int IdLector;
        private int IdBibliotecario;
        private int IdLibro;

        public int getIdPrestamo()
        {
            return IdPrestamo;
        }

        public void setIdPrestamo(int id)
        {
            IdPrestamo = id;
        }

        public DateTime getFecha_Prestamo()
        {
            return Fecha_Prestamo;
        }

        public void setFecha_Prestamo(DateTime fecha)
        {
            Fecha_Prestamo = fecha;
        }

        public DateTime getFecha_Devolucion()
        {
            return Fecha_Devolucion;
        }

        public void setFecha_Devolucion(DateTime fecha)
        {
            Fecha_Devolucion = fecha;
        }

        public string getCodigo()
        {
            return Codigo;
        }

        public void setCodigo(string codigo)
        {
            Codigo = codigo;
        }
        public int getIdLector()
        {
            return IdLector;
        }

        public void setIdLector(int id)
        {
            IdLector = id;
        }

        public int getIdBibliotecario()
        {
            return IdBibliotecario;
        }

        public void setIdBibliotecario(int id)
        {
            IdBibliotecario = id;
        }

        public int getIdLibro()
        {
            return IdLibro;
        }

        public void setIdLibro(int id)
        {
            IdLibro = id;
        }

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
        public bool GuardarPrestamo()
        {
            MySqlConnection con = EstableceConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_insert_prestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Bibliotecario", IdBibliotecario);
                cmd.Parameters.AddWithValue("@Id_Libro", IdLibro);
                cmd.Parameters.AddWithValue("@Id_Lector", IdLector);
                cmd.Parameters.AddWithValue("@Fecha_Prestamo", Fecha_Prestamo);
                cmd.Parameters.AddWithValue("@Fecha_Devolucion", Fecha_Devolucion);
                cmd.Parameters.AddWithValue("@codigo", Codigo);

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar préstamo: " + ex.Message);
                return false;
            }
        }
             
    }
}
