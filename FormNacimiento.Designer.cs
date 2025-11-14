namespace ProyectoEstupido
{
    partial class FormNacimiento
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
            btnDespues = new Button();
            btnContinuar = new Button();
            btnAntes = new Button();
            lblResultado = new Label();
            lblPregunta = new Label();
            SuspendLayout();
            // 
            // lblPregunta
            lblPregunta.AutoSize = true;
            lblPregunta.MaximumSize = new Size(600, 0); 
            lblPregunta.Left = (this.ClientSize.Width - lblPregunta.Width) / 2;
            lblPregunta.TextAlign = ContentAlignment.MiddleCenter;
            lblPregunta.Font = new Font("AudioWide", 13F, FontStyle.Bold);
            lblPregunta.ForeColor = Color.FromArgb(0, 255, 255);
            lblPregunta.Location = new Point(80, 40);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(600, 60);
            lblPregunta.TabIndex = 5;
            lblPregunta.Text = "Pregunta";

            // lblResultado
            lblResultado.AutoSize = false;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Font = new Font("AudioWide", 11F, FontStyle.Italic);
            lblResultado.ForeColor = Color.FromArgb(0, 255, 255);
            lblResultado.Location = new Point(80, 310);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(600, 40);
            lblResultado.TabIndex = 6;
            lblResultado.Text = ""; 

            // btnAntes
            btnAntes.Location = new Point(120, 170);
            btnAntes.Name = "btnAntes";
            btnAntes.Size = new Size(120, 38);
            btnAntes.TabIndex = 7;
            btnAntes.Text = "Antes";
            btnAntes.Font = new Font("Orbitron", 10F, FontStyle.Bold);
            btnAntes.BackColor = Color.FromArgb(0, 255, 255);
            btnAntes.ForeColor = Color.FromArgb(20, 20, 30);
            btnAntes.FlatStyle = FlatStyle.Flat;
            btnAntes.FlatAppearance.BorderSize = 0;
            btnAntes.Cursor = Cursors.Hand;
            btnAntes.Click += btnAntes_Click;

            // btnDespues
            btnDespues.Location = new Point(540, 170);
            btnDespues.Name = "btnDespues";
            btnDespues.Size = new Size(120, 38);
            btnDespues.TabIndex = 9;
            btnDespues.Text = "Después";
            btnDespues.Font = new Font("Orbitron", 10F, FontStyle.Bold);
            btnDespues.BackColor = Color.FromArgb(0, 255, 255);
            btnDespues.ForeColor = Color.FromArgb(20, 20, 30);
            btnDespues.FlatStyle = FlatStyle.Flat;
            btnDespues.FlatAppearance.BorderSize = 0;
            btnDespues.Cursor = Cursors.Hand;
            btnDespues.Click += btnDespues_Click;

            // btnContinuar
            btnContinuar.Location = new Point(320, 240);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(140, 40);
            btnContinuar.TabIndex = 8;
            btnContinuar.Text = "Continuar";
            btnContinuar.Font = new Font("Orbitron", 10F, FontStyle.Bold);
            btnContinuar.BackColor = Color.FromArgb(0, 255, 255);   // azul Google
            btnContinuar.ForeColor = Color.Black;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.Cursor = Cursors.Hand;
            btnContinuar.Click += btnContinuar_Click;
            // FormNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(5, 10, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDespues);
            Controls.Add(btnContinuar);
            Controls.Add(btnAntes);
            Controls.Add(lblResultado);
            Controls.Add(lblPregunta);
            Name = "FormNacimiento";
            Text = "FormNacimiento";
            Load += FormNacimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDespues;
        private Button btnContinuar;
        private Button btnAntes;
        private Label lblResultado;
        private Label lblPregunta;
    }
}