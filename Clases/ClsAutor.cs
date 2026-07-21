using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsAutor
    {
        private int IdAutor;
        private string Nombre="";
        private string A_Paterno = "";
        private string A_Materno = "";

        public int getIdAutor()
        {
            return IdAutor;
        }

        public void setIdAutor(int id)
        {
            IdAutor = id;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string getAPaterno()
        {
            return A_Paterno;
        }

        public void setAPaterno(string aPaterno)
        {
            A_Paterno = aPaterno;
        }
        public string getAMaterno()
        {
            return A_Materno;
        }

        public void setAMaterno(string aMaterno)
        {
            A_Materno = aMaterno;
        }

        public DataTable ObtenerAutores()
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_autor, nombres, apellido_paterno, apellido_materno FROM autor", con);
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

        public bool GuardarAutor()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO autor (nombres, apellido_materno, apellido_paterno) VALUES (@nombre,@aPaterno, @aMaterno)", con);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@aPaterno", A_Paterno);
                cmd.Parameters.AddWithValue("@aMaterno", A_Materno);
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

        public bool ActualizarAutor()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE autor set nombres=@nombre, apellido_paterno=@aPaterno, apellido_materno=@aMaterno WHERE id_autor=@id", con);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@aPaterno", A_Paterno);
                cmd.Parameters.AddWithValue("@aMaterno", A_Materno);
                cmd.Parameters.AddWithValue("@id", IdAutor);
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

        public bool BorrarAutor()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM autor WHERE id_autor=@id", con);
                cmd.Parameters.AddWithValue("@id", IdAutor);
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
