using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Ingresar()
        {
            if (txtUsuario.Text != "")
            {
                if (txtClave.Text != "")
                {
                    List<Usuario> TEST = new UsuarioService().ConsultarPrestamista();
                    Usuario usuario = new UsuarioService().LoginUser(txtUsuario.Text, txtClave.Text).FirstOrDefault();
                    if (usuario != null)
                    {
                        frmMenuPrincipal Menu = new frmMenuPrincipal();
                        Menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña no válido", "login");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una contraseña válida", "login");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario válido", "login");
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
    }
}
