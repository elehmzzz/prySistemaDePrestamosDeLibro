using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos;
using prySistemaDePrestamosDeLibro.Formularios.Libros;
using prySistemaDePrestamosDeLibro.Formularios.Multas;
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
        private FrmPerfilEmpleado moduloEmpleado;
        private FrmLectores moduloLectores;
        private FrmPrestamosHechos moduloPrestamos;
        private FrmMultas moduloMultas;
        private FrmLibros moduloLibros;
        private FrmRegistroLibro apartadoLibros;
        private FrmCategorias apartadoCategorias;
        private FrmAutores apartadoAutores;

        public FrmMenuPrincipal(FrmInicioSesion ventanaInicioSesion)
        {
            InitializeComponent();
            this.ventanaInicioSesion = ventanaInicioSesion;
            lblTituloModulo.Text = "Libros";
            moduloLibros = new FrmLibros(this);
            mostrarContenido(moduloLibros);

        }
        //cerrar sesion
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaInicioSesion.Show(); 
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            mostrarModuloLibros();
        }
        private void btnLectores_Click(object sender, EventArgs e)
        {
            mostrarModuloLectores();
        }
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            mostrarModuloPrestamos();
        }
        private void btnMultas_Click(object sender, EventArgs e)
        {
            mostrarModuloMultas();
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            mostrarModuloEmpleado();
        }

        //metodo para mostrar el contenido en el panel beige
        public void mostrarContenido(Form ventana)
        {
            //limpia el contenido del panel
            pnlContenido.Controls.Clear();
            ventana.TopLevel = false;
            //hace que el formulario abarque todo el panel
            ventana.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(ventana);
            ventana.Show();
        }
        //muestra el modulo de libros
        public void mostrarModuloLibros() {
            lblTituloModulo.Text = "Libros";
            mostrarContenido(moduloLibros);
        }
        //muestra el apartado para agregar un libro del modulo libros
        public void mostrarApartadoLibro() {
            if (apartadoLibros == null || apartadoLibros.IsDisposed)
            {
                apartadoLibros = new FrmRegistroLibro(this);
            }
            mostrarContenido(apartadoLibros);
        }
        //muestra el apartado de categorias del modulo libros
        public void mostrarApartadoCategorias() {
            if (apartadoCategorias == null || apartadoCategorias.IsDisposed) {
                apartadoCategorias = new FrmCategorias(this);
            }
            mostrarContenido(apartadoCategorias);
            apartadoCategorias.CargarCategorias();
        }
        //mostrar apartado autores
        public void mostrarApartadoAutores() {
            if (apartadoAutores == null || apartadoAutores.IsDisposed) {
                apartadoAutores = new FrmAutores(this);
            }
            mostrarContenido(apartadoAutores);
            apartadoAutores.CargarAutores();
        }
        //muestra el modulo de lectores
        public void mostrarModuloLectores() {
            lblTituloModulo.Text = "Lectores";
            if (moduloLectores == null)
            {
                moduloLectores = new FrmLectores();
            }
            mostrarContenido(moduloLectores);
        }
        //muestra el modulo de prestamos
        public void mostrarModuloPrestamos() {
            if (moduloPrestamos == null)
            {
                moduloPrestamos = new FrmPrestamosHechos();
            }
            mostrarContenido(moduloPrestamos);
        }
        //mostrar modulo de multas
        public void mostrarModuloMultas() {
            lblTituloModulo.Text = "Multas";
            if (moduloMultas == null)
            {
                moduloMultas = new FrmMultas();
            }
            mostrarContenido(moduloMultas);
        }
        //muestra el modulo de empleado
        public void mostrarModuloEmpleado() {
            lblTituloModulo.Text = "Empleado";
            if (moduloEmpleado == null)
            {
                moduloEmpleado = new FrmPerfilEmpleado();
                //MessageBox.Show("Se creó un nuevo formulario empleado");
            }
            mostrarContenido(moduloEmpleado);
        }
    }
}
