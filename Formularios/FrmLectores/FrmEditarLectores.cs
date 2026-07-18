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
        public FrmEditarLectores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarLectores_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime fechaActual = DateTime.Today;

            // Calcular la diferencia en años
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha pasado el cumpleaños de este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            // Mostrar el resultado en el TextBox de edad
            txtEdad.Text = edad.ToString();
        }

        private void cmbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
