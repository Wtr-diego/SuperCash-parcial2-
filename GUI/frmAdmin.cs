using System;
using System.Collections.Generic;
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
        private Producto productoSeleccionado;

        public frmAdmin()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarProductos();
            CargarCategorias();
            VerificarStockBajo();
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
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = DataStore.Productos.ToList();

            if (dgvProductos.Columns.Count > 0)
            {
                if (dgvProductos.Columns.Contains("Id"))
                    dgvProductos.Columns["Id"].HeaderText = "ID";
                if (dgvProductos.Columns.Contains("Nombre"))
                    dgvProductos.Columns["Nombre"].HeaderText = "Producto";
                if (dgvProductos.Columns.Contains("Categoria"))
                    dgvProductos.Columns["Categoria"].HeaderText = "Categoría";
                if (dgvProductos.Columns.Contains("Precio"))
                {
                    dgvProductos.Columns["Precio"].HeaderText = "Precio";
                    dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
                }
                if (dgvProductos.Columns.Contains("Cantidad"))
                    dgvProductos.Columns["Cantidad"].HeaderText = "Stock";
            }

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.DataBoundItem != null)
                {
                    var producto = (Producto)row.DataBoundItem;
                    if (producto.Cantidad < 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else if (producto.Cantidad < 20)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }

            lblTotalProductos.Text = $"Total productos: {DataStore.Productos.Count}";
        }

        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Granos");
            cmbCategoria.Items.Add("Lácteos");
            cmbCategoria.Items.Add("Panadería");
            cmbCategoria.Items.Add("Bebidas");
            cmbCategoria.Items.Add("Limpieza");
            cmbCategoria.Items.Add("Electrónica");
            cmbCategoria.Items.Add("Carnes");
            cmbCategoria.Items.Add("Verduras");
            cmbCategoria.SelectedIndex = 0;

            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.Add("Todos");
            cmbFiltroCategoria.Items.Add("Granos");
            cmbFiltroCategoria.Items.Add("Lácteos");
            cmbFiltroCategoria.Items.Add("Panadería");
            cmbFiltroCategoria.Items.Add("Bebidas");
            cmbFiltroCategoria.Items.Add("Limpieza");
            cmbFiltroCategoria.Items.Add("Electrónica");
            cmbFiltroCategoria.Items.Add("Carnes");
            cmbFiltroCategoria.Items.Add("Verduras");
            cmbFiltroCategoria.SelectedIndex = 0;
        }

        private void VerificarStockBajo()
        {
            var productosBajos = DataStore.Productos.Where(p => p.Cantidad < 10).ToList();

            if (productosBajos.Any())
            {
                string mensaje = "⚠️ ALERTA DE STOCK BAJO ⚠️\n\n";
                mensaje += "Los siguientes productos tienen menos de 10 unidades:\n\n";
                foreach (var p in productosBajos)
                {
                    mensaje += $"• {p.Nombre}: {p.Cantidad} unidades\n";
                }
                MessageBox.Show(mensaje, "Inventario Bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPrecio.Focus();
                return;
            }

            if (nudCantidad.Value < 0)
            {
                MessageBox.Show("La cantidad no puede ser negativa", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudCantidad.Focus();
                return;
            }

            if (productoSeleccionado == null)
            {
                int nuevoId = DataStore.Productos.Count > 0 ? DataStore.Productos.Max(p => p.Id) + 1 : 1;

                Producto nuevo = new Producto
                {
                    Id = nuevoId,
                    Nombre = txtNombre.Text,
                    Categoria = cmbCategoria.SelectedItem.ToString(),
                    Precio = nudPrecio.Value,
                    Cantidad = (int)nudCantidad.Value
                };

                DataStore.Productos.Add(nuevo);
                MessageBox.Show("Producto agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                productoSeleccionado.Nombre = txtNombre.Text;
                productoSeleccionado.Categoria = cmbCategoria.SelectedItem.ToString();
                productoSeleccionado.Precio = nudPrecio.Value;
                productoSeleccionado.Cantidad = (int)nudCantidad.Value;

                MessageBox.Show("Producto actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpiarFormulario();
            CargarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            productoSeleccionado = null;
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Eliminar {productoSeleccionado.Nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                DataStore.Productos.Remove(productoSeleccionado);
                LimpiarFormulario();
                CargarProductos();
                MessageBox.Show("Producto eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            string categoria = cmbFiltroCategoria.SelectedItem?.ToString();

            var query = DataStore.Productos.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                query = query.Where(p => p.Nombre.ToLower().Contains(busqueda) || p.Categoria.ToLower().Contains(busqueda));
            }

            if (categoria != null && categoria != "Todos")
            {
                query = query.Where(p => p.Categoria == categoria);
            }

            var filtrados = query.ToList();
            dgvProductos.DataSource = filtrados;
            lblTotalProductos.Text = $"Mostrando {filtrados.Count} de {DataStore.Productos.Count} productos";
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbFiltroCategoria.SelectedIndex = 0;
            CargarProductos();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarProductos();
            LimpiarFormulario();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                productoSeleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;
                txtNombre.Text = productoSeleccionado.Nombre;
                cmbCategoria.SelectedItem = productoSeleccionado.Categoria;
                nudPrecio.Value = productoSeleccionado.Precio;
                nudCantidad.Value = productoSeleccionado.Cantidad;
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = 0;
            nudPrecio.Value = 0;
            nudCantidad.Value = 0;
            productoSeleccionado = null;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataStore.UsuarioActual = null;
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void btnReporteStock_Click(object sender, EventArgs e)
        {
            var productosBajos = DataStore.Productos.Where(p => p.Cantidad < 10).ToList();
            var productosAgotados = DataStore.Productos.Where(p => p.Cantidad == 0).ToList();

            string reporte = "📊 REPORTE DE INVENTARIO 📊\n\n";
            reporte += $"Total productos: {DataStore.Productos.Count}\n";
            reporte += $"Productos con stock bajo (<10): {productosBajos.Count}\n";
            reporte += $"Productos agotados (0): {productosAgotados.Count}\n\n";

            if (productosBajos.Any())
            {
                reporte += "🔴 PRODUCTOS CON STOCK BAJO:\n";
                foreach (var p in productosBajos)
                {
                    reporte += $"   • {p.Nombre}: {p.Cantidad} unidades\n";
                }
            }

            MessageBox.Show(reporte, "Reporte de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}