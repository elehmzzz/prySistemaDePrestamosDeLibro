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

namespace prySistemaDePrestamosDeLibro.Formularios
{
    public partial class FrmDatosUsuario : Form
    {
        private FrmRegistroPersonal registroPersonal;
        public FrmDatosUsuario(FrmRegistroPersonal registroPersonal)
        {
            InitializeComponent();
            this.registroPersonal = registroPersonal;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            registroPersonal.abrirInicioSesion();
            registroPersonal.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            registroPersonal.mostrarPanelDatos();
        }

    }
}
