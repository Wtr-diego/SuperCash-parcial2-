namespace EL
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }     // Relación con la Venta
        public int IdProducto { get; set; }  // Relación con el Producto
        public int Cantidad { get; set; }    // Cuántos compró
        public decimal PrecioUnitario { get; set; } // Precio al momento de la venta
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}