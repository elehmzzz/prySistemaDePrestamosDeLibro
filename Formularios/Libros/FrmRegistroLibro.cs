using prySistemaDePrestamosDeLibro.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmRegistroLibro : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        private ClsRegistrarLibro objRegistro;
        public FrmRegistroLibro(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            ClsRegistrarLibro objLibro = new ClsRegistrarLibro();
            DataTable tablaLibros;
        }
        public void Cargarlibros()
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaPrincipal.mostrarModuloLibros();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        
    }
    }
}
