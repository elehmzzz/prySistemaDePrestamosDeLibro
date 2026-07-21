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

namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    public partial class FrmAgregarCategoria : Form
    {
        private ClsCategoria objCategoria;
        private FrmCategorias formularioPadre;

        public FrmAgregarCategoria(FrmCategorias padre)
        {
            InitializeComponent();
            objCategoria = new ClsCategoria();
            formularioPadre = padre;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNuevaCategoria.Text.Trim() == "") 
            {
                MessageBox.Show("Ingrese el nombre de la categoría");
                return;
            }

            objCategoria.setNombre(txtNuevaCategoria.Text.Trim());

            if (objCategoria.GuardarCategoria())
            {
                MessageBox.Show("Categoria guardada");
                if (formularioPadre != null)
                {
                    formularioPadre.CargarCategorias();
                }
                this.Close();
            }

        }
    }
}
