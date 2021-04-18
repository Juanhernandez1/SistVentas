using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Proveedor
    {
        public int Id_proveedor { get; set; }
        public string razon_social { get; set; }
        public string Sector_comercial { get; set; }
        public string Tipo_documento { get; set; }
        public string Numero_documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
