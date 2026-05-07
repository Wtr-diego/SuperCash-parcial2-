using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
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
            MessageBox.Show(
                "Por favor, contacte al administrador para recuperar su contraseña.\n\n" +
                "Email: admin@supercash.com",
                "Recuperar Contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

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

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de SuperCash?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            // Este evento se ejecuta cuando el texto cambia
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

		public void LimpiarCampos()
		{
			txtUsuario.Text = "";
			txtContrasena.Text = "";
			txtUsuario.Focus();
		}
	}
}