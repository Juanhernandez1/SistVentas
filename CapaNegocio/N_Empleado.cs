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
    public class N_Empleado
    {
        //Objeto de capa datos
        readonly D_Empleado Obj = new D_Empleado();

        public static DataTable MostrarRegistros()
        {
            return new D_Empleado().MostrarRegistro();
        }
        public static DataTable BuscarRegistros(string texto)
        {
            return new D_Empleado().BuscarRegistro(texto);
        }

        public void InsertarRegistro(E_Empleado Empleado)
        {
            Obj.InsertarRegistro(Empleado);
        }

        public void EditarRegistro(E_Empleado Empleado)
        {
            Obj.EditarRegistro(Empleado);
        }

        public void EliminarRegistro(E_Empleado Empleado)
        {
            Obj.EliminarRegistro(Empleado);
        }
        //Metodo para iniciar sesion
        //public static DataTable IniciarSesion(string usuario,string password)
        //{
        //    return new D_Empleado().IniciarSesion(usuario,password);
        //}
        public bool IniciarSesion(string usuario, string password)
        {
            return Obj.IniciarSesion(usuario, password);
        }
    }
}
