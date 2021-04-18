using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Producto
    {
        public int Id_producto { set; get; }
        public string  Codigo_barra { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id_categoria { get; set; }
        public int Id_presentacion { get; set; }
    }
}
