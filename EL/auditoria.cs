using System;

namespace EL
{
    public class Auditoria
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; } // ¿Quién fue?
        public DateTime FechaHora { get; set; }
        public string Accion { get; set; } // "Eliminó Producto", "Inició Sesión", etc.
        public string Detalle { get; set; }
    }
}