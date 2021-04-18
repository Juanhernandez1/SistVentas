using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class D_Detalle_Venta
    {
        //Metodo insertar detalle de ingreso
        public string InsertarDetalleVenta(E_Detalle_Venta DetalleVenta,ref SqlConnection Connection,ref SqlTransaction transaction)
        {
            string Rpta;
            try
            {
                SqlCommand SqlCmd = new SqlCommand("sp_insertar_detalle_venta", Connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Transaction=transaction
                };

                SqlCmd.Parameters.AddWithValue("@id_venta", DetalleVenta.Id_venta);
                SqlCmd.Parameters.AddWithValue("@id_detalle_ingreso", DetalleVenta.Id_detalle_ingreso);
                SqlCmd.Parameters.AddWithValue("@cantidad", DetalleVenta.Cantidad);
                SqlCmd.Parameters.AddWithValue("@precio_venta", DetalleVenta.Precio_venta);
                SqlCmd.Parameters.AddWithValue("@descuento", DetalleVenta.Descuento);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se puede ingresar el detalle de venta";
            }
            catch (Exception ex)
            {
                Rpta = "ERROR " + ex.Message + ex.StackTrace;
            }
            return Rpta;
        }
    }
}
