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
    public partial class FrmVistaProductoIngreso : Form
    {
        public FrmVistaProductoIngreso()
        {
            InitializeComponent();
        }
        private void Columnas()
        {
            DataListado.Columns[0].Visible = false;
            DataListado.Columns[1].HeaderText = "CODIGO";
            DataListado.Columns[2].HeaderText = "PRODUCTO";
            DataListado.Columns[3].HeaderText = "DESCRIPCION";
            DataListado.Columns[4].HeaderText = "CATEGORIA";
            DataListado.Columns[5].HeaderText = "PRESENTACION";
        }
        //Metodo para mostrar registro de productos
        public void MostrarRegistro()
        {
            DataListado.DataSource = N_Producto.MostrarRegistro();
            this.DataListado.ClearSelection();
        }
        //Metodo buscar producto 
        public void BuscarRegistro()
        {
            DataListado.DataSource = N_Producto.BuscarProductoNombre(this.txtBuscar.Text);
        }
        private void FrmVistaProductoIngreso_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
            this.Columnas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRegistro();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngreso DatosProducto=Owner as FrmIngreso;
            DatosProducto.txtIdProducto.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
            DatosProducto.txtProducto.Text = DataListado.CurrentRow.Cells[2].Value.ToString();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
