using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsLibro
    {
        //ingresas las propiedas
        private int IdLibro;
        private string ISBN = "";
        private string Titulo = "";
        private int IdAutor;
        private string NombreAutor = "";
        private DateTime FechaAdquisicion;
        private int Disponibles;
        private int Existencias;


        //get y set de las propiedas
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

        public string getNombreAutor()
        {
            return NombreAutor;
        }

        public void setNombreAutor(string nombreAutor)
        {
            NombreAutor = nombreAutor;
        }

        public DateTime getFechaAdquisicion()
        {
            return FechaAdquisicion;
        }

        public void setFechaAdquisicion(DateTime fecha)
        {
            FechaAdquisicion = fecha;
        }

        public int getDisponibles()
        {
            return Disponibles;
        }

        public void setDisponibles (int disponibles)
        {
            Disponibles = disponibles;
        }

        public int getExistencias()
        {
            return Existencias;
        }

        public void setExistencias(int existencias)
        {
            Existencias = existencias;
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
    }
}
