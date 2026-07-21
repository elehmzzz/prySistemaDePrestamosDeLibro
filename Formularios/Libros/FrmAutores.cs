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
    public partial class FrmAutores : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        private FrmAgregarAutor ventanaAgregarAutor;
        private ClsAutor objAutor;
        public FrmAutores(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            objAutor = new ClsAutor();
            dataGridView1.CellClick += dtAutores_Click;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarModuloLibros();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            ventanaAgregarAutor = new FrmAgregarAutor(this);
            ventanaAgregarAutor.ShowDialog();

        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            CargarAutores();
        }

        public void CargarAutores()
        {
            DataTable dt = objAutor.ObtenerAutores();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }


        private void dtAutores_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridView1.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    objAutor.setIdAutor(Convert.ToInt32(fila.Cells[0].Value));
                }

                if (fila.Cells[1].Value != null)
                {
                    objAutor.setNombre(fila.Cells[1].Value.ToString());
                    txtNombre.Text = fila.Cells[1].Value.ToString();
                }

                if (fila.Cells[2].Value != null)
                {
                    objAutor.setAPaterno(fila.Cells[2].Value.ToString());
                    txtAPaterno.Text = fila.Cells[2].Value.ToString();
                }

                if (fila.Cells[3].Value != null)
                {
                    objAutor.setAMaterno(fila.Cells[3].Value.ToString());
                    txtAMaterno.Text = fila.Cells[3].Value.ToString();
                }
            }
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
                        txtNombre.Clear();
                        txtAPaterno.Clear();
                        txtAMaterno.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un autor para borrar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
        }
    }
}
