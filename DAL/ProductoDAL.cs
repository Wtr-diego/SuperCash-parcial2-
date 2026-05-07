using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
	public class ProductoDAL
	{
		private ConexionBD conexion = new ConexionBD();

		// Insertar un nuevo producto
		public bool Insertar(string nombre, decimal precio, int stock, int idCategoria)
		{
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = "INSERT INTO Productos (Nombre, Precio, Stock, ID_Categoria) VALUES (@n, @p, @s, @c)";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@n", nombre);
				cmd.Parameters.AddWithValue("@p", precio);
				cmd.Parameters.AddWithValue("@s", stock);
				cmd.Parameters.AddWithValue("@c", idCategoria);

				con.Open();
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable BuscarProductosVendedor(string nombre, string categoria)
		{
			DataTable dt = new DataTable();
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = @"SELECT P.ID_Producto, P.Nombre, P.Precio, P.Stock, C.Nombre as Categoria 
                         FROM Productos P 
                         INNER JOIN Categoria C ON P.ID_Categoria = C.ID_Categoria 
                         WHERE P.Nombre LIKE @nombre 
                         AND (@categoria = 'Todos' OR C.Nombre = @categoria)";

				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
				cmd.Parameters.AddWithValue("@categoria", categoria);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			return dt;
		}
		public DataTable ListarCategoria()
		{
			DataTable dt = new DataTable();
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = "SELECT ID_Categoria, Nombre FROM Categoria";
				SqlDataAdapter adapter = new SqlDataAdapter(query, con);
				adapter.Fill(dt);
			}
			return dt;
		}

		public DataTable ObtenerTodos()
		{
			DataTable dt = new DataTable();
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = "SELECT ID_Producto, Nombre, Precio, Stock, ID_Categoria FROM Productos";
				SqlDataAdapter adapter = new SqlDataAdapter(query, con);
				adapter.Fill(dt);
			}
			return dt;
		}

		// Editar un producto existente
		public bool Editar(int id, string nombre, decimal precio, int stock, int idCategoria)
		{
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = "UPDATE Productos SET Nombre = @n, Precio = @p, Stock = @s, ID_Categoria = @c WHERE ID_Producto = @id";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@n", nombre);
				cmd.Parameters.AddWithValue("@p", precio);
				cmd.Parameters.AddWithValue("@s", stock);
				cmd.Parameters.AddWithValue("@c", idCategoria);
				cmd.Parameters.AddWithValue("@id", id);

				con.Open();
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		// Eliminar un producto
		public bool Eliminar(int id)
		{
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = "DELETE FROM Productos WHERE ID_Producto = @id";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@id", id);

				con.Open();
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public DataTable ObtenerStockBajo(int limite)
		{
			DataTable dt = new DataTable();
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				// Traemos solo los que tengan stock menor o igual al límite
				string query = @"SELECT P.ID_Producto, P.Nombre, P.Stock, C.Nombre as Categoria 
                         FROM Productos P 
                         INNER JOIN Categoria C ON P.ID_Categoria = C.ID_Categoria 
                         WHERE P.Stock <= @limite";

				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@limite", limite);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			return dt;
		}

		// Nuevo método: ReporteStockMenorAlerta
		// Nota: actualmente los parámetros de fecha se ignoran porque la tabla Productos
		// no contiene información temporal en el esquema proporcionado. Este método
		// devuelve los productos con stock menor o igual a un umbral de alerta.
		public DataTable ReporteStockMenorAlerta(DateTime fechaInicio, DateTime fechaFin)
		{
			DataTable dt = new DataTable();
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = @"SELECT P.ID_Producto, P.Nombre, P.Stock, C.Nombre as Categoria 
                         FROM Productos P 
                         INNER JOIN Categoria C ON P.ID_Categoria = C.ID_Categoria 
                         WHERE P.Stock <= @alerta";

				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@alerta", 5); // umbral de alerta fijo
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			return dt;
		}
	}
}