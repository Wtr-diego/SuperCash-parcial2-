using System.Collections.Generic;
using System.Linq;
using SuperCash.Models;  // ← IMPORTANTE: Agregar este using

namespace SuperCash.Data
{
    public static class DataStore
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public static List<Producto> Productos { get; set; } = new List<Producto>();
        public static List<Venta> Ventas { get; set; } = new List<Venta>();
        public static Usuario UsuarioActual { get; set; }

        public static void InicializarDatos()
        {
            if (Usuarios.Count == 0)
            {
                Usuarios.Add(new Usuario
                {
                    Id = 1,
                    Nombre = "Admin",
                    Apellido = "Super",
                    Email = "admin@supercash.com",
                    Contrasena = "admin123",
                    Rol = "Administrador"
                });

                Usuarios.Add(new Usuario
                {
                    Id = 2,
                    Nombre = "Vendedor",
                    Apellido = "User",
                    Email = "vendedor@supercash.com",
                    Contrasena = "vende123",
                    Rol = "Vendedor"
                });
            }

            if (Productos.Count == 0)
            {
                Productos.Add(new Producto { Id = 1, Nombre = "Arroz", Categoria = "Granos", Precio = 2.50m, Cantidad = 50 });
                Productos.Add(new Producto { Id = 2, Nombre = "Leche", Categoria = "Lácteos", Precio = 1.80m, Cantidad = 30 });
                Productos.Add(new Producto { Id = 3, Nombre = "Pan", Categoria = "Panadería", Precio = 0.90m, Cantidad = 5 });
                Productos.Add(new Producto { Id = 4, Nombre = "Coca Cola", Categoria = "Bebidas", Precio = 1.50m, Cantidad = 20 });
                Productos.Add(new Producto { Id = 5, Nombre = "Jabón", Categoria = "Limpieza", Precio = 2.00m, Cantidad = 15 });
            }
        }
    }
}