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

namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    public partial class FrmEditoriales : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        FrmAgregarEditorial ventanaAgregarEditorial;
        private ClsEditorial objEditorial;
        private DataTable tablaeditorial;
        public FrmEditoriales(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            objEditorial = new();
            ventanaPrincipal = ventana;
            dtEditoriales.CellClick += dtEditoriales_CellDoubleClick;
        }

        private void FrmEditoriales_Load(object sender, EventArgs e)
        {
            CargarEditoriales();
        }

        public void CargarEditoriales()
        {
            tablaeditorial = objEditorial.ObtenerEditoriales();
            dtEditoriales.DataSource = null;
            dtEditoriales.DataSource = tablaeditorial;
            dtEditoriales.Refresh();
        }

        private void BtnAgregarEditorial_Click(object sender, EventArgs e)
        {
            ventanaAgregarEditorial = new FrmAgregarEditorial(this, objEditorial);
            ventanaAgregarEditorial.ShowDialog();
        }

        private void dtEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dtEditoriales.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    objEditorial.SetId(Convert.ToInt32(fila.Cells[0].Value));
                }

                if (fila.Cells[1].Value != null)
                {
                    objEditorial.SetNombre(fila.Cells[1].Value.ToString()!);
                }
            }
            ventanaAgregarEditorial = new FrmAgregarEditorial(this, objEditorial);
            ventanaAgregarEditorial.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarModuloLibros();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (tablaeditorial == null)
                return;
            
            string texto = txtBuscador.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                
                tablaeditorial.DefaultView.RowFilter = "";
            }
            else
            {
                texto = texto.Replace("'", "''");

                tablaeditorial.DefaultView.RowFilter =
                    $"Convert(id, 'System.String') LIKE '%{texto}%' OR " +
                    $"nombre LIKE '%{texto}%'";
            }

            dtEditoriales.DataSource = tablaeditorial.DefaultView;
        }
    }
}
