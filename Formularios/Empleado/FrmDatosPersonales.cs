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
        public FrmDatosPersonales(FrmRegistroPersonal padre)
        {
            InitializeComponent();
            registroPersonal = padre;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellidoMat = txtApellidoMat.Text.Trim();
            string apellidoPat = txtApellidoPat.Text.Trim();
            DateOnly fechaNacimiento = DateOnly.FromDateTime(dtpFechaNac.Value);
            string correo = txtCorreo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();


            //arreglo para guardar campos y comprobar si estan vacios
            string[] campos = {
                nombre, apellidoPat, apellidoMat, telefono,correo
            };
            //comprueba si hay campos vacios
            if (comprobarCamposVacios(campos))
            {
                MessageBox.Show("Porfavor llena todo los campos");
                return;
            }
            registroPersonal.guardarDatosPersonales(campos[0], campos[1], campos[2], campos[3], campos[4]);
            registroPersonal.mostrarPanelUsuario();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            registroPersonal.abrirInicioSesion();
            registroPersonal.Close();
        }

        //funcion que comprueba algun campo vacio y devuelve un valor booleano
        private bool comprobarCamposVacios(string[] campos) {
            return campos.Any(string.IsNullOrWhiteSpace);//devuelve un valor true o false
        }
    }
}
