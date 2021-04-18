using System;
using System.Collections.Generic;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Venta
    {
        //Instancia a la clase detalle venta e instancia a la cadena conexion
        readonly D_Detalle_Venta d_Detalle_Venta = new D_Detalle_Venta();

        SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Metodo mostrar registro
        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_ventas", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
            SqlDat.Dispose();

            return DtResultado;
        }
        //Metodo buscar registro ventas entre fechas
        public DataTable BuscarRegistroFechas(DateTime fecha1, DateTime fecha2)
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_buscar_venta_fecha", Conectar)
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
        public DataTable MostrarDetalle(int id)
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_detalle_venta", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@id_venta", id);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo para mostrar producto para la venta
        public DataTable MostrarProductoVenta(string Texto)
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_producto_venta", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", Texto);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo disminuir stock
        public void DisminuirStock(int id_detalle_ingreso, int cantidad)
        {
            string Rpta;

            try
            {
                
                SqlCommand SqlCmd = new SqlCommand("sp_disminuir_stock_venta", Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };

                Conectar.Open();

                SqlCmd.Parameters.AddWithValue("@id_detalle_ingreso", id_detalle_ingreso);
                SqlCmd.Parameters.AddWithValue("@cantidad", cantidad);

                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
           
        }
        //Metodo insertar ventas
        public string InsertarVentas(E_Venta Ventas,List<E_Detalle_Venta>DetallesVestas)
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
                    CommandText = "sp_insertar_venta",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdVenta = new SqlParameter
                {
                    ParameterName = "@id_venta",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                SqlCmd.Parameters.Add(ParIdVenta);

                SqlCmd.Parameters.AddWithValue("@id_empleado", Ventas.Id_empleado);
                SqlCmd.Parameters.AddWithValue("@fecha", Ventas.Fecha);
                SqlCmd.Parameters.AddWithValue("@tipo_comprobante", Ventas.Tipo_comprobante);
                SqlCmd.Parameters.AddWithValue("@serie", Ventas.Serie);
                SqlCmd.Parameters.AddWithValue("@correlativo", Ventas.Correlativo);
                SqlCmd.Parameters.AddWithValue("@iva", Ventas.Iva);
                SqlCmd.Parameters.AddWithValue("@cliente", Ventas.Cliente);

                Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se registro la venta";

                if (Rpta.Equals("OK"))
                {
                    Ventas.Id_venta = Convert.ToInt32(SqlCmd.Parameters["@id_venta"].Value);
                    foreach (E_Detalle_Venta det in DetallesVestas)
                    {
                        det.Id_venta = Ventas.Id_venta;

                        Rpta = d_Detalle_Venta.InsertarDetalleVenta(det,ref Conectar,ref transaccion);

                        if (!Rpta.Equals("OK"))
                        {
                            break;
                        }
                        //else if(Rpta.Equals("OK"))
                        //{
                        //    ////ACTUALIZAR STOCK
                        //    Rpta = DisminuirStock(det.Id_detalle_ingreso, det.Cantidad);
                        //    if (!Rpta.Equals("OK"))
                        //    {
                        //        break;
                        //    }
                        //}
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
                Rpta = ex.Message+ex.StackTrace;
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
        
        //Metodo Eliminar venta
        public void EliminarVenta(E_Venta Venta)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_eliminar_venta", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_venta", Venta.Id_venta);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //------Metodo para generar correlativo
        public E_Venta GenerarCorrelativo(string Tipo)
        {
            E_Venta Venta = new E_Venta();
            try
            {
                SqlCommand SqlCmd = new SqlCommand("sp_generar_serie_correlativo", Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };

                Conectar.Open();

                SqlCmd.Parameters.AddWithValue("@tipo", Tipo);

                SqlDataReader LeerFilas = SqlCmd.ExecuteReader();
                if (LeerFilas.HasRows)
                {
                    while (LeerFilas.Read())
                    {
                        int serie = Convert.ToInt32(LeerFilas["Serie"]);
                        int Numero = Convert.ToInt32(LeerFilas["Correlativo"]);

                        if (Numero == 0)
                        {
                            //--Es el primer comprobante
                            Numero = 1;
                            serie = 1;
                        }
                        else if (Numero > 9999999)
                        {
                            //--Se reinicia el correlativo a 1 a la serie aumenta 1
                            Numero = 1;
                            serie++;
                        }
                        else
                        {
                            Numero++;
                        }
                        //--Transformar la serie y numero a string con ceros a la izquierda
                        int longitudSerie = 4;
                        int logintudNumero = 7;

                        string diCerosSerie = new string('0', longitudSerie - serie.ToString().Length);
                        Venta.Serie = diCerosSerie + serie.ToString();

                        string diCerosNumero = new string('0', logintudNumero - Numero.ToString().Length);
                        Venta.Correlativo = diCerosNumero + Numero.ToString();

                        //E_Datos_Login.Id_empleado = LeerFilas.GetInt32(0);
                        //E_Datos_Login.Nombre = LeerFilas.GetString(1);
                        //E_Datos_Login.Apellido = LeerFilas.GetString(2);
                        //E_Datos_Login.Acceso = LeerFilas.GetString(3);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conectar.Close();
            }
            return Venta;
           
        }
    }
}
