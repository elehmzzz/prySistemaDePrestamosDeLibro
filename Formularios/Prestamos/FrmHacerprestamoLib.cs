using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos;
using prySistemaDePrestamosDeLibro.Formularios.Prestamos;
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
    public partial class FrmHacerprestamoLib : Form
    {
        private FrmHacerprestamoLect formularioAnterior;

        public FrmHacerprestamoLib(FrmHacerprestamoLect anterior)
        {
            InitializeComponent();
            formularioAnterior = anterior;
        }

        private void btnRegresarPre_Click(object sender, EventArgs e)
        {
            this.Close(); // regresa al anterior
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
