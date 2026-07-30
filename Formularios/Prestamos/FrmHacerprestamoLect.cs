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
    public partial class FrmHacerprestamoLect : Form
    {
        public FrmHacerprestamoLect()
        {
            InitializeComponent();
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
            FrmHacerprestamoLib frm = new FrmHacerprestamoLib(this);

            this.Hide();        // ocultas (NO se pierde info)
            frm.ShowDialog();   // abres el siguiente paso
            this.Show();        // cuando regrese, aparece igual
        }

        private void btnAgregarCLector_Click(object sender, EventArgs e)
        {

        }
    }
}
