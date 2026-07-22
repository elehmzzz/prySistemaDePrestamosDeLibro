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
            DataTable dt = objLector.ObtenerLectores();
            dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.Trim();

            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.IsNullOrEmpty(filtro)
                    ? ""
                    : string.Format("Nombres LIKE '%{0}%' OR Apellido_Paterno LIKE '%{0}%'", filtro);
            }
        }

        private void btnAgregarLector_Click(object sender, EventArgs e)
        {
            FrmAgregarLectores ventanaAgregar = new FrmAgregarLectores();
            ventanaAgregar.ShowDialog();
        }

        private void txtBuscador_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
