using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
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

        public FrmPerfilEmpleado(

            string NombreCompleto,
            string Usuario,
            string Correo,
            string Telefono)

        {
            InitializeComponent();
            textBox1.Text = NombreCompleto;
            textBox4.Text = Usuario;
            textBox2.Text = Correo;
            textBox3.Text = Telefono;

        }


        public void mostrarDatos()
        {

        }
        private void FrmPerfilEmpleado_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPerfilEmpleado_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmPerfilEmpleado_Load_2(object sender, EventArgs e)
        {

        }
    }
}
