using prySistemaDePrestamosDeLibro.Formularios;
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
    public partial class FrmRegistroLibro : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        public FrmRegistroLibro(FrmMenuPrincipal ventana )
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaPrincipal.mostrarModuloLibros();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

        }
    }
}
