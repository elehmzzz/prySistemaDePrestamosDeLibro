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

namespace prySistemaDePrestamosDeLibro.Formularios.Multas
{
    public partial class FrmMultas : Form
    {
        ClsMulta objMulta = new ClsMulta();

        public FrmMultas()
        {
            InitializeComponent();
            objMulta=new ClsMulta();
        }
         
        private void txtDiasTolerancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLoadMultas(object sender, EventArgs e)
        {
            DataRow fila = objMulta.ObtenerMultaPorId(2);

            if (fila != null)
            {
                txtDiasTolerancia.Text = fila["Dias_tolerancia"].ToString();
                txtPenalizacion.Text = fila["Penalizacion"].ToString();
            }

        }
    }
}
