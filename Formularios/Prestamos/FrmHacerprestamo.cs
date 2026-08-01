using MySqlX.XDevAPI.Relational;
using prySistemaDePrestamosDeLibro.Clases;
using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Formularios.Prestamos
{
    public partial class FrmHacerprestamo : Form
    {
        ClsLectores objLectores; //instancia
        ClsBibliotecario objBibliotecario;
        ClsLibro objLibro;
        public FrmHacerprestamo(ClsBibliotecario objBibliotecario)
        {
            InitializeComponent();
            this.objBibliotecario = objBibliotecario;
            objLectores = new ClsLectores();
            objLibro = new ClsLibro();
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
                txtDisponibles.Text = libro["Disponibles"].ToString();
            }
        }

        private void btnvalidarprestamo_Click(object sender, EventArgs e)
        {
            DateTime fechaPrestamo = dtpFechaprestamo.Value;
            DateTime fechaDevolucion = dtpFechadevolucion.Value;

            MessageBox.Show("Fecha préstamo: " + fechaPrestamo.ToString());
            MessageBox.Show("Fecha devolución: " + fechaDevolucion.ToString());
        }
    }
}
