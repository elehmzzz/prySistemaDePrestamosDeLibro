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
        private FrmMenuPrincipal ventanaPrincipal;
        private DataTable tablaLibros;
        private FrmRegistroLibro apartadoLibros;
        private FrmCategorias apartadoCategorias;
        private FrmAutores apartadoAutores;
        private ClsLibros objLibro;
        
        public FrmLibros(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventana;
            objLibro = new ClsLibros();
            
        }
        public FrmLibros()
        {
            InitializeComponent();
            objLibro = new ClsLibros();
        }
        public void CargarLibros()
        {
            ClsLibros clsLibros = new ClsLibros();
            DataTable dt = clsLibros.ObtenerLibros();
            tablaLibros = clsLibros.ObtenerLibros();


            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }
        private void FrmLibro_Load(object sender, EventArgs e)
        {


            CargarLibros();
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
            if (tablaLibros == null)
                return;

            string texto = txtBuscador.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                tablaLibros.DefaultView.RowFilter = "";
            }
            else
            {
                texto = texto.Replace("'", "''");

                tablaLibros.DefaultView.RowFilter =
                    $"Convert(ISBN, 'System.String') LIKE '%{texto}%' OR " +
                    $"Titulo LIKE '%{texto}%'";
            }

            dataGridView1.DataSource = tablaLibros.DefaultView;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
       