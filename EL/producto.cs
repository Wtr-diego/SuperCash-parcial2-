namespace EL
{
    // Esta entidad ya estaba creada anteriormente para las pruebas, solo se le hicieron unas pequeñas correcciones.
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; } // Se modifica el nombre para no confundirlo con el de venta.
    }
}