using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos; // <-- NUEVO
using System.Data;


namespace prySistemaDePrestamosDeLibro.Formularios.Prestamos
{
    public partial class FrmHacerprestamo : Form
    {
        ClsLectores objLectores; //instancia
        ClsBibliotecario objBibliotecario;
        ClsLibro objLibro;
        ClsPrestamo objPrestamo;
        private FrmPrestamosHechos ventanaPrestamos; // <-- NUEVO

        public FrmHacerprestamo(ClsBibliotecario objBibliotecario, FrmPrestamosHechos ventanaPrestamos)
        {
            InitializeComponent();
            this.objBibliotecario = objBibliotecario;
            this.ventanaPrestamos = ventanaPrestamos; // <-- NUEVO
            objLectores = new ClsLectores();
            objLibro = new ClsLibro();
            objPrestamo = new ClsPrestamo();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresarPre_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cancelar el préstamo?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregarCLector_Click(object sender, EventArgs e)
        {

        }

        private void load_FrmLector(object sender, EventArgs e)
        {

            DataTable dtLectores = objLectores.ObtenerLectores(); //aqui consulto los lectores
            dtLectores.Columns.Add("NombreCompleto", typeof(string), "Nombres + ' ' + Apellido_Paterno + '  '+ Apellido_Materno");
            cmbLectores.DataSource = dtLectores;
            cmbLectores.DisplayMember = "NombreCompleto";
            cmbLectores.ValueMember = "Id_Lector";
            cmbLectores.DropDownStyle = ComboBoxStyle.DropDown;
            cmbLectores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLectores.AutoCompleteSource = AutoCompleteSource.ListItems;
            

            DataTable dtLibros = objLibro.ObtenerLibros(); //aqui consulto los lectores
            cmbLibros.DataSource = dtLibros;
            cmbLibros.DisplayMember = "Titulo";
            cmbLibros.ValueMember = "id_libro";
            cmbLibros.DropDownStyle = ComboBoxStyle.DropDown;
            cmbLibros.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLibros.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbLectores.SelectedIndex = -1;
            txtEdad.Clear();
            txtMunicipio.Clear();
            txtColonia.Clear();
            txtcp.Clear();
            txtTelefono.Clear();
            cmbLibros.SelectedIndex = -1;
            txtISBN.Clear();
            txtAutor.Clear();
            txtDisponibles.Clear();
        }

        private void cmbLectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLectores.SelectedItem is DataRowView lector)
            {
                dtpFechanac.Value = Convert.ToDateTime(lector["Fecha_Nacimiento"]);
                txtEdad.Text = lector["Edad"].ToString();
                txtMunicipio.Text = lector["Municipio"].ToString();
                txtColonia.Text = lector["Colonia"].ToString();
                txtcp.Text = lector["CP"].ToString();
                txtTelefono.Text = lector["Telefono"].ToString();
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLibros_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedItem is DataRowView libro)
            {
                txtISBN.Text = libro["ISBN"].ToString();
                txtAutor.Text = libro["Nombres"].ToString();
            }
        }

        private void btnvalidarprestamo_Click(object sender, EventArgs e)
        {
            int idLibro = Convert.ToInt32(cmbLibros.SelectedValue);
            int idLector = Convert.ToInt32(cmbLectores.SelectedValue);
            int idUsuario = objBibliotecario.getIdBibliotecario();
            // Validar lector
            if (cmbLectores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un lector.");
                cmbLectores.Focus();
                return;
            }

            // Validar libro
            if (cmbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro.");
                cmbLibros.Focus();
                return;
            }

            // Validar fechas
            if (dtpFechadevolucion.Value.Date <= dtpFechaprestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la fecha de préstamo.");
                dtpFechadevolucion.Focus();
                return;
            }

            objPrestamo.setFecha_Prestamo(dtpFechaprestamo.Value.Date);
            objPrestamo.setFecha_Devolucion(dtpFechadevolucion.Value.Date);
            objPrestamo.setIdLector(idLector);
            objPrestamo.setIdBibliotecario(idUsuario);
            objPrestamo.setIdLibro(idLibro);

            if (objPrestamo.GuardarPrestamo())
            {
                MessageBox.Show("Prestamo guardado");
                ventanaPrestamos.CargarPrestamos(); // <-- NUEVO: refresca el dgv
                this.Close();
            }


        }
    }
}
