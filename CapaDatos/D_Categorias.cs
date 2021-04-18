using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Categorias
    {
        //Instancia de la cadena de coneccion
        readonly SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Metodo para mostrar
        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_categoria", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo para buscar categoria
        public DataTable BuscarRegistro(string texto)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_buscar_categoria", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", texto);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        //Metodo registrar categorias
        public void InsertarRegistro(E_Categorias Categorias)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_insertar_categoria", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@nombre", Categorias.Nombre);
            SqlCmd.Parameters.AddWithValue("@descripcion", Categorias.Descripcion);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }

        //Metodo editar categorias
        public void EditarRegistro(E_Categorias Categorias)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_editar_categoria", Conectar)
            {
                CommandType=CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id", Categorias.Id_categoria);
            SqlCmd.Parameters.AddWithValue("@nombre", Categorias.Nombre);
            SqlCmd.Parameters.AddWithValue("@descripcion", Categorias.Descripcion);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }

        //Metodo eliminar categoria
        public void EliminarRegistro(E_Categorias Categorias)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_eliminar_categoria", Conectar)
            {
                CommandType=CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id", Categorias.Id_categoria);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
    }
}
