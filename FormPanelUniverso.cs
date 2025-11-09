using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class FormPanelUniverso : Form
    {
        private Random random = new Random();
        private bool cargando = false;


        //Constructor
        public FormPanelUniverso()
        {
            InitializeComponent();
            PosicionarAleatoriamente();
        }

        //Se ejecuta al abrir el panel
        private void FormPanelUniverso_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "🪐 Panel de Control del Universo 🪐";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Text = "El universo espera tus órdenes.";
        }


        //Botones con interacciones graciosas
        private void btnArriba_Click(object sender, EventArgs e)
        {
            int numero = random.Next(100, 999);
            if (numero % 3 == 0)
            {
                EjecutarAccionConCarga(
                    "Moviendo el universo hacia el norte...",
                    "Una estrella fugaz cruzó mientras movías el universo. Todo sigue igual."
                );
            }
            else
            {
                EjecutarAccionConCarga(
                    "Moviendo el universo hacia el norte...",
                    "El universo se movió 3.4 cm hacia arriba. Todo sigue igual."
                );
            }
        }
        private void btnAbajo_Click(object sender, EventArgs e)
        {
            int numero = random.Next(100, 999);
            if (numero % 3 == 0)
            {
                EjecutarAccionConCarga(
                    "Descendiendo el universo...",
                    "Un agujero negro se trago una roca mientras descendías el universo."
                );
            }
            else
            {
                EjecutarAccionConCarga(
                    "Descendiendo el universo...",
                    "El universo descendió 2.1 cm. Algunos átomos se quejaron."
                );
            }
        }
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            int numero = random.Next(100, 999);
            if (numero % 3 == 0)
            {
                EjecutarAccionConCarga(
                    "Girando el universo a la izquierda...",
                    "Un planeta se salio de la orbita."
                );
            }
            else
            {
                EjecutarAccionConCarga(
                    "Girando el universo a la izquierda...",
                    "El universo se inclinó 0.02°. Nadie lo notó."
                );
            }
        }
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int numero = random.Next(100, 999);
            if (numero % 3 == 0)
            {
                EjecutarAccionConCarga(
                    "Deslizando el universo a la derecha...",
                    "El universo se desplazó ligeramente y un pingüino perdió el equilibrio."
                );
            }
            else
            {
                EjecutarAccionConCarga(
                    "Deslizando el universo a la derecha...",
                    "Un meteorito choco con otro mientras deslizabas el universo."
                );
            }
        }
        private void btnResbalarPinguino_Click(object sender, EventArgs e)
        {
            int numero = random.Next(100, 999);
            if (numero % 3 == 0)
            {
                EjecutarAccionConCarga(
                    "Invocando un pingüino...",
                    "🐧 El pingüino decidio que no se iba a resbalar y se agarro de un compañero pinguino (Se resbalaron los 2)"
                );
            }
            else
            {
                EjecutarAccionConCarga(
                    "Invocando un pingüino...",
                    "🐧 El pingüino ha resbalado con elegancia. Nada de qué preocuparse."
                );
            }
        }
        private void btnSubirPan_Click(object sender, EventArgs e)
        {
            int numero = random.Next(100, 999);
            if (numero % 3 == 0)
            {
                EjecutarAccionConCarga(
                    "Subiendo el pan...",
                    "El pan ha subido con éxito."
                );
            }
            else
            {
                EjecutarAccionConCarga(
                    "Intentando subir el pan...",
                    "❌ El botón ha sido presionado demasiado recientemente. Intenta de nuevo en un rato."
                );
            }
        }
        private void btnReiniciarUniverso_Click(object sender, EventArgs e)
        {
            EjecutarAccionConCarga("Reiniciando el universo...", "❌ Error: otro usuario ya está reiniciando el universo desde otra dimensión.");
        }



        //Simula una barra de carga con protección contra múltiples clics y errores de valor
        private void EjecutarAccionConCarga(string mensajeInicial, string mensajeFinal)
        {
            if (cargando) return;
            cargando = true;

            lblEstado.Text = mensajeInicial;
            lblEstado.ForeColor = Color.Yellow;

            ProgressBar barra = new ProgressBar
            {
                Width = 200,
                Style = ProgressBarStyle.Continuous,
                Location = new Point((this.Width / 2) - 100, lblEstado.Bottom + 10),
                Maximum = 100
            };
            this.Controls.Add(barra);
            barra.BringToFront();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 50;

            timer.Tick += (s, e) =>
            {
                if (barra.Value < barra.Maximum)
                {
                    int incremento = random.Next(5, 20);
                    barra.Value = Math.Min(barra.Value + incremento, barra.Maximum);
                }
                else
                {
                    timer.Stop();
                    this.Controls.Remove(barra);
                    lblEstado.Text = mensajeFinal;
                    lblEstado.ForeColor = Color.LimeGreen;
                    cargando = false;
                }
            };

            timer.Start();
        }


        // Posiciona la ventana de forma aleatoria en la pantalla
        private void PosicionarAleatoriamente()
        {
            Random random = new Random();
            var screen = Screen.PrimaryScreen.WorkingArea;
            int randomX = random.Next(screen.Left, screen.Right - this.Width);
            int randomY = random.Next(screen.Top, screen.Bottom - this.Height);

            this.StartPosition = FormStartPosition.Manual;
            this.Left = randomX;
            this.Top = randomY;
        }
    }
}
