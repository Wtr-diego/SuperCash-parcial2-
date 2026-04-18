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
        public frmLogin()
        {
            InitializeComponent();
            ConfigurarFormulario();
            ConfigurarPlaceholders();
            CargarDatosPrueba();
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

        private void CargarDatosPrueba()
        {
            DataStore.InicializarDatos();
        }

        private void ConfigurarPlaceholders()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "correo@ejemplo.com";
                txtUsuario.ForeColor = Color.Gray;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.Text = "Ingrese su contraseña";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "correo@ejemplo.com" || txtUsuario.Text == "Ingrese su usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "correo@ejemplo.com";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Ingrese su contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.PasswordChar = '●';
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.Text = "Ingrese su contraseña";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioInput = txtUsuario.Text.Trim();
            string contrasenaInput = txtContrasena.Text;

            // Validar campos
            if (usuarioInput == "correo@ejemplo.com" || string.IsNullOrWhiteSpace(usuarioInput))
            {
                MessageBox.Show("Por favor, ingrese su usuario o correo electrónico", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (contrasenaInput == "Ingrese su contraseña" || string.IsNullOrWhiteSpace(contrasenaInput))
            {
                MessageBox.Show("Por favor, ingrese su contraseña", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            // Buscar usuario por email o nombre
            var usuario = DataStore.Usuarios.FirstOrDefault(u =>
                (u.Email == usuarioInput || u.Nombre == usuarioInput ||
                 (u.Email != null && u.Email.Split('@')[0] == usuarioInput)) &&
                u.Contrasena == contrasenaInput);

            if (usuario != null)
            {
                DataStore.UsuarioActual = usuario;

                MessageBox.Show($"¡Bienvenido {usuario.Nombre} {usuario.Apellido}!\n\nRol: {usuario.Rol}",
                    "Inicio de Sesión Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Redirigir según el rol
                if (usuario.Rol == "Administrador")
                {
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                }
                else
                {
                    frmVendedor vendedor = new frmVendedor();
                    vendedor.Show();
                }

                this.Hide(); // Ocultar el formulario de login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Text = "";
                txtContrasena.Focus();
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
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.PasswordChar = '●';
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de SuperCash?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
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
    }
}