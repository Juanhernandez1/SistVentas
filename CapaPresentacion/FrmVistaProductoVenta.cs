using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVistaProductoVenta : Form
    {
        public FrmVistaProductoVenta()
        {
            InitializeComponent();
        }
        public void BuscarProductoVenta()
        {
            DataListado.DataSource = N_Venta.MostrarProductoVenta(txtBuscar.Text.ToUpper());
            this.DataListado.ClearSelection();
        }
        public void BuscarRegistroRazon()
        {
            DataListado.DataSource = N_Proveedor.BuscarProveedorRazon(this.txtBuscar.Text);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVistaProductoVenta_Load(object sender, EventArgs e)
        {
            //this.BuscarProductoVenta();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarProductoVenta();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmVenta DatosProducto = Owner as FrmVenta;
            DatosProducto.txtIdProducto.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
            DatosProducto.txtProducto.Text = DataListado.CurrentRow.Cells[2].Value.ToString();
            DatosProducto.txtStock.Text = DataListado.CurrentRow.Cells[5].Value.ToString();
            DatosProducto.txtPrecioVenta.Text = DataListado.CurrentRow.Cells[7].Value.ToString();
            DatosProducto.dtFechaVence.Value = Convert.ToDateTime(DataListado.CurrentRow.Cells[8].Value);

            this.Close();
        }
    }
}
