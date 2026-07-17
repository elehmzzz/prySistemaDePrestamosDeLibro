using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        private FrmInicioSesion ventanaInicioSesion;
        private FrmPerfilEmpleado ventanaEmpleado;
        private FrmLectores ventanaLectores;
        private FrmPrestamosHechos ventanaPrestamos;
        private FrmConsultaLibros ventanaLibros;

        public FrmMenuPrincipal(FrmInicioSesion ventanaInicioSesion)
        {
            InitializeComponent();
            this.ventanaInicioSesion = ventanaInicioSesion;
            lblTituloModulo.Text = "Libros";
        }
        //cerrar sesion
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaInicioSesion.Show(); 
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            lblTituloModulo.Text = "Libros";
            if (ventanaLibros == null) { 
                ventanaLibros = new FrmConsultaLibros();
            }
            mostrarContenido(ventanaLibros);
        }
        private void btnLectores_Click(object sender, EventArgs e)
        {
            lblTituloModulo.Text = "Lectores";
            if (ventanaLectores == null)
            {
                ventanaLectores = new FrmLectores();
                //MessageBox.Show("Se creó un nuevo formulario lector");
            }
            mostrarContenido(ventanaLectores);

        }
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            if (ventanaPrestamos == null) {
                ventanaPrestamos = new FrmPrestamosHechos();
            }
            mostrarContenido(ventanaPrestamos);
        }
        private void btnMultas_Click(object sender, EventArgs e)
        {
            lblTituloModulo.Text = "Multas";
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            lblTituloModulo.Text = "Empleado";
            if (ventanaEmpleado == null)
            {
                ventanaEmpleado = new FrmPerfilEmpleado();
                //MessageBox.Show("Se creó un nuevo formulario empleado");
            }
            mostrarContenido(ventanaEmpleado);
        }
        //metodo para mostrar el contenido en el panel beige
        private void mostrarContenido(Form ventana)
        {
            //limpia el contenido del panel
            pnlContenido.Controls.Clear();
            ventana.TopLevel = false;
            //hace que el formulario abarque todo el panel
            ventana.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(ventana);
            ventana.Show();
        }


    }
}
