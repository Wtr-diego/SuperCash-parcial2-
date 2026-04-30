namespace EL
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }  // Id numérico de categoría (opcional)
        public string Categoria { get; set; } // Nombre de la categoría (usado por DAL.DataStore y consultas)
        public decimal Precio { get; set; }
        public int Stock { get; set; }  // ← Puede ser "Stock" o "Cantidad"
        public int StockMinimo { get; set; }
    }
}