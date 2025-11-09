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
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(609, 203);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(87, 203);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(465, 27);
            txtRespuesta.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(217, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 20);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Responde las preguntas para verificar que no eres un robot";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(356, 108);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(0, 20);
            lblPregunta.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(244, 317);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label2";
            lblResultado.Visible = false;
            // 
            // FormCaptcha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(lblPregunta);
            Controls.Add(lblTitulo);
            Controls.Add(txtRespuesta);
            Controls.Add(btnEnviar);
            Name = "FormCaptcha";
            Text = "FormCaptcha";
            Load += FormCaptcha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtRespuesta;
        private Label lblTitulo;
        private Label lblPregunta;
        private Label lblResultado;
    }
}