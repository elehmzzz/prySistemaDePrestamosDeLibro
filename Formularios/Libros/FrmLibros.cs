using prySistemaDePrestamosDeLibro.Formularios;
using prySistemaDePrestamosDeLibro.Formularios.Libros;
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
    public partial class FrmLibros : Form
    {
        ClsLibro objLibro;
        private FrmMenuPrincipal ventanaPrincipal;

        public FrmLibros(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            objLibro = new ClsLibro();
            ventanaPrincipal = ventana;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarApartadoLibro();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarApartadoCategorias();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarApartadoAutores();
        }

        private void Editoriales_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarApartadoEditoriales();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_FrmLibros(object sender, EventArgs e)
        {
            CargarLibros();
        }

        public void CargarLibros()
        {
            DataTable dt = objLibro.ObtenerLibros();
            // LIMPIAR 
            dGVLibros.DataSource = null;
            dGVLibros.Columns.Clear();
            // CONFIGURAR
            dGVLibros.AutoGenerateColumns = true;
            dGVLibros.AllowUserToAddRows = false;

            dGVLibros.DataSource = dt;

            dGVLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }

}
