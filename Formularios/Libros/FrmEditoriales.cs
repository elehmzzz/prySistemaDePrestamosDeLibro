using prySistemaDePrestamosDeLibro.Clases;
using System.Data;


namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    public partial class FrmEditoriales : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        FrmAgregarEditorial ventanaAgregarEditorial;
        private ClsEditorial objEditorial;
        public FrmEditoriales(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            objEditorial = new();
            ventanaPrincipal = ventana;
        }
        private void FrmEditoriales_Load(object sender, EventArgs e)
        {
            CargarEditoriales();
        }
        public void CargarEditoriales()
        {
            DataTable dt = objEditorial.ObtenerEditoriales();
            dtEditoriales.DataSource = null;
            dtEditoriales.Refresh();

            // CONFIGURAR
            dtEditoriales.AutoGenerateColumns = true;
            dtEditoriales.AllowUserToAddRows = false;

            // ASIGNAR DATOS
            dtEditoriales.DataSource = dt;

            // AJUSTAR VISUAL
            dtEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // CAMBIAR NOMBRES
            if (dtEditoriales.Columns["id"] != null)
                dtEditoriales.Columns["id"].HeaderText = "ID";

            if (dtEditoriales.Columns["nombre"] != null)
                dtEditoriales.Columns["nombre"].HeaderText = "Nombre";
        }
        private void BtnAgregarEditorial_Click(object sender, EventArgs e)
        {
            ventanaAgregarEditorial = new FrmAgregarEditorial(this);
            ventanaAgregarEditorial.ShowDialog();
        }
        private void dtEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dtEditoriales.Rows[e.RowIndex];

                objEditorial.SetId(Convert.ToInt32(fila.Cells[0].Value));

                if (fila.Cells[0].Value != null)
                {
                    txtNombre.Text = fila.Cells[1].Value.ToString();
                    objEditorial.SetNombre(fila.Cells[1].Value.ToString()!);
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
                MessageBox.Show("Ingrese el nombre de la editorial");
                txtNombre.Text = objEditorial.GetNombre();
                return;
            }

            objEditorial.SetNombre(nombre);

            if (objEditorial.ActualizarEditorial())
            {
                MessageBox.Show("Editorial Actualizada");
                CargarEditoriales();
            }

            Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objEditorial.GetId() > 0)
            {
                if (MessageBox.Show("Estas seguro de borrar esta editorail", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (objEditorial.BorrarEditorial())
                    {
                        MessageBox.Show("Editorial eliminada correctamente");
                        CargarEditoriales();
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una editorial para borrar");
            }
        }
        private void Clear()
        {
            objEditorial.SetId(0);
            objEditorial.SetNombre("");
            txtNombre.Clear();
        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (dtEditoriales.DataSource is DataTable dt)
            {
                string texto = txtBuscador.Text.Trim().Replace("'", "''");
                dt.DefaultView.RowFilter = $"nombre LIKE '%{texto}%'";
            }
        }
    }
}
