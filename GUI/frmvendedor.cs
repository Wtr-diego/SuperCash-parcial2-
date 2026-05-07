using System;
using System.Collections.Generic;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using EL;
using BLL;

namespace GUI
{
	public partial class frmVendedor : Form
	{
		private List<ItemVenta> carrito = new List<ItemVenta>();
		private ProductoDAL proDAL = new ProductoDAL(); 

		public frmVendedor()
		{
			InitializeComponent();
			ConfigurarFormulario();
			CargarProductos(); 
			ActualizarCarrito();
		}

		private void ConfigurarFormulario()
		{
			this.Text = "Panel Vendedor - SuperCash";
			this.WindowState = FormWindowState.Maximized;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.BackColor = Color.White;

			// Uso de la nueva clase Sesion que creamos
			if (EL.Sesion.UsuarioActual != null)
			{
				lblVendedor.Text = $"Vendedor: {EL.Sesion.UsuarioActual.Nombres} {EL.Sesion.UsuarioActual.Apellidos}";
			}
			else
			{
				lblVendedor.Text = "Vendedor: Invitado";
			}
		}

		private void CargarProductos(string filtro = "")
		{
			try
			{
				// Obtenemos los datos reales de SQL Server
				DataTable dt = proDAL.ObtenerTodos();

				// Si hay filtro, lo aplicamos al DataTable
				if (!string.IsNullOrWhiteSpace(filtro))
				{
					dt.DefaultView.RowFilter = $"Nombre LIKE '%{filtro}%'";
				}

				dgvProductos.DataSource = dt;

				// Configuración de columnas (Asegúrate que los nombres coincidan con tu SQL)
				if (dgvProductos.Columns.Count > 0)
				{
					dgvProductos.Columns["ID_Producto"].HeaderText = "ID";
					dgvProductos.Columns["Nombre"].HeaderText = "Producto";
					dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
					dgvProductos.Columns["Stock"].HeaderText = "Stock";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar productos: " + ex.Message);
			}
		}

		private void ActualizarCarrito()
		{
			dgvCarrito.DataSource = null;
			dgvCarrito.DataSource = carrito;

			decimal total = carrito.Sum(item => item.Subtotal);
			lblTotal.Text = $"Total: {total:C2}";
			lblCantidadItems.Text = $"Items: {carrito.Sum(i => i.Cantidad)}";
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (dgvProductos.CurrentRow == null)
			{
				MessageBox.Show("Seleccione un producto de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Obtenemos datos de la fila seleccionada del DataTable
			int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID_Producto"].Value);
			string nombre = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
			decimal precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["Precio"].Value);
			int stockActual = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value);
			int cantidad = (int)nudCantidad.Value;

			if (cantidad > stockActual)
			{
				MessageBox.Show($"Stock insuficiente. Solo hay {stockActual} unidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var itemExistente = carrito.FirstOrDefault(i => i.ProductoId == id);

			if (itemExistente != null)
			{
				itemExistente.Cantidad += cantidad;
				itemExistente.Subtotal = itemExistente.Cantidad * itemExistente.PrecioUnitario;
			}
			else
			{
				carrito.Add(new ItemVenta
				{
					ProductoId = id,
					NombreProducto = nombre,
					Cantidad = cantidad,
					PrecioUnitario = precio,
					Subtotal = cantidad * precio
				});
			}

			ActualizarCarrito();
			nudCantidad.Value = 1;
		}

		private void btnFinalizarVenta_Click(object sender, EventArgs e)
		{
			if (carrito.Count == 0) return;

			var confirmacion = MessageBox.Show($"¿Confirmar venta por {lblTotal.Text}?", "Venta", MessageBoxButtons.YesNo);

			if (confirmacion == DialogResult.Yes)
			{
				// En el futuro llamaremos a VentaDAL para guardar en SQL
				// Por ahora simulamos el éxito
				MessageBox.Show(GenerarTicket(), "Ticket");

				carrito.Clear();
				ActualizarCarrito();
				CargarProductos(); // Refrescamos stock desde la DB
			}
		}

		private string GenerarTicket()
		{
			string ticket = "      SUPERCASH TICKET\n";
			ticket += $"Fecha: {DateTime.Now}\n";
			ticket += $"Atendido por: {EL.Sesion.UsuarioActual?.Nombres ?? "Admin"}\n";
			ticket += "---------------------------\n";
			foreach (var item in carrito)
			{
				ticket += $"{item.NombreProducto} x{item.Cantidad} - {item.Subtotal:C2}\n";
			}
			ticket += "---------------------------\n";
			ticket += $"TOTAL: {lblTotal.Text}";
			return ticket;
		}

		private void btnBuscarProducto_Click(object sender, EventArgs e)
		{
			CargarProductos(txtBuscarProducto.Text);
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
         // Preguntar confirmación antes de cerrar sesión
			var resp = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resp != DialogResult.Yes)
			{
				return;
			}

			// Limpiar sesión y volver al formulario de login en lugar de cerrar la aplicación
			EL.Sesion.UsuarioActual = null;
			// Mostrar la ventana de login existente si está abierta, si no crear una nueva
			var existingLogin = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
			if (existingLogin != null)
			{
				existingLogin.Show();
				existingLogin.BringToFront();
			}
			else
			{
				new frmLogin().Show();
			}
			this.Close();
		}

		// --- Added missing event handlers referenced by the Designer ---
		private void btnQuitar_Click(object sender, EventArgs e)
		{
			if (dgvCarrito.CurrentRow == null)
			{
				MessageBox.Show("Seleccione un item del carrito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var item = dgvCarrito.CurrentRow.DataBoundItem as ItemVenta;
			if (item == null) return;

			carrito.Remove(item);
			ActualizarCarrito();
		}

		private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
		{
			txtBuscarProducto.Text = string.Empty;
			CargarProductos();
		}

		private void nudCantidad_ValueChanged(object sender, EventArgs e)
		{
			if (nudCantidad.Value < 1)
				nudCantidad.Value = 1;
		}
	}

	public class ItemVenta
	{
		public int ProductoId { get; set; }
		public string NombreProducto { get; set; }
		public int Cantidad { get; set; }
		public decimal PrecioUnitario { get; set; }
		public decimal Subtotal { get; set; }
	}
}