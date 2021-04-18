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
    public partial class FrmProducto : Form
    {
        //OBJETOS DE CAPA ENTIDAD Y NEGOCIO
        readonly E_Producto ObjEntidad = new E_Producto();
        readonly N_Producto ObjNegocio = new N_Producto();
        public FrmProducto()
        {
            InitializeComponent();
            //para inicializar los combobox
            this.LLenarComboCategoria();
            this.LlenarComboPresentacion();
        }
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
            txtCodigoBarra.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Focus();
        }
        //Metodo mostrar combobox categoria
        private void LLenarComboCategoria()
        {
            this.cbCategoria.DataSource = N_Categorias.MostrarRegistros();
            this.cbCategoria.ValueMember = "id_categoria";
            this.cbCategoria.DisplayMember = "nombre";
        }
        //Metodo mostrar combocox presentaciones
        private void LlenarComboPresentacion()
        {
            this.cbPresentacion.DataSource = N_Presentacion.MostrarRegistro();
            this.cbPresentacion.ValueMember = "id_presentacion";
            this.cbPresentacion.DisplayMember = "nombre";

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoBarra.Text==string.Empty||txtNombre.Text == string.Empty)
                {
                    MensajeError("Debe proporcionar Codigo, Nombre, categoria y presentación del Producto");
                }
                else
                {
                    if (Program.Evento == 0)
                    {
                        ObjEntidad.Codigo_barra = txtCodigoBarra.Text;
                        ObjEntidad.Nombre = txtNombre.Text.Trim().ToUpper();
                        ObjEntidad.Descripcion = txtDescripcion.Text.ToUpper().Trim();
                        ObjEntidad.Id_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                        ObjEntidad.Id_presentacion = Convert.ToInt32(cbPresentacion.SelectedValue);

                        ObjNegocio.InsertarRegistro(ObjEntidad);

                        MensajeConfirmacion("Se ingresó correctamente el nuevo registro");

                        Program.Evento = 0;

                        LimpiarTexto();

                        Close();
                    }
                    if (Program.Evento == 1)
                    {
                        ObjEntidad.Id_producto = Convert.ToInt32(txtID.Text);
                        ObjEntidad.Codigo_barra = txtCodigoBarra.Text;
                        ObjEntidad.Nombre = txtNombre.Text.Trim().ToUpper();
                        ObjEntidad.Descripcion = txtDescripcion.Text.Trim().ToUpper();
                        ObjEntidad.Id_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                        ObjEntidad.Id_presentacion = Convert.ToInt32(cbPresentacion.SelectedValue);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
