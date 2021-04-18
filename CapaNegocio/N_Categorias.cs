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
    public class N_Categorias
    {
        //Objeto de capa datos
        readonly D_Categorias Obj = new D_Categorias();

        public static DataTable MostrarRegistros()
        {
            return new D_Categorias().MostrarRegistro();
        }
        public static DataTable BuscarRegistros(string texto)
        {
            return new D_Categorias().BuscarRegistro(texto);
        }

        public void InsertarRegistro(E_Categorias Categorias)
        {
            Obj.InsertarRegistro(Categorias);
        }

        public void EditarRegistro(E_Categorias Categorias)
        {
            Obj.EditarRegistro(Categorias);
        }

        public void EliminarRegistro(E_Categorias Categorias)
        {
            Obj.EliminarRegistro(Categorias);
        }
    }
}
