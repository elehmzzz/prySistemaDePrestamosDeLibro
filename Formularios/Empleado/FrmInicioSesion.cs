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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void llbRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistroPersonal registroPersonal = new FrmRegistroPersonal(this);
            registroPersonal.Show();
            this.Hide();
        }
    }
}
