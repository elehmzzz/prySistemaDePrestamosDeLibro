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

namespace prySistemaDePrestamosDeLibro.Formularios
{
    public partial class FrmDatosUsuario : Form
    {
        private FrmRegistroPersonal registroPersonal;
        public FrmDatosUsuario(FrmRegistroPersonal registroPersonal)
        {
            InitializeComponent();
            this.registroPersonal = registroPersonal;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContrasenia.Text.Trim();
            string confirmarContrasenia = txtConfirmarContrasenia.Text.Trim();

            if (contraseña != confirmarContrasenia) {
                MessageBox.Show("La contraseña debe ser igual");
                return;
            }

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(confirmarContrasenia)) {
                MessageBox.Show("Porfavor llena todo los campos");
                return;
            }
            registroPersonal.guardarDatosUsuario(usuario, confirmarContrasenia);
            if (!registroPersonal.registrarUsuario())
            {
                MessageBox.Show("No se realizo el registro");
            }
            else {
                MessageBox.Show("Registro realizado con exito");
            }
                registroPersonal.abrirInicioSesion();
            registroPersonal.Close();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            registroPersonal.mostrarPanelDatos();
        }

    }
}
