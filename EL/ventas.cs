using System;

namespace EL
{
    public class Venta
    {
        public int ID_Venta { get; set; }
        public DateTime Fecha { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public int ID_Vendedor { get; set; }
    }
}