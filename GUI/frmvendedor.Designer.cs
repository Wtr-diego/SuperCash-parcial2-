namespace GUI
{
    partial class frmVendedor
    {
        private System.ComponentModel.IContainer components = null;

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
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.btnFinalizarVenta = new System.Windows.Forms.Button();
			this.lblCantidadItems = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvCarrito = new System.Windows.Forms.DataGridView();
			this.lblCarrito = new System.Windows.Forms.Label();
			this.txtBuscarProducto = new System.Windows.Forms.TextBox();
			this.lblProductos = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblVendedor = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lblTotal.Location = new System.Drawing.Point(4, 541);
			this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(267, 37);
			this.lblTotal.TabIndex = 20;
			this.lblTotal.Text = "Total: $0.00";
			// 
			// btnQuitar
			// 
			this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnQuitar.Location = new System.Drawing.Point(8, 490);
			this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(133, 37);
			this.btnQuitar.TabIndex = 19;
			this.btnQuitar.Text = "Quitar ❌";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrarSesion.Location = new System.Drawing.Point(355, 10);
			this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(160, 37);
			this.btnCerrarSesion.TabIndex = 16;
			this.btnCerrarSesion.Text = "Cerrar Sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnAgregar.Location = new System.Drawing.Point(221, 644);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(133, 37);
			this.btnAgregar.TabIndex = 18;
			this.btnAgregar.Text = "Agregar ➕";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// nudCantidad
			// 
			this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.nudCantidad.Location = new System.Drawing.Point(98, 648);
			this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
			this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(107, 22);
			this.nudCantidad.TabIndex = 17;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.Click += new System.EventHandler(this.nudCantidad_ValueChanged);
			// 
			// lblCantidad
			// 
			this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCantidad.Location = new System.Drawing.Point(10, 646);
			this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(80, 31);
			this.lblCantidad.TabIndex = 16;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProductos.ColumnHeadersHeight = 29;
			this.dgvProductos.Location = new System.Drawing.Point(10, 144);
			this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersWidth = 51;
			this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new System.Drawing.Size(600, 492);
			this.dgvProductos.TabIndex = 15;
			// 
			// btnLimpiarBusqueda
			// 
			this.btnLimpiarBusqueda.Location = new System.Drawing.Point(391, 83);
			this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
			this.btnLimpiarBusqueda.Size = new System.Drawing.Size(100, 28);
			this.btnLimpiarBusqueda.TabIndex = 14;
			this.btnLimpiarBusqueda.Text = "Limpiar";
			this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
			this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.Location = new System.Drawing.Point(283, 83);
			this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.Size = new System.Drawing.Size(100, 28);
			this.btnBuscarProducto.TabIndex = 13;
			this.btnBuscarProducto.Text = "Buscar";
			this.btnBuscarProducto.UseVisualStyleBackColor = true;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
			// 
			// btnFinalizarVenta
			// 
			this.btnFinalizarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFinalizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnFinalizarVenta.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnFinalizarVenta.Location = new System.Drawing.Point(0, 638);
			this.btnFinalizarVenta.Margin = new System.Windows.Forms.Padding(4);
			this.btnFinalizarVenta.Name = "btnFinalizarVenta";
			this.btnFinalizarVenta.Size = new System.Drawing.Size(537, 49);
			this.btnFinalizarVenta.TabIndex = 22;
			this.btnFinalizarVenta.Text = "FINALIZAR VENTA 💰";
			this.btnFinalizarVenta.UseVisualStyleBackColor = false;
			this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
			// 
			// lblCantidadItems
			// 
			this.lblCantidadItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCantidadItems.Location = new System.Drawing.Point(196, 541);
			this.lblCantidadItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCantidadItems.Name = "lblCantidadItems";
			this.lblCantidadItems.Size = new System.Drawing.Size(200, 31);
			this.lblCantidadItems.TabIndex = 21;
			this.lblCantidadItems.Text = "Items: 0";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnFinalizarVenta);
			this.panel2.Controls.Add(this.lblCantidadItems);
			this.panel2.Controls.Add(this.lblTotal);
			this.panel2.Controls.Add(this.btnQuitar);
			this.panel2.Controls.Add(this.dgvCarrito);
			this.panel2.Controls.Add(this.lblCarrito);
			this.panel2.Controls.Add(this.btnCerrarSesion);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(790, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(519, 709);
			this.panel2.TabIndex = 1;
			// 
			// dgvCarrito
			// 
			this.dgvCarrito.AllowUserToAddRows = false;
			this.dgvCarrito.AllowUserToDeleteRows = false;
			this.dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCarrito.ColumnHeadersHeight = 29;
			this.dgvCarrito.Location = new System.Drawing.Point(4, 98);
			this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCarrito.Name = "dgvCarrito";
			this.dgvCarrito.ReadOnly = true;
			this.dgvCarrito.RowHeadersWidth = 51;
			this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCarrito.Size = new System.Drawing.Size(511, 384);
			this.dgvCarrito.TabIndex = 18;
			// 
			// lblCarrito
			// 
			this.lblCarrito.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lblCarrito.Location = new System.Drawing.Point(4, 63);
			this.lblCarrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCarrito.Name = "lblCarrito";
			this.lblCarrito.Size = new System.Drawing.Size(267, 31);
			this.lblCarrito.TabIndex = 17;
			this.lblCarrito.Text = "CARRITO DE COMPRAS";
			// 
			// txtBuscarProducto
			// 
			this.txtBuscarProducto.Location = new System.Drawing.Point(10, 83);
			this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscarProducto.Name = "txtBuscarProducto";
			this.txtBuscarProducto.Size = new System.Drawing.Size(265, 22);
			this.txtBuscarProducto.TabIndex = 12;
			// 
			// lblProductos
			// 
			this.lblProductos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lblProductos.Location = new System.Drawing.Point(10, 48);
			this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProductos.Name = "lblProductos";
			this.lblProductos.Size = new System.Drawing.Size(267, 31);
			this.lblProductos.TabIndex = 11;
			this.lblProductos.Text = "LISTA DE PRODUCTOS";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.nudCantidad);
			this.panel1.Controls.Add(this.lblCantidad);
			this.panel1.Controls.Add(this.dgvProductos);
			this.panel1.Controls.Add(this.btnLimpiarBusqueda);
			this.panel1.Controls.Add(this.btnBuscarProducto);
			this.panel1.Controls.Add(this.txtBuscarProducto);
			this.panel1.Controls.Add(this.lblProductos);
			this.panel1.Controls.Add(this.lblVendedor);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(781, 709);
			this.panel1.TabIndex = 0;
			// 
			// lblVendedor
			// 
			this.lblVendedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lblVendedor.Location = new System.Drawing.Point(10, 17);
			this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVendedor.Name = "lblVendedor";
			this.lblVendedor.Size = new System.Drawing.Size(533, 31);
			this.lblVendedor.TabIndex = 10;
			this.lblVendedor.Text = "Vendedor: ";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1312, 715);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// frmVendedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1312, 715);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmVendedor";
			this.Text = "Panel Vendedor - SuperCash";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnLimpiarBusqueda;
		private System.Windows.Forms.Button btnBuscarProducto;
		private System.Windows.Forms.Button btnFinalizarVenta;
		private System.Windows.Forms.Label lblCantidadItems;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvCarrito;
		private System.Windows.Forms.Label lblCarrito;
		private System.Windows.Forms.TextBox txtBuscarProducto;
		private System.Windows.Forms.Label lblProductos;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblVendedor;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}