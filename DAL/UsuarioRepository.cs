using System.Data.SqlClient;
using EL;  // Referencia a las entidades

namespace DAL
{
    public class UsuarioRepository
    {
        public Usuario Login(string email, string contrasena)
        {
            string query = "SELECT Id, Nombre, Apellido, Email, Rol FROM Usuarios WHERE Email = @Email AND Contrasena = @Contrasena AND Activo = 1";

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Email = reader.GetString(3),
                                Rol = reader.GetString(4)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}