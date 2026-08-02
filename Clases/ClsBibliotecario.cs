using MySql.Data.MySqlClient;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public class ClsBibliotecario : Persona
    {
        private int IdBibliotecario=0;
        private string Usuario="";
        private string Contrasenia="";
        private int tipo_usuario;
        private string nombre_tipo_usuario;

        public void setIdBibliotecario(int id)
        {
            IdBibliotecario = id;
        }
        public int getIdBibliotecario()
        {
            return IdBibliotecario;
        }
        public string getUsuario() {
            return Usuario;
        }
        public void setUsuario(string usuario) {
            Usuario = usuario;
        }
        public string getContraseña() {
            return Contrasenia;
        }
        public void setContrasenia(string contrasenia) {
            Contrasenia = contrasenia;
        }
        public int getTipoUsuario() {
            return tipo_usuario;
        }
        public void setTipoUsuario(int tipo) {
            tipo_usuario = tipo;
        }
        public string getNombreTipoUsuario() {
            return nombre_tipo_usuario;
        }
        //constructor 
        public ClsBibliotecario() : base() {
        }

        //constructor sin id, sirve para cuando se necesite crear un registro
        public ClsBibliotecario(string nombre, string aPaterno, string aMaterno, string telefono, string correo, string usuario, string contrasenia) : base(nombre, aPaterno, aMaterno, telefono, correo)
        {
            Usuario = usuario;
            Contrasenia = contrasenia;
        }

        public bool buscarBibliotecario() 
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection conn = conexion.ObtenerConexion();

            try
            {
                string consultaUsuario = @"SELECT b.Id_Bibliotecario, b.Nombre_Usuario,b.Contrasenia,b.Nombre,b.Apellido_Paterno,b.Apellido_Materno,b.Telefono,b.Correo,b.Id_Tipo_Usuario,t.Nombre_Tipo FROM bibliotecario b INNER JOIN tipo_usuario t ON b.Id_Tipo_Usuario = t.Id_Tipo_Usuario WHERE b.Nombre_Usuario = @nombre";
                //se crea el comando para ejecutar la consulta
                MySqlCommand comando = new MySqlCommand(consultaUsuario, conn);
                //se asigna el usuario al parametro
                comando.Parameters.AddWithValue("@nombre", Usuario);
                //se ejecuta la consulta y se obtiene el resultado
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    //entra cuando el uusuario coincide - Aqui no se ocupa Ñ 
                    string contraseniaAlmacenada = reader["Contrasenia"].ToString()!;
                    Boolean verifica = BCrypt.Net.BCrypt.Verify(Contrasenia, contraseniaAlmacenada);
                    if (verifica)
                    {
                        Usuario = reader["Nombre_Usuario"].ToString()!;
                        Nombre = reader["Nombre"].ToString()!;
                        aPaterno = reader["Apellido_Paterno"].ToString()!;
                        aMaterno = reader["Apellido_Materno"].ToString()!;
                        telefono = reader["Telefono"].ToString()!;
                        correo = reader["Correo"].ToString()!;
                        tipo_usuario = reader.GetInt32("Id_Tipo_Usuario");
                        nombre_tipo_usuario = reader["Nombre_Tipo"].ToString()!;
                        IdBibliotecario = reader.GetInt32("Id_Bibliotecario");
                        conn.Close();
                        return true;
                    }
                    else {
                        MessageBox.Show("La contraseña es incorrecta\nintente de nuevo");
                        conn.Close();
                        return false;
                    }
                }
                else {
                    //entra cuando el usuario no coindice
                    MessageBox.Show("Usuario incorrecto\nintente de nuevo");
                    conn.Close();
                    return false;
                }
            }
            catch(MySqlException ex) 
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                conn.Close();
                return false;
            }
        }
        public bool guardarBibliotecario()
        {
            MySqlConnection conn = crearConexion();
            string consulta = "INSERT INTO bibliotecario (Nombre, Apellido_Paterno, Apellido_Materno, Telefono, Correo, Nombre_Usuario, Contrasenia, Id_Tipo_Usuario) " +
                "VALUES (@nombre, @apellidoPat, @apellidoMat, @telefono, @correo, @usuario, @contrasenia, @id_tipo_usuario)";
            string hassContrasenia = BCrypt.Net.BCrypt.HashPassword(Contrasenia);
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellidoPat", aPaterno);
                cmd.Parameters.AddWithValue("@apellidoMat", aMaterno);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contrasenia", hassContrasenia);
                cmd.Parameters.AddWithValue("@id_tipo_usuario", tipo_usuario);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool actualizarBibliotecario() {
            MySqlConnection conn = crearConexion();
            string consulta = "UPDATE bibliotecario SET nombre=@nombre, Apellido_Paterno=@apellidoPat,Apellido_Materno=@apellidoMat, " +
                "Telefono=@telefono, Correo=@correo, Nombre_Usuario=@usuario, Contrasenia=@contrasenia WHERE IdBibliotecario=@id";
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@apellidoPat",aPaterno );
                comando.Parameters.AddWithValue("@apellidoMat", aMaterno);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@correo",correo);
                comando.Parameters.AddWithValue("@usuario", Usuario);
                comando.Parameters.AddWithValue("@Contrasenia", Contrasenia);
                comando.Parameters.AddWithValue("@id", IdBibliotecario);
                comando.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException e) {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
        }
        public bool eliminarBibliotecario() {
            MySqlConnection conn = crearConexion();
            string consulta = "DELETE FROM bibliotecario WHERE Id_Bibliotecario=@id";
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("@id", IdBibliotecario);
                comando.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException e) {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
        }
        private MySqlConnection crearConexion() {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection conn = conexion.ObtenerConexion();
            return conn;
        }
    }
}
