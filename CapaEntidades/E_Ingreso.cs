using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Ingreso
    {
        private int _Id_ingreso;
        private int _Id_empleado;
        private int _Id_proveedor;
        private DateTime _Fecha;
        private string _Tipo_comprobante;
        private string _Serie;
        private string _Correlativo;
        private decimal _Iva;
        private string _Estado;

        public int Id_ingreso { get => _Id_ingreso; set => _Id_ingreso = value; }
        public int Id_empleado { get => _Id_empleado; set => _Id_empleado = value; }
        public int Id_proveedor { get => _Id_proveedor; set => _Id_proveedor = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Tipo_comprobante { get => _Tipo_comprobante; set => _Tipo_comprobante = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Correlativo { get => _Correlativo; set => _Correlativo = value; }
        public decimal Iva { get => _Iva; set => _Iva = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
    }
}
