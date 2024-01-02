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
            if (txtIdBoli.Text == "" || cboxSabor.Text == "" || txtCantidadBoli.Text == "" || txtPrecioTotalBoli.Text == "")
            {
                MessageBox.Show("Por favor, Llene todas las casillas");
            }
            else
            {
                Venta venta = new Venta
                {
                    idVenta = txtIdBoli.Text,
                    saborBoli = cboxSabor.Text,
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
            //if (dgvConsultaVentas.Columns[e.ColumnIndex].Name == "ModificarDGV")
            //{
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtIdBoli.Text = dgvConsultaVentas.Rows[index].Cells["dgvIdVenta"].Value.ToString();
                cboxSabor.Text = dgvConsultaVentas.Rows[index].Cells["dgvSaborBoli"].Value.ToString();
                txtCantidadBoli.Text = dgvConsultaVentas.Rows[index].Cells["dgvCantidadBoli"].Value.ToString();
                txtPrecioTotalBoli.Text = dgvConsultaVentas.Rows[index].Cells["dgvPrecioVenta"].Value.ToString();
                dtpFechaVenta.Text = dgvConsultaVentas.Rows[index].Cells["dgvFechaVenta"].Value.ToString();
            }
            //}
        }

        private void frmCrudVentas_Load(object sender, EventArgs e)
        {
            cargarGrillaVentas(ventaService.ConsultarVenta());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarVentasFiltro();
        }

        private void CargarVentasFiltro()
        {
            var filtro = txtBuscar.Text;
            var list = ventaService.BuscarFiltradoVenta(filtro);
            cargarGrillaVentas(list);
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            if (txtIdBoli.Text != "" || cboxSabor.Text != "" || txtCantidadBoli.Text != "" || txtPrecioTotalBoli.Text != "" || dtpFechaVenta.Text != "")
            {
                Venta venta = new Venta
                {
                    idVenta = txtIdBoli.Text,
                    saborBoli = cboxSabor.Text,
                    cantidadBoli = Convert.ToInt32(txtCantidadBoli.Text),
                    precio = Convert.ToInt32(txtPrecioTotalBoli.Text),
                    fechaBoli = Convert.ToString(dtpFechaVenta.Value.ToString("d"))
                };
                /*if (venta == null)
                {
                    var msg = ventaService.ModificarVenta(venta);
                    MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrillaVentas(ventaService.ConsultarVenta());
                }
                else
                {
                    var msg = ventaService.ModificarVenta(venta);
                    MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                ModificarBD(venta);
                cargarGrillaVentas(ventaService.ConsultarVenta());
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ModificarBD(Venta venta)
        {
            var msg = ventaService.ModificarVenta(venta);
            MessageBox.Show(msg);
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (txtIdBoli.Text != "" || cboxSabor.Text != "" || txtCantidadBoli.Text != "" || txtPrecioTotalBoli.Text != "" || dtpFechaVenta.Text != "")
            {
                Venta venta = new Venta
                {
                    idVenta = txtIdBoli.Text,
                    saborBoli = cboxSabor.Text,
                    cantidadBoli = Convert.ToInt32(txtCantidadBoli.Text),
                    precio = Convert.ToInt32(txtPrecioTotalBoli.Text),
                    fechaBoli = Convert.ToString(dtpFechaVenta.Value.ToString("d"))
                };
                EliminarBD(venta);
                cargarGrillaVentas(ventaService.ConsultarVenta());
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void EliminarBD(Venta venta)
        {
            var msg = ventaService.EliminarVenta(venta);
            MessageBox.Show(msg);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcelVentas_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvConsultaVentas);
        }

        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }
    }
}
