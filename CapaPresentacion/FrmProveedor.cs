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
    public partial class FrmProveedor : Form
    {
        //OBJETOS DE CAPA ENTIDAD Y NEGOCIO
        readonly E_Proveedor ObjEntidad = new E_Proveedor();
        readonly N_Proveedor ObjNegocio = new N_Proveedor();
        public FrmProveedor()
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
        private void LimpiarTexto()
        {
            this.txtID.Text = string.Empty;
            this.txtRazonSocial.Text = string.Empty;
            this.txtSectorComercial.Text = string.Empty;
            this.txtTipoDocumento.Text = string.Empty;
            this.txtNumeroDocumento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtRazonSocial.Focus();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRazonSocial.Text == string.Empty || txtSectorComercial.Text == string.Empty || txtTipoDocumento.Text == string.Empty || txtNumeroDocumento.Text == string.Empty)
                {
                    MensajeError("Debe proporcionar Razón Social, Sector Comercial, Comprobante y Número de Comprobante");
                }
                else
                {
                    if (Program.Evento == 0)
                    {
                        ObjEntidad.razon_social = txtRazonSocial.Text.Trim().ToUpper();
                        ObjEntidad.Sector_comercial = txtSectorComercial.Text.Trim().ToUpper();
                        ObjEntidad.Tipo_documento = txtTipoDocumento.Text.Trim().ToUpper();
                        ObjEntidad.Numero_documento = txtNumeroDocumento.Text;
                        ObjEntidad.Direccion = txtDireccion.Text.Trim().ToUpper();
                        ObjEntidad.Telefono = txtTelefono.Text.Trim().ToUpper();
                        ObjEntidad.Email = txtEmail.Text.Trim().ToUpper();

                        ObjNegocio.InsertarRegistro(ObjEntidad);

                        MensajeConfirmacion("Se ingresó correctamente el nuevo registro");

                        Program.Evento = 0;

                        LimpiarTexto();

                        Close();
                    }
                    if (Program.Evento == 1)
                    {
                        if (txtID.Text==string.Empty)
                        {
                            MensajeError("Debe seleccionar antes un registro de la tabla!!!");
                        }
                        else
                        {
                            ObjEntidad.Id_proveedor = Convert.ToInt32(txtID.Text);
                            ObjEntidad.razon_social = txtRazonSocial.Text.Trim().ToUpper();
                            ObjEntidad.Sector_comercial = txtSectorComercial.Text.Trim().ToUpper();
                            ObjEntidad.Tipo_documento = txtTipoDocumento.Text.Trim().ToUpper();
                            ObjEntidad.Numero_documento = txtNumeroDocumento.Text;
                            ObjEntidad.Direccion = txtDireccion.Text.Trim().ToUpper();
                            ObjEntidad.Telefono = txtTelefono.Text.Trim().ToUpper();
                            ObjEntidad.Email = txtEmail.Text.Trim().ToUpper();

                            ObjNegocio.EditarRegistro(ObjEntidad);

                            MensajeConfirmacion("Se modificó correctamente el registro");

                            Program.Evento = 0;

                            LimpiarTexto();

                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
