using System;

namespace SuperCash.EL
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? CategoriaPadreId { get; set; }
        public bool Activo { get; set; } = true;
        public int Orden { get; set; } = 0;
        public string IconoUrl { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public string ColorHex { get; set; } = "#2E86C1";
    }
}