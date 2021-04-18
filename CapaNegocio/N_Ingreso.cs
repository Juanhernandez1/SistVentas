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
    public class N_Ingreso
    {
        //Instancia a la clase d_ingreso
        readonly D_Ingreso Obj = new D_Ingreso();

        //Metodo mostrar llama al metodo mostrar ingresos de capa datos
        public static DataTable MostrarRegistro()
        {
            return new D_Ingreso().MostrarRegistro();
        }
        //Metodo buscar llama al metodo buscar ingresos de capa datos
        public static DataTable BuscarRegistroFecha(DateTime fecha1, DateTime fecha2)
        {
            return new D_Ingreso().BuscarRegistroFechas(fecha1,fecha2);
        }
        //Metodo mostrar detalle de ingreso
        public static DataTable MostrarDetalle(int fecha1)
        {
            return new D_Ingreso().MostrarDetalle(fecha1);
        }
        //Metodo insertar
        public static string InsertarIngreso(E_Ingreso Ingreso, DataTable DTDetalleIngreso)
        {
            D_Ingreso ObjIngreso = new D_Ingreso();
            List<E_Detalle_Ingreso> detalles = new List<E_Detalle_Ingreso>();
            foreach (DataRow row in DTDetalleIngreso.Rows)
            {
                E_Detalle_Ingreso e_Detalle_Ingreso = new E_Detalle_Ingreso()
                {
                    Id_producto = Convert.ToInt32(row["id_producto"].ToString()),
                    Precio_compra = Convert.ToDecimal(row["precio_compra"].ToString()),
                    Precio_venta = Convert.ToDecimal(row["precio_venta"].ToString()),
                    Stock_inicial = Convert.ToInt32(row["stock_inicial"].ToString()),
                    Stock_actual = Convert.ToInt32(row["stock_inicial"].ToString()),
                    Fecha_produccion = Convert.ToDateTime(row["fecha_produccion"].ToString()),
                    Fecha_vence = Convert.ToDateTime(row["fecha_vence"].ToString())
                };

                detalles.Add(e_Detalle_Ingreso);
            }
            return ObjIngreso.InsertarIngreso(Ingreso,detalles);
        }
        //metodo anular ingreso
        public void AnularIngreso(E_Ingreso Ingreso)
        {
            Obj.AnularIngreso(Ingreso);
        }
    }
}
