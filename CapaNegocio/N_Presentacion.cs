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
    public class N_Presentacion
    {
        //Objeto se la capa datos
        readonly D_Presentacion Obj = new D_Presentacion();

        public static DataTable MostrarRegistro()
        {
            return new D_Presentacion().MostrarRegistro();
        }
        public static DataTable BuscarRegistro(string texto)
        {
            return new D_Presentacion().BuscarRegistro(texto);
        }
        public void InsertarRegistro(E_Presentacion Presentacion)
        {
            Obj.InsertarRegistro(Presentacion);
        }
        public void EditarRegistro(E_Presentacion Presentacion)
        {
            Obj.EditarRegistro(Presentacion);
        }
        public void EliminarRegistro(E_Presentacion Presentacion)
        {
            Obj.EliminarRegistro(Presentacion);
        }
        
    }
}
