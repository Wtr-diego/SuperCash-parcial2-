using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace GUI
{
    partial class frmAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnReporteStock;
        private System.Windows.Forms.Button btnAgregarVendedor;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbLogo;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
			this.nudPrecio = new System.Windows.Forms.NumericUpDown();
			this.nudStock = new System.Windows.Forms.NumericUpDown();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnLimpiarFiltros = new System.Windows.Forms.Button();
			this.btnRefrescar = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.btnReporteStock = new System.Windows.Forms.Button();
			this.btnAgregarVendedor = new System.Windows.Forms.Button();
			this.lblTotalProductos = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
			this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvProductos.ColumnHeadersHeight = 29;
			this.dgvProductos.Location = new System.Drawing.Point(11, 337);
			this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersWidth = 51;
			this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new System.Drawing.Size(739, 650);
			this.dgvProductos.TabIndex = 0;
			this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
			this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
			this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(16, 116);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(265, 22);
			this.txtNombre.TabIndex = 1;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(483, 100);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(265, 22);
			this.txtBuscar.TabIndex = 2;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategoria.Location = new System.Drawing.Point(16, 146);
			this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(265, 24);
			this.cmbCategoria.TabIndex = 3;
			// 
			// cmbFiltroCategoria
			// 
			this.cmbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFiltroCategoria.Location = new System.Drawing.Point(483, 138);
			this.cmbFiltroCategoria.Margin = new System.Windows.Forms.Padding(4);
			this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
			this.cmbFiltroCategoria.Size = new System.Drawing.Size(265, 24);
			this.cmbFiltroCategoria.TabIndex = 4;
			this.cmbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCategoria_SelectedIndexChanged);
			// 
			// nudPrecio
			// 
			this.nudPrecio.DecimalPlaces = 2;
			this.nudPrecio.Location = new System.Drawing.Point(16, 178);
			this.nudPrecio.Margin = new System.Windows.Forms.Padding(4);
			this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudPrecio.Name = "nudPrecio";
			this.nudPrecio.Size = new System.Drawing.Size(265, 22);
			this.nudPrecio.TabIndex = 5;
			this.nudPrecio.ThousandsSeparator = true;
			// 
			// nudStock
			// 
			this.nudStock.Location = new System.Drawing.Point(16, 210);
			this.nudStock.Margin = new System.Windows.Forms.Padding(4);
			this.nudStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudStock.Name = "nudStock";
			this.nudStock.Size = new System.Drawing.Size(265, 22);
			this.nudStock.TabIndex = 6;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Location = new System.Drawing.Point(313, 116);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(133, 37);
			this.btnGuardar.TabIndex = 7;
			this.btnGuardar.Text = "💾 Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Location = new System.Drawing.Point(313, 178);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(133, 37);
			this.btnNuevo.TabIndex = 8;
			this.btnNuevo.Text = "✨ Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(16, 252);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(133, 37);
			this.btnEliminar.TabIndex = 9;
			this.btnEliminar.Text = "🗑️ Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(756, 94);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(119, 37);
			this.btnBuscar.TabIndex = 10;
			this.btnBuscar.Text = "🔍 Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnLimpiarFiltros
			// 
			this.btnLimpiarFiltros.Location = new System.Drawing.Point(756, 138);
			this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
			this.btnLimpiarFiltros.Size = new System.Drawing.Size(119, 28);
			this.btnLimpiarFiltros.TabIndex = 11;
			this.btnLimpiarFiltros.Text = "Limpiar filtros";
			this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
			this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
			// 
			// btnRefrescar
			// 
			this.btnRefrescar.Location = new System.Drawing.Point(157, 252);
			this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRefrescar.Name = "btnRefrescar";
			this.btnRefrescar.Size = new System.Drawing.Size(133, 37);
			this.btnRefrescar.TabIndex = 12;
			this.btnRefrescar.Text = "🔄 Refrescar";
			this.btnRefrescar.UseVisualStyleBackColor = true;
			this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrarSesion.BackColor = System.Drawing.Color.Gray;
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
			this.btnCerrarSesion.Location = new System.Drawing.Point(1774, 15);
			this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(133, 37);
			this.btnCerrarSesion.TabIndex = 13;
			this.btnCerrarSesion.Text = "🚪 Cerrar sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// btnReporteStock
			// 
			this.btnReporteStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporteStock.Location = new System.Drawing.Point(1566, 15);
			this.btnReporteStock.Margin = new System.Windows.Forms.Padding(4);
			this.btnReporteStock.Name = "btnReporteStock";
			this.btnReporteStock.Size = new System.Drawing.Size(200, 37);
			this.btnReporteStock.TabIndex = 14;
			this.btnReporteStock.Text = "📊 Reporte de stock";
			this.btnReporteStock.UseVisualStyleBackColor = true;
			this.btnReporteStock.Click += new System.EventHandler(this.btnReporteStock_Click);
			// 
			// btnAgregarVendedor
			// 
			this.btnAgregarVendedor.Location = new System.Drawing.Point(360, 15);
			this.btnAgregarVendedor.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregarVendedor.Name = "btnAgregarVendedor";
			this.btnAgregarVendedor.Size = new System.Drawing.Size(200, 37);
			this.btnAgregarVendedor.TabIndex = 19;
			this.btnAgregarVendedor.Text = "➕ Vendedores";
			this.btnAgregarVendedor.UseVisualStyleBackColor = true;
			this.btnAgregarVendedor.Click += new System.EventHandler(this.btnAgregarVendedor_Click);
			// 
			// lblTotalProductos
			// 
			this.lblTotalProductos.AutoSize = true;
			this.lblTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalProductos.Location = new System.Drawing.Point(479, 76);
			this.lblTotalProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalProductos.Name = "lblTotalProductos";
			this.lblTotalProductos.Size = new System.Drawing.Size(51, 20);
			this.lblTotalProductos.TabIndex = 15;
			this.lblTotalProductos.Text = "Total:";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(16, 78);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(347, 21);
			this.textBox1.TabIndex = 16;
			this.textBox1.Text = "Ingrese la informacion del producto:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
			this.lblTitulo.Location = new System.Drawing.Point(8, 9);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(297, 49);
			this.lblTitulo.TabIndex = 17;
			this.lblTitulo.Text = "SUPERCASH";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pbLogo
			// 
			this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
			this.pbLogo.ImageLocation = "";
			this.pbLogo.Location = new System.Drawing.Point(299, 9);
			this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(51, 49);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 18;
			this.pbLogo.TabStop = false;
			// 
			// dtpFechaInicio
			// 
			this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaInicio.Location = new System.Drawing.Point(1798, 59);
			this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFechaInicio.Name = "dtpFechaInicio";
			this.dtpFechaInicio.Size = new System.Drawing.Size(111, 22);
			this.dtpFechaInicio.TabIndex = 20;
			// 
			// chartVentas
			// 
			this.chartVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chartVentas.BackColor = System.Drawing.Color.DarkGray;
			this.chartVentas.BorderlineColor = System.Drawing.Color.Black;
			this.chartVentas.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.Name = "ChartArea1";
			this.chartVentas.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartVentas.Legends.Add(legend1);
			this.chartVentas.Location = new System.Drawing.Point(783, 337);
			this.chartVentas.Margin = new System.Windows.Forms.Padding(4);
			this.chartVentas.Name = "chartVentas";
			this.chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartVentas.Series.Add(series1);
			this.chartVentas.Size = new System.Drawing.Size(1034, 650);
			this.chartVentas.TabIndex = 21;
			this.chartVentas.Text = "chart1";
			this.chartVentas.Click += new System.EventHandler(this.chart1_Click);
			// 
			// frmAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 1000);
			this.Controls.Add(this.chartVentas);
			this.Controls.Add(this.pbLogo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblTotalProductos);
			this.Controls.Add(this.dtpFechaInicio);
			this.Controls.Add(this.btnReporteStock);
			this.Controls.Add(this.btnAgregarVendedor);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnRefrescar);
			this.Controls.Add(this.btnLimpiarFiltros);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.nudStock);
			this.Controls.Add(this.nudPrecio);
			this.Controls.Add(this.cmbFiltroCategoria);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.dgvProductos);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmAdmin";
			this.Text = "Panel Administrador - SuperCash";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmAdmin_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
	}
}