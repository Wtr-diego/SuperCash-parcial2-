using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using EL;

namespace DAL
{
	public class VentaDAL
	{
		private ConexionBD conexion = new ConexionBD();
		public DataTable ObtenerTopProductos()
		{
			DataTable dt = new DataTable();
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				string query = @"SELECT TOP 5 p.Nombre, SUM(d.Cantidad) AS TotalVendido 
                                 FROM DetalleVenta d 
                                 INNER JOIN Productos p ON d.ID_Producto = p.ID_Producto 
                                 GROUP BY p.Nombre 
                                 ORDER BY TotalVendido DESC";

				SqlDataAdapter da = new SqlDataAdapter(query, con);
				da.Fill(dt);
			}
			return dt;
		}

		public bool RegistrarVentaCompleta(int idUsuario, decimal total, List<ItemVenta> carrito)
		{
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				con.Open();
				SqlTransaction trans = con.BeginTransaction();
				try
				{
					string qVenta = "INSERT INTO Ventas (ID_Usuario, Fecha, Total) VALUES (@idUsu, GETDATE(), @t); SELECT SCOPE_IDENTITY();";
					SqlCommand cmdV = new SqlCommand(qVenta, con, trans);
					cmdV.Parameters.AddWithValue("@idUsu", idUsuario);
					cmdV.Parameters.AddWithValue("@t", total);
					int idVenta = Convert.ToInt32(cmdV.ExecuteScalar());

					foreach (var item in carrito)
					{
						string qDetalle = "INSERT INTO DetalleVenta (ID_Venta, ID_Producto, Cantidad, PrecioUnitario, Subtotal) " +
										  "VALUES (@idV, @idP, @c, @precio, @sub)";
						SqlCommand cmdD = new SqlCommand(qDetalle, con, trans);
						cmdD.Parameters.AddWithValue("@idV", idVenta);
						cmdD.Parameters.AddWithValue("@idP", item.ProductoId);
						cmdD.Parameters.AddWithValue("@c", item.Cantidad);
						cmdD.Parameters.AddWithValue("@precio", item.PrecioUnitario);
						cmdD.Parameters.AddWithValue("@sub", item.Subtotal);
						cmdD.ExecuteNonQuery();

						string qStock = "UPDATE Productos SET Existencias = Existencias - @c WHERE ID_Producto = @idP";
						SqlCommand cmdS = new SqlCommand(qStock, con, trans);
						cmdS.Parameters.AddWithValue("@c", item.Cantidad);
						cmdS.Parameters.AddWithValue("@idP", item.ProductoId);
						cmdS.ExecuteNonQuery();
					}

					trans.Commit();
					return true;
				}
				catch (Exception ex)
				{
					trans.Rollback();
					throw new Exception("Error en DAL: " + ex.Message);
				}
			}
		}
	}
}