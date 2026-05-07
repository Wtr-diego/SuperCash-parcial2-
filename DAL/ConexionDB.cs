using System.Data.SqlClient;

namespace DAL
{
	public class ConexionBD
	{
        private readonly string cadenaConexion = "Server=DIEGO\\SQLEXPRESS;Database=SuperCashDB;Integrated Security=True;TrustServerCertificate=True;";
        public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(cadenaConexion);
		}
	}
}