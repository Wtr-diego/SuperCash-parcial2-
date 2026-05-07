using System;
using System.Text.RegularExpressions;

namespace BLL
{
    public static class Validaciones
    {
        // Validar que un campo no esté vacío
        public static string CampoVacio(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return $"El campo {nombreCampo} es obligatorio.";

			return "";
        }

        // Validar que el precio sea mayor a 0
        public static string PrecioValido(decimal precio)
        {
            if (precio <= 0)
                return "El precio debe ser mayor a cero.";
            
            return "";
        }

        // Validar que la cantidad no sea negativa
        public static string CantidadValida(int cantidad)
        {
            if (cantidad < 0)
                return "La cantidad no puede ser negativa.";

			return "";
        }

        // Validar que el email tenga formato correcto
        public static string EmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return "El campo Email es obligatorio.";

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patronEmail))
            {
                return "El formato del email es inválido.";
            }
            return "";
		}

        // Fecha Valida
        public static string FechaValida(string fechaTexto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(fechaTexto))
                return $"El campo {nombreCampo} es obligatorio.";
            if (!DateTime.TryParse(fechaTexto, out _))
                return $"El campo {nombreCampo} debe ser una fecha válida.";
            return "";
		}

		// Validar que solo tenga números
		public static string SoloNumeros(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "El campo es obligatorio.";
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return "Este campo solo acepta números.";
                }
            }
            return "";
        }

        // Validar que solo tenga letras
        public static string SoloLetras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "El campo es obligatorio.";
			
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return "Este campo solo acepta letras.";
                }
            }
            return "";
		}

		// Validar si un producto alcanzó el stock mínimo
		public static string EsStockBajo(int cantidadActual, int limiteMinimo = 5)
		{
			if (cantidadActual <= limiteMinimo)
			{
				return $"¡Alerta de Inventario! El stock actual ({cantidadActual}) es bajo.";
			}
			return "";
		}

		// Validar que el texto sea un número decimal válido
		public static string EsDecimalValido(string texto, out decimal resultado)
		{
			if (string.IsNullOrWhiteSpace(texto))
			{
				resultado = 0;
				return "El campo es obligatorio.";
			}
			if (!decimal.TryParse(texto, out resultado))
			{
				return "Por favor, ingrese un monto válido (ejemplo: 10.50).";
			}
			return "";
		}

		// Validar que un campo tenga una longitud mínima
		public static string LongitudMinima(string texto, int minimo, string nombreCampo)
		{
			if (texto.Length < minimo)
			{
				return $"El campo {nombreCampo} debe tener al menos {minimo} caracteres.";
			}
			return "";
		}
			
	}
}