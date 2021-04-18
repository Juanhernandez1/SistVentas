using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Producto
    {
        //Objeto se la capa datos
        readonly D_Producto Obj = new D_Producto();
        //metodo mostrar que llama al metodo de capa datos 
        public static DataTable MostrarRegistro()
        {
            return new D_Producto().MostrarRegistro();
        }
        //Metodo para buscar producto por nombre llama al metodo de capa datos
        public static DataTable BuscarProductoNombre(string Texto)
        {
            return new D_Producto().BuscarProductoNombre(Texto);
        }
        //Metodo agregar registro llama al metodo de capa datos 
        public void InsertarRegistro(E_Producto Producto)
        {
            Obj.InsertarRegistro(Producto);
        }
        //Metodo editar producto llama al metodo editar de capa datos
        public void EditarRegistro(E_Producto Producto)
        {
            Obj.Editargistro(Producto);
        }
        //Metodo para eliminar Producto llama al metodo de capa datos
        public void EliminarRegistro(E_Producto Producto)
        {
            Obj.EliminarRegistro(Producto);
        }
    }
}
