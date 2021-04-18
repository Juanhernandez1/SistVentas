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
    public partial class FrmListadoProveedor : Form
    {
        //OBJETOS DE CAPA ENTIDAD Y NEGOCIO Y VARIABLE PARA DETERMINAR SI EDITAR O GUARDAR
        
        readonly E_Proveedor ObjEntidad = new E_Proveedor();
        readonly N_Proveedor ObjNegocio = new N_Proveedor();
        public FrmListadoProveedor()
        {
            InitializeComponent();
        }
        //Metodo para mostrar mensaje de confirmacion
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Metodo para mostrar Mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MostrarRegistro()
        {
            DataListado.DataSource = N_Proveedor.MostrarRegistro();
        }
        public void BuscarRegistroRazon()
        {
            DataListado.DataSource = N_Proveedor.BuscarProveedorRazon(this.txtBuscar.Text);
        }
        //Metodo para cuando se cierre el formulario de mantenimineot empleado actualice la tabla
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProveedor NuevoRegistro = new FrmProveedor();
            NuevoRegistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            NuevoRegistro.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRegistroRazon();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProveedor EditarRegistro = new FrmProveedor();
                EditarRegistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
                if (DataListado.SelectedRows.Count > 0)
                {
                    Program.Evento = 1;
                    EditarRegistro.txtID.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
                    EditarRegistro.txtRazonSocial.Text = DataListado.CurrentRow.Cells[1].Value.ToString();
                    EditarRegistro.txtSectorComercial.Text = DataListado.CurrentRow.Cells[2].Value.ToString();
                    EditarRegistro.txtTipoDocumento.Text = DataListado.CurrentRow.Cells[3].Value.ToString();
                    EditarRegistro.txtNumeroDocumento.Text = DataListado.CurrentRow.Cells[4].Value.ToString();
                    EditarRegistro.txtDireccion.Text = DataListado.CurrentRow.Cells[5].Value.ToString();
                    EditarRegistro.txtTelefono.Text = DataListado.CurrentRow.Cells[6].Value.ToString();
                    EditarRegistro.txtEmail.Text = DataListado.CurrentRow.Cells[7].Value.ToString();

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
            if (this.DataListado.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el registro?", "Ferreteria Emanuel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.Id_proveedor = Convert.ToInt32(this.DataListado.CurrentRow.Cells[0].Value.ToString());
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
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
