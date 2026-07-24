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

namespace prySistemaDePrestamosDeLibro.Formularios.FRMprestamos
{
    public partial class FrmPrestamosHechos : Form
    {

        ClsPrestamoVista objPrestamo = new ClsPrestamoVista();
        bool cargandoCombo = false;
        public FrmPrestamosHechos()
        {
            InitializeComponent();
            this.Load += FrmPrestamosHechos_Load;
            cmbxbuscarprestamo.TextChanged += cmbxbuscarprestamo_TextChanged;

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

            // CAMBIAR NOMBRES (como tu compañero)
            if (dGVPrestamos.Columns["Id_Prestamo"] != null)
                dGVPrestamos.Columns["Id_Prestamo"].HeaderText = "ID";

            if (dGVPrestamos.Columns["Nombres"] != null)
                dGVPrestamos.Columns["Nombres"].HeaderText = "Nombre";

            if (dGVPrestamos.Columns["Apellido_Paterno"] != null)
                dGVPrestamos.Columns["Apellido_Paterno"].HeaderText = "Apellido";

            if (dGVPrestamos.Columns["Titulo"] != null)
                dGVPrestamos.Columns["Titulo"].HeaderText = "Libro";

            if (dGVPrestamos.Columns["Fecha_Prestamo"] != null)
                dGVPrestamos.Columns["Fecha_Prestamo"].HeaderText = "Préstamo";

            if (dGVPrestamos.Columns["Fecha_Devolucion"] != null)
                dGVPrestamos.Columns["Fecha_Devolucion"].HeaderText = "Devolución";


        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dGVPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            DataTable dt = objPrestamo.BuscarLectores(texto);

            cmbxbuscarprestamo.DataSource = null;
            cmbxbuscarprestamo.DataSource = dt;
            cmbxbuscarprestamo.DisplayMember = "NombreCompleto";
            cmbxbuscarprestamo.ValueMember = "Id_Lector";

            if (!cmbxbuscarprestamo.DroppedDown)
                cmbxbuscarprestamo.DroppedDown = true;

            cmbxbuscarprestamo.Focus();

            cmbxbuscarprestamo.Text = texto;
            cmbxbuscarprestamo.SelectionStart = texto.Length;
            cmbxbuscarprestamo.SelectionLength = 0;

            cargandoCombo = false;
        }

        private void textBoxnamelector_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmPrestamosHechos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
