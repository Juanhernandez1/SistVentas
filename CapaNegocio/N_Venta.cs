using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public class N_Venta
    {
        //Instancia a la clase d_venta
        readonly D_Venta Obj = new D_Venta();

        //Metodo mostrar llama al metodo mostrar ingresos de capa datos
        public static DataTable MostrarRegistro()
        {
            return new D_Venta().MostrarRegistro();
        }
        //Metodo buscar llama al metodo buscar ingresos de capa datos
        public static DataTable BuscarRegistroFecha(DateTime fecha1, DateTime fecha2)
        {
            return new D_Venta().BuscarRegistroFechas(fecha1, fecha2);
        }
        //Metodo mostrar detalle de ingreso
        public static DataTable MostrarDetalle(int fecha1)
        {
            return new D_Venta().MostrarDetalle(fecha1);
        }
        //Metodo mostrar producto para la venta
        public static DataTable MostrarProductoVenta(string Texto)
        {
            return new D_Venta().MostrarProductoVenta(Texto);
        }
        //Metodo insertar
        public static string InsertarVenta(E_Venta Venta, DataTable DTDetalleIngreso)
        {
            D_Venta ObjVenta = new D_Venta();
            List<E_Detalle_Venta> detalles = new List<E_Detalle_Venta>();
            foreach (DataRow row in DTDetalleIngreso.Rows)
            {
                E_Detalle_Venta e_Detalle_Ingreso = new E_Detalle_Venta()
                {
                    Id_detalle_ingreso = Convert.ToInt32(row["id_detalle_ingreso"].ToString()),
                    Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                    Precio_venta = Convert.ToDecimal(row["precio_venta"].ToString()),
                    Descuento = Convert.ToDecimal(row["descuento"].ToString()),
                };

                detalles.Add(e_Detalle_Ingreso);
            }
            return ObjVenta.InsertarVentas(Venta, detalles);
        }
        //metodo eliminar venrta
        public void EliminarVenta(E_Venta Venta)
        {
            Obj.EliminarVenta(Venta);
        }
        //metodo eliminar venrta
        public void DisminuirStock(int id,int cantidad)
        {
            Obj.DisminuirStock(id,cantidad);
        }
        public E_Venta GenerarCorrelativo(string Tipo)
        {
            try
            {
                E_Venta Venta = new E_Venta();
                D_Venta Dventa = new D_Venta();
                Venta = Dventa.GenerarCorrelativo(Tipo);
                return Venta;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
