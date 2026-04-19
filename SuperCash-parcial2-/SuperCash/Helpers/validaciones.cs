using System;
using System.Windows.Forms;

namespace SuperCash.Helpers
{
    public static class Validaciones
    {
        public static bool CampoVacio(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show($"El campo {nombreCampo} es obligatorio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        public static bool PrecioValido(decimal precio)
        {
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool CantidadValida(int cantidad)
        {
            if (cantidad < 0)
            {
                MessageBox.Show("La cantidad no puede ser negativa", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}