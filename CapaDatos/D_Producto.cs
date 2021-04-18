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
    public class D_Producto
    {
        //Instancia de la cadena de coneccion
        readonly SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Metodo para mostrar producto
        public DataTable MostrarRegistro()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_mostrar_producto", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo buscar producto por nombre
        public DataTable BuscarProductoNombre(string texto)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_buscar_producto_nombre", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", texto);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        //Metodo agregar producto
        public void InsertarRegistro(E_Producto Producto)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_insertar_producto", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@codigo_barra", Producto.Codigo_barra);
            SqlCmd.Parameters.AddWithValue("@nombre", Producto.Nombre);
            SqlCmd.Parameters.AddWithValue("@descripcion", Producto.Descripcion);
            SqlCmd.Parameters.AddWithValue("@id_categoria", Producto.Id_categoria);
            SqlCmd.Parameters.AddWithValue("@id_presentacion", Producto.Id_presentacion);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo editar categorias
        public void Editargistro(E_Producto Producto)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_editar_producto", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_producto", Producto.Id_producto);
            SqlCmd.Parameters.AddWithValue("@codigo_barra", Producto.Codigo_barra);
            SqlCmd.Parameters.AddWithValue("@nombre", Producto.Nombre);
            SqlCmd.Parameters.AddWithValue("@descripcion", Producto.Descripcion);
            SqlCmd.Parameters.AddWithValue("@id_categoria", Producto.Id_categoria);
            SqlCmd.Parameters.AddWithValue("@id_presentacion", Producto.Id_presentacion);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
        //Metodo eliminar categoria
        public void EliminarRegistro(E_Producto Producto)
        {
            SqlCommand SqlCmd = new SqlCommand("sp_eliminar_producto", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            Conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_producto", Producto.Id_producto);

            SqlCmd.ExecuteNonQuery();

            Conectar.Close();
        }
    }
}
