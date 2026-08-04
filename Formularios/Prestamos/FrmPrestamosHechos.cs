using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prySistemaDePrestamosDeLibro.Formularios.FRMprestamos
{
    public partial class FrmPrestamosHechos : Form
    {
        ClsPrestamo objPrestamo;
        ClsBibliotecario objBibliotecario;
        ClsLectores objLectores; // <-- NUEVO
        private FrmMenuPrincipal ventanaPrincipal;
        bool cargandoCombo = false;
        public FrmPrestamosHechos(FrmMenuPrincipal ventana, ClsBibliotecario objBibliotecario)
        {
            InitializeComponent();
            objPrestamo = new ClsPrestamo();
            objLectores = new ClsLectores(); // <-- NUEVO
            this.Load += FrmPrestamosHechos_Load;
            cmbxbuscarprestamo.TextChanged += cmbxbuscarprestamo_TextChanged;
            ventanaPrincipal = ventana;
            this.objBibliotecario = objBibliotecario;
        }

        private void FrmPrestamosHechos_Load(object sender, EventArgs e)
        {
            CargarPrestamos();

            // Cargar combo de búsqueda por lector
            DataTable dtLectores = objLectores.ObtenerLectores();
            dtLectores.Columns.Add("NombreCompleto", typeof(string), "Nombres + ' ' + Apellido_Paterno + ' ' + Apellido_Materno");
            cmbxbuscarprestamo.DataSource = dtLectores;
            cmbxbuscarprestamo.DisplayMember = "NombreCompleto";
            cmbxbuscarprestamo.ValueMember = "Id_Lector";
            cmbxbuscarprestamo.DropDownStyle = ComboBoxStyle.DropDown;
            cmbxbuscarprestamo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbxbuscarprestamo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbxbuscarprestamo.SelectedIndex = -1;


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
        //cositas del buscador

        private void cmbxbuscarprestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxbuscarprestamo.SelectedItem is DataRowView lector)
            {
                string nombreCompleto = lector["NombreCompleto"].ToString()!;

                foreach (DataGridViewRow fila in dGVPrestamos.Rows)
                {
                    if (fila.Cells["Lector"].Value?.ToString() == nombreCompleto)
                    {
                        dGVPrestamos.ClearSelection();
                        fila.Selected = true;
                        dGVPrestamos.FirstDisplayedScrollingRowIndex = fila.Index; // sube esa fila hasta arriba
                        dGVPrestamos.CurrentCell = fila.Cells[0];
                        break;
                    }
                }
            }
        }
        private void cmbxbuscarprestamo_TextChanged(object sender, EventArgs e)
        {

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
            FrmRPrestamo frm = new FrmRPrestamo(objPrestamo, this);
            frm.Show();
        }
    }
}
