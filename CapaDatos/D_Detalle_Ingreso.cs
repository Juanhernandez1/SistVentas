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
    public class D_Detalle_Ingreso
    {
        //Metodo insertar detalle de ingreso
        public string InsertarDetalleIngreso(E_Detalle_Ingreso DetalleIngreso,ref SqlConnection Connection,ref SqlTransaction transaction)
        {
            string Rpta;
            try
            {
                SqlCommand SqlCmd = new SqlCommand("sp_insertar_detalle_ingreso", Connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Transaction=transaction
                };

                SqlCmd.Parameters.AddWithValue("@id_ingreso", DetalleIngreso.Id_ingreso);
                SqlCmd.Parameters.AddWithValue("@id_producto", DetalleIngreso.Id_producto);
                SqlCmd.Parameters.AddWithValue("@precio_compra", DetalleIngreso.Precio_compra);
                SqlCmd.Parameters.AddWithValue("@precio_venta", DetalleIngreso.Precio_venta);
                SqlCmd.Parameters.AddWithValue("@stock_inicial", DetalleIngreso.Stock_inicial);
                SqlCmd.Parameters.AddWithValue("@stock_actual", DetalleIngreso.Stock_actual);
                SqlCmd.Parameters.AddWithValue("@fecha_produccion", DetalleIngreso.Fecha_produccion);
                SqlCmd.Parameters.AddWithValue("@fecha_vence", DetalleIngreso.Fecha_vence);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se puede ingresar detalle de ingreso";
        }
            catch (Exception ex)
            {
                Rpta = "ERROR" + ex.Message + ex.StackTrace;
            }
            return Rpta;
        }
    }
}
