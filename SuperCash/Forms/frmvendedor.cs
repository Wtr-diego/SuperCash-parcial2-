using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SuperCash.Data;
using SuperCash.Models;

namespace SuperCash.Forms
{
    public partial class frmVendedor : Form
    {
        private List<ItemVenta> carrito = new List<ItemVenta>();
        private int nextVentaId = 1;

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

            if (DataStore.UsuarioActual != null)
            {
                lblVendedor.Text = $"Vendedor: {DataStore.UsuarioActual.Nombre} {DataStore.UsuarioActual.Apellido}";
            }
        }

        private void CargarProductos(string filtro = "")
        {
            var productos = DataStore.Productos.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                productos = productos.Where(p => p.Nombre.ToLower().Contains(filtro.ToLower()) ||
                                                p.Categoria.ToLower().Contains(filtro.ToLower()));
            }

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos.ToList();

            if (dgvProductos.Columns.Count > 0)
            {
                dgvProductos.Columns["Id"].HeaderText = "ID";
                dgvProductos.Columns["Id"].Width = 50;
                dgvProductos.Columns["Nombre"].HeaderText = "Producto";
                dgvProductos.Columns["Nombre"].Width = 200;
                dgvProductos.Columns["Categoria"].HeaderText = "Categoría";
                dgvProductos.Columns["Categoria"].Width = 120;
                dgvProductos.Columns["Precio"].HeaderText = "Precio";
                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dgvProductos.Columns["Precio"].Width = 100;
                dgvProductos.Columns["Cantidad"].HeaderText = "Stock";
                dgvProductos.Columns["Cantidad"].Width = 80;
            }

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.DataBoundItem != null)
                {
                    var producto = (Producto)row.DataBoundItem;
                    if (producto.Cantidad == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else if (producto.Cantidad < 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        private void ActualizarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito.ToList();

            if (dgvCarrito.Columns.Count > 0)
            {
                dgvCarrito.Columns["ProductoId"].HeaderText = "ID";
                dgvCarrito.Columns["ProductoId"].Width = 50;
                dgvCarrito.Columns["NombreProducto"].HeaderText = "Producto";
                dgvCarrito.Columns["NombreProducto"].Width = 200;
                dgvCarrito.Columns["Cantidad"].HeaderText = "Cantidad";
                dgvCarrito.Columns["Cantidad"].Width = 80;
                dgvCarrito.Columns["PrecioUnitario"].HeaderText = "Precio Unit.";
                dgvCarrito.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
                dgvCarrito.Columns["PrecioUnitario"].Width = 100;
                dgvCarrito.Columns["Subtotal"].HeaderText = "Subtotal";
                dgvCarrito.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
                dgvCarrito.Columns["Subtotal"].Width = 100;
            }

            decimal total = carrito.Sum(item => item.Subtotal);
            lblTotal.Text = $"Total: {total:C2}";
            lblCantidadItems.Text = $"Items: {carrito.Sum(i => i.Cantidad)}";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto producto = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;
            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > producto.Cantidad)
            {
                MessageBox.Show($"Stock insuficiente. Solo hay {producto.Cantidad} unidades", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemExistente = carrito.FirstOrDefault(i => i.ProductoId == producto.Id);

            if (itemExistente != null)
            {
                if (itemExistente.Cantidad + cantidad > producto.Cantidad)
                {
                    MessageBox.Show($"No puede agregar más. Stock máximo: {producto.Cantidad}", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                itemExistente.Cantidad += cantidad;
                itemExistente.Subtotal = itemExistente.Cantidad * itemExistente.PrecioUnitario;
            }
            else
            {
                carrito.Add(new ItemVenta
                {
                    ProductoId = producto.Id,
                    NombreProducto = producto.Nombre,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.Precio,
                    Subtotal = cantidad * producto.Precio
                });
            }

            ActualizarCarrito();
            nudCantidad.Value = 1;
            MessageBox.Show("Producto agregado al carrito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un item del carrito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItemVenta item = (ItemVenta)dgvCarrito.SelectedRows[0].DataBoundItem;
            carrito.Remove(item);
            ActualizarCarrito();
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Finalizar venta por {lblTotal.Text}?", "Confirmar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                foreach (var item in carrito)
                {
                    var producto = DataStore.Productos.First(p => p.Id == item.ProductoId);
                    producto.Cantidad -= item.Cantidad;

                    DataStore.Ventas.Add(new Venta
                    {
                        Id = nextVentaId++,
                        Fecha = DateTime.Now,
                        ProductoId = item.ProductoId,
                        Cantidad = item.Cantidad,
                        Total = item.Subtotal,
                        VendedorId = DataStore.UsuarioActual?.Id ?? 0
                    });
                }

                string ticket = GenerarTicket();
                MessageBox.Show(ticket, "Ticket de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carrito.Clear();
                ActualizarCarrito();
                CargarProductos(txtBuscarProducto.Text);

                MessageBox.Show("Venta completada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GenerarTicket()
        {
            string ticket = "═══════════════════════════════\n";
            ticket += "        SUPERCASH - TICKET\n";
            ticket += "═══════════════════════════════\n";
            ticket += $"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}\n";
            ticket += $"Vendedor: {DataStore.UsuarioActual?.Nombre ?? "Desconocido"}\n";
            ticket += "───────────────────────────────\n";
            ticket += "Productos:\n";

            foreach (var item in carrito)
            {
                ticket += $"{item.Cantidad}x {item.NombreProducto}\n";
                ticket += $"       {item.Subtotal:C2}\n";
            }

            ticket += "───────────────────────────────\n";
            ticket += $"Total: {lblTotal.Text}\n";
            ticket += "═══════════════════════════════\n";
            ticket += "     ¡Gracias por su compra!\n";
            ticket += "═══════════════════════════════\n";

            return ticket;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            CargarProductos(txtBuscarProducto.Text);
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Clear();
            CargarProductos();
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