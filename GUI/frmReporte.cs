using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    // Simple report form used by frmAdmin. Provides a DataGridView to display a DataTable.
    public class frmReporte : Form
    {
        private DataGridView dgvReporte;

        public frmReporte()
        {
            this.Text = "Reporte";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 900;
            this.Height = 600;

            dgvReporte = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            this.Controls.Add(dgvReporte);
        }

        // Permite a frmAdmin pasar un DataTable para visualizar en el reporte
        public void SetDataSource(DataTable dt)
        {
            dgvReporte.DataSource = dt;
        }
    }
}
