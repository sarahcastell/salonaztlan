using Login.Properties;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class cambioContraseña : Form
    {
        public cambioContraseña()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        String contraseña = Settings.Default.contraseña;
        String usuario = Settings.Default.usuario;

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (verificaUsuario(txtUsuario.Text))
            {
                if (txtNuevaContraseña.Text == txtConfirmarContraseña.Text)
                {
                    Settings.Default.contraseña = txtNuevaContraseña.Text;
                    Settings.Default.Save();
                    MessageBox.Show("Cambios realizados");
                    Application.Restart();
                }
                else
                    MessageBox.Show("Contraseñas no coinciden");
            }

            else
                MessageBox.Show("Usuario no encontrado");
        }

        public bool verificaUsuario(String usr)
        {

            if (usr == usuario)
            {
                return true;
            }
            else
                return false;
        }
    }
}
