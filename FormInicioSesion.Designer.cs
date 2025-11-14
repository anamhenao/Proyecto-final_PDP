namespace ProyectoEstupido
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnIniciarSesion = new Button();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            lblUsuario = new Label();
            txtContrasena = new TextBox();
            btnVerContrasena = new Button();
            SuspendLayout();
            
                        // ======== FONDO DEL FORMULARIO ========
            this.BackColor = Color.FromArgb(5, 10, 25); // Fondo gamer profundo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // ======== TÍTULO ========
            lblTitulo.Font = new Font("Orbitron", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 255, 255);
            lblTitulo.Location = new Point(250, 60);
            lblTitulo.Size = new Size(480, 50);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Text = "INGRESA TUS CREDENCIALES";

            // ======== LABEL USUARIO ========
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(180, 200, 255);
            lblUsuario.Location = new Point(330, 160);
            lblUsuario.Text = "USUARIO";

            // ======== TEXTBOX USUARIO ========
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.BackColor = Color.FromArgb(20, 25, 40);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(330, 190);
            txtUsuario.Size = new Size(300, 32);
            txtUsuario.PasswordChar = '\0'; // Mostrar texto normal

            // ======== LABEL CONTRASEÑA ========
            lblContrasena.AutoSize = false;
            lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.FromArgb(180, 200, 255);
            lblContrasena.Location = new Point(330, 245);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(300, 28); // ancho suficiente para "CONTRASEÑA"
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "CONTRASEÑA"; // asegúrate de que el archivo esté en UTF-8 si la ñ falla
            lblContrasena.TextAlign = ContentAlignment.MiddleLeft;


            // ======== TEXTBOX CONTRASEÑA ========
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.BackColor = Color.FromArgb(20, 25, 40);
            txtContrasena.ForeColor = Color.White;
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Location = new Point(330, 275);
            txtContrasena.Size = new Size(300, 32);
            txtContrasena.PasswordChar = '*';
            

            // ======== BOTÓN VER CONTRASEÑA ========
            btnVerContrasena.Size = new Size(34, 28);
            btnVerContrasena.FlatStyle = FlatStyle.Flat;
            btnVerContrasena.FlatAppearance.BorderSize = 0;
            btnVerContrasena.Cursor = Cursors.Hand;
            

            // ICONO INICIAL (IMPORTANTE PARA QUE SEA VISIBLE)
            btnVerContrasena.Text = "👁";     
            btnVerContrasena.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Regular);

            // posición
            int paddingRight = 6;
            btnVerContrasena.Location = new Point(
                txtContrasena.Location.X + txtContrasena.Width - btnVerContrasena.Width - paddingRight,
                txtContrasena.Location.Y + (txtContrasena.Height - btnVerContrasena.Height) / 2
            );

            btnVerContrasena.BackColor = txtContrasena.BackColor;
            btnVerContrasena.ForeColor = Color.White;

            btnVerContrasena.Click += btnVerContrasena_Click;


            // ======== BOTÓN INICIAR SESIÓN ========
            btnIniciarSesion.Font = new Font("Orbitron", 14F, FontStyle.Bold);
            btnIniciarSesion.ForeColor = Color.FromArgb(0, 255, 255);
            btnIniciarSesion.BackColor = Color.FromArgb(20, 20, 30);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.FlatAppearance.BorderSize = 2;
            btnIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
            btnIniciarSesion.Location = new Point(330, 360);
            btnIniciarSesion.Size = new Size(300, 55);
            btnIniciarSesion.Text = "INICIAR SESIÓN";

            // Hover Effects
            btnIniciarSesion.MouseEnter += (s, e) =>
            {
                btnIniciarSesion.ForeColor = Color.FromArgb(0, 255, 180);
                btnIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 180);
                btnIniciarSesion.BackColor = Color.FromArgb(30, 30, 45);
            };

            btnIniciarSesion.MouseLeave += (s, e) =>
            {
                btnIniciarSesion.ForeColor = Color.FromArgb(0, 255, 255);
                btnIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
                btnIniciarSesion.BackColor = Color.FromArgb(20, 20, 30);
            };

            btnIniciarSesion.Click += btnIniciarSesion_Click;

            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 581);
            Controls.Add(txtContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(btnVerContrasena);
            btnVerContrasena.BringToFront();
            Controls.Add(txtUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblTitulo);
            Name = "FormInicioSesion";
            Text = "FormInicioSesion";
            Load += FormInicioSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnIniciarSesion;
        private TextBox txtUsuario;
        private Label lblContrasena;
        private Label lblUsuario;
        private TextBox txtContrasena;

        private Button btnVerContrasena;
    }
}