using prySistemaDePrestamosDeLibro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prySistemaDePrestamosDeLibro.Formularios
{
    public partial class FrmDatosPersonales : Form
    {
        private FrmRegistroPersonal registroPersonal;
        //construcor que recibe el formulario RegistroPersonal
        public FrmDatosPersonales(FrmRegistroPersonal registroPersonal)
        {
            InitializeComponent();
            this.registroPersonal = registroPersonal;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellidoMat = txtApellidoMat.Text.Trim();
            string apellidoPat = txtApellidoPat.Text.Trim();
            DateOnly fechaNacimiento = DateOnly.FromDateTime(dtpFechaNac.Value);
            string correo = txtCorreo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string ciudad = txtLocalidad.Text.Trim();
            string municipio = txtMunicipio.Text.Trim();
            string CP = txtCP.Text.Trim();

            //arreglo para guardar campos y comprobar si estan vacios
            string[] campos = {
                nombre, apellidoPat, apellidoMat, correo, telefono, ciudad, municipio, CP
            };
            //comprueba si hay campos vacios
            if (comprobarCamposVacios(campos))
            {
                MessageBox.Show("Porfavor llena todo los campos!");
                return;
            }


            registroPersonal.mostrarPanelUsuario();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            registroPersonal.abrirInicioSesion();
            registroPersonal.Close();
        }

        //funcion que comprueba algun campo vacio y devuelve un valor booleano
        private bool comprobarCamposVacios(string[] campos) {
            return campos.Any(string.IsNullOrWhiteSpace);
        }
    }
}
