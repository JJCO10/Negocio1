using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace GUI
{
    public partial class frmCrudVentas : Form
    {
        VentaService ventaService = new VentaService();
        public frmCrudVentas()
        {
            InitializeComponent();
        }

        private void InsertarVenta(Venta venta)
        {
            var msg = ventaService.RegistrarVenta(venta);
            MessageBox.Show(msg);
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtSaborBoli_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtCantidadBoli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnInsertarVenta_Click(object sender, EventArgs e)
        {
            if (txtIdBoli.Text == "" || txtSaborBoli.Text == "" || txtCantidadBoli.Text == "" || txtPrecioTotalBoli.Text == "")
            {
                MessageBox.Show("Por favor, Llene todas las casillas");
            }
            else
            {
                Venta venta = new Venta
                {
                    idVenta = txtIdBoli.Text,
                    saborBoli = txtSaborBoli.Text,
                    cantidadBoli = Convert.ToInt32(txtCantidadBoli.Text),
                    precio = Convert.ToInt32(txtPrecioTotalBoli.Text),
                    fechaBoli = Convert.ToString(dtpFechaVenta.Value.ToString("d"))
                };
                InsertarVenta(venta);
                cargarGrillaVentas(ventaService.ConsultarVenta());
            }
        }

        private void cargarGrillaVentas(List<Venta> ventas)
        {
            dgvConsultaVentas.Rows.Clear();

            if (ventas != null)
            {
                foreach (var venta in ventas)
                {
                    int index = dgvConsultaVentas.Rows.Add();
                    DataGridViewRow row = dgvConsultaVentas.Rows[index];
                    row.Cells["dgvIdVenta"].Value = venta.idVenta;
                    row.Cells["dgvSaborBoli"].Value = venta.saborBoli;
                    row.Cells["dgvCantidadBoli"].Value = venta.cantidadBoli;
                    row.Cells["dgvPrecioVenta"].Value = venta.precio;
                    row.Cells["dgvFechaVenta"].Value = venta.fechaBoli;
                }
            }
        }

        private void dgvConsultaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaVentas.Columns[e.ColumnIndex].Name == "ModificarDGV")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtIdBoli.Text = dgvConsultaVentas.Rows[index].Cells["id_venta"].Value.ToString();
                    txtSaborBoli.Text = dgvConsultaVentas.Rows[index].Cells["sabor"].Value.ToString();
                    txtCantidadBoli.Text = dgvConsultaVentas.Rows[index].Cells["cantidad"].Value.ToString();
                    txtPrecioTotalBoli.Text = dgvConsultaVentas.Rows[index].Cells["precio"].Value.ToString();
                    dtpFechaVenta.Text = dgvConsultaVentas.Rows[index].Cells["fecha"].Value.ToString();
                }
            }
        }


    }
}
