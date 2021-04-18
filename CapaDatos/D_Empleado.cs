using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Empleado
    {
        //Instancia de la cadena de conexion de la clase app.config
        readonly SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Metodo para mostrar registros
        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();

            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_empleado", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
            return DtResultado;
        }
        //Metodo para buscar registro
        public DataTable BuscarRegistro(string Texto)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_buscar_empleado", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", Texto);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
            return DtResultado;
        }
        //Metodo para insertar
        public void InsertarRegistro(E_Empleado Empleado)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_insertar_empleado", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@nombre", Empleado.Nombre);
            SqlCmd.Parameters.AddWithValue("@apellidos", Empleado.Apellido);
            SqlCmd.Parameters.AddWithValue("@sexo", Empleado.Sexo);
            SqlCmd.Parameters.AddWithValue("@fecha_nac", Empleado.Fecha_Nacimiento);
            SqlCmd.Parameters.AddWithValue("@num_doc", Empleado.Numero_Documento);
            SqlCmd.Parameters.AddWithValue("@direccion", Empleado.Direccion);
            SqlCmd.Parameters.AddWithValue("@telefono", Empleado.Telefono);
            SqlCmd.Parameters.AddWithValue("@email", Empleado.Email);
            SqlCmd.Parameters.AddWithValue("@acceso", Empleado.Acceso);
            SqlCmd.Parameters.AddWithValue("@usuario", Empleado.Usuario);
            SqlCmd.Parameters.AddWithValue("@password", Empleado.Password);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo para editar registro
        public void EditarRegistro(E_Empleado Empleado)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_editar_empleado", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_empleado", Empleado.Id_empleado);
            SqlCmd.Parameters.AddWithValue("@nombre", Empleado.Nombre);
            SqlCmd.Parameters.AddWithValue("@apellidos", Empleado.Apellido);
            SqlCmd.Parameters.AddWithValue("@sexo", Empleado.Sexo);
            SqlCmd.Parameters.AddWithValue("@fecha_nac", Empleado.Fecha_Nacimiento);
            SqlCmd.Parameters.AddWithValue("@num_doc", Empleado.Numero_Documento);
            SqlCmd.Parameters.AddWithValue("@direccion", Empleado.Direccion);
            SqlCmd.Parameters.AddWithValue("@telefono", Empleado.Telefono);
            SqlCmd.Parameters.AddWithValue("@email", Empleado.Email);
            SqlCmd.Parameters.AddWithValue("@acceso", Empleado.Acceso);
            SqlCmd.Parameters.AddWithValue("@usuario", Empleado.Usuario);
            SqlCmd.Parameters.AddWithValue("@password", Empleado.Password);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo para eliminar registro de la tabla empleado
        public void EliminarRegistro(E_Empleado Empleado)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_eliminar_empleado", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_empleado", Empleado.Id_empleado);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }

        //METODO PARA INICIAR SESION
        //public DataTable IniciarSesion(string usuario,string password)
        //{
        //    DataTable DtResultado = new DataTable();
        //    SqlCommand SqlCmd = new SqlCommand("sp_iniciar_sesion", Conectar)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };

        //    SqlCmd.Parameters.AddWithValue("@user", usuario);
        //    SqlCmd.Parameters.AddWithValue("@pass", password);

        //    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
        //    SqlDat.Fill(DtResultado);
        //    return DtResultado;
        //}

        public bool IniciarSesion(string usuario, string password)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_iniciar_sesion", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@user", usuario);
            SqlCmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader LeerFilas = SqlCmd.ExecuteReader();
            if (LeerFilas.HasRows)
            {
                while (LeerFilas.Read())
                {
                    E_Datos_Login.Id_empleado = LeerFilas.GetInt32(0);
                    E_Datos_Login.Nombre = LeerFilas.GetString(1);
                    E_Datos_Login.Apellido = LeerFilas.GetString(2);
                    E_Datos_Login.Acceso = LeerFilas.GetString(3);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
