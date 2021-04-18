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
    public class D_Presentacion
    {
        //Instancia de la cadena de coneccion
        readonly SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Metodo Mostrar
        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_presentacion", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo buscar presentación 
        public DataTable BuscarRegistro(string texto)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_buscar_presentacion", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textbuscar", texto);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        //Metodo Agregar Presentacion
        public void InsertarRegistro(E_Presentacion Presentacion)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_insertar_presentacion", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@nombre", Presentacion.Nombre);
            SqlCmd.Parameters.AddWithValue("@descripcion", Presentacion.Descripcion);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo EditarRegistro
        public void EditarRegistro(E_Presentacion Presentacion)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_editar_presentacion", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id", Presentacion.Id_presentacion);
            SqlCmd.Parameters.AddWithValue("@nombre", Presentacion.Nombre);
            SqlCmd.Parameters.AddWithValue("@descripcion", Presentacion.Descripcion);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo eliminar presentacion
        public void EliminarRegistro(E_Presentacion Presentacion)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_eliminar_presentacion", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id", Presentacion.Id_presentacion);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        
    }
}
