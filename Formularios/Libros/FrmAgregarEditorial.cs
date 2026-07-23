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
    public partial class FrmAgregarEditorial : Form
    {
        private FrmEditoriales frmPadre;
        private ClsEditorial editorial;
        public FrmAgregarEditorial(FrmEditoriales frmPadre, ClsEditorial editorial)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.editorial = editorial;
            txtEditorial.Text = editorial.GetNombre();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void FrmAgregarEditorial_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nombre = txtEditorial.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre de la editorial");
                return;
            }

            editorial.SetNombre(nombre);

            if (editorial.GetId() == 0)
            {
                if (editorial.GuardarEditorial())
                {
                    MessageBox.Show("Editorial Guardada");
                    frmPadre.CargarEditoriales();
                }
            }
            else
            {
                if (editorial.ActualizarEditorial())
                {
                    MessageBox.Show("Editorial Actualizada");
                    frmPadre.CargarEditoriales();
                }
            }
            Clear();
        }

        private void Clear()
        {
            editorial.SetId(0);
            editorial.SetNombre("");
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (editorial.GetId() > 0)
            {
                if (MessageBox.Show("Estas seguro de borrar esta editorail", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (editorial.BorrarEditorial())
                    {
                        MessageBox.Show("Editorial eliminada correctamente");
                        frmPadre.CargarEditoriales();
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una editorial para borrar");
            }
        }
    }
}
