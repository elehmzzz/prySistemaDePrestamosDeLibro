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
        public FrmAgregarLectores2()
        {
            InitializeComponent();
            principal = new FrmMenuPrincipal(ventana2,"","","","");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            principal.mostrarModuloLibros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
