using System;
using System.Windows.Forms;

namespace SuperCash.Helpers
{
    public static class Validaciones
    {
        // Validar que un campo no esté vacío
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

        // Validar que el precio sea mayor a 0
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

        // Validar que la cantidad no sea negativa
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

        // Validar que el email tenga formato correcto
        public static bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("El formato del correo electrónico no es válido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // Validar que solo tenga números
        public static bool SoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Este campo solo acepta números", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        // Validar que solo tenga letras
        public static bool SoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Este campo solo acepta letras", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

		// Validar si un producto alcanzó el stock mínimo
		public static bool EsStockBajo(int cantidadActual, int limiteMinimo = 5)
		{
			if (cantidadActual <= limiteMinimo)
			{
				MessageBox.Show($"¡Alerta de Inventario! El stock actual ({cantidadActual}) es bajo.", "Control de Stock",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			return false;
		}

		// Validar que el texto sea un número decimal válido
		public static bool EsDecimalValido(string texto, out decimal resultado)
		{
			// TryParse intenta convertirlo. Si falla, devuelve false sin romper el programa.
			if (!decimal.TryParse(texto, out resultado))
			{
				MessageBox.Show("Por favor, ingrese un monto válido (ejemplo: 10.50).", "Validación",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		// Validar que un campo tenga una longitud mínima
		public static bool LongitudMinima(string texto, int minimo, string nombreCampo)
		{
			if (texto.Length < minimo)
			{
				MessageBox.Show($"El campo {nombreCampo} debe tener al menos {minimo} caracteres.", "Validación",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		// Limpiar todos los TextBox dentro de un formulario o panel
		public static void LimpiarTextboxes(Control.ControlCollection controles)
		{
			foreach (Control ctrl in controles)
			{
				if (ctrl is TextBox)
				{
					((TextBox)ctrl).Clear();
				}
			}
		}
	}
}