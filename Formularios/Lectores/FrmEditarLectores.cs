using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmEditarLectores : Form
    {
        private int idLectorSeleccionado;

        public FrmEditarLectores(int idLector)
        {
            InitializeComponent();
            idLectorSeleccionado = idLector;
        }

        private void FrmEditarLectores_Load(object sender, EventArgs e)
        {
            CargarDatosLector();
        }

        private void CargarDatosLector()
        {
            ClsLectores clsLectores = new ClsLectores();
            DataRow fila = clsLectores.ObtenerLectorPorId(idLectorSeleccionado);

            if (fila != null)
            {
                txtIdLector.Text = fila["Id_Lector"].ToString();
                txtNombre.Text = fila["Nombres"].ToString();
                txtApellidoPaterno.Text = fila["Apellido_Paterno"].ToString();
                txtApellidoMaterno.Text = fila["Apellido_Materno"].ToString();
                txtTelefono.Text = fila["Telefono"].ToString();
                txtMunicipio.Text = fila["Municipio"].ToString();
                txtColonia.Text = fila["Colonia"].ToString();
                txtCP.Text = fila["CP"].ToString();
                txtEdad.Text = fila["Edad"] != DBNull.Value ? fila["Edad"].ToString() : "";
                dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            }
            else
            {
                MessageBox.Show("No se encontró el lector seleccionado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            txtEdad.Text = edad.ToString();
        }

        private void cmbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
        string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
            {
                MessageBox.Show("Por favor completa los campos obligatorios.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsLectores lector = new ClsLectores();
            lector.setIdLector(idLectorSeleccionado);
            lector.setNombres(txtNombre.Text.Trim());
            lector.setApellidoPaterno(txtApellidoPaterno.Text.Trim());
            lector.setApellidoMaterno(txtApellidoMaterno.Text.Trim());
            lector.setTelefono(txtTelefono.Text.Trim());
            lector.setMunicipio(txtMunicipio.Text.Trim());
            lector.setColonia(txtColonia.Text.Trim());
            lector.setCP(txtCP.Text.Trim());
            lector.setFechaNacimiento(dtpFechaNacimiento.Value.Date);
            lector.setEdad(string.IsNullOrWhiteSpace(txtEdad.Text) ? 0 : Convert.ToInt32(txtEdad.Text.Trim()));

            bool actualizado = lector.ActualizarLector();

            if (actualizado)
            {
                MessageBox.Show("Lector actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}