using System;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmAgregarVendedor : Form
    {
        public frmAgregarVendedor()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(16, 56);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(300, 22);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(16, 112);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(300, 22);
			this.txtApellido.TabIndex = 1;
			this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(16, 283);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(140, 36);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(176, 283);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(140, 36);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(16, 168);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(300, 22);
			this.txtUsuario.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(16, 224);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(300, 22);
			this.txtPassword.TabIndex = 4;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Nombre:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Apellido:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Usuario:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label4.Location = new System.Drawing.Point(13, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Contraseña:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// frmAgregarVendedor
			// 
			this.ClientSize = new System.Drawing.Size(332, 331);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAgregarVendedor";
			this.Text = "Agregar Vendedor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text.Trim();
            string apellidos = txtApellido.Text.Trim();
            string nombreUsuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor complete Nombre, Apellido, Usuario y Contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuarioDal = new UsuarioDAL();
                bool ok = usuarioDal.Insertar(nombres, apellidos, nombreUsuario, password, "Vendedor");

                if (ok)
                {
                    MessageBox.Show("Vendedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el vendedor en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnGuardar;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button btnCancelar;

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
