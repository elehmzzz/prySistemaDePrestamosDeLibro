using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsCategoria
    {
        private int IdCategoria;
        private string Nombre = "";

        //get set 
        public int getIdCategoria()
        {
            return IdCategoria;
        }

        public void setIdCategoria(int id)
        {
            IdCategoria = id;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        //metodos crud
        public DataTable ObtenerCategorias()
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_categoria id, nombre_categoria nombre FROM categoria", con);
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

        public bool GuardarCategoria()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO categoria (nombre_categoria) VALUES (@nombre)", con);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            } catch(Exception ex) {
               MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool BorrarCategoria()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM categoria WHERE id_categoria=@id", con);
                cmd.Parameters.AddWithValue("@id", IdCategoria);
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
