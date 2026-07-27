using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsLibros
    {
        private int Id_Libro;
        private int ISBN;
        private DateTime Fecha_Adquisicion;
        private string Titulo = " ";
        private int Id_Editorial;
        private int Id_Autor;
        private int Id_Categoria;
        public int getId_Libro()
        {
            return Id_Libro;
        }
        public void setId_Libro(int id_libro)
        {
            Id_Libro = id_libro;
        }
        public int getISBN()
        {
            return ISBN;
        }
        public void setISBN(int isbn)
        {
            ISBN = isbn;
        }
        public DateTime getFecha_Adquisicion()
        {
            return Fecha_Adquisicion;
        }
        public void setFecha_Adquisicion(DateTime fecha_adquisicion)
        {
            Fecha_Adquisicion = fecha_adquisicion;
        }
        public string getTitulo()
        {
            return Titulo;
        }
        public void setTitulo(string titulo)
        {
            Titulo = titulo;
        }
        public int getId_Editorial()
        {
            return Id_Editorial;
        }
        public void setId_Editorial(int id_editorial)
        {
            Id_Editorial = id_editorial;
        }
        public int getId_Autor()
        {
            return Id_Autor;
        }
        public void setId_Autor(int id_autor)
        {
            Id_Autor = id_autor;
        }
        public int getId_Categoria()
        {
            return Id_Categoria;
        }
        public void setId_Categoria(int id_categoria)
        {
            Id_Categoria = id_categoria;
        }
        private MySqlConnection EstableceConexion()
        {
            ClsConexion conexion = new();
            return conexion.ObtenerConexion();
        }

        public DataTable ObtenerLibros()
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(@"SELECT Id_Libro, ISBN, Fecha_Adquisicion, Titulo, Id_Editorial, Id_Autor, Id_Categoria FROM libro", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener lectores: " + ex.Message);
            }
            finally
            {
                con.Close();

            }
            return dt;
        }




    }
}
