namespace EL
{
    public class DetalleVenta
    {
        public int ID_Detalle { get; set; }
        public int ID_Venta { get; set; }     // Relación con la Venta
        public int ID_Producto { get; set; }  // Relación con el Producto
        public int Cantidad { get; set; }    // Cuántos compró
        public decimal PrecioUnitario { get; set; } // Precio al momento de la venta
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}