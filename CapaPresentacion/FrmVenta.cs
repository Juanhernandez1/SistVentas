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
    public partial class FrmVenta : Form
    {
        //Objetos de la capa eentidad y negocio
        readonly E_Venta ObjEntidad = new E_Venta();
        readonly N_Venta ObjNegocio = new N_Venta();

        //Variables 
        private DataTable DTDetalles;
        private decimal TotalPagar = 0;
        public FrmVenta()
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
        //Metodo crear tabla para el detalle de ingreso
        private void Creartabla()
        {
            DTDetalles = new DataTable();
            DTDetalles.Columns.Add("id_detalle_ingreso", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("producto", Type.GetType("System.String"));
            DTDetalles.Columns.Add("cantidad", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("precio_venta", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("descuento", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("subtotal", Type.GetType("System.Decimal"));

            //AGREGARMOS EL DETALLE AL DATAGRIDVIEW
            DataDetalle.DataSource = DTDetalles;
        }
        //METODO PARA MANDAR ID DETALLE INGRES Y CANTIDAD PARA DISMINUIR STOCK
        private void DisminuirStock(int iddetalleingreso,int cantidad)
        {
            ObjNegocio.DisminuirStock(iddetalleingreso,cantidad);
        }
        //Metodo limpiar datos de texto
        private void LimpiarDatos()
        {
            txtId.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtCorrelativo.Text = string.Empty;
            txtIva.Text = "0";
            lblTotal.Text = "0.00";
            Creartabla();
        }
        private void LimpiarDetalle()
        {
            txtIdProducto.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            //txtPrecioCompra.Text = "0";
            txtPrecioVenta.Text = string.Empty;
            txtDescuento.Text = "0";
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            Creartabla();
            try
            {
                cbTipoComprobante.SelectedIndex = 0;
                string Tipo = cbTipoComprobante.Text.ToUpper();
                N_Venta Negocio = new N_Venta();
                E_Venta Venta = new E_Venta();
                Venta = Negocio.GenerarCorrelativo(Tipo);

                txtSerie.Text = Venta.Serie;
                txtCorrelativo.Text = Venta.Correlativo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarproducto_Click(object sender, EventArgs e)
        {
            FrmVistaProductoVenta ListadoProducto = new FrmVistaProductoVenta();
            AddOwnedForm(ListadoProducto);
            ListadoProducto.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool agregar = true;
                if (txtIdProducto.Text == string.Empty || txtCantidad.Text == string.Empty||txtDescuento.Text==string.Empty|| txtPrecioVenta.Text == string.Empty )
                {
                    MensajeError("Falta ingresar los datos para el detalle de venta");
                }
                else
                {
                    foreach (DataRow row in DTDetalles.Rows)
                    {
                        if (Convert.ToInt32(row["id_detalle_ingreso"]) == Convert.ToInt32(txtIdProducto.Text))
                        {
                            agregar = false;
                            MensajeError("Ya se encuentra el producto en el detalle");
                        }
                    }
                    if (agregar&& Convert.ToInt32(txtCantidad.Text)<= Convert.ToInt32(txtStock.Text))
                    {
                        decimal SubTotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioVenta.Text)-Convert.ToDecimal(txtDescuento.Text);
                        TotalPagar = TotalPagar + SubTotal;
                        lblTotal.Text = TotalPagar.ToString("#0.00#");

                        //AÑADIR LOS DATOS DEL TEXBOX AL DATAGRIDVIEW
                        DataRow row = DTDetalles.NewRow();
                        row["id_detalle_ingreso"] = Convert.ToInt32(txtIdProducto.Text);
                        row["producto"] = txtProducto.Text.ToUpper();
                        row["cantidad"] = Convert.ToInt32(txtCantidad.Text);
                        row["precio_venta"] = Convert.ToDecimal(txtPrecioVenta.Text);
                        row["descuento"] = Convert.ToDecimal(txtDescuento.Text);
                        row["SubTotal"] = SubTotal;
                       
                        DTDetalles.Rows.Add(row);
                        LimpiarDetalle();
                    }
                    else
                    {
                        MensajeError("NO hay stock suficiente!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError("ERROR " + ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceFila = DataDetalle.CurrentCell.RowIndex;
                DataRow row = DTDetalles.Rows[IndiceFila];

                //Disminuir el total pagado
                TotalPagar = TotalPagar - Convert.ToDecimal(row["SubTotal"].ToString());
                lblTotal.Text = TotalPagar.ToString("#0.00#");

                //REMOVER LA FILA
                DTDetalles.Rows.Remove(row);
                MensajeConfirmacion("Se ha quitado el detalle seleccionado");
            }
            catch (Exception)
            {
                MensajeError("No hay detalles a remover ");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if ( txtSerie.Text != string.Empty || txtCorrelativo.Text != string.Empty || txtIva.Text != string.Empty)
                {
                    if (MessageBox.Show("¿esta seguro de ralizar la operación?", "Ferreteria Emanuel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ObjEntidad.Id_empleado = E_Datos_Login.Id_empleado;
                        ObjEntidad.Fecha = dTPFecha.Value;
                        ObjEntidad.Tipo_comprobante = cbTipoComprobante.Text;
                        ObjEntidad.Serie = txtSerie.Text;
                        ObjEntidad.Correlativo = txtCorrelativo.Text;
                        ObjEntidad.Iva = Convert.ToDecimal(txtIva.Text);
                        ObjEntidad.Cliente = txtCliente.Text.ToUpper().Trim();
                        DisminuirStock(Convert.ToInt32(DataDetalle.CurrentRow.Cells[0].Value), Convert.ToInt32(DataDetalle.CurrentRow.Cells[2].Value));

                        Rpta = N_Venta.InsertarVenta(ObjEntidad, DTDetalles);

                        if (Rpta.Equals("OK"))
                        {
                            MensajeConfirmacion("Se guardó correctamente la venta");
                        }
                        else
                        {
                            MensajeError(Rpta);
                        }

                        Close();
                    }
                }
                else
                {
                    MensajeError("Asignar serie y correlativo!!!");
                }
            }
            catch (Exception ex)
            {
                MensajeError("ERROR " + ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            LimpiarDetalle();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
