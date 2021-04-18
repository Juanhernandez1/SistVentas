using CapaEntidades;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoIngreso : Form
    {

        //VARIABLE PARA ALMACENAR ID EMPLEADO
        public int Id;
        //INSTANICIAS A CAPA ENTIDAD Y NEGOCIO
        readonly E_Ingreso ObjEntidad = new E_Ingreso();
        readonly N_Ingreso ObjNegocio = new N_Ingreso();

        public int idempleado;
        public FrmListadoIngreso()
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
            this.DataListado.DataSource = N_Ingreso.MostrarRegistro();
            this.DataListado.ClearSelection();
        }
        //metodo llama al metodo buscar registro de la clase N_Empleado
        private void BuscarRegistroFecha()
        {
            this.DataListado.DataSource = N_Ingreso.BuscarRegistroFecha(Convert.ToDateTime(this.dtFecha1.Value.ToString("dd/MM/yyyy")), Convert.ToDateTime(this.dtFecha2.Value.ToString("dd/MM/yyyy")));
        }
        //metodo llama al metodo mostrar registro de la clase N_Empleado NOOO FUNNNCIONA
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

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            FrmIngreso Ingreso = new FrmIngreso();
            Ingreso.FormClosed += new FormClosedEventHandler(ActualizarDatos);

            Ingreso.ShowDialog();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataListado.SelectedRows.Count > 0)
                {
                    DialogResult Option;
                    Option = MessageBox.Show("¿Realmente desea Anular el registro?", "Ferreteria Emanuel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Option == DialogResult.OK)
                    {
                        ObjEntidad.Id_ingreso = Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value.ToString());
                        ObjNegocio.AnularIngreso(ObjEntidad);

                        MensajeConfirmacion("Se Anuló correctamente el registro");

                        MostrarRegistro();
                    }
                }
                else
                {
                    MensajeError("Seleccione un registro de la tabla para Anular!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message + ex.StackTrace);
            }
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngreso Ingreso = new FrmIngreso();

            AddOwnedForm(Ingreso);

            Ingreso.txtID.Text = Convert.ToString(DataListado.CurrentRow.Cells[0].Value);
            Ingreso.txtProveedor.Text = Convert.ToString(DataListado.CurrentRow.Cells[2].Value);
            Ingreso.dTPFecha.Value = Convert.ToDateTime(DataListado.CurrentRow.Cells[3].Value);
            Ingreso.cbTipoComprobante.Text = Convert.ToString(DataListado.CurrentRow.Cells[4].Value);
            Ingreso.txtSerie.Text = Convert.ToString(DataListado.CurrentRow.Cells[5].Value);
            Ingreso.txtCorrelativo.Text = Convert.ToString(DataListado.CurrentRow.Cells[6].Value);
            Ingreso.lblTotal.Text = Convert.ToString(DataListado.CurrentRow.Cells[8].Value);
            MostrarDetalle();
            Ingreso.ShowDialog();
        }
    }
}
