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
    public partial class FrmListadoVenta : Form
    {

        //VARIABLE PARA ALMACENAR ID EMPLEADO
        public int Id;
        //INSTANICIAS A CAPA ENTIDAD Y NEGOCIO
        readonly E_Venta ObjEntidad = new E_Venta();
        readonly N_Venta ObjNegocio = new N_Venta();
        public FrmListadoVenta()
        {
            InitializeComponent();
        }
        //Medoto para mostrar mensaje de confirmacion
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Metodo para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo llama al metodo mostrar registro de la clase N_Empleado
        private void MostrarRegistro()
        {
            this.DataListado.DataSource = N_Venta.MostrarRegistro();
            this.DataListado.ClearSelection();
        }
        //metodo llama al metodo buscar registro de la clase N_Empleado
        private void BuscarRegistroFecha()
        {
            this.DataListado.DataSource = N_Venta.BuscarRegistroFecha(Convert.ToDateTime(this.dtFecha1.Value.ToString("dd/MM/yyyy")), Convert.ToDateTime(this.dtFecha2.Value.ToString("dd/MM/yyyy")));
        }
        //metodo llama al metodo mostrar registro de la clase N_Empleado NOOO FUNNNCIONA
        //PENDIENTE A UTILIZAR HASTA ENCONTRAR SOLUCION
        private void MostrarDetalle()
        {
            FrmIngreso Ingreso = new FrmIngreso();
            Ingreso.DataDetalle.DataSource = N_Ingreso.MostrarDetalle(Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value.ToString()));
        }
        //Metodo para cuando se cierre el formulario de mantenimineot empleado actualice la tabla
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }

        private void FrmListadoVenta_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.BuscarRegistroFecha();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.MostrarRegistro();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmVenta Venta = new FrmVenta();
            Venta.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            Venta.ShowDialog();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataListado.SelectedRows.Count > 0)
                {
                    DialogResult Option;
                    Option = MessageBox.Show("¿Realmente desea Eliminar el registro?", "Ferreteria Emanuel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Option == DialogResult.OK)
                    {
                        ObjEntidad.Id_venta = Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value.ToString());
                        ObjNegocio.EliminarVenta(ObjEntidad);

                        MensajeConfirmacion("Se Eliminó correctamente el registro");

                        MostrarRegistro();
                    }
                }
                else
                {
                    MensajeError("Seleccione un registro de la tabla para Eliminar!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message + ex.StackTrace);
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporteFactura Factura = new FrmReporteFactura();
            Factura.IdVenta = Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value);
            Factura.ShowDialog();
        }
    }
}
