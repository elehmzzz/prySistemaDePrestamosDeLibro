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
    public partial class FrmCategorias : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        private FrmAgregarCategoria ventanaAgregarCategoria;
        private ClsCategoria objCategoria;
        public FrmCategorias(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            objCategoria = new ClsCategoria();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        public void CargarCategorias()
        {
            DataTable dt = objCategoria.ObtenerCategorias();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridView1.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    objCategoria.setIdCategoria(Convert.ToInt32(fila.Cells[0].Value));
                }

                if (fila.Cells[1].Value != null)
                {
                    objCategoria.setNombre(fila.Cells[1].Value.ToString());
                    txtcategoriaSeleccioanda.Text = fila.Cells[1].Value.ToString();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarModuloLibros();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            ventanaAgregarCategoria = new FrmAgregarCategoria(this);
            ventanaAgregarCategoria.ShowDialog();
            CargarCategorias();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (objCategoria.getIdCategoria() > 0)
            {
                if (MessageBox.Show("Estás seguro de borrar esta categoría", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (objCategoria.BorrarCategoria())
                    {
                        MessageBox.Show("Categoria eliminada correctamente");
                        CargarCategorias();
                        txtcategoriaSeleccioanda.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una categoria para borrar");
            }
        }
    }
}
