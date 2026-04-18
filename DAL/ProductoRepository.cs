using System.Collections.Generic;
using System.Data.SqlClient;
using EL;

namespace DAL
{
    public class ProductoRepository
    {
        public List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            string query = "SELECT Id, Nombre, Categoria, Precio, Stock FROM Productos WHERE Activo = 1";

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Categoria = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Precio = reader.GetDecimal(3),
                            Stock = reader.GetInt32(4)
                        });
                    }
                }
            }
            return productos;
        }
    }
}