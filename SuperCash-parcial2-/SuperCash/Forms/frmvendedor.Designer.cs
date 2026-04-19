namespace SuperCash.Forms
{
    partial class frmVendedor
    {
        private System.ComponentModel.IContainer components = null;

        // Controles del formulario
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
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Panel pnlCarrito;
        private System.Windows.Forms.Panel pnlBotonesInferiores;
        private System.Windows.Forms.GroupBox grpCantidad;

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
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.grpCantidad = new System.Windows.Forms.GroupBox();
            this.pnlCarrito = new System.Windows.Forms.Panel();
            this.pnlBotonesInferiores = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.pnlProductos.SuspendLayout();
            this.grpCantidad.SuspendLayout();
            this.pnlCarrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeight = 40;
            this.dgvProductos.Location = new System.Drawing.Point(10, 95);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 35;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(525, 350);
            this.dgvProductos.TabIndex = 4;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarrito.ColumnHeadersHeight = 40;
            this.dgvCarrito.Location = new System.Drawing.Point(10, 50);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 35;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(525, 380);
            this.dgvCarrito.TabIndex = 1;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarProducto.Location = new System.Drawing.Point(10, 50);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(280, 30);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.Text = "🔍 Buscar producto...";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudCantidad.Location = new System.Drawing.Point(100, 30);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(100, 34);
            this.nudCantidad.TabIndex = 1;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(220, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "➕ AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(10, 440);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(525, 40);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "❌ QUITAR DEL CARRITO";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarVenta.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenta.Location = new System.Drawing.Point(10, 535);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(525, 50);
            this.btnFinalizarVenta.TabIndex = 5;
            this.btnFinalizarVenta.Text = "💵 FINALIZAR VENTA";
            this.btnFinalizarVenta.UseVisualStyleBackColor = false;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(300, 50);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(410, 50);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiarBusqueda.TabIndex = 3;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(950, 12);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(160, 35);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "🚪 CERRAR SESIÓN";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.lblVendedor.Location = new System.Drawing.Point(12, 15);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(114, 28);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor: ";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotal.Location = new System.Drawing.Point(10, 490);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(250, 35);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "💰 Total: $0.00";
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCantidadItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCantidadItems.Location = new System.Drawing.Point(300, 490);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(200, 35);
            this.lblCantidadItems.TabIndex = 4;
            this.lblCantidadItems.Text = "📦 Items: 0";
            this.lblCantidadItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.lblProductos.Location = new System.Drawing.Point(10, 10);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(254, 28);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "📦 LISTA DE PRODUCTOS";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.lblCarrito.Location = new System.Drawing.Point(10, 10);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(264, 28);
            this.lblCarrito.TabIndex = 0;
            this.lblCarrito.Text = "🛒 CARRITO DE COMPRAS";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 35);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(83, 23);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // pnlProductos
            // 
            this.pnlProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProductos.BackColor = System.Drawing.Color.Silver;
            this.pnlProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductos.Controls.Add(this.lblProductos);
            this.pnlProductos.Controls.Add(this.txtBuscarProducto);
            this.pnlProductos.Controls.Add(this.btnBuscarProducto);
            this.pnlProductos.Controls.Add(this.btnLimpiarBusqueda);
            this.pnlProductos.Controls.Add(this.dgvProductos);
            this.pnlProductos.Controls.Add(this.grpCantidad);
            this.pnlProductos.Location = new System.Drawing.Point(12, 60);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Padding = new System.Windows.Forms.Padding(10);
            this.pnlProductos.Size = new System.Drawing.Size(550, 600);
            this.pnlProductos.TabIndex = 0;
            // 
            // grpCantidad
            // 
            this.grpCantidad.Controls.Add(this.lblCantidad);
            this.grpCantidad.Controls.Add(this.nudCantidad);
            this.grpCantidad.Controls.Add(this.btnAgregar);
            this.grpCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpCantidad.Location = new System.Drawing.Point(10, 460);
            this.grpCantidad.Name = "grpCantidad";
            this.grpCantidad.Size = new System.Drawing.Size(525, 80);
            this.grpCantidad.TabIndex = 5;
            this.grpCantidad.TabStop = false;
            this.grpCantidad.Text = "Agregar al carrito";
            // 
            // pnlCarrito
            // 
            this.pnlCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCarrito.BackColor = System.Drawing.Color.Silver;
            this.pnlCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCarrito.Controls.Add(this.lblCarrito);
            this.pnlCarrito.Controls.Add(this.dgvCarrito);
            this.pnlCarrito.Controls.Add(this.btnQuitar);
            this.pnlCarrito.Controls.Add(this.lblTotal);
            this.pnlCarrito.Controls.Add(this.lblCantidadItems);
            this.pnlCarrito.Controls.Add(this.btnFinalizarVenta);
            this.pnlCarrito.Location = new System.Drawing.Point(575, 60);
            this.pnlCarrito.Name = "pnlCarrito";
            this.pnlCarrito.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCarrito.Size = new System.Drawing.Size(550, 600);
            this.pnlCarrito.TabIndex = 1;
            // 
            // pnlBotonesInferiores
            // 
            this.pnlBotonesInferiores.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonesInferiores.Name = "pnlBotonesInferiores";
            this.pnlBotonesInferiores.Size = new System.Drawing.Size(200, 100);
            this.pnlBotonesInferiores.TabIndex = 0;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1140, 680);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.pnlCarrito);
            this.Controls.Add(this.pnlProductos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Vendedor - SuperCash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            this.grpCantidad.ResumeLayout(false);
            this.grpCantidad.PerformLayout();
            this.pnlCarrito.ResumeLayout(false);
            this.pnlCarrito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}