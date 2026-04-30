using System;
using System.Data;
using System.Data.SqlClient;
using EL;

namespace DAL
{
	public class UsuarioDAL
	{
		private string cadena = @"Server=.\SQLEXPRESS;Database=SuperCashDB;Trusted_Connection=True;";

		public Usuario ValidarUsuario(string userOrEmail, string password)
		{
			Usuario usuarioEncontrado = null;

			using (SqlConnection cn = new SqlConnection(cadena))
			{

				string query = "SELECT ID_Usuario, Nombres, Apellidos, Rol, NombreUsuario, Password FROM Usuarios WHERE NombreUsuario = @user AND Password = @pass"; SqlCommand cmd = new SqlCommand(query, cn);
				cmd.Parameters.AddWithValue("@user", userOrEmail);
				cmd.Parameters.AddWithValue("@pass", password);

				cn.Open();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					if (dr.Read())
					{
						usuarioEncontrado = new Usuario
						{
							ID_Usuario = Convert.ToInt32(dr["ID_Usuario"]),
							Nombres = dr["Nombres"].ToString(),
							Apellidos = dr["Apellidos"].ToString(),
							Rol = dr["Rol"].ToString(),
						};
					}
				}
			}
			return usuarioEncontrado;
		}
	}
}