using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prySistemaDePrestamosDeLibro.Formularios.Lectores;
using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmLectores : Form
    {

        private ClsLectores objLector;
        private FrmMenuPrincipal ventanaPrincipal;
        public FrmLectores(FrmMenuPrincipal padre)
        {
            InitializeComponent();
            objLector = new ClsLectores();
            ventanaPrincipal = padre;
            CargarLectores();

            txtBuscador.TextChanged += txtBuscador_TextChanged_1;
            txtBuscador.Enter += txtBuscador_Enter;
            txtBuscador.Leave += txtBuscador_Leave;
            this.Load += FrmLectores_Load;
            this.VisibleChanged += FrmLectores_VisibleChanged;
        }
        public void CargarLectores()
        {
            ClsLectores clsLectores = new ClsLectores();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = clsLectores.ObtenerLectores();

            if (dataGridView1.Columns["Id_Lector"] != null)
            {
                dataGridView1.Columns["Id_Lector"].HeaderText = "ID Lector";
                dataGridView1.Columns["Id_Lector"].Visible = false;
            }


            if (dataGridView1.Columns["Nombres"] != null)
                dataGridView1.Columns["Nombres"].HeaderText = "Nombre";

            if (dataGridView1.Columns["Apellido_Paterno"] != null)
                dataGridView1.Columns["Apellido_Paterno"].HeaderText = "Apellido Paterno";

            if (dataGridView1.Columns["Apellido_Materno"] != null)
                dataGridView1.Columns["Apellido_Materno"].HeaderText = "Apellido Materno";

            if (dataGridView1.Columns["Fecha_Nacimiento"] != null)
                dataGridView1.Columns["Fecha_Nacimiento"].HeaderText = "Fecha de Nacimiento";

        }
        private void FrmLectores_VisibleChanged(object? sender, EventArgs e)
        {
            if (this.Visible)
            {
                CargarLectores();
            }
        }

        private void txtBuscador_TextChanged_1(object? sender, EventArgs? e)
        {
            dataGridView1.SuspendLayout();

            if (dataGridView1.DataSource is DataView dv)
            {
                string texto = txtBuscador.Text.Trim();
                if (string.IsNullOrEmpty(texto) || texto == "Buscar")
                {
                    dv.RowFilter = "";
                }
                else
                {
                    string textoSeguro = texto.Replace("'", "''");
                    dv.RowFilter = string.Format("Nombres LIKE '%{0}%' OR Apellido_Paterno LIKE '%{0}%' OR Apellido_Materno LIKE '%{0}%' OR Telefono LIKE '%{0}%' OR Colonia LIKE '%{0}%'",textoSeguro);
                }
            }
            else if (dataGridView1.DataSource is DataTable dt)
            {
                dataGridView1.DataSource = dt.DefaultView;
            }

            dataGridView1.ResumeLayout();
        }

        private void btnAgregarLectores_Click(object sender, EventArgs e)
        {
            //FrmAgregarLectores frmAgregar = new FrmAgregarLectores();
            ventanaPrincipal.mostrarApartadoAgregarLectores();
        }

        private void chkAlfabetico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlfabetico.Checked)
            {
                OrdenarAlfabeticamente();
            }
            else
            {
                CargarLectores();
            }
        }

        private void OrdenarAlfabeticamente()
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "Nombres ASC";
                dataGridView1.DataSource = dv;
            }
        }

        private void btnEditarLectores_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow ||
                dataGridView1.CurrentRow.Cells["Id_Lector"].Value == null ||
                dataGridView1.CurrentRow.Cells["Id_Lector"].Value == DBNull.Value)
            {
                MessageBox.Show("Selecciona un lector de la tabla para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idLector = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Lector"].Value);
            ventanaPrincipal.mostrarApartadoEditarLector(idLector);

        }

        private void txtBuscador_Enter(object? sender, EventArgs? e)
        {
            if (txtBuscador.Text == "Buscar")
            {
                txtBuscador.Text = "";
                txtBuscador.ForeColor = Color.Black;
            }
        }

        private void txtBuscador_Leave(object? sender, EventArgs? e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                txtBuscador.Text = "Buscar";
                txtBuscador.ForeColor = Color.Gray;
            }
            txtBuscador_TextChanged_1(sender, e);
        }

        private void FrmLectores_Load(object? sender, EventArgs? e)
        {
            txtBuscador.Text = "Buscar";
            txtBuscador.ForeColor = Color.Gray;

            this.Click += (s, ev) => this.ActiveControl = null;
            dataGridView1.Click += (s, ev) => this.ActiveControl = null;
        }
    }
}
