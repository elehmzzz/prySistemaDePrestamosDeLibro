using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using prySistemaDePrestamosDeLibro.Formularios;
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
    public partial class FrmPerfilEmpleado : Form
    {
        private ClsBibliotecario objBibliotecario;
        private FrmMenuPrincipal menuPrincipal;

        public FrmPerfilEmpleado(FrmMenuPrincipal padre, ClsBibliotecario obj)
        {
            InitializeComponent();
            menuPrincipal = padre;
            objBibliotecario = obj;
            cargarDatos();
        }

        public void cargarDatos()
        {
            txtNombre.Text = objBibliotecario.getNombre() + " " + objBibliotecario.getAPaterno() + " " + objBibliotecario.getAMaterno();
            txtUsuario.Text = objBibliotecario.getUsuario();
            txtCorreo.Text = objBibliotecario.getCorreo();
            txtTelefono.Text = objBibliotecario.getTelefono();
            txtTipoUsuario.Text = objBibliotecario.getNombreTipoUsuario();
        }

    }
}
