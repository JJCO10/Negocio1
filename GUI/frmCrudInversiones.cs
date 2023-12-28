using BLL;
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

namespace GUI
{
    public partial class frmCrudInversiones : Form
    {
        InversionService inversionService = new InversionService();
        public frmCrudInversiones()
        {
            InitializeComponent();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
        }

        private void btnInsertarInversion_Click(object sender, EventArgs e)
        {
            if (txtIdInversion.Text == "" || txtProducto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Por favor, Llene todas las casillas");
            }
            else
            {
                Inversion inversion = new Inversion()
                {
                    idInversion = txtIdInversion.Text,
                    producto = txtProducto.Text,
                    precioProducto = Convert.ToInt32(txtPrecio.Text),
                    fechaInversion = Convert.ToString(dtpFechaInversion.Value.ToString("d"))
                };
                InsertarInversion(inversion);
               // cargraGrillaInversiones(inversionService.ConsultarInversion());
            }
        }

        private void InsertarInversion(Inversion inversion)
        {
            var msg = inversionService.RegistrarInversion(inversion);
            MessageBox.Show(msg);
        }

        private void btnModificarInversion_Click(object sender, EventArgs e)
        {
            if (txtIdInversion.Text != "" || txtProducto.Text != "" || txtPrecio.Text != "" || dtpFechaInversion.Text != "")
            {
                Inversion inversion = new Inversion()
                {
                    idInversion = txtIdInversion.Text,
                    producto = txtProducto.Text,
                    precioProducto = Convert.ToInt32(txtPrecio.Text),
                    fechaInversion = Convert.ToString(dtpFechaInversion.Value.ToString("d"))
                };
                ModificarInversion(inversion);
                // cargraGrillaInversiones(inversionService.ConsultarInversion());

            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ModificarInversion(Inversion inversion)
        {
            var msg = inversionService.ModificarInversion(inversion);
            MessageBox.Show(msg);
        }

        private void btnEliminarInversion_Click(object sender, EventArgs e)
        {
            if (txtIdInversion.Text != "" || txtProducto.Text != "" || txtPrecio.Text != "" || dtpFechaInversion.Text != "")
            {
                Inversion inversion = new Inversion()
                {
                    idInversion = txtIdInversion.Text,
                    producto = txtProducto.Text,
                    precioProducto = Convert.ToInt32(txtPrecio.Text),
                    fechaInversion = Convert.ToString(dtpFechaInversion.Value.ToString("d"))
                };
                EliminarInversion(inversion);
                // cargraGrillaInversiones(inversionService.ConsultarInversion());

            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarInversion(Inversion inversion)
        {
            var msg = inversionService.EliminarInversion(inversion);
            MessageBox.Show(msg);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarInversionesFiltro();
        }

        private void CargarInversionesFiltro()
        {
            var filtro = txtBuscar.Text;
            var list = inversionService.BuscarFiltradoInversion(filtro);
            //cargarGrillaInversiones(list);
        }
    }
}
