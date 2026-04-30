using System;

namespace EL
{
    public class Auditoria
    {
        public int ID_Auditoria { get; set; }
        public int ID_Usuario { get; set; } // ¿Quién fue?
        public DateTime FechaHora { get; set; }
        public string Accion { get; set; } // "Eliminó Producto", "Inició Sesión", etc.
        public string Detalle { get; set; }
        public string Modulo { get; set; } // "Inventario", "Ventas", "Login"
    }
}

// se hicieron correciones por un error cuando se subio

