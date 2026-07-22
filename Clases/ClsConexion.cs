using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsConexion
    {
        private readonly string cadena;

        public ClsConexion()
        {
            cadena = "Server=127.0.0.1; Database=bd_biblioteca; Uid=root; Pwd=root; Port=3306";
        }

        public MySqlConnection ObtenerConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadena);
                conexion.Open();
                return conexion;
                MessageBox.Show("Conexion exitosa");
            }
            catch {
                return null;
            }

        }
    }
}
