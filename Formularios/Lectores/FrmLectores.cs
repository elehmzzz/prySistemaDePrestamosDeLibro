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

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmLectores : Form
    {

        private ClsLectores objLector;
        public FrmLectores()
        {
            InitializeComponent();
            objLector = new ClsLectores();
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmLectores_Load(object sender, EventArgs e)
        {
            CargarLectores();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarLector_Click(object sender, EventArgs e)
        {
            FrmAgregarLectores ventanaAgregar = new FrmAgregarLectores();
            ventanaAgregar.ShowDialog();
        }

        private void txtBuscador_TextChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                string texto = txtBuscador.Text.Trim();

                if (string.IsNullOrEmpty(texto) || texto == "Buscar")
                {
                    dv.RowFilter = "";
                }
                else
                {
                    string textoSeguro = texto.Replace("'", "''");
                    dv.RowFilter = string.Format(
                        "Nombres LIKE '%{0}%' OR Apellido_Paterno LIKE '%{0}%' OR Apellido_Materno LIKE '%{0}%' OR Telefono LIKE '%{0}%' OR Colonia LIKE '%{0}%'",
                        textoSeguro);
                }

                dataGridView1.DataSource = dv;
            }
        }

        private void btnAgregarLectores_Click(object sender, EventArgs e)
        {
            FrmAgregarLectores frmAgregar = new FrmAgregarLectores();
            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                CargarLectores(); // O el método que uses para llenar el DataGridView
            }
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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un lector de la tabla para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idLector = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Lector"].Value);

            FrmEditarLectores frmEditar = new FrmEditarLectores(idLector);
            if (frmEditar.ShowDialog() == DialogResult.OK)
            {
                CargarLectores();
            }
        }
    }
}
