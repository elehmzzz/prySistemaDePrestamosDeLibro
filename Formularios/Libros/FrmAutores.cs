using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    public partial class FrmAutores : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        public FrmAutores(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarModuloLibros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmAgregarAutor formulario = new FrmAgregarAutor();
            formulario.ShowDialog();
        }
    }
}
