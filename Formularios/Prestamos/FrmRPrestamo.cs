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

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmRPrestamo : Form
    {
        ClsPrestamo objPrestamo;
        public FrmRPrestamo(ClsPrestamo objPrestamo)
        {
            InitializeComponent();
            this.objPrestamo = objPrestamo;
            this.objPrestamo.ObtenerDetalle();
            if (this.objPrestamo.ObtenerDetalle())
            {
                txtprestatario.Text = this.objPrestamo.getBibliotecario();
                txtNombre.Text = this.objPrestamo.getLector();
                txtTelefono.Text = this.objPrestamo.getTelefono();
                txtMunicipio.Text = this.objPrestamo.getMunicipio();
                txtColonia.Text = this.objPrestamo.getColonia();
                txtCp.Text = this.objPrestamo.getColonia();
                txtLibro.Text = this.objPrestamo.getLibro();
                txtISBN.Text = this.objPrestamo.getISBN();
                txtAutor.Text = this.objPrestamo.getAutor();
                dtpFechprestamo.Value = this.objPrestamo.getFechaPrestamo();
                dtpFechdevolucion.Value = this.objPrestamo.getFechaDevolucion();
                txtDiasretraso.Text = this.objPrestamo.getDiasAtraso().ToString();
                txtMulta.Text = this.objPrestamo.getMulta().ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el préstamo.");
            }
        }

        private void FrmRPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Buscador_SelectedIndexChanged(object sender, EventArgs e)

        {

        }

        private void btRegresarPrHechos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (objPrestamo.FinalizarPrestamo())
            {
                MessageBox.Show("Prestamo Finalizado");
                this.Close();
            }
        }
    }
}

