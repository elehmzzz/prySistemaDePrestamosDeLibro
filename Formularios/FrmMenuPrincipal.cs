using prySistemaDePrestamosDeLibro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Formularios
{
    public partial class FrmMenuPrincipal : Form
    {

        private FrmConsultaLibros ventanaLibros;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            ventanaLibros = new FrmConsultaLibros();
            ventanaLibros.Show();
        }

        private void mostrarPanelLibros() {
            abrirFormulario(ventanaLibros);
        }

        private void abrirFormulario(Form formulario)
        {
            //limpia el contenido del panel
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            //hace que el formulario abarque todo el panel
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
