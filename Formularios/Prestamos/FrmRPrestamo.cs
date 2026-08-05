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
        private FrmPrestamosHechos ventanaPrestamos; // <-- NUEVO
        public FrmRPrestamo(ClsPrestamo objPrestamo, FrmPrestamosHechos ventanaPrestamos)
        {
            InitializeComponent();
            this.objPrestamo = objPrestamo;
            this.objPrestamo.ObtenerDetalle();
            this.ventanaPrestamos = ventanaPrestamos; // <-- NUEVO

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
                txtEjemplar.Text = this.objPrestamo.getCodigo().ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el préstamo.");
            }
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
                ventanaPrestamos.CargarPrestamos(); // <-- NUEVO: refresca el dgv
                this.Close();
            }
        }
    }
}
