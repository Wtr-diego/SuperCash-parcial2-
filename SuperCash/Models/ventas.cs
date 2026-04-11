using System;

namespace SuperCash.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public int VendedorId { get; set; }
    }
}