namespace ProyectoEstupido
{
    partial class FormCaptcha
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

            btnEnviar = new Button();
            txtRespuesta = new TextBox();
            lblTitulo = new Label();
            lblPregunta = new Label();
            lblResultado = new Label();

            SuspendLayout();

            // ==== FORM ====
            BackColor = Color.FromArgb(15, 15, 25); 
            ClientSize = new Size(700, 400);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificación Humana";

            // ==== TÍTULO ====

            lblTitulo.Font = new Font("Orbitron", 16, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 255, 255); // Cian neón gamer
            lblTitulo.Location = new Point(75, 40);            
            lblTitulo.AutoSize = true;
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "No respondas si no eres un humano";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // ==== PREGUNTA ====
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("AudioWide", 14, FontStyle.Regular);
            lblPregunta.ForeColor = Color.White;
            lblPregunta.Location = new Point(75, 120);

            // ==== TEXTBOX RESPUESTA ====
            txtRespuesta.Font = new Font("Segoe UI", 12);
            txtRespuesta.BackColor = Color.FromArgb(25, 25, 35);
            txtRespuesta.ForeColor = Color.White;
            txtRespuesta.BorderStyle = BorderStyle.FixedSingle;
            txtRespuesta.Location = new Point(75, 170);
            txtRespuesta.Size = new Size(350, 35);

            // ==== BOTÓN ENVIAR ====
            btnEnviar.Font = new Font("Orbitron", 12, FontStyle.Bold);
            btnEnviar.BackColor = Color.FromArgb(20, 20, 30);
            btnEnviar.ForeColor = Color.FromArgb(0, 255, 255);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
            btnEnviar.FlatAppearance.BorderSize = 2;

            btnEnviar.Location = new Point(450, 170);
            btnEnviar.Size = new Size(130, 40);
            btnEnviar.Text = "VALIDAR";
            btnEnviar.Cursor = Cursors.Hand;

            btnEnviar.MouseEnter += (s, e) =>
            {
                btnEnviar.ForeColor = Color.FromArgb(0, 255, 180);
                btnEnviar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
                btnEnviar.BackColor = Color.FromArgb(30, 30, 45);
            };

            btnEnviar.MouseLeave += (s, e) =>
            {
                btnEnviar.ForeColor = Color.FromArgb(0, 255, 255);
                btnEnviar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
                btnEnviar.BackColor = Color.FromArgb(20, 20,30 );
            };

            btnEnviar.Click += btnEnviar_Click;

            // ==== RESULTADO ====
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Orbitron", 12, FontStyle.Bold);
            lblResultado.ForeColor = Color.FromArgb(0, 255, 180);
            lblResultado.Location = new Point(75, 260);
            lblResultado.Visible = false;

            // ==== ADD CONTROLS ====
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblPregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(btnEnviar);
            Controls.Add(lblResultado);
            Name = "FormCaptcha";
            Text = "FormCaptcha";
            Load += FormCaptcha_Load;
            ResumeLayout(false);
            PerformLayout();


            // 
            // FormCaptcha
            //
  
  
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtRespuesta;
        private Label lblTitulo;
        private Label lblPregunta;
        private Label lblResultado;
    }
}