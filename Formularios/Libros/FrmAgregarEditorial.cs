using prySistemaDePrestamosDeLibro.Clases;

namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    public partial class FrmAgregarEditorial : Form
    {
        private FrmEditoriales frmPadre;
        private ClsEditorial editorial;
        public FrmAgregarEditorial(FrmEditoriales frmPadre)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.editorial = new ClsEditorial();
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

            if (editorial.GuardarEditorial())
            {
                MessageBox.Show("Editorial Guardada");
                frmPadre.CargarEditoriales();
            }

            Clear();
        }

        private void Clear()
        {
            editorial.SetId(0);
            editorial.SetNombre("");
            this.Close();
        }
    }
}
