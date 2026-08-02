using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsLibro
    {
        //ingresas las propiedas
        private int IdLibro;
        private string ISBN = "";
        private string Titulo = "";
        private int IdAutor;
        private int IdEditorial;
        private int IdCategoria;
        private string NombreAutor = "";
        private DateTime FechaAdquisicion;

        public int getIdLibro()
        {
            return IdLibro;
        }
        public void setIdLibro(int id)
        {
            IdLibro = id;
        }
        public string getISBN()
        { 
            return ISBN;
        }
        public void setISBN(string isbn)
        {
            ISBN = isbn;
        }
        public string getTitulo()
        {
            return Titulo;
        }
        public void setTitulo(string titulo)
        {
            Titulo = titulo;
        }
        public int getIdAutor()
        {
            return IdAutor;
        }
        public void setIdAutor(int idAutor)
        {
            IdAutor = idAutor;
        }
        public int getIdEditorial()
        {
            return IdEditorial;
        }
        public void setIdEditorial(int idEditorial)
        {
            IdEditorial = idEditorial;
        }
        public int getIdCategoria()
        {
            return IdCategoria;
        }
        public void setIdCategoria(int idCategoria)
        {
            IdCategoria = idCategoria;
        }        
        public DateTime getFechaAdquisicion()
        {
            return FechaAdquisicion;
        }
        public void setFechaAdquisicion(DateTime fecha)
        {
            FechaAdquisicion = fecha;
        }     

        //metodo para obtener los libros llamando una vista con un SP
        public DataTable ObtenerLibros()
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_get_libros", con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener lectores: " + ex.Message);
            }

            return dt;
        }
        public bool GuardarLibro()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO libro (isbn, titulo, id_autor, fecha_adquisicion, id_editorial, id_categoria ) VALUES (@isbn, @titulo, @idAutor, @fechaAdquisicion, @idEditorial, @idCategoria)", con);
                cmd.Parameters.AddWithValue("@isbn", ISBN);
                cmd.Parameters.AddWithValue("@titulo", Titulo);
                cmd.Parameters.AddWithValue("@idAutor", IdAutor);
                cmd.Parameters.AddWithValue("@fechaAdquisicion", new DateTime());
                cmd.Parameters.AddWithValue("@idEditorial", IdEditorial);
                cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);
   
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
