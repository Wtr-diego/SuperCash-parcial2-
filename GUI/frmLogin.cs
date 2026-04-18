using System;
using System.Windows.Forms;
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

        private void lnkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacte al administrador: admin@supercash.com\n\n" +
                "O llame al: 7777-8888",
                "Recuperar contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

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
    }
}