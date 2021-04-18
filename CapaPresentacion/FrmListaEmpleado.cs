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
    public partial class FrmListaEmpleado : Form
    {
        //OBJETOS DE CAPA ENTIDAD Y NEGOCIO Y VARIABLE PARA DETERMINAR SI EDITAR O GUARDAR

        readonly E_Empleado ObjEntidad = new E_Empleado();
        readonly N_Empleado ObjNegocio = new N_Empleado();
        public FrmListaEmpleado()
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
            this.DataListado.DataSource = N_Empleado.MostrarRegistros();
            this.DataListado.ClearSelection();
        }
        //metodo llama al metodo buscar registro de la clase N_Empleado
        private void BuscarRegistro()
        {
            this.DataListado.DataSource = N_Empleado.BuscarRegistros(this.txtBuscar.Text);
        }
        //Metodo para cuando se cierre el formulario de mantenimineot empleado actualice la tabla
        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }

        private void FrmListaEmpleado_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEmpleado NuevoRegistro = new FrmMantenimientoEmpleado();
            NuevoRegistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            NuevoRegistro.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMantenimientoEmpleado EditarRegistro = new FrmMantenimientoEmpleado();
                EditarRegistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
                if (DataListado.SelectedRows.Count > 0)
                {
                    Program.Evento = 1;
                    EditarRegistro.txtID.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
                    EditarRegistro.txtNombre.Text = DataListado.CurrentRow.Cells[1].Value.ToString();
                    EditarRegistro.txtApellido.Text = DataListado.CurrentRow.Cells[2].Value.ToString();
                    EditarRegistro.cbSexo.Text = DataListado.CurrentRow.Cells[3].Value.ToString();
                    EditarRegistro.dTPFecha.Value = Convert.ToDateTime(DataListado.CurrentRow.Cells[4].Value.ToString());
                    EditarRegistro.txtNumDoc.Text = DataListado.CurrentRow.Cells[5].Value.ToString();
                    EditarRegistro.txtDireccion.Text = DataListado.CurrentRow.Cells[6].Value.ToString();
                    EditarRegistro.txtTelefono.Text = DataListado.CurrentRow.Cells[7].Value.ToString();
                    EditarRegistro.txtEmail.Text = DataListado.CurrentRow.Cells[8].Value.ToString();
                    EditarRegistro.cbAcceso.Text = DataListado.CurrentRow.Cells[9].Value.ToString();
                    EditarRegistro.txtUsuario.Text = DataListado.CurrentRow.Cells[10].Value.ToString();
                    EditarRegistro.txtPassword.Text = DataListado.CurrentRow.Cells[11].Value.ToString();

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
            try
            {
                if (DataListado.SelectedRows.Count > 0)
                {
                    DialogResult Option;
                    Option = MessageBox.Show("¿Realmente desea eliminar el registro?", "Ferreteria Emanuel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Option == DialogResult.OK)
                    {
                        ObjEntidad.Id_empleado = Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value.ToString());
                        ObjNegocio.EliminarRegistro(ObjEntidad);

                        MensajeConfirmacion("Se eliminó correctamente el registro");

                        MostrarRegistro();
                    }
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
    }
}
