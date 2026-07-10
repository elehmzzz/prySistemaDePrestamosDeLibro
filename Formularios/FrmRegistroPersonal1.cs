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
    public partial class frmRegistroPersonal1 : Form
    {
        private UcRegistroDatos registroDatos;
        public frmRegistroPersonal1()
        {
            InitializeComponent();
        }

        private void frmRegistroPersonal1_Load(object sender, EventArgs e)
        {
            registroDatos = new UcRegistroDatos();
            pnlContenido.Controls.Add(registroDatos);
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
