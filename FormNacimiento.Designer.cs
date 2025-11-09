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
            // btnDespues
            // 
            btnDespues.Location = new Point(568, 159);
            btnDespues.Name = "btnDespues";
            btnDespues.Size = new Size(94, 29);
            btnDespues.TabIndex = 9;
            btnDespues.Text = "Despues";
            btnDespues.UseVisualStyleBackColor = true;
            btnDespues.Click += btnDespues_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(347, 244);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 29);
            btnContinuar.TabIndex = 8;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnAntes
            // 
            btnAntes.Location = new Point(139, 196);
            btnAntes.Name = "btnAntes";
            btnAntes.Size = new Size(94, 29);
            btnAntes.TabIndex = 7;
            btnAntes.Text = "Antes";
            btnAntes.UseVisualStyleBackColor = true;
            btnAntes.Click += btnAntes_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(357, 356);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "label2";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(357, 75);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(50, 20);
            lblPregunta.TabIndex = 5;
            lblPregunta.Text = "label1";
            // 
            // FormNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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