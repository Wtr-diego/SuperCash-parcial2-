using System;
using System.Windows.Forms;
<<<<<<< HEAD
using DAL;
using EL;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ConfigurarPlaceholders();
        }

        private void ConfigurarPlaceholders()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "correo@ejemplo.com";
                txtUsuario.ForeColor = System.Drawing.Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.Text = "Ingrese su contraseña";
                txtContrasena.ForeColor = System.Drawing.Color.Gray;
                txtContrasena.PasswordChar = '\0';
            }
        }

        // ============================================
        // BOTÓN PROBAR CONEXIÓN (NUEVO)
        // ============================================
        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                // Cambiar cursor a "espera" mientras prueba
                Cursor = Cursors.WaitCursor;

                // Probar conexión a la base de datos
                if (DatabaseConnection.TestConnection())
                {
                    MessageBox.Show("✅ Conexión exitosa a la base de datos SuperCashDB\n\n" +
                        "Servidor: DIEGO\\SQLEXPRESS\n" +
                        "Base de datos: SuperCashDB",
                        "Conexión Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("❌ No se pudo conectar a la base de datos.\n\n" +
                        "Verifique que:\n" +
                        "1. SQL Server esté corriendo (Servicios → SQL Server)\n" +
                        "2. La base de datos 'SuperCashDB' exista en SSMS\n" +
                        "3. La cadena de conexión sea correcta\n\n" +
                        "Cadena usada: Server=DIEGO\\SQLEXPRESS;Database=SuperCashDB;Integrated Security=True",
                        "Error de Conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Excepción",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar cursor normal
                Cursor = Cursors.Default;
            }
        }

        // ============================================
        // BOTÓN INICIAR SESIÓN
        // ============================================
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (email == "correo@ejemplo.com" || string.IsNullOrWhiteSpace(email))
            {
                lblError.Text = "Ingrese su correo";
                lblError.Visible = true;
                return;
            }

            if (contrasena == "Ingrese su contraseña" || string.IsNullOrWhiteSpace(contrasena))
            {
                lblError.Text = "Ingrese su contraseña";
                lblError.Visible = true;
                return;
            }

            // Probar conexión y login
            if (DatabaseConnection.TestConnection())
            {
                var repo = new UsuarioRepository();
                var usuario = repo.Login(email, contrasena);

                if (usuario != null)
                {
                    MessageBox.Show($"Bienvenido {usuario.Nombre} {usuario.Apellido}", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Guardar usuario actual en el DataStore (opcional) y abrir la interfaz correspondiente
                    DAL.DataStore.UsuarioActual = usuario;

                    if (usuario.Rol != null && usuario.Rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                    {
                        var adminForm = new frmAdmin();
                        adminForm.Show();
                    }
                    else
                    {
                        var vendedorForm = new frmVendedor();
                        vendedorForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    lblError.Text = "Usuario o contraseña incorrectos";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Error de conexión a la base de datos";
                lblError.Visible = true;
            }
        }

        // ============================================
        // EVENTOS DE PLACEHOLDERS
        // ============================================
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "correo@ejemplo.com")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "correo@ejemplo.com";
                txtUsuario.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Ingrese su contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = System.Drawing.Color.Black;
                txtContrasena.PasswordChar = '●';
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.Text = "Ingrese su contraseña";
                txtContrasena.ForeColor = System.Drawing.Color.Gray;
                txtContrasena.PasswordChar = '\0';
            }
        }

        // ============================================
        // OTROS EVENTOS
        // ============================================
        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }
=======
using DAL; 
using EL; 
using BLL;

namespace GUI
{
	public partial class frmLogin : Form
	{
		// Instancia de la capa de datos para validar usuarios
		private UsuarioDAL userDAL = new UsuarioDAL();

		public frmLogin()
		{
			InitializeComponent();
			txtContrasena.UseSystemPasswordChar = true;
			chkMostrarContrasena.Checked = false;
			ConfigurarFormulario();
			ConfigurarPlaceholders();
		}

		private void ConfigurarFormulario()
		{
			this.Text = "SuperCash - Inicio de Sesión";
			this.Size = new Size(450, 550);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.BackColor = Color.White;
		}

		private void ConfigurarPlaceholders()
		{
			if (string.IsNullOrWhiteSpace(txtUsuario.Text))
			{
				txtUsuario.Text = "";
				txtUsuario.ForeColor = Color.Black;
			}

			if (string.IsNullOrWhiteSpace(txtContrasena.Text))
			{
				txtContrasena.Text = "";
				txtContrasena.ForeColor = Color.Black;
				txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
			}
		}

			private void txtContrasena_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtContrasena.Text))
			{
				txtContrasena.Text = "";
				txtContrasena.ForeColor = Color.Black;

				txtContrasena.UseSystemPasswordChar = false;
			}
		}

		private void txtUsuario_Enter(object sender, EventArgs e) {}
		private void txtUsuario_Leave(object sender, EventArgs e) {}
		private void txtContrasena_Enter(object sender, EventArgs e) {}

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
			string usuarioInput = txtUsuario.Text.Trim();
			string contrasenaInput = txtContrasena.Text;


			if (usuarioInput == "correo@ejemplo.com" || string.IsNullOrWhiteSpace(usuarioInput))
			{
				MessageBox.Show("Por favor, ingrese su usuario o correo electrónico", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return;
			}

			if (contrasenaInput == "Ingrese su contraseña" || string.IsNullOrWhiteSpace(contrasenaInput))
			{
				MessageBox.Show("Por favor, ingrese su contraseña", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtContrasena.Focus();
				return;
			}

			try
			{
				var usuario = userDAL.ValidarUsuario(usuarioInput, contrasenaInput);

				if (usuario != null)
				{

					EL.Sesion.UsuarioActual = usuario;

					MessageBox.Show($"¡Bienvenido {usuario.Nombres} {usuario.Apellidos}!\n\nRol: {usuario.Rol}",
						"Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

>>>>>>> 21b8bb4b051c176eb666c7c7a6d1fcedbf3db64c

					if (usuario.Rol == "Administrador" || usuario.ID_Rol == 1)
					{
						frmAdmin admin = new frmAdmin();
						admin.Show();
					}
					else
					{
						frmVendedor vendedor = new frmVendedor();
						vendedor.Show();
					}

					this.Hide();
				}
				else
				{
					MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtContrasena.Clear();
					txtContrasena.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
			}
		}

		private void lnkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacte al administrador: admin@supercash.com\n\n" +
                "O llame al: 7777-8888",
                "Recuperar contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

<<<<<<< HEAD
=======
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContrasena.Focus();
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIniciarSesion.PerformClick();
            }
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
			if (chkMostrarContrasena.Checked)
			{
				txtContrasena.PasswordChar = '\0';
				txtContrasena.UseSystemPasswordChar = false;
			}
			else
			{
				txtContrasena.PasswordChar = '●';
			}
		}

>>>>>>> 21b8bb4b051c176eb666c7c7a6d1fcedbf3db64c
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (lblError.Visible) lblError.Visible = false;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtContrasena.Focus();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIniciarSesion.PerformClick();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            // Evento opcional para el logo
        }

		public void LimpiarCampos()
		{
			txtUsuario.Text = "";
			txtContrasena.Text = "";
			txtUsuario.Focus();
		}
	}
}