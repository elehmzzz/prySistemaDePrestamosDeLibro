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
        private ClsBibliotecario objBibliotecario;
        private FrmMenuPrincipal menuPrincipal;

        public FrmInicioSesion()
        {
            InitializeComponent();

        }
        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

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

            objBibliotecario = new ClsBibliotecario();
            objBibliotecario.setUsuario(usuario);
            objBibliotecario.setContrasenia(contrasenia);

            if (objBibliotecario.buscarBibliotecario())
            {
                menuPrincipal = new FrmMenuPrincipal(this, objBibliotecario);
                this.Hide();
                menuPrincipal.Show();
                txtUsuario.Clear();
                txtContrasenia.Clear();
                txtUsuario.Focus();
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

        private void llbSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
