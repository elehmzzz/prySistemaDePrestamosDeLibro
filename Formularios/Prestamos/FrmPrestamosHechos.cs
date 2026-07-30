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
        private FrmMenuPrincipal ventanaPrincipal;
        bool cargandoCombo = false;
        public FrmPrestamosHechos(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            objPrestamo= new ClsPrestamo();
            this.Load += FrmPrestamosHechos_Load;
            cmbxbuscarprestamo.TextChanged += cmbxbuscarprestamo_TextChanged;
            ventanaPrincipal = ventana;
        }

        private void FrmPrestamosHechos_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
            cmbxbuscarprestamo.DropDownStyle = ComboBoxStyle.DropDown;
            cmbxbuscarprestamo.AutoCompleteMode = AutoCompleteMode.None;
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

            if (dGVPrestamos.Columns["Fecha_Prestamo"] != null)
                dGVPrestamos.Columns["Fecha_Prestamo"].HeaderText = "Préstamo";

            if (dGVPrestamos.Columns["Fecha_Devolucion"] != null)
                dGVPrestamos.Columns["Fecha_Devolucion"].HeaderText = "Devolución";

        }
        //cositas del buscador

        private void cmbxbuscarprestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxbuscarprestamo.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cmbxbuscarprestamo.SelectedItem;
                textBoxnamelector.Text = row["NombreCompleto"].ToString();
            }
        }
        private void cmbxbuscarprestamo_TextChanged(object sender, EventArgs e)
        {
            if (cargandoCombo) return;

            string texto = cmbxbuscarprestamo.Text;

            if (string.IsNullOrWhiteSpace(texto))
            {
                cmbxbuscarprestamo.DataSource = null;
                return;
            }

            cargandoCombo = true;

            //DataTable dt = objPrestamo.BuscarLectores(texto);

            //cmbxbuscarprestamo.DataSource = null;
            //cmbxbuscarprestamo.DataSource = dt;
            //cmbxbuscarprestamo.DisplayMember = "NombreCompleto";
            //cmbxbuscarprestamo.ValueMember = "Id_Lector";

            //if (!cmbxbuscarprestamo.DroppedDown)
            //    cmbxbuscarprestamo.DroppedDown = true;

            //cmbxbuscarprestamo.Focus();

            //cmbxbuscarprestamo.Text = texto;
            //cmbxbuscarprestamo.SelectionStart = texto.Length;
            //cmbxbuscarprestamo.SelectionLength = 0;

            cargandoCombo = false;
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            FrmHacerprestamoLect frm = new FrmHacerprestamoLect();
            frm.Show();
        }

        private void btnDatosLectores_Click(object sender, EventArgs e)
        {
            FrmRPrestamo frm = new FrmRPrestamo();
            frm.ShowDialog();
        }
    }
}
