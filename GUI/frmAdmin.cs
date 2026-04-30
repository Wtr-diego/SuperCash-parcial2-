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
	public partial class frmAdmin : Form
	{
		// Instancia de la capa de datos
		private ProductoDAL proDAL = new ProductoDAL();
		private int idProductoSeleccionado = 0; // Usaremos el ID directamente

		public frmAdmin()
		{
			InitializeComponent();
			ConfigurarFormulario();
			CargarProductos();
			CargarCategoria();
		}

		private void LimpiarTextboxes(Control.ControlCollection controles)
		{
			foreach (Control ctrl in controles)
			{
				if (ctrl is TextBox)
				{
					((TextBox)ctrl).Clear();
				}
			}
		}

		private void ConfigurarFormulario()
		{
			this.Text = "Panel Administrador - SuperCash";
			this.WindowState = FormWindowState.Maximized;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.BackColor = Color.White;
		}

		private void CargarProductos()
		{
			try
			{
				dgvProductos.DataSource = null;
				DataTable dt = proDAL.ObtenerTodos();
				dgvProductos.DataSource = dt;

				if (dgvProductos.Columns.Count > 0)
				{
					if (dgvProductos.Columns.Contains("ID_Producto")) dgvProductos.Columns["ID_Producto"].HeaderText = "ID";
					if (dgvProductos.Columns.Contains("Nombre")) dgvProductos.Columns["Nombre"].HeaderText = "Producto";
					if (dgvProductos.Columns.Contains("Precio")) dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
					if (dgvProductos.Columns.Contains("Stock")) dgvProductos.Columns["Stock"].HeaderText = "Existencias";
				}

				// Aplicar colores según stock
				foreach (DataGridViewRow row in dgvProductos.Rows)
				{
					if (!row.IsNewRow && row.Cells["Stock"].Value != null)
					{
						int stock = Convert.ToInt32(row.Cells["Stock"].Value);
						if (stock < 10) row.DefaultCellStyle.BackColor = Color.LightCoral;
						else if (stock < 20) row.DefaultCellStyle.BackColor = Color.LemonChiffon;
						else row.DefaultCellStyle.BackColor = Color.White;
					}
				}

				lblTotalProductos.Text = $"Total productos: {dt.Rows.Count}";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar productos: " + ex.Message);
			}
		}

		private void CargarCategoria()
		{

			string[] cats = { "Granos", "Lácteos", "Panadería", "Bebidas", "Limpieza", "Carnes", "Verduras" };

			cmbCategoria.Items.Clear();
			cmbCategoria.Items.AddRange(cats);
			cmbCategoria.SelectedIndex = 0;

			cmbFiltroCategoria.Items.Clear();
			cmbFiltroCategoria.Items.Add("Todos");
			cmbFiltroCategoria.Items.AddRange(cats);
			cmbFiltroCategoria.SelectedIndex = 0;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				string nombre = txtNombre.Text;
				decimal precio = nudPrecio.Value;
				int stock = (int)nudStock.Value;
				int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
				string error = "";


				// Validar campos vacíos
				error = BLL.Validaciones.CampoVacio(nombre, "Nombre del Producto");
				if (error != "") { MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

				// Validar montos (No negativos ni cero)
				error = BLL.Validaciones.PrecioValido(precio);
				if (error != "") { MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

				// Validar cantidades (No negativos)
				error = BLL.Validaciones.CantidadValida(stock);
				if (error != "") { MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

				// Validar duplicados
				if (idProductoSeleccionado == 0)
				{
					if (proDAL.ExisteProducto(nombre)) // Asegúrate de tener este método en ProductoDAL
					{
						MessageBox.Show("Ya existe un producto con ese nombre. Evite duplicados.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}


				bool resultado = false;

				// Determina si es un guardado nuevo o una edición
				if (idProductoSeleccionado == 0)
				{
					resultado = proDAL.Insertar(nombre, precio, stock, idCategoria);
				}
				else
				{
					resultado = proDAL.Editar(idProductoSeleccionado, nombre, precio, stock, idCategoria);
				}

				if (resultado)
				{
					MessageBox.Show("¡Operación realizada con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

					LimpiarFormulario();
					CargarProductos();
				}
				else
				{
					MessageBox.Show("No se pudo completar la operación en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error inesperado al guardar: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvProductos.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID_Producto"].Value);

				// Preguntar al usuario para evitar accidentes
				DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este producto?",
					"Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (respuesta == DialogResult.Yes)
				{
					if (proDAL.Eliminar(id))
					{
						MessageBox.Show("Producto eliminado con éxito");
						CargarProductos(); // Refrescamos la lista para que desaparezca
						LimpiarFormulario();
					}
					else
					{
						MessageBox.Show("No se pudo eliminar el producto");
					}
				}
			}
			else
			{
				MessageBox.Show("Por favor, selecciona un producto de la lista");
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dgvProductos.DataSource;
			if (dt != null)
			{
				string filtro = $"Nombre LIKE '%{txtBuscar.Text}%'";
				if (cmbFiltroCategoria.Text != "Todos")
				{

				}
				dt.DefaultView.RowFilter = filtro;
				lblTotalProductos.Text = $"Resultados: {dgvProductos.Rows.Count}";
			}
		}

		private void dgvProductos_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvProductos.CurrentRow != null)
			{
				idProductoSeleccionado = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID_Producto"].Value);
				txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
				nudPrecio.Value = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["Precio"].Value);
				nudStock.Value = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value);
			}
		}

		private void LimpiarFormulario()
		{
			txtNombre.Clear();
			nudPrecio.Value = 0;
			nudStock.Value = 0;
			idProductoSeleccionado = 0;

			idProductoSeleccionado = 0;

			txtNombre.Focus();
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Form login = Application.OpenForms["frmLogin"];

				if (login != null)
				{
					login.Show();

					if (login is frmLogin f) f.LimpiarCampos();
				}
				this.Close();
			}
		}

		private void VerificarStockBajo()
		{
			{
				int limite = 5;
				DataTable dtBajos = proDAL.ObtenerStockBajo(limite);

				if (dtBajos.Rows.Count > 0)
				{
					int agotados = 0;
					foreach (DataRow fila in dtBajos.Rows)
					{
						if (Convert.ToInt32(fila["Stock"]) <= 0) agotados++;
					}

					string mensaje = $"¡Atención! Hay {dtBajos.Rows.Count} productos con stock bajo (menos de {limite}).";

					if (agotados > 0)
					{
						mensaje += $"\n\n¡ALERTA!: {agotados} productos están totalmente AGOTADOS.";
					}

					MessageBox.Show(mensaje, "Aviso de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void frmAdmin_Load(object sender, EventArgs e)
		{
			LlenarComboCategoria();

			CargarProductos();

			VerificarStockBajo();
		}

		private void LlenarComboCategoria()
		{
			DataTable dt = proDAL.ListarCategoria();

			DataRow filaTodos = dt.NewRow();
			filaTodos["ID_Categoria"] = 0;
			filaTodos["Nombre"] = "Todos";

			dt.Rows.InsertAt(filaTodos, 0);

			cmbCategoria.DataSource = dt;
			cmbCategoria.ValueMember = "ID_Categoria";
			cmbCategoria.DisplayMember = "Nombre";
		}

		private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

				idProductoSeleccionado = Convert.ToInt32(fila.Cells["ID_Producto"].Value);

				txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
				nudPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
				nudStock.Value = Convert.ToInt32(fila.Cells["Stock"].Value);

				cmbCategoria.SelectedValue = fila.Cells["ID_Categoria"].Value;
			}
		}

		private void FiltrarAhora()
		{
			string texto = txtBuscar.Text;
			string categoria = cmbCategoria.Text;

			dgvProductos.DataSource = proDAL.BuscarProductosVendedor(texto, categoria);

			lblTotalProductos.Text = "Total productos: " + dgvProductos.Rows.Count;
		}

		private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			string textoBusqueda = txtBuscar.Text;
			string catSeleccionada = cmbFiltroCategoria.Text;

			dgvProductos.DataSource = proDAL.BuscarProductosVendedor(textoBusqueda, catSeleccionada);

		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			FiltrarAhora();
		}

		}
	}
