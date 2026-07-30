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
            cadena = "Server=sql5.freesqldatabase.com; Database=sql5834101; Uid=sql5834101; Pwd=tPmyrfuZEg; Port=3306";
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
