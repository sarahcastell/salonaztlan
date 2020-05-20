using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Properties;

namespace Login
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        String contraseña = Settings.Default.contraseña;
        String usuario = Settings.Default.usuario;
        public void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
                this.DialogResult = DialogResult.None;
            }
        }

        private void Sesion_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {
            cambioContraseña fm = new cambioContraseña();
            fm.Show();
            //this.Hide();            
        }



    }
}
