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
    public partial class FrmAgregarAutor : Form
    {
        private FrmAutores formularioPadre;
        ClsAutor objAutor;

        public FrmAgregarAutor()
        {
        }

        public FrmAgregarAutor(FrmAutores padre)
        {
            InitializeComponent();
            objAutor = new ClsAutor();
            formularioPadre = padre;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del autor");
                return;
            }
            if (txtAPaterno.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el apellido Paterno del autor");
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el apellido Materno del autor");
                return;
            }

            objAutor.setNombre(txtNombre.Text.Trim());
            objAutor.setAPaterno(txtAPaterno.Text.Trim());
            objAutor.setAMaterno(txtAMaterno.Text.Trim());

            if (objAutor.GuardarAutor())
            {
                MessageBox.Show("Autor guardado");
                if (formularioPadre != null)
                {
                    formularioPadre.CargarAutores();
                }
                this.Close();
            }
        }
    }
}
