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
    public class D_Proveedor
    {
        //Instancia a la cadena de conexion
        readonly SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Metodo para mostrar
        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_proveedor", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metod buscar proveedor
        public DataTable BuscarRegistro(string texto)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_buscar_proveedor_razon",Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", texto);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo registrar nuevoproveedor
        public void InsertarRegistro(E_Proveedor Proveedor)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_insertar_proveedor", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@razon", Proveedor.razon_social);
            SqlCmd.Parameters.AddWithValue("@sector", Proveedor.Sector_comercial);
            SqlCmd.Parameters.AddWithValue("@tipo_doc", Proveedor.Tipo_documento);
            SqlCmd.Parameters.AddWithValue("@numero_doc", Proveedor.Numero_documento);
            SqlCmd.Parameters.AddWithValue("@direccion", Proveedor.Direccion);
            SqlCmd.Parameters.AddWithValue("@telefono", Proveedor.Telefono);
            SqlCmd.Parameters.AddWithValue("@email", Proveedor.Email);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo editar proveedor
        public void EditarRegistro(E_Proveedor Proveedor)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_editar_proveedor",Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_proveedor", Proveedor.Id_proveedor);
            SqlCmd.Parameters.AddWithValue("@razon", Proveedor.razon_social);
            SqlCmd.Parameters.AddWithValue("@sector", Proveedor.Sector_comercial);
            SqlCmd.Parameters.AddWithValue("@tipo_doc", Proveedor.Tipo_documento);
            SqlCmd.Parameters.AddWithValue("@numero_doc", Proveedor.Numero_documento);
            SqlCmd.Parameters.AddWithValue("@direccion", Proveedor.Direccion);
            SqlCmd.Parameters.AddWithValue("@telefono", Proveedor.Telefono);
            SqlCmd.Parameters.AddWithValue("@email", Proveedor.Email);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo editar proveedor
        public void EliminarRegistro(E_Proveedor Proveedor)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_eliminar_proveedor", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_proveedor", Proveedor.Id_proveedor);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
    }
}
