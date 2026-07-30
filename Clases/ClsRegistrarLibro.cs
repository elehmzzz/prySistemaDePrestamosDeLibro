using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsRegistrarLibro
    {
        private string ISBN=" ";
        private string Titulo=" ";
        private string Autor= " ";
        private int Disponible;
        private DateTime FechaRegistro;

        public string getISBN ()
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
        public string getAutor()
        {
            return Autor;
        }
        public void setAutor(string autor)
        {
            Autor= autor;
        }
        public int getDisponible()
        {
            return Disponible;
        }
        public void setDisponible(int disponible)
        {
            Disponible = disponible;
        }
        public DateTime getFechaRegistro()
        {
            return FechaRegistro;
        }
        public void setFechaRegistro(DateTime fecharegistro)
        {
            FechaRegistro = fecharegistro;
        }
        private MySqlConnection EstableceConexion()
        {
            ClsConexion conexion = new();
            return conexion.ObtenerConexion();
        }
    }
}
