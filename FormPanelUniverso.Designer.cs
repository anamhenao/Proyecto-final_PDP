namespace ProyectoEstupido
{
    partial class FormPanelUniverso
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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

            // ============================
            // FORM PROPIEDADES GENERALES
            // ============================
            this.BackColor = Color.FromArgb(5, 10, 25);
            this.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.ClientSize = new Size(1378, 779);

            this.MaximumSize = new Size(1378, 779);
            this.MinimumSize = new Size(1378, 779);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // ============================
            // TÍTULO
            // ============================
            lblTitulo = new Label();
            lblTitulo.AutoSize = false;
            lblTitulo.Width = this.ClientSize.Width;
            lblTitulo.Height = 90;
            lblTitulo.Location = new Point(0, 20);
            lblTitulo.Text = "🪐 PANEL DEL UNIVERSO 🪐";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Font = new Font("Orbitron", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(0, 255, 255);

            // ============================
            // ESTILO BOTONES PRINCIPALES (direccionales)
            // ============================
            Color baseBtn = Color.FromArgb(40, 45, 70);
            Color hoverBtn = Color.FromArgb(0, 255, 180);
            Color textoBtn = Color.White;

            Action<Button> estiloDireccion = (btn) =>
            {
                btn.BackColor = baseBtn;
                btn.ForeColor = textoBtn;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Arial Unicode MS", 26F, FontStyle.Bold, GraphicsUnit.Point); // unicode seguro para flechas
                btn.Size = new Size(100, 80);

                btn.MouseEnter += (s, e) => { btn.BackColor = hoverBtn; btn.ForeColor = Color.Black; };
                btn.MouseLeave += (s, e) => { btn.BackColor = baseBtn; btn.ForeColor = textoBtn; };
            };

            // Centro para botones direccionales
            int centroX = (this.ClientSize.Width / 2) - 50; // boton ancho 100
            int centroY = 320;

            // Arriba
            btnArriba = new Button();
            btnArriba.Location = new Point(centroX, centroY - 110);
            estiloDireccion(btnArriba);
            btnArriba.Text = "↑";
            btnArriba.Click += new EventHandler(this.btnArriba_Click);

            // Izquierda
            btnIzquierda = new Button();
            btnIzquierda.Location = new Point(centroX - 140, centroY);
            estiloDireccion(btnIzquierda);
            btnIzquierda.Text = "←";
            btnIzquierda.Click += new EventHandler(this.btnIzquierda_Click);

            // Derecha
            btnDerecha = new Button();
            btnDerecha.Location = new Point(centroX + 140, centroY);
            estiloDireccion(btnDerecha);
            btnDerecha.Text = "→";
            btnDerecha.Click += new EventHandler(this.btnDerecha_Click);

            // Abajo
            btnAbajo = new Button();
            btnAbajo.Location = new Point(centroX, centroY + 110);
            estiloDireccion(btnAbajo);
            btnAbajo.Text = "↓";
            btnAbajo.Click += new EventHandler(this.btnAbajo_Click);

            // ============================
            // ESTILO BOTONES SECUNDARIOS
            // ============================
            Action<Button> estiloSec = (btn) =>
            {
                btn.BackColor = Color.FromArgb(60, 70, 100);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Orbitron", 12F, FontStyle.Bold, GraphicsUnit.Point);
                btn.Size = new Size(220, 44);

                btn.MouseEnter += (s, e) => { btn.BackColor = Color.FromArgb(0, 200, 255); btn.ForeColor = Color.Black; };
                btn.MouseLeave += (s, e) => { btn.BackColor = Color.FromArgb(60, 70, 100); btn.ForeColor = Color.White; };
            };

            // ============================
            // BOTONES SECUNDARIOS
            // ============================
            btnResbalarPinguino = new Button();
            btnResbalarPinguino.Location = new Point(80, 500);
            estiloSec(btnResbalarPinguino);
            btnResbalarPinguino.Text = "Resbalar Pingüino";
            btnResbalarPinguino.Click += new EventHandler(this.btnResbalarPinguino_Click);

            btnSubirPan = new Button();
            btnSubirPan.Location = new Point(80, 560);
            estiloSec(btnSubirPan);
            btnSubirPan.Text = "Subir Pan";
            btnSubirPan.Click += new EventHandler(this.btnSubirPan_Click);

            btnReiniciarUniverso = new Button();
            btnReiniciarUniverso.Location = new Point(80, 620);
            estiloSec(btnReiniciarUniverso);
            btnReiniciarUniverso.Text = "Reiniciar Universo";
            btnReiniciarUniverso.Click += new EventHandler(this.btnReiniciarUniverso_Click);

            // ============================
            // ESTADO (ABAJO CENTRADO)
            // ============================
            lblEstado = new Label();
            lblEstado.AutoSize = false;
            lblEstado.Width = this.ClientSize.Width;
            lblEstado.Height = 48;
            lblEstado.Location = new Point(0, this.ClientSize.Height - 70);
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Font = new Font("Audiowide", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.White;
            lblEstado.Text = "El universo espera tus órdenes.";

            // ============================
            // AGREGAR CONTROLES AL FORM
            // ============================
            Controls.Add(lblEstado);
            Controls.Add(btnReiniciarUniverso);
            Controls.Add(btnSubirPan);
            Controls.Add(btnResbalarPinguino);

            Controls.Add(btnArriba);
            Controls.Add(btnIzquierda);
            Controls.Add(btnDerecha);
            Controls.Add(btnAbajo);

            Controls.Add(lblTitulo);

            this.Name = "FormPanelUniverso";
            this.Text = "Panel del Universo";
            this.Load += new EventHandler(this.FormPanelUniverso_Load);

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
