using MySql.Data.MySqlClient;
using prySistemaDePrestamosDeLibro.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            //validar que los campos no vayan vacios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasenia))
            {
                MessageBox.Show("El usuario o la contraseña no pueden \n ir vacios");
                return;
            }
            //se hace la conexion con la base de datos
            ClsConexion conexion = new ClsConexion();
            MySqlConnection conn = conexion.ObtenerConexion();

            //
            try
            {
                //entra cuando el usuario coindice
                string consultaUsuario = "select * from bibliotecario where Nombre_Usuario = @nombre";
                //se crea el comando para ejecutar la consulta
                MySqlCommand comando = new MySqlCommand(consultaUsuario, conn);
                //se asigna el usuario al parametro
                comando.Parameters.AddWithValue("@nombre", usuario);
                //se ejecuta la consulta y se obtiene el resultado
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    //entra cuando el uusuario coincide - Aqui no se ocupa Ñ 
                    string contraseniaAlmacenada = BCrypt.Net.BCrypt.HashPassword(reader["Contrasenia"].ToString());
                    Boolean verifica = BCrypt.Net.BCrypt.Verify(contrasenia, contraseniaAlmacenada);
                    if (verifica)
                    {
                        //si el usuario y contraseña es correcta
                        this.Hide();
                        FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(this);
                        menuPrincipal.Show();
                        txtUsuario.Clear();
                        txtContrasenia.Clear();
                        txtUsuario.Focus();
                    }
                    else
                    {
                        //cuando el usuario es correcto pero la contraseña es incorrecta
                        conn.Close();
                        MessageBox.Show("La contraseña es incorrecta\nintente de nuevo");
                        txtContrasenia.Clear();
                        txtContrasenia.Focus();
                    }
                }
                else
                {
                    //ejecuta cuando el usuario no coincide
                    MessageBox.Show("Usuario incorrecto\nIntente de nuevo");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                }
                conn.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                return;
            }


        }

        private void llbRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistroPersonal registroPersonal = new FrmRegistroPersonal(this);
            registroPersonal.Show();
            this.Hide();
            txtContrasenia.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
