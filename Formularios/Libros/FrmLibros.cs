using prySistemaDePrestamosDeLibro.Formularios;
using System.Data;


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
        private void Load_FrmLibros(object sender, EventArgs e)
        {
            CargarLibros();
        }
        public void CargarLibros()
        {
            DataTable dt = objLibro.ObtenerLibros();
            // LIMPIAR 
            dtLibros.DataSource = null;
            dtLibros.Columns.Clear();
            // CONFIGURAR
            dtLibros.AutoGenerateColumns = true;
            dtLibros.AllowUserToAddRows = false;

            dtLibros.DataSource = dt;
            dtLibros.Columns["id_Autor"].Visible = false;
            dtLibros.Columns["Id_Categoria"].Visible = false;
            dtLibros.Columns["Id_Editorial"].Visible = false;

            dtLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void dtEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dtLibros.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    objLibro.setIdLibro(Convert.ToInt32(fila.Cells[0].Value));
                }

                if (fila.Cells[1].Value != null)
                {
                    txtISBN.Text = fila.Cells[1].Value.ToString();
                    objLibro.setISBN(fila.Cells[1].Value.ToString()!);
                }
            }

        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        
    }

}
