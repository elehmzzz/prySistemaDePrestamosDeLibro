using prySistemaDePrestamosDeLibro.Formularios;
using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmRegistroPersonal : Form
    {
        private FrmDatosPersonales ventanaDatos;
        private FrmDatosUsuario ventanaUsuario;
        private FrmInicioSesion inicioSesion;
        private ClsBibliotecario objBibliotecario;

        public FrmRegistroPersonal(FrmInicioSesion formPadre)
        {
            InitializeComponent();
            ventanaDatos = new FrmDatosPersonales(this);
            ventanaUsuario = new FrmDatosUsuario(this);
            abrirFormulario(ventanaDatos);
            this.inicioSesion = formPadre;
            objBibliotecario = new ClsBibliotecario();
        }
        //muestra el formulario de datos personales en el panel
        public void mostrarPanelDatos()
        {
            abrirFormulario(ventanaDatos);
        }
        //muestra el formulario de datos de usuario en el panel
        public void mostrarPanelUsuario()
        {
            abrirFormulario(ventanaUsuario);
        }
        //abre el formulario ya sea de datos personales o de usuario en el panel
        private void abrirFormulario(Form formulario)
        {
            //limpia el contenido del panel
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            //hace que el formulario abarque todo el panel
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }
        //funcion que abre el formulario inicio de sesión
        public void abrirInicioSesion() {
            inicioSesion.Show();
        }
        public void guardarDatosPersonales(string nombre, string aPaterno, string aMaterno, string telefono, string correo) {
            objBibliotecario.setNombre(nombre);
            objBibliotecario.setAPaterno(aPaterno);
            objBibliotecario.setAMaterno(aMaterno);
            objBibliotecario.setTelefono(telefono);
            objBibliotecario.setCorreo(correo);
        }
        public void guardarDatosUsuario(string usuario, string contrasenia) {
            objBibliotecario.setUsuario(usuario);
            objBibliotecario.setContrasenia(contrasenia);
        }
        public bool registrarUsuario() {
            return objBibliotecario.guardarBibliotecario();
        }

    }
}
