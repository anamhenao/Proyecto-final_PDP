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
            txtContrasena = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(163, 77);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "label1";
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(609, 216);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 29);
            btnContinuar.TabIndex = 1;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnAceptar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(64, 218);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(408, 27);
            txtContrasena.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(172, 329);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // FormContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtContrasena);
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
        private TextBox txtContrasena;
        private Label lblResultado;
    }
}