namespace ProyectoEstupido
{
    partial class FormInicio
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
            btnRegistro = new Button();
            lblSubtitulo = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitulo


            lblTitulo.Font = new Font("Orbitron", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 255, 255); // Cian neón gamer
            lblTitulo.Location = new Point(220, 70); // Leve ajuste para estética centrada gamer
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 150); // Más ancho para títulos gamer
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIENVENIDO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;

            // 
            // btnRegistro
            // 
            // Estilo base gamer
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.Font = new Font("Orbitron", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = Color.FromArgb(0, 255, 255); // Neón base
            btnRegistro.BackColor = Color.FromArgb(20, 20, 30);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.FlatAppearance.BorderSize = 2;
            btnRegistro.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

            btnRegistro.Location = new Point(85, 467);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(241, 90);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "REGISTRARSE";
            btnRegistro.UseVisualStyleBackColor = false;

            // Eventos hover
            

            btnRegistro.Click += btnRegistro_Click;

            btnRegistro.MouseEnter += (s, e) =>
            {
                btnRegistro.ForeColor = Color.FromArgb(0, 255, 200);          // Cian brillante
                btnRegistro.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
                btnRegistro.BackColor = Color.FromArgb(30, 30, 45);           // Fondo más claro al hacer hover
            };

            btnRegistro.MouseLeave += (s, e) =>
            {
                btnRegistro.ForeColor = Color.FromArgb(0, 255, 255);          // Neón normal
                btnRegistro.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
                btnRegistro.BackColor = Color.FromArgb(20, 20, 30);           // Fondo original gamer
            };


            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Audiowide", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(0, 200, 255); // Cian suave gamer
            lblSubtitulo.Location = new Point(206, 327);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(602, 89);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Crea una cuenta o inicia sesión";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitulo.Click += lblSubtitulo_Click;

            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Orbitron", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(0, 255, 255); // Neón base
            btnLogin.BackColor = Color.FromArgb(20, 20, 30);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

            btnLogin.Location = new Point(652, 467);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 90);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "INICIAR SESIÓN";
            btnLogin.UseVisualStyleBackColor = false;

            // Eventos hover
            

            
            btnLogin.Click += btnLogin_Click;

            btnLogin.MouseEnter += (s, e) =>
            {
                btnLogin.ForeColor = Color.FromArgb(0, 255, 200);          // Cian brillante
                btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
                btnLogin.BackColor = Color.FromArgb(30, 30, 45);           // Fondo más claro al hacer hover
            };

            btnLogin.MouseLeave += (s, e) =>
            {
                btnLogin.ForeColor = Color.FromArgb(0, 255, 255);          // Neón normal
                btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
                btnLogin.BackColor = Color.FromArgb(20, 20, 30);           // Fondo original gamer
            };


            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(5, 10, 25);
            ClientSize = new Size(982, 653);
            Controls.Add(btnLogin);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnRegistro);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            Load += FormInicio_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnRegistro;
        private Label lblSubtitulo;
        private Button btnLogin;
    }
}