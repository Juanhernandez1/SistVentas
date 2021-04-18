using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Ingreso
    {
        readonly D_Detalle_Ingreso d_DetalleIngreso = new D_Detalle_Ingreso();

        SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Metodo Mostrar registro
        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_ingreso", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
            SqlDat.Dispose();

            return DtResultado;
        }
        //Metodo buscar ingresos
        public DataTable BuscarRegistroFechas(DateTime fecha1, DateTime fecha2)
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_buscar_ingreso_fecha", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@fecha", fecha1);
            SqlCmd.Parameters.AddWithValue("@fecha2", fecha2);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
            SqlDat.Dispose();

            return DtResultado;
        }
        //Mostrar detalle de ingreso aun no se si ocuparlo!""""!!!!!!!!!!!!!!!"""""""""""!"!#!!!#!/&!(/#
        //ljasgdcqyetwutr634tfrkuaewgfo fyugcbrlfyuag.fffffffffffffffffffffffffffffffjgdj
        public DataTable MostrarDetalle(int fecha)
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_detalle_ingreso", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", fecha);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo insertar ingreso
        public string InsertarIngreso(E_Ingreso Ingreso, List<E_Detalle_Ingreso> DetalleIngreso)
        {
            string Rpta;
            try
            {
                Conectar.Open();
                SqlTransaction transaccion = Conectar.BeginTransaction();

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = Conectar,
                    Transaction = transaccion,
                    CommandText = "sp_insertar_ingreso",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdIngreso = new SqlParameter
                {
                    ParameterName = "@id_ingreso",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                SqlCmd.Parameters.Add(ParIdIngreso);

                SqlCmd.Parameters.AddWithValue("@id_empleado", Ingreso.Id_empleado);
                SqlCmd.Parameters.AddWithValue("@id_proveedor", Ingreso.Id_proveedor);
                SqlCmd.Parameters.AddWithValue("@fecha", Ingreso.Fecha);
                SqlCmd.Parameters.AddWithValue("@tipo_comprobante", Ingreso.Tipo_comprobante);
                SqlCmd.Parameters.AddWithValue("@serie", Ingreso.Serie);
                SqlCmd.Parameters.AddWithValue("@correlativo", Ingreso.Correlativo);
                SqlCmd.Parameters.AddWithValue("@iva", Ingreso.Iva);
                SqlCmd.Parameters.AddWithValue("@estado", Ingreso.Estado);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se guardo el registro";

                if (Rpta.Equals("OK"))
                {
                    Ingreso.Id_ingreso = Convert.ToInt32(SqlCmd.Parameters["@id_ingreso"].Value);
                    foreach (E_Detalle_Ingreso det in DetalleIngreso)
                    {
                        det.Id_ingreso = Ingreso.Id_ingreso;

                        Rpta = d_DetalleIngreso.InsertarDetalleIngreso(det, ref Conectar, ref transaccion);

                        if (!Rpta.Equals("OK"))
                        {
                            break;
                        }
                    }
                }
                if (Rpta.Equals("OK"))
                {
                    transaccion.Commit();
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            catch (Exception ex)
            {
                Rpta = "ERROR" + ex.Message + ex.StackTrace;
            }
            finally
            {
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return Rpta;
        }
        //Metodo anular ingreso
        public void AnularIngreso(E_Ingreso Ingreso)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_anular_ingreso", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_ingreso", Ingreso.Id_ingreso);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
    }
}
