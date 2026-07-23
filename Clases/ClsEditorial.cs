using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public class ClsEditorial
    {
        private int Id;
        private string Nombre="";

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        private MySqlConnection  EstableceConexion()
        {
            ClsConexion conexion = new ();
            return conexion.ObtenerConexion();
        }

        public DataTable ObtenerEditoriales()
        {
            MySqlConnection con =  EstableceConexion();
            DataTable dt = new ();
            try
            {
                MySqlCommand cmd = new("SELECT id_editorial id, nombre_editorial nombre FROM editorial", con);
                MySqlDataAdapter adapter = new (cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return dt;
            }
            finally {
                con.Close();
            }
        }

        public bool GuardarEditorial()
        {
            MySqlConnection con = EstableceConexion();
            try
            {
                MySqlCommand cmd = new("INSERT INTO editorial (nombre_editorial) VALUES (@nombre)", con);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
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

        public bool ActualizarEditorial()
        {
            MySqlConnection con = EstableceConexion();
            try
            {
                MySqlCommand cmd = new("UPDATE editorial set nombre_editorial=@nombre WHERE id_editorial=@id", con);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@id", Id);
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

        public bool BorrarEditorial()
        {
            MySqlConnection con = EstableceConexion();
            try
            {
                MySqlCommand cmd = new("DELETE FROM editorial WHERE id_editorial=@id", con);
                cmd.Parameters.AddWithValue("@id", Id);
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
