using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class ItemVenta
	{
		public int ProductoId { get; set; }
		public string NombreProducto { get; set; }
		public int Cantidad { get; set; }
		public decimal PrecioUnitario { get; set; }
		public decimal Subtotal { get; set; }
	}
}