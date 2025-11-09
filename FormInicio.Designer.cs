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
            // 
            lblTitulo.Font = new Font("Sans Serif Collection", 34.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(269, 89);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(446, 130);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(85, 467);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(241, 90);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Sans Serif Collection", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(206, 327);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(602, 89);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Crea una cuenta o inicia session";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(652, 467);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 90);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Iniciar Session";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
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