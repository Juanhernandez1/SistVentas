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
    public partial class FrmMantenimientoEmpleado : Form
    {
        //OBJETOS DE CAPA ENTIDAD Y NEGOCIO
        readonly E_Empleado ObjEntidad = new E_Empleado();
        readonly N_Empleado ObjNegocio = new N_Empleado();
        public FrmMantenimientoEmpleado()
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
        //Metodo para Limpiar texto
        private void LimpiarTexto()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtApellido.Focus();
        }


        private void FrmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || cbSexo.Text == "Seleccionar"||cbAcceso.Text=="Seleccionar" || txtUsuario.Text == string.Empty || txtPassword.Text == string.Empty)
                {
                    MensajeError("Debe proporcionar Nombre, Apellido, sexo, fecha de nacimiento, numero de identidad, usuario y password del empleado");
                }
                else
                {
                    if (Program.Evento == 0)
                    {
                        ObjEntidad.Nombre = txtNombre.Text.Trim().ToUpper();
                        ObjEntidad.Apellido = txtApellido.Text.Trim().ToUpper();
                        ObjEntidad.Sexo = cbSexo.Text.Trim().ToUpper();
                        ObjEntidad.Fecha_Nacimiento = dTPFecha.Value;
                        ObjEntidad.Numero_Documento = txtNumDoc.Text.Trim();
                        ObjEntidad.Direccion = txtDireccion.Text.Trim().ToUpper();
                        ObjEntidad.Telefono = txtTelefono.Text.Trim().ToUpper();
                        ObjEntidad.Email = txtEmail.Text.Trim().ToUpper();
                        ObjEntidad.Acceso = cbAcceso.Text.Trim().ToUpper();
                        ObjEntidad.Usuario = txtUsuario.Text.Trim();
                        ObjEntidad.Password = txtPassword.Text.Trim();

                        ObjNegocio.InsertarRegistro(ObjEntidad);

                        MensajeConfirmacion("Se ingresó correctamente el nuevo registro");

                        Program.Evento = 0;

                        LimpiarTexto();

                        Close();
                    }
                    if (Program.Evento == 1)
                    {
                        ObjEntidad.Id_empleado = Convert.ToInt32(txtID.Text);
                        ObjEntidad.Nombre = txtNombre.Text.Trim().ToUpper();
                        ObjEntidad.Apellido = txtApellido.Text.Trim().ToUpper();
                        ObjEntidad.Sexo = cbSexo.Text.Trim().ToUpper();
                        ObjEntidad.Fecha_Nacimiento = dTPFecha.Value;
                        ObjEntidad.Numero_Documento = txtNumDoc.Text.Trim();
                        ObjEntidad.Direccion = txtDireccion.Text.Trim().ToUpper();
                        ObjEntidad.Telefono = txtTelefono.Text.Trim().ToUpper();
                        ObjEntidad.Email = txtEmail.Text.Trim().ToUpper();
                        ObjEntidad.Acceso = cbAcceso.Text.Trim().ToUpper();
                        ObjEntidad.Usuario = txtUsuario.Text.Trim();
                        ObjEntidad.Password = txtPassword.Text.Trim();

                        ObjNegocio.EditarRegistro(ObjEntidad);

                        MensajeConfirmacion("Se modificó correctamente el registro");

                        Program.Evento = 0;

                        LimpiarTexto();

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message + ex.StackTrace);
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }
    }
}
