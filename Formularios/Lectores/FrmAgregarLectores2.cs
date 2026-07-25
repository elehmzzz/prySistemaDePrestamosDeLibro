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

namespace prySistemaDePrestamosDeLibro.Formularios.Lectores
{
    public partial class FrmAgregarLectores2 : Form
    {
        private FrmMenuPrincipal principal;
        FrmInicioSesion ventana2;
        public FrmAgregarLectores2(FrmMenuPrincipal padre)
        {
            InitializeComponent();
            principal = padre;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            principal.mostrarModuloLectores();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación básica de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPat.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMat.Text))
            {
                MessageBox.Show("Por favor completa los campos obligatorios.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsLectores lector = new ClsLectores();
            lector.setNombres(txtNombre.Text.Trim());
            lector.setApellidoPaterno(txtApellidoPat.Text.Trim());
            lector.setApellidoMaterno(txtApellidoMat.Text.Trim());
            lector.setTelefono(txtTelefono.Text.Trim());
            lector.setMunicipio(txtMunicipio.Text.Trim());
            lector.setColonia(txtColonia.Text.Trim());
            lector.setCP(txtCP.Text.Trim());
            lector.setFechaNacimiento(dtpFechaNac.Value.Date);
            lector.setEdad(Convert.ToInt32(txtEdad.Text));

            bool guardado = lector.GuardarLector();

            if (guardado)
            {
                MessageBox.Show("Lector guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            principal.mostrarModuloLectores();
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtpFechaNac.Value.Date;
            DateTime hoy = DateTime.Today;

            int edad = hoy.Year - fechaNacimiento.Year;

            // Ajusta si aún no ha cumplido años este año
            if (fechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }

            txtEdad.Text = edad.ToString();
        }
    }
}
