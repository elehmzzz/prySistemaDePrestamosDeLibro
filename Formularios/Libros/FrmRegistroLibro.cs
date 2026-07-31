using MySql.Data.MySqlClient;
using prySistemaDePrestamosDeLibro.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmRegistroLibro : Form
    {
        private FrmMenuPrincipal ventanaPrincipal;
        private ClsRegistrarLibro objRegistro;
        private DataTable tablaRegistro;
        public FrmRegistroLibro(FrmMenuPrincipal ventana)
        {
            InitializeComponent();
            ventanaPrincipal = ventana;
            objRegistro = new ClsRegistrarLibro();
            tablaRegistro = new DataTable();
            
        }
        public void CargarLibros()
        {
            ClsConexion conexion = new ClsConexion();
            MySqlConnection conn = conexion.ObtenerConexion();
            conn.Open();

            string query = @"
            SELECT
            l.ISBN,
            l.Titulo,
            CONCAT(a.Nombres,' ',a.Apellido_Paterno) AS Autor,
            e.Cantidad_E AS Disponibles,
            l.Fecha_Adquisicion
            FROM libro l
            INNER JOIN autor a
            ON l.Id_Autor = a.Id_Autor
            INNER JOIN ejemplar e
            ON l.Id_Ejemplar = e.Id_Ejemplar;
            ";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }
        private void FrmRegistroLibro_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaPrincipal.mostrarModuloLibros();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
