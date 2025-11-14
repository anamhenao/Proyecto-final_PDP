namespace ProyectoEstupido
{
    partial class FormUsuario
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
            lblInstruccion = new Label();
            txtNombre = new TextBox();
            btnContinuar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            
            // ======== FORM ========
            this.BackColor = Color.FromArgb(5, 10, 25);   // Fondo oscuro elegante
            this.ClientSize = new Size(800, 450);

            // ======== INSTRUCCIÓN ========
            lblInstruccion.AutoSize = false;
            lblInstruccion.Location = new Point(100, 40);
            lblInstruccion.Size = new Size(600, 80);
            lblInstruccion.Font = new Font("AudioWide", 20F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(0, 255, 255);
            lblInstruccion.TextAlign = ContentAlignment.MiddleCenter;
            lblInstruccion.Text = "Por favor ingresa un nombre de usuario";

            // ======== TXT NOMBRE ========
            txtNombre.Location = new Point(80, 200);
            txtNombre.Size = new Size(500, 35);
            txtNombre.Font = new Font("Audiowide", 12F, FontStyle.Regular);
            txtNombre.BackColor = Color.FromArgb(30, 35, 55);
            txtNombre.ForeColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;

            // ======== BOTÓN CONTINUAR ========
            btnContinuar.Location = new Point(600, 200);
            btnContinuar.Size = new Size(120, 40);
            btnContinuar.Font = new Font("Orbitron", 12F, FontStyle.Bold);
            btnContinuar.ForeColor = Color.Black;
            btnContinuar.BackColor = Color.FromArgb(20, 20, 30);
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.Text = "Continuar";

            // Eventos
            btnContinuar.Click += btnContinuar_Click;

            btnContinuar.MouseEnter += (s, e) =>
            {
                btnContinuar.BackColor = Color.FromArgb(0, 255, 255);
            };

            btnContinuar.MouseLeave += (s, e) =>
            {
                btnContinuar.BackColor = Color.FromArgb(0, 255, 180);
            };

            // ======== RESULTADO ========
            lblResultado.AutoSize = true;
            lblResultado.MaximumSize = new Size(600, 0); 
            lblResultado.Location = new Point(100, 300);
            lblResultado.Size = new Size(600, 50);
            lblResultado.Font = new Font("AudioWide", 14F, FontStyle.Bold);
            lblResultado.ForeColor = Color.White;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Visible = false;


            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnContinuar);
            Controls.Add(txtNombre);
            Controls.Add(lblInstruccion);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruccion;
        private TextBox txtNombre;
        private Button btnContinuar;
        private Label lblResultado;
    }
}