using prySistemaDePrestamosDeLibro.Formularios.FRMprestamos;
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

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmHacerprestamoLib : Form
    {
        ClsLibro objLibro; //instancia
        public FrmHacerprestamoLib(FrmHacerprestamoLect anterior)
        {
            InitializeComponent();
            objLibro = new ClsLibro();
        }

        private void btnRegresarPre_Click(object sender, EventArgs e)
        {
            this.Close(); // regresa al anterior
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void cmbLectores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void load_FrmLibro(object sender, EventArgs e)
        {
            DataTable dtLibro = objLibro.ObtenerLibros(); //aqui consulto los libros
            cmbLibros.DataSource = dtLibro;
            cmbLibros.DisplayMember = "Titulo";
            cmbLibros.ValueMember = "id_Libro";
            cmbLibros.DropDownStyle = ComboBoxStyle.DropDown;
            cmbLibros.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLibros.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLibros.SelectedIndex = -1; // 👈 ESTO EVITA EL ERROR
        }

        private void on_selected(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedItem != null)
            {
                DataRowView fila = (DataRowView)cmbLibros.SelectedItem;

                txtISBN.Text = fila["ISBN"].ToString();
               
            }
        }
    }
}
