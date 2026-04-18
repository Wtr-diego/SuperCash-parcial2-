namespace GUI
{
    partial class frmVendedor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidadItems;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblCantidad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.dgvCarrito = new System.Windows.Forms.DataGridView();
			this.txtBuscarProducto = new System.Windows.Forms.TextBox();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnFinalizarVenta = new System.Windows.Forms.Button();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.lblVendedor = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblCantidadItems = new System.Windows.Forms.Label();
			this.lblProductos = new System.Windows.Forms.Label();
			this.lblCarrito = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.ColumnHeadersHeight = 29;
			this.dgvProductos.Location = new System.Drawing.Point(16, 135);
			this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersWidth = 51;
			this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new System.Drawing.Size(600, 492);
			this.dgvProductos.TabIndex = 6;
			// 
			// dgvCarrito
			// 
			this.dgvCarrito.AllowUserToAddRows = false;
			this.dgvCarrito.AllowUserToDeleteRows = false;
			this.dgvCarrito.ColumnHeadersHeight = 29;
			this.dgvCarrito.Location = new System.Drawing.Point(667, 98);
			this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCarrito.Name = "dgvCarrito";
			this.dgvCarrito.ReadOnly = true;
			this.dgvCarrito.RowHeadersWidth = 51;
			this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCarrito.Size = new System.Drawing.Size(600, 431);
			this.dgvCarrito.TabIndex = 11;
			// 
			// txtBuscarProducto
			// 
			this.txtBuscarProducto.Location = new System.Drawing.Point(16, 98);
			this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscarProducto.Name = "txtBuscarProducto";
			this.txtBuscarProducto.Size = new System.Drawing.Size(265, 22);
			this.txtBuscarProducto.TabIndex = 3;
			// 
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(104, 642);
			this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
			this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(107, 22);
			this.nudCantidad.TabIndex = 8;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnAgregar.Location = new System.Drawing.Point(227, 638);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(133, 37);
			this.btnAgregar.TabIndex = 9;
			this.btnAgregar.Text = "Agregar ➕";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnQuitar.Location = new System.Drawing.Point(667, 542);
			this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(133, 37);
			this.btnQuitar.TabIndex = 12;
			this.btnQuitar.Text = "Quitar ❌";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// btnFinalizarVenta
			// 
			this.btnFinalizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnFinalizarVenta.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnFinalizarVenta.Location = new System.Drawing.Point(667, 638);
			this.btnFinalizarVenta.Margin = new System.Windows.Forms.Padding(4);
			this.btnFinalizarVenta.Name = "btnFinalizarVenta";
			this.btnFinalizarVenta.Size = new System.Drawing.Size(600, 49);
			this.btnFinalizarVenta.TabIndex = 15;
			this.btnFinalizarVenta.Text = "FINALIZAR VENTA 💰";
			this.btnFinalizarVenta.UseVisualStyleBackColor = false;
			this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.Location = new System.Drawing.Point(293, 96);
			this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.Size = new System.Drawing.Size(100, 28);
			this.btnBuscarProducto.TabIndex = 4;
			this.btnBuscarProducto.Text = "Buscar";
			this.btnBuscarProducto.UseVisualStyleBackColor = true;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
			// 
			// btnLimpiarBusqueda
			// 
			this.btnLimpiarBusqueda.Location = new System.Drawing.Point(401, 96);
			this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
			this.btnLimpiarBusqueda.Size = new System.Drawing.Size(100, 28);
			this.btnLimpiarBusqueda.TabIndex = 5;
			this.btnLimpiarBusqueda.Text = "Limpiar";
			this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
			this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.Location = new System.Drawing.Point(1139, 11);
			this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(160, 37);
			this.btnCerrarSesion.TabIndex = 1;
			this.btnCerrarSesion.Text = "Cerrar Sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// lblVendedor
			// 
			this.lblVendedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lblVendedor.Location = new System.Drawing.Point(16, 11);
			this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVendedor.Name = "lblVendedor";
			this.lblVendedor.Size = new System.Drawing.Size(533, 31);
			this.lblVendedor.TabIndex = 0;
			this.lblVendedor.Text = "Vendedor: ";
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lblTotal.Location = new System.Drawing.Point(667, 591);
			this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(267, 37);
			this.lblTotal.TabIndex = 13;
			this.lblTotal.Text = "Total: $0.00";
			// 
			// lblCantidadItems
			// 
			this.lblCantidadItems.Location = new System.Drawing.Point(933, 597);
			this.lblCantidadItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCantidadItems.Name = "lblCantidadItems";
			this.lblCantidadItems.Size = new System.Drawing.Size(200, 31);
			this.lblCantidadItems.TabIndex = 14;
			this.lblCantidadItems.Text = "Items: 0";
			// 
			// lblProductos
			// 
			this.lblProductos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lblProductos.Location = new System.Drawing.Point(16, 62);
			this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProductos.Name = "lblProductos";
			this.lblProductos.Size = new System.Drawing.Size(267, 31);
			this.lblProductos.TabIndex = 2;
			this.lblProductos.Text = "LISTA DE PRODUCTOS";
			// 
			// lblCarrito
			// 
			this.lblCarrito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lblCarrito.Location = new System.Drawing.Point(667, 62);
			this.lblCarrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCarrito.Name = "lblCarrito";
			this.lblCarrito.Size = new System.Drawing.Size(267, 31);
			this.lblCarrito.TabIndex = 10;
			this.lblCarrito.Text = "CARRITO DE COMPRAS";
			// 
			// lblCantidad
			// 
			this.lblCantidad.Location = new System.Drawing.Point(16, 640);
			this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(80, 31);
			this.lblCantidad.TabIndex = 7;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// frmVendedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1312, 715);
			this.Controls.Add(this.btnFinalizarVenta);
			this.Controls.Add(this.lblCantidadItems);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.dgvCarrito);
			this.Controls.Add(this.lblCarrito);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.nudCantidad);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.btnLimpiarBusqueda);
			this.Controls.Add(this.btnBuscarProducto);
			this.Controls.Add(this.txtBuscarProducto);
			this.Controls.Add(this.lblProductos);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.lblVendedor);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmVendedor";
			this.Text = "Panel Vendedor - SuperCash";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
    }
}