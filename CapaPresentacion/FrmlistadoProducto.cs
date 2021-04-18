using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmlistadoProducto : Form
    {
        //OBJETOS DE CAPA ENTIDAD Y NEGOCIO
        
        readonly E_Producto ObjEntidad = new E_Producto();
        readonly N_Producto ObjNegocio = new N_Producto();

        public FrmlistadoProducto()
        {
            InitializeComponent();
        }
        //Metodo para mostrar mensaje de confirmacion
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Metodo para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
        private void Columnas()
        {
            DataListado.Columns[0].Visible = false;
            DataListado.Columns[1].HeaderText = "CODIGO";
            DataListado.Columns[2].HeaderText = "PRODUCTO";
            DataListado.Columns[3].HeaderText = "DESCRIPCION";
            DataListado.Columns[4].HeaderText = "CATEGORIA";
            DataListado.Columns[5].HeaderText = "PRESENTACION";
            DataListado.Columns[5].Width = 120;
        }
        //Metodo para mostrar registro de productos
        public void MostrarRegistro()
        {
            DataListado.DataSource = N_Producto.MostrarRegistro();
        }
        //Metodo buscar producto 
        public void BuscarRegistro()
        {
            DataListado.DataSource = N_Producto.BuscarProductoNombre(this.txtBuscar.Text);
        }
        //Metodo para cuando se cierre el formulario de mantenimineot empleado actualice la tabla
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
            this.Columnas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRegistro();
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto NuevoRegistro = new FrmProducto();
            NuevoRegistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            NuevoRegistro.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProducto EditarRegistro = new FrmProducto();
                EditarRegistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
                if (DataListado.SelectedRows.Count > 0)
                {
                    Program.Evento = 1;
                    EditarRegistro.txtID.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
                    EditarRegistro.txtCodigoBarra.Text = DataListado.CurrentRow.Cells[1].Value.ToString();
                    EditarRegistro.txtNombre.Text = DataListado.CurrentRow.Cells[2].Value.ToString();
                    EditarRegistro.cbCategoria.Text = DataListado.CurrentRow.Cells[4].Value.ToString();
                    EditarRegistro.cbPresentacion.Text = DataListado.CurrentRow.Cells[5].Value.ToString();
                    EditarRegistro.txtDescripcion.Text = DataListado.CurrentRow.Cells[3].Value.ToString();
                    

                    EditarRegistro.ShowDialog();
                }
                else
                {
                    MensajeError("Seleccione un registro de la tabla para modificar!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.DataListado.SelectedRows.Count>0)
            {
                DialogResult opcion;
                opcion=MessageBox.Show("¿Realmente desea eliminar el registro?", "Ferreteria Emanuel",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                if (opcion==DialogResult.OK)
                {
                    ObjEntidad.Id_producto = Convert.ToInt32(this.DataListado.CurrentRow.Cells[0].Value.ToString());
                    ObjNegocio.EliminarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se eliminó correctamente el registro");

                    this.MostrarRegistro();
                }
            }
            else
            {
                MensajeError("Seleccione un registro de la tabla!!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRegistro();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
