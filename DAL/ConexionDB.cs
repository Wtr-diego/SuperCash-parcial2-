using System.Data.SqlClient;

namespace DAL
{
	public class ConexionBD
	{
		private readonly string cadenaConexion = "Server=SANCHEZ\\SQLEXPRESS;Database=SuperCashDB;Integrated Security=True;";

		public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(cadenaConexion);
		}
	}
}