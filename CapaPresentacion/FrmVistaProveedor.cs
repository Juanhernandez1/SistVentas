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
    public partial class FrmVistaProveedor : Form
    {
        public FrmVistaProveedor()
        {
            InitializeComponent();
        }
        public void MostrarRegistro()
        {
            DataListado.DataSource = N_Proveedor.MostrarRegistro();
            this.DataListado.ClearSelection();
        }
        public void BuscarRegistroRazon()
        {
            DataListado.DataSource = N_Proveedor.BuscarProveedorRazon(this.txtBuscar.Text);
        }
        private void FrmVistaProveedor_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRegistroRazon();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmIngreso DatosProducto = Owner as FrmIngreso;
            DatosProducto.txtIdProveedor.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
            DatosProducto.txtProveedor.Text = DataListado.CurrentRow.Cells[1].Value.ToString();

            this.Close();
        }
    }
}
