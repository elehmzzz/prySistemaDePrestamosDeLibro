using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsLectores
    {
        private int IdLector;
        private string Nombres = "";
        private string Apellido_Paterno = "";
        private string Apellido_Materno = "";
        private string Telefono = "";
        private string Municipio = "";
        private string Colonia = "";
        private string CP = "";

        public int getIdLector()
        {
            return IdLector;
        }

        public void setIdLector(int id)
        {
            IdLector = id;
        }

        public string getNombres()
        {
            return Nombres;
        }

        public void setNombres(string nombres)
        {
            Nombres = nombres;
        }

        public string getApellidoPaterno()
        {
            return Apellido_Paterno;
        }

        public void setApellidoPaterno(string aPaterno)
        {
            Apellido_Paterno = aPaterno;
        }

        public string getApellidoMaterno()
        {
            return Apellido_Materno;
        }

        public void setApellidoMaterno(string aMaterno)
        {
            Apellido_Materno = aMaterno;
        }

        public string getTelefono()
        {
            return Telefono;
        }

        public void setTelefono(string telefono)
        {
            Telefono = telefono;
        }

        public string getMunicipio()
        {
            return Municipio;
        }

        public void setMunicipio(string municipio)
        {
            Municipio = municipio;
        }

        public string getColonia()
        {
            return Colonia;
        }

        public void setColonia(string colonia)
        {
            Colonia = colonia;
        }

        public string getCP()
        {
            return CP;
        }

        public void setCP(string cp)
        {
            CP = cp;
        }


        public DataTable ObtenerLectores()
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Id_Lector, Nombres, Apellido_Paterno, Apellido_Materno, Telefono, Municipio, Colonia, CP FROM lector", con);
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

        // 2. Insertar un nuevo lector en MySQL
        public bool GuardarLector()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO lector (Nombres, Apellido_Paterno, Apellido_Materno, Telefono, Municipio, Colonia, CP) VALUES (@nombres, @aPaterno, @aMaterno, @telefono, @municipio, @colonia, @cp)", con);
                cmd.Parameters.AddWithValue("@nombres", Nombres);
                cmd.Parameters.AddWithValue("@aPaterno", Apellido_Paterno);
                cmd.Parameters.AddWithValue("@aMaterno", Apellido_Materno);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@municipio", Municipio);
                cmd.Parameters.AddWithValue("@colonia", Colonia);
                cmd.Parameters.AddWithValue("@cp", CP);

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar lector: " + ex.Message);
                return false;
            }
        }

        // 3. Actualizar datos de un lector existente
        public bool ActualizarLector()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE lector SET Nombres=@nombres, Apellido_Paterno=@aPaterno, Apellido_Materno=@aMaterno, Telefono=@telefono, Municipio=@municipio, Colonia=@colonia, CP=@cp WHERE Id_Lector=@id", con);
                cmd.Parameters.AddWithValue("@nombres", Nombres);
                cmd.Parameters.AddWithValue("@aPaterno", Apellido_Paterno);
                cmd.Parameters.AddWithValue("@aMaterno", Apellido_Materno);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@municipio", Municipio);
                cmd.Parameters.AddWithValue("@colonia", Colonia);
                cmd.Parameters.AddWithValue("@cp", CP);
                cmd.Parameters.AddWithValue("@id", IdLector);

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar lector: " + ex.Message);
                return false;
            }
        }

        // 4. Borrar un lector
        public bool BorrarLector()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM lector WHERE Id_Lector=@id", con);
                cmd.Parameters.AddWithValue("@id", IdLector);

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar lector: " + ex.Message);
                return false;
            }

        }
    }
}
