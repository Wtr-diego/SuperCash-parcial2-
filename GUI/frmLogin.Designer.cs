namespace GUI
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.CheckBox chkMostrarContrasena;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnProbarConexion;  // ← NUEVO BOTÓN
        private System.Windows.Forms.LinkLabel lnkRecuperar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFooter;

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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lnkRecuperar = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();  // ← NUEVO
            this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.White;
            this.pnlFondo.Controls.Add(this.lblFooter);
            this.pnlFondo.Controls.Add(this.lblError);
            this.pnlFondo.Controls.Add(this.lnkRecuperar);
            this.pnlFondo.Controls.Add(this.btnProbarConexion);  // ← NUEVO
            this.pnlFondo.Controls.Add(this.btnIniciarSesion);
            this.pnlFondo.Controls.Add(this.chkMostrarContrasena);
            this.pnlFondo.Controls.Add(this.txtContrasena);
            this.pnlFondo.Controls.Add(this.lblContrasena);
            this.pnlFondo.Controls.Add(this.txtUsuario);
            this.pnlFondo.Controls.Add(this.lblUsuario);
            this.pnlFondo.Controls.Add(this.lblSubtitulo);
            this.pnlFondo.Controls.Add(this.lblTitulo);
            this.pnlFondo.Controls.Add(this.pbLogo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(600, 677);
            this.pnlFondo.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Tahoma", 7F);
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(160, 640);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(291, 14);
            this.lblFooter.TabIndex = 11;
            this.lblFooter.Text = "SuperCash © 2026 - Todos los derechos reservados";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(80, 600);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(440, 37);
            this.lblError.TabIndex = 10;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lnkRecuperar
            // 
            this.lnkRecuperar.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lnkRecuperar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.lnkRecuperar.Location = new System.Drawing.Point(160, 560);
            this.lnkRecuperar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRecuperar.Name = "lnkRecuperar";
            this.lnkRecuperar.Size = new System.Drawing.Size(280, 31);
            this.lnkRecuperar.TabIndex = 9;
            this.lnkRecuperar.TabStop = true;
            this.lnkRecuperar.Text = "¿Olvidaste tu contraseña? Recuperar";
            this.lnkRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecuperar_LinkClicked);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(80, 455);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(440, 49);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbarConexion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnProbarConexion.ForeColor = System.Drawing.Color.White;
            this.btnProbarConexion.Location = new System.Drawing.Point(80, 515);
            this.btnProbarConexion.Margin = new System.Windows.Forms.Padding(4);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(440, 35);
            this.btnProbarConexion.TabIndex = 12;
            this.btnProbarConexion.Text = "🔌 PROBAR CONEXIÓN A BD";
            this.btnProbarConexion.UseVisualStyleBackColor = false;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // chkMostrarContrasena
            // 
            this.chkMostrarContrasena.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chkMostrarContrasena.Location = new System.Drawing.Point(80, 406);
            this.chkMostrarContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.chkMostrarContrasena.Name = "chkMostrarContrasena";
            this.chkMostrarContrasena.Size = new System.Drawing.Size(173, 31);
            this.chkMostrarContrasena.TabIndex = 7;
            this.chkMostrarContrasena.Text = "Mostrar contraseña";
            this.chkMostrarContrasena.UseVisualStyleBackColor = true;
            this.chkMostrarContrasena.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena_CheckedChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(80, 369);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(439, 28);
            this.txtContrasena.TabIndex = 6;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.Location = new System.Drawing.Point(80, 338);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(93, 18);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(80, 289);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(439, 28);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(80, 258);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(133, 197);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(333, 37);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Inicio de Sesión";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.lblTitulo.Location = new System.Drawing.Point(133, 148);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 49);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SUPERCASH";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(246, 32);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(107, 98);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 677);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperCash - Inicio de Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
=======
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.pnlFondo = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.lnkRecuperar = new System.Windows.Forms.LinkLabel();
			this.btnIniciarSesion = new System.Windows.Forms.Button();
			this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.lblContrasena = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.pnlFondo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlFondo
			// 
			this.pnlFondo.BackColor = System.Drawing.Color.White;
			this.pnlFondo.Controls.Add(this.lblFooter);
			this.pnlFondo.Controls.Add(this.lblError);
			this.pnlFondo.Controls.Add(this.lnkRecuperar);
			this.pnlFondo.Controls.Add(this.btnIniciarSesion);
			this.pnlFondo.Controls.Add(this.chkMostrarContrasena);
			this.pnlFondo.Controls.Add(this.txtContrasena);
			this.pnlFondo.Controls.Add(this.lblContrasena);
			this.pnlFondo.Controls.Add(this.txtUsuario);
			this.pnlFondo.Controls.Add(this.lblUsuario);
			this.pnlFondo.Controls.Add(this.lblSubtitulo);
			this.pnlFondo.Controls.Add(this.lblTitulo);
			this.pnlFondo.Controls.Add(this.pbLogo);
			this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFondo.Location = new System.Drawing.Point(0, 0);
			this.pnlFondo.Margin = new System.Windows.Forms.Padding(4);
			this.pnlFondo.Name = "pnlFondo";
			this.pnlFondo.Size = new System.Drawing.Size(600, 677);
			this.pnlFondo.TabIndex = 0;
			// 
			// lblFooter
			// 
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Tahoma", 7F);
			this.lblFooter.ForeColor = System.Drawing.Color.Gray;
			this.lblFooter.Location = new System.Drawing.Point(160, 640);
			this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(291, 14);
			this.lblFooter.TabIndex = 11;
			this.lblFooter.Text = "SuperCash © 2026 - Todos los derechos reservados";
			this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblError
			// 
			this.lblError.Font = new System.Drawing.Font("Tahoma", 8F);
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(80, 566);
			this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(440, 37);
			this.lblError.TabIndex = 10;
			this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblError.Visible = false;
			// 
			// lnkRecuperar
			// 
			this.lnkRecuperar.Font = new System.Drawing.Font("Tahoma", 9F);
			this.lnkRecuperar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
			this.lnkRecuperar.Location = new System.Drawing.Point(160, 523);
			this.lnkRecuperar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lnkRecuperar.Name = "lnkRecuperar";
			this.lnkRecuperar.Size = new System.Drawing.Size(280, 31);
			this.lnkRecuperar.TabIndex = 9;
			this.lnkRecuperar.TabStop = true;
			this.lnkRecuperar.Text = "¿Olvidaste tu contraseña? Recuperar";
			this.lnkRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lnkRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecuperar_LinkClicked);
			// 
			// btnIniciarSesion
			// 
			this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
			this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIniciarSesion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
			this.btnIniciarSesion.Location = new System.Drawing.Point(80, 455);
			this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
			this.btnIniciarSesion.Name = "btnIniciarSesion";
			this.btnIniciarSesion.Size = new System.Drawing.Size(440, 49);
			this.btnIniciarSesion.TabIndex = 8;
			this.btnIniciarSesion.Text = "INICIAR SESIÓN";
			this.btnIniciarSesion.UseVisualStyleBackColor = false;
			this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
			// 
			// chkMostrarContrasena
			// 
			this.chkMostrarContrasena.Font = new System.Drawing.Font("Tahoma", 8F);
			this.chkMostrarContrasena.Location = new System.Drawing.Point(80, 406);
			this.chkMostrarContrasena.Margin = new System.Windows.Forms.Padding(4);
			this.chkMostrarContrasena.Name = "chkMostrarContrasena";
			this.chkMostrarContrasena.Size = new System.Drawing.Size(173, 31);
			this.chkMostrarContrasena.TabIndex = 7;
			this.chkMostrarContrasena.Text = "Mostrar contraseña";
			this.chkMostrarContrasena.UseVisualStyleBackColor = true;
			this.chkMostrarContrasena.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena_CheckedChanged);
			// 
			// txtContrasena
			// 
			this.txtContrasena.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtContrasena.Location = new System.Drawing.Point(80, 369);
			this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(439, 28);
			this.txtContrasena.TabIndex = 6;
			this.txtContrasena.UseSystemPasswordChar = true;
			this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
			this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
			this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
			this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
			// 
			// lblContrasena
			// 
			this.lblContrasena.AutoSize = true;
			this.lblContrasena.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.lblContrasena.Location = new System.Drawing.Point(80, 338);
			this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblContrasena.Name = "lblContrasena";
			this.lblContrasena.Size = new System.Drawing.Size(93, 18);
			this.lblContrasena.TabIndex = 5;
			this.lblContrasena.Text = "Contraseña";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtUsuario.Location = new System.Drawing.Point(80, 289);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(439, 28);
			this.txtUsuario.TabIndex = 4;
			this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
			this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
			this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.lblUsuario.Location = new System.Drawing.Point(80, 258);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(66, 18);
			this.lblUsuario.TabIndex = 3;
			this.lblUsuario.Text = "Usuario";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
			this.lblSubtitulo.Location = new System.Drawing.Point(133, 197);
			this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(333, 37);
			this.lblSubtitulo.TabIndex = 2;
			this.lblSubtitulo.Text = "Inicio de Sesión";
			this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
			this.lblTitulo.Location = new System.Drawing.Point(133, 148);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(333, 49);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "SUPERCASH";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbLogo
			// 
			this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
			this.pbLogo.ImageLocation = "";
			this.pbLogo.Location = new System.Drawing.Point(246, 32);
			this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(107, 98);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
			this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 677);
			this.Controls.Add(this.pnlFondo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SuperCash - Inicio de Sesión";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.pnlFondo.ResumeLayout(false);
			this.pnlFondo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

>>>>>>> 21b8bb4b051c176eb666c7c7a6d1fcedbf3db64c
        }
    }
}