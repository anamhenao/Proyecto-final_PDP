namespace ProyectoEstupido
{
    partial class FormConfirmacion
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
            btnSi = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
                // ===== FORM =====
            BackColor = Color.FromArgb(15, 15, 25);
            ClientSize = new Size(500, 250);
            Font = new Font("Segoe UI", 10);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirmación";
            MaximizeBox = false;
            MinimizeBox = false;

            // ===== LABEL MENSAJE =====
            lblMensaje.AutoSize = false;
            lblMensaje.Font = new Font("AudioWide", 14, FontStyle.Bold);
            lblMensaje.ForeColor = Color.FromArgb(0, 255, 255);
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Location = new Point(40, 40);
            lblMensaje.Size = new Size(420, 60);
            lblMensaje.Text = "¿Deseas continuar?";

            // ===== BOTÓN SÍ =====
            btnSi.Font = new Font("Orbitron", 12, FontStyle.Bold);
            btnSi.BackColor = Color.FromArgb(20, 20, 30);
            btnSi.ForeColor = Color.FromArgb(0, 255, 255);
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
            btnSi.FlatAppearance.BorderSize = 2;
            btnSi.Location = new Point(85, 150);
            btnSi.Size = new Size(130, 40);
            btnSi.Text = "SÍ";
            btnSi.Cursor = Cursors.Hand;

            btnSi.MouseEnter += (s, e) =>
            {
                btnSi.ForeColor = Color.FromArgb(0, 255, 180);
                btnSi.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 180);
            };

            btnSi.MouseLeave += (s, e) =>
            {
                btnSi.ForeColor = Color.FromArgb(0, 255, 255);
                btnSi.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
            };

            btnSi.Click += btnSi_Click;


            // ===== BOTÓN NO =====
            btnNo.Font = new Font("Orbitron", 12, FontStyle.Bold);
            btnNo.BackColor = Color.FromArgb(20, 20, 30);
            btnNo.ForeColor = Color.FromArgb(255, 80, 80);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 80);
            btnNo.FlatAppearance.BorderSize = 2;
            btnNo.Location = new Point(285, 150);
            btnNo.Size = new Size(130, 40);
            btnNo.Text = "NO";
            btnNo.Cursor = Cursors.Hand;

            btnNo.MouseEnter += (s, e) =>
            {
                btnNo.ForeColor = Color.FromArgb(255, 120, 120);
                btnNo.FlatAppearance.BorderColor = Color.FromArgb(255, 120, 120);
            };

            btnNo.MouseLeave += (s, e) =>
            {
                btnNo.ForeColor = Color.FromArgb(255, 80, 80);
                btnNo.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 80);
            };

            btnNo.Click += btnNo_Click;

            // 
            // FormConfirmacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 293);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblMensaje);
            Name = "FormConfirmacion";
            Load += FormConfirmacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnSi;
        private Button btnNo;
    }
}