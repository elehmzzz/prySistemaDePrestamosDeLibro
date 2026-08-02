using prySistemaDePrestamosDeLibro.Formularios;

namespace prySistemaDePrestamosDeLibro.Clases
{
    public partial class FrmInicioSesion : Form
    {
        private ClsBibliotecario objBibliotecario;
        private FrmMenuPrincipal menuPrincipal;

        public FrmInicioSesion()
        {
            InitializeComponent();
            objBibliotecario = new ClsBibliotecario();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            //validar que los campos no vayan vacios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasenia))
            {
                MessageBox.Show("El usuario o la contraseña no pueden \n ir vacios");
                return;
            }
  
            objBibliotecario.setUsuario(usuario);
            objBibliotecario.setContrasenia(contrasenia);

            if (objBibliotecario.buscarBibliotecario())
            {
                menuPrincipal = new FrmMenuPrincipal(this, objBibliotecario);
                this.Hide();
                menuPrincipal.Show();
                txtUsuario.Clear();
                txtContrasenia.Clear();
                txtUsuario.Focus();
            }
        }

        private void llbRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistroPersonal registroPersonal = new FrmRegistroPersonal(this);
            registroPersonal.Show();
            this.Hide();
            txtContrasenia.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void llbSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
