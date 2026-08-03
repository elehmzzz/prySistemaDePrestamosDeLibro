using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsMulta
    {
        private int IdMulta;
        private decimal Penalizacion;
        private int Dias_tolerancia;

        //get y set
        public int getIdMulta()
        {
            return IdMulta;
        }

        public void setIdMulta(int id)
        {
            IdMulta = id;
        }

        public decimal getPenalizacion()
        {
            return Penalizacion;
        }

        public void setPenalizacion(decimal penalizacion)
        {
            Penalizacion = penalizacion;
        }

        public int getDias_tolerancia()
        {
            return Dias_tolerancia;
        }

        public void setDias_tolerancia(int diast)
        {
            Dias_tolerancia = diast;
        }

        public DataRow ObtenerMultaPorId(int id)
        {
            DataTable dt = new DataTable();
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Id_Multa, Penalizacion, Dias_tolerancia FROM multa WHERE Id_Multa = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la multa: " + ex.Message);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool ActualizarMulta()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection con = conexion.ObtenerConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE multa SET Penalizacion = @penalizacion, Dias_tolerancia = @diast WHERE Id_Multa = @id", con);

                cmd.Parameters.AddWithValue("@penalizacion", Penalizacion);
                cmd.Parameters.AddWithValue("@diast", Dias_tolerancia);
                cmd.Parameters.AddWithValue("@id", IdMulta);

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la multa: " + ex.Message);
                return false;
            }
        }      
    }
}