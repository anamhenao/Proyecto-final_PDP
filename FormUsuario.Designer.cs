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
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(280, 95);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(266, 20);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Por favor ingresa tu nombre de usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(62, 221);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(446, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(569, 221);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 29);
            btnContinuar.TabIndex = 2;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(139, 319);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
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