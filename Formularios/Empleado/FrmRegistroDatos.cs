using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Formularios
{
    public partial class FrmRegistroDatos : Form
    {
        public FrmRegistroDatos()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = this.ParentForm as FrmMenuPrincipal;

            if (menu != null)
                menu.mostrarFormularioUsuario();
        }
    }
}
