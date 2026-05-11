using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EL;

namespace DAL
{
    public class UsuarioDAL
    {
        private string cadena = "Server=SANCHEZ\\SQLEXPRESS;Database=SuperCashDB;Integrated Security=True;TrustServerCertificate=True;";

        public Usuario ValidarUsuario(string userOrEmail, string password)
        {
            Usuario usuarioEncontrado = null;

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                string query = "SELECT ID_Usuario, Nombres, Apellidos, Rol, NombreUsuario FROM Usuarios WHERE NombreUsuario = @user AND Password = @pass";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@user", userOrEmail);
                cmd.Parameters.AddWithValue("@pass", password);

                try
                {
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
                                NombreUsuario = dr["NombreUsuario"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al conectar con la base de datos: " + ex.Message);
                }
            }
            return usuarioEncontrado;
        }

        public bool Insertar(string nombres, string apellidos, string nombreUsuario, string password, string rol = "Vendedor")
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Usuarios (Nombres, Apellidos, Rol, NombreUsuario, Password) " +
                               "VALUES (@n, @a, @r, @nu, @p)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@n", nombres);
                cmd.Parameters.AddWithValue("@a", apellidos);
                cmd.Parameters.AddWithValue("@r", rol);
                cmd.Parameters.AddWithValue("@nu", nombreUsuario);
                cmd.Parameters.AddWithValue("@p", password);

                try
                {
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar usuario: " + ex.Message);
                }
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                string query = "SELECT ID_Usuario, Nombres, Apellidos, Rol, NombreUsuario FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, cn);

                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Usuario
                        {
                            ID_Usuario = Convert.ToInt32(dr["ID_Usuario"]),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            Rol = dr["Rol"].ToString(),
                            NombreUsuario = dr["NombreUsuario"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}