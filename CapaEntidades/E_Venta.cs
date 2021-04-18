using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Venta
    {
        private int _Id_venta;
        private int _Id_empleado;
        private DateTime _Fecha;
        private string _Tipo_comprobante;
        private string _Serie;
        private string _Correlativo;
        private decimal _Iva;
        private string _Cliente;

        public int Id_venta { get => _Id_venta; set => _Id_venta = value; }
        public int Id_empleado { get => _Id_empleado; set => _Id_empleado = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Tipo_comprobante { get => _Tipo_comprobante; set => _Tipo_comprobante = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Correlativo { get => _Correlativo; set => _Correlativo = value; }
        public decimal Iva { get => _Iva; set => _Iva = value; }
        public string Cliente { get => _Cliente; set => _Cliente = value; }
    }
}
