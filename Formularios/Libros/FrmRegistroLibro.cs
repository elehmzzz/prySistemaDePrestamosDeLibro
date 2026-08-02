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
    public partial class FrmRegistroLibro : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        private ClsAutor objAutor;
        private ClsCategoria objCategoria;
        private ClsEditorial objEditorial;
        private ClsLibro objLibro;
        public FrmRegistroLibro(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            objAutor = new ClsAutor();
            objCategoria = new ClsCategoria();
            objEditorial = new ClsEditorial();
            objLibro= new ClsLibro();
            ventanaPrincipal = ventana;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaPrincipal.mostrarModuloLibros();
        }

        private async void load_frmRegistroLibro(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Enabled = false;

            try
            {
                var autoresTask = Task.Run(() => objAutor.ObtenerAutores());
                var categoriasTask = Task.Run(() => objCategoria.ObtenerCategorias());
                var editorialesTask = Task.Run(() => objEditorial.ObtenerEditoriales());

                await Task.WhenAll(autoresTask, categoriasTask, editorialesTask);

                CargarCombos(
                    await autoresTask,
                    await categoriasTask,
                    await editorialesTask
                );
            }
            finally
            {
                Enabled = true;
                UseWaitCursor = false;
            }
        }

        private void CargarCombos(DataTable dtAutores, DataTable dtCategorias, DataTable dtEditoriales)
        {
            DataRow opcionAutores = dtAutores.NewRow();
            opcionAutores["id_autor"] = 0;
            opcionAutores["nombres"] = "Selecciona una opción";
            dtAutores.Rows.InsertAt(opcionAutores, 0);
            dtAutores.Columns.Add(
                "NombreCompleto",
                typeof(string),
                "nombres + ' ' + apellido_paterno + ' ' + apellido_materno"
            );

          
            cmbAutor.DataSource = dtAutores;
            cmbAutor.DisplayMember = "NombreCompleto";
            cmbAutor.ValueMember = "id_autor";

            DataRow opcionCategoria = dtCategorias.NewRow();
            opcionCategoria["id"] = 0;
            opcionCategoria["nombre"] = "Selecciona una opción";
            dtCategorias.Rows.InsertAt(opcionCategoria, 0);
            cmbCategoria.DataSource = dtCategorias;
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "id";


            DataRow opcionEditoriales = dtEditoriales.NewRow();
            opcionEditoriales["id"] = 0;
            opcionEditoriales["nombre"] = "Selecciona una opción";
            dtEditoriales.Rows.InsertAt(opcionEditoriales, 0);
            cmbEditorial.DataSource = dtEditoriales;
            cmbEditorial.DisplayMember = "nombre";
            cmbEditorial.ValueMember = "id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            string titulo = txtTitulo.Text.Trim();            
            int idAutor = Convert.ToInt32(cmbAutor.SelectedValue);
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            int idEditorial = Convert.ToInt32(cmbEditorial.SelectedValue);

            if(isbn == "")
            {
                MessageBox.Show("Ingrese el ISBN.");
                return;
            }

            if(titulo == "")
            {
                MessageBox.Show("Ingrese el título.");
                return;
            }
            
            if(cmbAutor.SelectedValue == null || Convert.ToInt32(cmbAutor.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione un autor.");
                return;
            }

            if (cmbCategoria.SelectedValue == null || Convert.ToInt32(cmbCategoria.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (cmbEditorial.SelectedValue == null || Convert.ToInt32(cmbEditorial.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione una editorial.");
                return;
            }

            objLibro.setISBN(isbn);
            objLibro.setTitulo(titulo);
            objLibro.setIdAutor(idAutor);
            objLibro.setIdCategoria(idEditorial);
            objLibro.setIdEditorial(idEditorial);

            if (objLibro.GuardarLibro())
            {
               
                this.Close();
            }

        }
    }
}
