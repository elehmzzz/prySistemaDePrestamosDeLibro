using prySistemaDePrestamosDeLibro.Clases;
using System.Data;


namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    public partial class FrmAutores : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        private FrmAgregarAutor ventanaAgregarAutor;
        private ClsAutor objAutor;
        public FrmAutores(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            objAutor = new ClsAutor();
            ventanaPrincipal = ventana;
        }
        private void FrmAutores_Load(object sender, EventArgs e)
        {
            CargarAutores();
        }
        public void CargarAutores()
        {
            DataTable dt = objAutor.ObtenerAutores();
            dtAutores.DataSource = null;
            dtAutores.Refresh();

            // CONFIGURAR
            dtAutores.AutoGenerateColumns = true;
            dtAutores.AllowUserToAddRows = false;

            // ASIGNAR DATOS
            dtAutores.DataSource = dt;

            // AJUSTAR VISUAL
            dtAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // CAMBIAR NOMBRES
            if (dtAutores.Columns["id_autor"] != null)
                dtAutores.Columns["id_autor"].HeaderText = "ID";

            if (dtAutores.Columns["nombres"] != null)
                dtAutores.Columns["nombres"].HeaderText = "Nombre";

            if (dtAutores.Columns["apellido_paterno"] != null)
                dtAutores.Columns["apellido_paterno"].HeaderText = "Apellido Paterno";

            if (dtAutores.Columns["apellido_materno"] != null)
                dtAutores.Columns["apellido_materno"].HeaderText = "Apellido Materno";
        }
        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            FrmAgregarAutor formulario = new FrmAgregarAutor(this);
            formulario.ShowDialog();
        }
        private void dtAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dtAutores.Rows[e.RowIndex];

                objAutor.setIdAutor(Convert.ToInt32(fila.Cells[0].Value));

                if (fila.Cells[1].Value != null)
                {
                    txtNombre.Text = fila.Cells[1].Value.ToString();
                    objAutor.setNombre(fila.Cells[1].Value.ToString()!);
                }

                if (fila.Cells[2].Value != null)
                {
                    txtAPaterno.Text = fila.Cells[2].Value.ToString();
                    objAutor.setAPaterno(fila.Cells[2].Value.ToString()!);
                }

                if (fila.Cells[3].Value != null)
                {
                    txtAMaterno.Text = fila.Cells[3].Value.ToString();
                    objAutor.setAMaterno(fila.Cells[3].Value.ToString()!);
                }
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarModuloLibros();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del autor");
                return;
            }

            if (txtAPaterno.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el apellido Paterno del autor");
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el apellido Materno del autor");
                return;
            }

            objAutor.setNombre(txtNombre.Text.Trim());
            objAutor.setAPaterno(txtAPaterno.Text.Trim());
            objAutor.setAMaterno(txtAMaterno.Text.Trim());

            if (objAutor.ActualizarAutor())
            {
                MessageBox.Show("Autor actualizado");
                CargarAutores();
            }

            Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objAutor.getIdAutor() > 0)
            {
                if (MessageBox.Show("Estás seguro de borrar este autor", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (objAutor.BorrarAutor())
                    {
                        MessageBox.Show("Autor eliminado correctamente");
                        CargarAutores();
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un autor para borrar");
            }
        }
        private void Clear()
        {
            objAutor.setIdAutor(0);
            objAutor.setNombre("");
            objAutor.setAPaterno("");
            objAutor.setAMaterno("");
            txtNombre.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (dtAutores.DataSource is DataTable dt)
            {
                string texto = txtBuscador.Text.Trim().Replace("'", "''");
                dt.DefaultView.RowFilter = $"nombres LIKE '%{texto}%' OR apellido_paterno LIKE '%{texto}%' OR apellido_materno LIKE '%{texto}%'";
            }
        }       
    }
}
