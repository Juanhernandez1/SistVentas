using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaEntidades
{
    public class E_Detalle_Ingreso
    {
        private int _Id_detalle_ingreso;
        private int _Id_ingreso;
        private int _Id_producto;
        private decimal _Precio_compra;
        private decimal _Precio_venta;
        private int _Stock_inicial;
        private int _Stock_actual;
        private DateTime _Fecha_produccion;
        private DateTime _Fecha_vence;

        public int Id_detalle_ingreso { get => _Id_detalle_ingreso; set => _Id_detalle_ingreso = value; }
        public int Id_ingreso { get => _Id_ingreso; set => _Id_ingreso = value; }
        public int Id_producto { get => _Id_producto; set => _Id_producto = value; }
        public decimal Precio_compra { get => _Precio_compra; set => _Precio_compra = value; }
        public decimal Precio_venta { get => _Precio_venta; set => _Precio_venta = value; }
        public int Stock_inicial { get => _Stock_inicial; set => _Stock_inicial = value; }
        public int Stock_actual { get => _Stock_actual; set => _Stock_actual = value; }
        public DateTime Fecha_produccion { get => _Fecha_produccion; set => _Fecha_produccion = value; }
        public DateTime Fecha_vence { get => _Fecha_vence; set => _Fecha_vence = value; }
    }
}
