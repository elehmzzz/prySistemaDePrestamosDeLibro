using prySistemaDePrestamosDeLibro.Clases;
using System.Data;

namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    public partial class FrmCategorias : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        private FrmAgregarCategoria ventanaAgregarCategoria;
        private ClsCategoria objCategoria;

        private DataTable tablaCategoria;
        public FrmCategorias(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            objCategoria = new ClsCategoria();
            ventanaPrincipal = ventana;           
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        public void CargarCategorias()
        {


            DataTable dt = objCategoria.ObtenerCategorias();
            dtCategorias.DataSource = null;
            dtCategorias.Refresh();

            // CONFIGURAR
            dtCategorias.AutoGenerateColumns = true;
            dtCategorias.AllowUserToAddRows = false;

            // ASIGNAR DATOS
            dtCategorias.DataSource = dt;

            // AJUSTAR VISUAL
            dtCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // CAMBIAR NOMBRES
            if (dtCategorias.Columns["id"] != null)
                dtCategorias.Columns["id"].HeaderText = "ID";

            if (dtCategorias.Columns["nombre"] != null)
                dtCategorias.Columns["nombre"].HeaderText = "Nombre";
        }
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            ventanaAgregarCategoria = new FrmAgregarCategoria(this);
            ventanaAgregarCategoria.ShowDialog();
            CargarCategorias();
        }
        private void dtCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dtCategorias.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    objCategoria.setIdCategoria(Convert.ToInt32(fila.Cells[0].Value));
                }

                if (fila.Cells[1].Value != null)
                {
                    txtNombre.Text = fila.Cells[1].Value.ToString();
                    objCategoria.setNombre(fila.Cells[1].Value.ToString()!);
                }
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarModuloLibros();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre de la categoria");
                txtNombre.Text = objCategoria.getNombre();
                return;
            }

            objCategoria.setNombre(txtNombre.Text.Trim());

            if (objCategoria.ActualizarCategoria())
            {
                MessageBox.Show("Categoria actualizada");
                CargarCategorias();
            }
        }

       

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            ventanaAgregarCategoria = new FrmAgregarCategoria(this);
            ventanaAgregarCategoria.ShowDialog();

            CargarCategorias();
            if (txtcategoriaSeleccioanda.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre de la categoría");
                txtcategoriaSeleccioanda.Text = objCategoria.getNombre();
                return;
            }

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (tablaCategoria == null)
                return;

            string texto = txtBuscador.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                tablaCategoria.DefaultView.RowFilter = "";
            }
            else
            {
                texto = texto.Replace("'", "''");

                tablaCategoria.DefaultView.RowFilter =
                     $"Convert(id, 'System.String') LIKE '%{texto}%' OR " +
                     $"nombre LIKE '%{texto}%'";
            }

            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            if (objCategoria.getIdCategoria() > 0)
            {
                if (MessageBox.Show("¿Estás seguro de borrar esta categoría?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (objCategoria.BorrarCategoria())
                    {
                        MessageBox.Show("Categoría eliminada correctamente");
                        CargarCategorias();
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una categoria para borrar");
            }
        }

        private void Clear()
        {
            objCategoria.setIdCategoria(0);
            objCategoria.setNombre("");
            txtNombre.Clear();
        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (dtCategorias.DataSource is DataTable dt)
            {
                string texto = txtBuscador.Text.Trim().Replace("'", "''");
                dt.DefaultView.RowFilter = $"nombre LIKE '%{texto}%'";
            }
        }
    }
}
