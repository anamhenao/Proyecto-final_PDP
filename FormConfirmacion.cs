using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class FormConfirmacion : Form
    {

        private int pasoActual;
        private static Random random = new Random();

        //Lista de mensajes para mostrar al usuario
        private List<string> mensajes = new List<string>
        {
            "Ha presionado el boton de registrarse, ¿Desea continuar?",
            "Una vez registrado no se puede eliminar el usuario",
            "Última advertencia. ¿Desea proceder?",
            "No hay vuelta atrás...",
            "¿Seguro? Esto creará un nuevo usuario"
        };

        //Constructor
        public FormConfirmacion(int paso = 0)
        {
            InitializeComponent();
            pasoActual = paso;
            MostrarMensajeActual();
            PosicionarAleatoriamente();
            this.Opacity = 0;
            this.Load += (s, e) => IniciarFadeIn();
        }


        private void FormConfirmacion_Load(object sender, EventArgs e)
        {
        }

        //Añade un efecto de fade in a cada ventana
        private void IniciarFadeIn()
        {
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 30;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                }
            };
            fadeTimer.Start();
        }

        //Muestra el mensaje que se añadio en la lista previamente
        private void MostrarMensajeActual()
        {
            lblMensaje.Text = mensajes[pasoActual];
        }

        //Posiciona aleatoriamente el formulario
        private void PosicionarAleatoriamente()
        {
            var screen = Screen.PrimaryScreen.WorkingArea;
            int randomX = random.Next(screen.Left, screen.Right - this.Width);
            int randomY = random.Next(screen.Top, screen.Bottom - this.Height);

            this.StartPosition = FormStartPosition.Manual;
            this.Left = randomX;
            this.Top = randomY;
        }


        //Abre la siguiente confirmacion en caso de que haya uno
        //si no hay mas mensajes pasa al siguiente formulario
        private void btnSi_Click(object sender, EventArgs e)
        {
            if (pasoActual < mensajes.Count - 1)
            {
                FormConfirmacion siguiente = new FormConfirmacion(pasoActual + 1);
                this.Enabled = false;
                siguiente.FormClosed += (s, args) => this.Enabled = true;
                siguiente.Show();
            }
            else
            {
                FormUsuario formUsuario = new FormUsuario();
                this.Enabled = false;
                formUsuario.FormClosed += (s, args) => this.Enabled = true;
                formUsuario.Show();
            }
        }


        //Si se presiona "No" se se devuelve al mensaje anterior hasta que vuelva al primer mensaje
        //si vuelve a presionar no, regresa al formulario inicial
        private void btnNo_Click(object sender, EventArgs e)
        {
            if (pasoActual > 0)
            {
                FormConfirmacion anterior = new FormConfirmacion(pasoActual - 1);
                this.Enabled = false;
                anterior.FormClosed += (s, args) => this.Enabled = true;
                anterior.Show();
            }
            else
            {
                CustomMessageBox.Mostrar("Sabia decisión");

                this.Close();
            }
        }
    }
}
