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
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(408, 109);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingresa tus credenciales";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(357, 391);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(262, 29);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(357, 238);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '*';
            txtUsuario.Size = new Size(262, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(357, 280);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(83, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(357, 198);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(357, 303);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(262, 27);
            txtContrasena.TabIndex = 5;
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 581);
            Controls.Add(txtContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblContrasena);
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
    }
}