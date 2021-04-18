using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Detalle_Venta
    {
        private int _Id_detalle_venta;
        private int _Id_venta;
        private int _Id_detalle_ingreso;
        private int _Cantidad;
        private decimal _Precio_venta;
        private decimal _Descuento;

        public int Id_detalle_venta { get => _Id_detalle_venta; set => _Id_detalle_venta = value; }
        public int Id_venta { get => _Id_venta; set => _Id_venta = value; }
        public int Id_detalle_ingreso { get => _Id_detalle_ingreso; set => _Id_detalle_ingreso = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Precio_venta { get => _Precio_venta; set => _Precio_venta = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }
    }
}
