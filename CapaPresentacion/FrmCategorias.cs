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
    public partial class FrmCategorias : Form
    {
        private bool Editar = false;
        readonly E_Categorias ObjEntidad = new E_Categorias();
        readonly N_Categorias ObjNegocio = new N_Categorias();
        public FrmCategorias()
        {
            InitializeComponent();
        }
        //metodo para confirmar
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //metodo para mostrar mensaje error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria de Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Metodo mostrar registro categoria
        public void MostrarRegistro()
        {
            DataListado.DataSource = N_Categorias.MostrarRegistros();
            this.DataListado.ClearSelection();
        }
        //Metodo bustrar registro categoria
        public void BuscarRegistro()
        {
            DataListado.DataSource = N_Categorias.BuscarRegistros(txtBuscar.Text);
        }
        //Metodo para limpiar textbox
        private void LimpiarTextbox()
        {
            Editar = false;
            txtID.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            this.MostrarRegistro();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarTextbox();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DataListado.SelectedRows.Count>0)
            {
                Editar = true;
                txtID.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = DataListado.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = DataListado.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MensajeError("Seleccione un registro de la tabla!!!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataListado.SelectedRows.Count>0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el registro?","Ferreteria Emanuel", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (opcion==DialogResult.OK)
                {
                    ObjEntidad.Id_categoria = Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value.ToString());
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar==false)
            {
                try
                {
                    if (txtNombre.Text==string.Empty)
                    {
                        MensajeError("Debe proporcionar un nombre para agregar nueva categoria");
                    }
                    else
                    {
                        ObjEntidad.Nombre = txtNombre.Text.ToUpper();
                        ObjEntidad.Descripcion = txtDescripcion.Text.ToUpper();

                        ObjNegocio.InsertarRegistro(ObjEntidad);

                        MensajeConfirmacion("Se ingresó correctamente el nuevo registro");

                        this.MostrarRegistro();

                        this.LimpiarTextbox();
                    }
                }
                catch (Exception)
                {
                    MensajeError("Error al guardar el registro!!!");
                }
            }
            if (Editar==true)
            {
                try
                {
                    ObjEntidad.Id_categoria = Convert.ToInt32(txtID.Text);
                    ObjEntidad.Nombre = txtNombre.Text.ToUpper();
                    ObjEntidad.Descripcion = txtDescripcion.Text.ToUpper();

                    ObjNegocio.EditarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se modificó correctamente el registro");

                    this.MostrarRegistro();

                    this.LimpiarTextbox();
                }
                catch (Exception)
                {
                    MensajeError("Error al modificar el registro!!!");
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRegistro();
        }
    }
}
