using MySql.Data.MySqlClient;
using System.Data;


namespace prySistemaDePrestamosDeLibro.Clases
{
    public class ClsPrestamo
    {
        private int IdPrestamo;
        private DateTime Fecha_Prestamo;
        private DateTime Fecha_Devolucion;
        private string Codigo = "";
        private int IdLector;
        private int IdBibliotecario;
        private int IdLibro;
        private int IdEjemplar;

        private string Lector;
        private string Telefono;
        private string Municipio;
        private string Colonia;
        private string CP;
        private string Libro;
        private string ISBN;
        private string Autor;
        private DateTime FechaPrestamo;
        private DateTime FechaDevolucion;
        private int DiasAtraso;
        private decimal Multa;
        private string bibliotecario;
        public int getIdPrestamo()
        {
            return IdPrestamo;
        }
        public void setIdPrestamo(int id)
        {
            IdPrestamo = id;
        }
        public DateTime getFecha_Prestamo()
        {
            return Fecha_Prestamo;
        }
        public void setFecha_Prestamo(DateTime fecha)
        {
            Fecha_Prestamo = fecha;
        }
        public DateTime getFecha_Devolucion()
        {
            return Fecha_Devolucion;
        }
        public void setFecha_Devolucion(DateTime fecha)
        {
            Fecha_Devolucion = fecha;
        }
        public string getCodigo()
        {
            return Codigo;
        }
        public void setCodigo(string codigo)
        {
            Codigo = codigo;
        }
        public int getIdLector()
        {
            return IdLector;
        }
        public void setIdLector(int id)
        {
            IdLector = id;
        }
        public int getIdBibliotecario()
        {
            return IdBibliotecario;
        }
        public void setIdBibliotecario(int id)
        {
            IdBibliotecario = id;
        }
        public int getIdLibro()
        {
            return IdLibro;
        }
        public void setIdLibro(int id)
        {
            IdLibro = id;
        }
        public string getLector()
        {
            return Lector;
        }
        public void setLector(string lector)
        {
            Lector = lector;
        }
        //
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
        public string getLibro()
        {
            return Libro;
        }
        public void setIdEjemplar(int id)
        {
            IdEjemplar = id;
        }
        public int getIdEjemplar()
        {
            return IdEjemplar;
        }
        public void setLibro(string libro)
        {
            Libro = libro;
        }
        public string getISBN()
        {
            return ISBN;
        }
        public void setISBN(string isbn)
        {
            ISBN = isbn;
        }
        public string getAutor()
        {
            return Autor;
        }
        public void setAutor(string autor)
        {
            Autor = autor;
        }
        public DateTime getFechaPrestamo()
        {
            return FechaPrestamo;
        }
        public void setFechaPrestamo(DateTime fechaPrestamo)
        {
            FechaPrestamo = fechaPrestamo;
        }
        public DateTime getFechaDevolucion()
        {
            return FechaDevolucion;
        }
        public void setFechaDevolucion(DateTime fechaDevolucion)
        {
            FechaDevolucion = fechaDevolucion;
        }
        public int getDiasAtraso()
        {
            return DiasAtraso;
        }
        public void setDiasAtraso(int diasAtraso)
        {
            DiasAtraso = diasAtraso;
        }
        public decimal getMulta()
        {
            return Multa;
        }
        public void setMulta(decimal multa)
        {
            Multa = multa;
        }
        public string getBibliotecario()
        {
            return bibliotecario;
        }
        public void setBibliotecario(string bibliotecario)
        {
            this.bibliotecario = bibliotecario;
        }
        private MySqlConnection EstableceConexion()
        {
            ClsConexion conexion = new();
            return conexion.ObtenerConexion();
        }
        public DataTable ObtenerPrestamos()
        {
            MySqlConnection con = EstableceConexion();
            DataTable dt = new();
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_get_prestamos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return dt;
            }
            finally
            {
                con.Close();
            }
        }

        public bool ObtenerDetalle()
        {
            MySqlConnection con = EstableceConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM vista_prestamo_detalle WHERE Id_Prestamo=@id", con);

                cmd.Parameters.AddWithValue("@id", IdPrestamo);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Lector = dr["lector"].ToString()!;
                    Telefono = dr["Telefono"].ToString()!;
                    Municipio = dr["Municipio"].ToString()!;
                    Colonia = dr["Colonia"].ToString()!;
                    CP = dr["CP"].ToString()!;
                    Libro = dr["libro"].ToString()!;
                    ISBN = dr["ISBN"].ToString()!;
                    Autor = dr["autor"].ToString()!;
                    FechaPrestamo = Convert.ToDateTime(dr["Fecha_Prestamo"]);
                    FechaDevolucion = Convert.ToDateTime(dr["Fecha_Devolucion"]);
                    DiasAtraso = Convert.ToInt32(dr["dias_atraso"]);
                    Multa = Convert.ToDecimal(dr["multa"]);
                    bibliotecario = dr["bibliotecario"].ToString()!;
                    Codigo = dr["folio"].ToString()!;

                    dr.Close();
                    con.Close();
                    return true;
                }

                dr.Close();
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener detalle: " + ex.Message);
                return false;
            }
        }

        // INSERTA EN TABLA PRESTAMO Y DEVUELVE EL ID GENERADO
        public bool GuardarPrestamo()
        {
            MySqlConnection con = EstableceConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_insert_prestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pId_Bibliotecario", IdBibliotecario);
                cmd.Parameters.AddWithValue("@pId_Libro", IdLibro);
                cmd.Parameters.AddWithValue("@pId_Lector", IdLector);
                cmd.Parameters.AddWithValue("@pFecha_Prestamo", Fecha_Prestamo);
                cmd.Parameters.AddWithValue("@pFecha_Devolucion", Fecha_Devolucion);
                cmd.Parameters.AddWithValue("@pId_Ejemplar", IdEjemplar);

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar préstamo: " + ex.Message);
                return false;
            }
        }
        public bool FinalizarPrestamo()
        {
            MySqlConnection con = EstableceConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_finalizar_prestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_prestamo", IdPrestamo);
                cmd.Parameters.AddWithValue("@p_multa", Multa);
                cmd.Parameters.AddWithValue("@p_retraso", DiasAtraso);

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar préstamo: " + ex.Message);
                return false;
            }
        }

        public DataTable ObtenerEjemplares()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = EstableceConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM ejemplar where id_libro = @id_libro and disponible=1", con);
                cmd.Parameters.AddWithValue("@id_libro", IdLibro);
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

            public DataTable obtenerTotalPrestamos(DateTime fecha)
            {

                DataTable dt = new DataTable();
                MySqlConnection con = EstableceConexion();
                string consulta = "SELECT * FROM vista_total_prestamos WHERE Fecha_Prestamo = @fecha";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
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

        public DataTable obtenerTotalMultas() {
            DataTable dt = new DataTable();
            MySqlConnection con = EstableceConexion();
            string consulta = "SELECT * FROM vista_reporte_multas";
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, con);
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

        public DataTable obtenerPrestamosPorDia() {
            DataTable dt = new DataTable();
            MySqlConnection con = EstableceConexion();
            string consulta = "SELECT * FROM vista_prestamo_dia";
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, con);
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

        public DataTable obtenerTotalDePrestamosRetrasados() {
            DataTable dt = new DataTable();
            MySqlConnection con = EstableceConexion();
            string consulta = "SELECT * FROM vista_prestamo_retraso";
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, con);
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
    }
}
