using prySistemaDePrestamosDeLibro.Formularios;
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
        private FrmMenuPrincipal menuPrincipal; // <-- NUEVO
        public FrmRPrestamo(ClsPrestamo objPrestamo, FrmMenuPrincipal padre)
        {
            InitializeComponent();
            this.objPrestamo = objPrestamo;
            this.objPrestamo.ObtenerDetalle();
            menuPrincipal = padre; // <-- NUEVO

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
            menuPrincipal.mostrarModuloPrestamos();
            this.Close();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (objPrestamo.FinalizarPrestamo())
            {
                MessageBox.Show("Prestamo Finalizado");
                menuPrincipal.mostrarModuloPrestamos();
                this.Close();
            }
            else {
                MessageBox.Show("Error al finalizar el prestamo");
            }
        }
    }
}
