namespace ProyectoEstupido
{
    partial class FormPanelUniverso
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
            lblTitulo = new Label();
            btnArriba = new Button();
            btnDerecha = new Button();
            btnIzquierda = new Button();
            btnAbajo = new Button();
            btnResbalarPinguino = new Button();
            btnSubirPan = new Button();
            btnReiniciarUniverso = new Button();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(447, 72);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(309, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Panel de Control del Universo";
            // 
            // btnArriba
            // 
            btnArriba.Location = new Point(620, 285);
            btnArriba.Name = "btnArriba";
            btnArriba.Size = new Size(94, 29);
            btnArriba.TabIndex = 1;
            btnArriba.Text = "↑";
            btnArriba.UseVisualStyleBackColor = true;
            btnArriba.Click += btnArriba_Click;
            // 
            // btnDerecha
            // 
            btnDerecha.Location = new Point(776, 415);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(94, 29);
            btnDerecha.TabIndex = 2;
            btnDerecha.Text = "→";
            btnDerecha.UseVisualStyleBackColor = true;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(435, 415);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(94, 29);
            btnIzquierda.TabIndex = 3;
            btnIzquierda.Text = "←";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // btnAbajo
            // 
            btnAbajo.Location = new Point(620, 542);
            btnAbajo.Name = "btnAbajo";
            btnAbajo.Size = new Size(94, 29);
            btnAbajo.TabIndex = 4;
            btnAbajo.Text = "↓";
            btnAbajo.UseVisualStyleBackColor = true;
            btnAbajo.Click += btnAbajo_Click;
            // 
            // btnResbalarPinguino
            // 
            btnResbalarPinguino.Location = new Point(83, 485);
            btnResbalarPinguino.Name = "btnResbalarPinguino";
            btnResbalarPinguino.Size = new Size(249, 29);
            btnResbalarPinguino.TabIndex = 5;
            btnResbalarPinguino.Text = "Hacer que un pinguino se resbale";
            btnResbalarPinguino.UseVisualStyleBackColor = true;
            btnResbalarPinguino.Click += btnResbalarPinguino_Click;
            // 
            // btnSubirPan
            // 
            btnSubirPan.Location = new Point(83, 564);
            btnSubirPan.Name = "btnSubirPan";
            btnSubirPan.Size = new Size(151, 29);
            btnSubirPan.TabIndex = 7;
            btnSubirPan.Text = "Subir el pan";
            btnSubirPan.UseVisualStyleBackColor = true;
            btnSubirPan.Click += btnSubirPan_Click;
            // 
            // btnReiniciarUniverso
            // 
            btnReiniciarUniverso.Location = new Point(83, 658);
            btnReiniciarUniverso.Name = "btnReiniciarUniverso";
            btnReiniciarUniverso.Size = new Size(151, 29);
            btnReiniciarUniverso.TabIndex = 8;
            btnReiniciarUniverso.Text = "Reiniciar el universo";
            btnReiniciarUniverso.UseVisualStyleBackColor = true;
            btnReiniciarUniverso.Click += btnReiniciarUniverso_Click;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(464, 662);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(309, 62);
            lblEstado.TabIndex = 9;
            // 
            // FormPanelUniverso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 779);
            Controls.Add(lblEstado);
            Controls.Add(btnReiniciarUniverso);
            Controls.Add(btnSubirPan);
            Controls.Add(btnResbalarPinguino);
            Controls.Add(btnAbajo);
            Controls.Add(btnIzquierda);
            Controls.Add(btnDerecha);
            Controls.Add(btnArriba);
            Controls.Add(lblTitulo);
            Name = "FormPanelUniverso";
            Text = "FormPanelUniverso";
            Load += FormPanelUniverso_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnArriba;
        private Button btnDerecha;
        private Button btnIzquierda;
        private Button btnAbajo;
        private Button btnResbalarPinguino;
        private Button btnSubirPan;
        private Button btnReiniciarUniverso;
        private Label lblEstado;
    }
}