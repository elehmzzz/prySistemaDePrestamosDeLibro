using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Formularios.Prestamos
{
    public partial class FrmHacerprestamo : Form
    {
        private ClsLectores objLectores; //instancia
        public FrmHacerprestamo()
        {
            InitializeComponent();
            objLectores = new ClsLectores();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresarPre_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cancelar el préstamo?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnseguirprestamo_Click(object sender, EventArgs e)
        {
            FrmHacerprestamo frm = new FrmHacerprestamo();

            this.Hide();        // ocultas (NO se pierde info)
            frm.ShowDialog();   // abres el siguiente paso
            this.Show();        // cuando regrese, aparece igual
        }

        private void btnAgregarCLector_Click(object sender, EventArgs e)
        {

        }

        private void load_FrmLector(object sender, EventArgs e)
        {
            DataTable dtLectores = objLectores.ObtenerLectores(); //aqui consulto los lectores
            cmbLectores.DataSource = dtLectores;
            cmbLectores.DisplayMember = "Nombres";
            cmbLectores.ValueMember = "Id_Lector";
            cmbLectores.DropDownStyle = ComboBoxStyle.DropDown;
            cmbLectores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLectores.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbLectores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
