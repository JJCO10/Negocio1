using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrudInversiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCrudInversiones frmCrudInversiones = new frmCrudInversiones();
            frmCrudInversiones.Show();
        }

        private void btnFiltrarInversiones_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFiltrarInversiones frm = new frmFiltrarInversiones();
            frm.Show();
        }

        private void btnCrudVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCrudVentas frm = new frmCrudVentas();
            frm.Show();
        }

        private void btnFiltrarVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFiltrarVentas frmFiltrarVentas = new frmFiltrarVentas();
            frmFiltrarVentas.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
            frmIniciarSesion.Show();
        }
    }
}
