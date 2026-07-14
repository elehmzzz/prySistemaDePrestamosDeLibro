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
    public partial class FrmDatosPersonales : Form
    {
        private FrmRegistroPersonal registroPersonal;
        //construcor que recibe el formulario RegistroPersonal
        public FrmDatosPersonales(FrmRegistroPersonal registroPersonal)
        {
            InitializeComponent();
            this.registroPersonal = registroPersonal;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            registroPersonal.mostrarPanelUsuario();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            registroPersonal.abrirInicioSesion();
            registroPersonal.Close();
        }
    }
}
