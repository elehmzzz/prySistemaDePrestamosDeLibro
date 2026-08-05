using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios.Prestamos;
using System.Data;

namespace prySistemaDePrestamosDeLibro.Formularios.FRMprestamos
{
    public partial class FrmPrestamosHechos : Form
    {
        ClsPrestamo objPrestamo;
        ClsBibliotecario objBibliotecario;

        private FrmMenuPrincipal ventanaPrincipal;

        public FrmPrestamosHechos(FrmMenuPrincipal ventana, ClsBibliotecario objBibliotecario)
        {
            InitializeComponent();
            objPrestamo = new ClsPrestamo();
            ventanaPrincipal = ventana;
            this.objBibliotecario = objBibliotecario;
            CargarPrestamos();
            cmbVistasPrestamos.SelectedIndex = 0;
        }
        public void CargarPrestamos()
        {
            DataTable dt = objPrestamo.ObtenerPrestamos();

            // LIMPIAR 
            dGVPrestamos.DataSource = null;
            dGVPrestamos.Columns.Clear();

            // CONFIGURAR
            dGVPrestamos.AutoGenerateColumns = true;
            dGVPrestamos.AllowUserToAddRows = false;

            // ASIGNAR DATOS
            dGVPrestamos.DataSource = dt;

            // AJUSTAR VISUAL
            dGVPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // CAMBIAR NOMBRES
            if (dGVPrestamos.Columns["ID"] != null)
                dGVPrestamos.Columns["ID"].HeaderText = "ID";

            if (dGVPrestamos.Columns["Lector"] != null)
                dGVPrestamos.Columns["Lector"].HeaderText = "Lector";

            if (dGVPrestamos.Columns["Libro"] != null)
                dGVPrestamos.Columns["Libro"].HeaderText = "Libro";

            if (dGVPrestamos.Columns["bibliotecario"] != null)
                dGVPrestamos.Columns["bibliotecario"].HeaderText = "Bibliotecario";

            if (dGVPrestamos.Columns["Fecha_Prestamo"] != null)
                dGVPrestamos.Columns["Fecha_Prestamo"].HeaderText = "Préstamo";

            if (dGVPrestamos.Columns["Fecha_Devolucion"] != null)
                dGVPrestamos.Columns["Fecha_Devolucion"].HeaderText = "Devolución";

        }
        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            FrmHacerprestamo frm = new FrmHacerprestamo(this.objBibliotecario, this); // <-- se agregó "this"
            frm.Show();
        }
        private void dtPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dGVPrestamos.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    objPrestamo.setIdPrestamo(Convert.ToInt32(fila.Cells[0].Value));
                }

                if (fila.Cells[1].Value != null)
                {
                    txtNombre.Text = fila.Cells[1].Value.ToString();
                }
            }
        }
        private void btnDatosLectores_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.mostrarDetallesPrestamo(objPrestamo, ventanaPrincipal);
        }
        private void onLoad(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        public void configurarDgv(DataTable dt)
        {
            dGVPrestamos.DataSource = null;
            dGVPrestamos.Columns.Clear();
            // CONFIGURAR
            dGVPrestamos.AutoGenerateColumns = true;
            dGVPrestamos.AllowUserToAddRows = false;
            // ASIGNAR DATOS
            dGVPrestamos.DataSource = dt;
        }

        private void on_Consultar(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DateTime fechaBusqueda = dtpFecha.Value;
            int opc = cmbVistasPrestamos.SelectedIndex;
            switch (opc)
            {
                case 1:
                    //ver prestamos
                    dtpFecha.Enabled = false;
                    CargarPrestamos();
                    break;
                case 2:
                    //ver prestamos totales por dia
                    dtpFecha.Enabled = true;
                    dt = objPrestamo.obtenerTotalPrestamos(fechaBusqueda);
                    txtNombre.Text = $"Total de préstamos del día {fechaBusqueda.ToShortDateString()}: {dt.Rows.Count}";
                    configurarDgv(dt);
                    break;
                case 3:
                    //ver prestamos con multa
                    dtpFecha.Enabled = false;
                    dt = objPrestamo.obtenerPrestamosConMulta(fechaBusqueda);
                    txtNombre.Text = $"Préstamos con multa: {dt.Rows.Count}";
                    configurarDgv(dt);
                    break;
                case 4:
                    //ver prestamos retrasados
                    dtpFecha.Enabled = false;
                    dt = objPrestamo.obtenerTotalDePrestamosRetrasados();
                    txtNombre.Text = $"Préstamos retrasados: {dt.Rows.Count}";
                    configurarDgv(dt);
                    break;

                default:
                    dtpFecha.Enabled = false;
                    break;
            }
        }

        private void on_changed(object sender, EventArgs e)
        {
            switch (cmbVistasPrestamos.SelectedIndex)
            {
                case 2:
                    // Ver préstamos totales por día
                    dtpFecha.Visible = true;
                    dtpFecha.Enabled = true;
                    break;

                default:
                    dtpFecha.Visible = false;
                    dtpFecha.Enabled = false;
                    break;
            }
        }
    }
}
