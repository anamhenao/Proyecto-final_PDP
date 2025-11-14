namespace ProyectoEstupido
{
    partial class FormContrasena
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
            lblMensaje = new Label();
            btnContinuar = new Button();
            txtContrasena2 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblMensaje
            lblMensaje.AutoSize = false;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Font = new Font("AudioWide", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.FromArgb(0, 255, 255);
            lblMensaje.Location = new Point(50, 40);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(600, 60);   // ancho amplio para texto centrado
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Mensaje";

            // txtContrasena
            txtContrasena2.Location = new Point(50, 140);
            txtContrasena2.Name = "txtContrasena";
            txtContrasena2.Size = new Size(500, 30);
            txtContrasena2.Font = new Font("Audiowide", 11F);
            txtContrasena2.TabIndex = 2;

            // btnContinuar
            btnContinuar.Location = new Point(580, 138);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(120, 33);
            btnContinuar.Font = new Font("Orbitron", 10F, FontStyle.Bold);
            btnContinuar.BackColor = Color.FromArgb(0, 255, 255);
            btnContinuar.ForeColor = Color.Black;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.TabIndex = 1;
            btnContinuar.Text = "Continuar";
            btnContinuar.Click += btnAceptar_Click;

            // lblResultado
            lblResultado.AutoSize = true;
            lblResultado.MaximumSize = new Size(600, 0); 
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Font = new Font("AudioWide", 10F, FontStyle.Italic);
            lblResultado.ForeColor = Color.FromArgb(0, 255, 255);
            lblResultado.Location = new Point(50, 220);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(600, 40);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "";

            // FormContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(5, 10, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtContrasena2);
            Controls.Add(btnContinuar);
            Controls.Add(lblMensaje);
            Name = "FormContrasena";
            Text = "FormContrasena";
            Load += FormContrasena_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnContinuar;
        private TextBox txtContrasena2;
        private Label lblResultado;
    }
}