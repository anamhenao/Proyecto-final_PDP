namespace ProyectoEstupido
{
    partial class CustomMessageBox
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
            btnAceptar = new Button();
            SuspendLayout();
            
            // 
            // lblMensaje
            // 
            lblMensaje.Font = new Font("Audiowide", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); // Fuente gamer
            lblMensaje.ForeColor = Color.FromArgb(0, 200, 255); // Cian suave
            lblMensaje.Location = new Point(20, 20);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(360, 100);
            lblMensaje.TabIndex = 0;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Orbitron", 10F, FontStyle.Bold, GraphicsUnit.Point, 0); // Fuente gamer
            btnAceptar.ForeColor = Color.FromArgb(0, 255, 255); // Neón base
            btnAceptar.BackColor = Color.FromArgb(20, 20, 30); // Fondo oscuro
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
            btnAceptar.Location = new Point(130, 130);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(140, 35);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;

            // Eventos hover para btnAceptar
            btnAceptar.MouseEnter += (s, e) =>
            {
                btnAceptar.ForeColor = Color.FromArgb(0, 255, 200);      // Cian brillante
                btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
                btnAceptar.BackColor = Color.FromArgb(30, 30, 45);      // Fondo más claro
            };

            btnAceptar.MouseLeave += (s, e) =>
            {
                btnAceptar.ForeColor = Color.FromArgb(0, 255, 255);      // Neón normal
                btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
                btnAceptar.BackColor = Color.FromArgb(20, 20, 30);      // Fondo original
            };
            
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 10, 25); // Fondo muy oscuro
            ClientSize = new Size(400, 180);
            Controls.Add(lblMensaje);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensaje";
            ResumeLayout(false);
        }

        #endregion

        private Label lblMensaje;
        private Button btnAceptar;
    }
}