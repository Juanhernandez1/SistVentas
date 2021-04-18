using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Proveedor
    {
        //Objeto de la capa datos
        readonly D_Proveedor Obj = new D_Proveedor();
        //Metodo que llama al metodo mostrar de la clase D_Proveedor
        public static DataTable MostrarRegistro()
        {
            return new D_Proveedor().MostrarRegistro();
        }
        //Metodo que llama al metodo buscar de la clase D_Proveedor
        public static DataTable BuscarProveedorRazon(string Texto)
        {
            return new D_Proveedor().BuscarRegistro(Texto);
        }
        //Metod que llama al metodo insertar de la clase D_Proveedor
        public void InsertarRegistro(E_Proveedor Proveedor)
        {
            Obj.InsertarRegistro(Proveedor);
        }
        //Metod que llama al metodo editar de la clase D_Proveedor
        public void EditarRegistro(E_Proveedor Proveedor)
        {
            Obj.EditarRegistro(Proveedor);
        }
        //Metod que llama al metodo eliminar de la clase D_Proveedor
        public void EliminarRegistro(E_Proveedor Proveedor)
        {
            Obj.EliminarRegistro(Proveedor);
        }
    }
}
