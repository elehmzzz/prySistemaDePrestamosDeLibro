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

namespace prySistemaDePrestamosDeLibro.Formularios.Multas
{
    public partial class FrmMultas : Form
    {
        ClsMulta objMulta = new ClsMulta();

        public FrmMultas()
        {
            InitializeComponent();
            objMulta = new ClsMulta();
        }

        private void txtDiasTolerancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLoadMultas(object sender, EventArgs e)
        {
            DataRow fila = objMulta.ObtenerMultaPorId(2);

            if (fila != null)
            {
                objMulta.setIdMulta(Convert.ToInt32(fila["Id_Multa"])); // <-- NUEVO
                txtDiasTolerancia.Text = fila["Dias_tolerancia"].ToString();
                txtPenalizacion.Text = fila["Penalizacion"].ToString();
            }
            // Estado inicial: bloqueado
            txtDiasTolerancia.ReadOnly = true;
            txtPenalizacion.ReadOnly = true;
            btnGuardarCambios.Enabled = false;
        }

        private void btnEditarMulta_Click(object sender, EventArgs e)
        {
            txtDiasTolerancia.ReadOnly = false;
            txtPenalizacion.ReadOnly = false;
            btnGuardarCambios.Enabled = true;
            txtDiasTolerancia.Focus();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDiasTolerancia.Text.Trim(), out int diasTolerancia))
            {
                MessageBox.Show("Días de tolerancia inválido. Ingrese solo números enteros.");
                txtDiasTolerancia.Focus();
                return;
            }

            if (!decimal.TryParse(txtPenalizacion.Text.Trim(), out decimal penalizacion))
            {
                MessageBox.Show("Penalización inválida. Ingrese solo números.");
                txtPenalizacion.Focus();
                return;
            }

            if (diasTolerancia < 0 || penalizacion < 0)
            {
                MessageBox.Show("Los valores no pueden ser negativos.");
                return;
            }

            objMulta.setDias_tolerancia(diasTolerancia);
            objMulta.setPenalizacion(penalizacion);

            if (objMulta.ActualizarMulta())
            {
                MessageBox.Show("Multa actualizada correctamente.");

                txtDiasTolerancia.ReadOnly = true;
                txtPenalizacion.ReadOnly = true;
                btnGuardarCambios.Enabled = false;
            }
        }
    }
}
