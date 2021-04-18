using CapaEntidades;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmIngreso : Form
    {
        //Objetos de la capa eentidad y negocio
        readonly E_Ingreso ObjEntidad = new E_Ingreso();
        readonly N_Ingreso ObjNegocio = new N_Ingreso();

        //Variables 
        private DataTable DTDetalles;
        private decimal TotalPagar = 0;

        public FrmIngreso()
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
            DTDetalles.Columns.Add("id_producto", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("producto", Type.GetType("System.String"));
            DTDetalles.Columns.Add("precio_compra", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("precio_venta", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("stock_inicial", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("fecha_produccion", Type.GetType("System.DateTime"));
            DTDetalles.Columns.Add("fecha_vence", Type.GetType("System.DateTime"));
            DTDetalles.Columns.Add("SubTotal", Type.GetType("System.Decimal"));

            //AGREGARMOS EL DETALLE AL DATAGRIDVIEW
            DataDetalle.DataSource = DTDetalles;
        }
        //Metodo limpiar datos de texto
        private void LimpiarDatos()
        {
            txtID.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtCorrelativo.Text = string.Empty;
            txtIva.Text = string.Empty;
            lblTotal.Text = "0.00";
            Creartabla();
        }
        private void LimpiarDetalle()
        {
            txtIdProducto.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtStock.Text = "0";
            txtPrecioCompra.Text = "0";
            txtPrecioVenta.Text = "0";
        }
        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            this.Creartabla();
        }

        private void btnBuscarproveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedor ListadoProveedor = new FrmVistaProveedor();
            AddOwnedForm(ListadoProveedor);
            ListadoProveedor.ShowDialog();
        }

        private void btnBuscarproducto_Click(object sender, EventArgs e)
        {
            FrmVistaProductoIngreso ListadoProducto = new FrmVistaProductoIngreso();
            AddOwnedForm(ListadoProducto);
            ListadoProducto.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool agregar = true;
                if (txtIdProducto.Text == string.Empty || txtStock.Text == "0" || txtStock.Text == string.Empty || txtPrecioCompra.Text == "0" || txtPrecioCompra.Text == string.Empty || txtPrecioVenta.Text == "0" || txtPrecioVenta.Text == string.Empty)
                {
                    MensajeError("Cargue los datos para el detalle");
                }
                else
                {
                    foreach (DataRow row in DTDetalles.Rows)
                    {
                        if (Convert.ToInt32(row["id_producto"]) == Convert.ToInt32(txtIdProducto.Text))
                        {
                            agregar = false;
                            MensajeError("Ya se encuentra el producto en el detalle");
                        }
                    }
                    if (agregar)
                    {
                        decimal SubTotal = Convert.ToDecimal(txtStock.Text) * Convert.ToDecimal(txtPrecioCompra.Text);
                        TotalPagar = TotalPagar + SubTotal;
                        lblTotal.Text = TotalPagar.ToString("#0.00#");

                        decimal subtotal = Convert.ToDecimal(txtStock.Text) * Convert.ToDecimal(txtPrecioCompra.Text);
                        //AÑADIR LOS DATOS DEL TEXBOX AL DATAGRIDVIEW
                        DataRow row = DTDetalles.NewRow();
                        row["id_producto"] = Convert.ToInt32(txtIdProducto.Text);
                        row["producto"] = txtProducto.Text.ToUpper();
                        row["precio_compra"] = Convert.ToDecimal(txtPrecioCompra.Text);
                        row["precio_venta"] = Convert.ToDecimal(txtPrecioVenta.Text);
                        row["stock_inicial"] = Convert.ToInt32(txtStock.Text);
                        row["fecha_produccion"] = Convert.ToDateTime(dtFechProduccion.Value);
                        row["fecha_vence"] = Convert.ToDateTime(dtFechaVence.Value);
                        row["SubTotal"] = subtotal;


                        DTDetalles.Rows.Add(row);
                        LimpiarDetalle();
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
                if (txtIdProveedor.Text != string.Empty || txtSerie.Text != string.Empty || txtCorrelativo.Text != string.Empty || txtIva.Text != string.Empty)
                {
                    if (MessageBox.Show("¿esta seguro de ralizar la operación?", "Ferreteria Emanuel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ObjEntidad.Id_empleado = E_Datos_Login.Id_empleado;
                        ObjEntidad.Id_proveedor = Convert.ToInt32(txtIdProveedor.Text);
                        ObjEntidad.Fecha = dTPFecha.Value;
                        ObjEntidad.Tipo_comprobante = cbTipoComprobante.Text;
                        ObjEntidad.Serie = txtSerie.Text;
                        ObjEntidad.Correlativo = txtCorrelativo.Text;
                        ObjEntidad.Iva = Convert.ToDecimal(txtIva.Text);
                        ObjEntidad.Estado = "EMITIDO";

                        Rpta = N_Ingreso.InsertarIngreso(ObjEntidad, DTDetalles);

                        if (Rpta.Equals("OK"))
                        {
                            MensajeConfirmacion("Se guardó correctamente la compra");
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
                    MensajeError("Seleccione el proveedor y cargar datos de Ingreso");
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

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
