using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoEstupido
{
    public partial class FormNacimiento : Form
    {
        private string _nombreUsuario;
        private string _contraseña;
        private DateTime fechaMin;
        private DateTime fechaMax;
        private DateTime fechaActual;
        private static Random random = new Random();

        //Constructor
        public FormNacimiento(string nombre, string contraseña)
        {
            _nombreUsuario = nombre;
            _contraseña = contraseña;
            InitializeComponent();
            PosicionarAleatoriamente();
            fechaMin = new DateTime(1900, 1, 1);
            fechaMax = new DateTime(2025, 12, 31);
        }
        
        //Al cargar el formulario crea una nueva fecha
        private void FormNacimiento_Load(object sender, EventArgs e)
        {
                GenerarNuevaFecha();
        }


        //Genera una fecha aleatoria entre un rango establecido
        private void GenerarNuevaFecha()
        {
            long ticksMin = fechaMin.Ticks;
            long ticksMax = fechaMax.Ticks;

            long randomTicks = ticksMin + (long)(random.NextDouble() * (ticksMax - ticksMin));
            fechaActual = new DateTime(randomTicks);

            lblPregunta.Text = $"¿Naciste antes o después del {fechaActual:dd 'de' MMMM 'de' yyyy}?";
        }

        //Para elegir una fecha anterior
        private void btnAntes_Click(object sender, EventArgs e)
        {
            fechaMax = fechaActual;
            VerificarRango();
        }

        //Para elegir una fecha posterior
        private void btnDespues_Click(object sender, EventArgs e)
        {
            fechaMin = fechaActual;
            VerificarRango();
        }


        //Si la fecha ya se adivino se puede presionar continuar para seguir con el captcha
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Finalizar(fechaActual);
        }


        //Verifica si ya se adivino la fecha, sino se genera una nueva
        private void VerificarRango()
        {
            // Si el rango se vuelve muy pequeño, ya se “adivina” la fecha
            if ((fechaMax - fechaMin).TotalDays <= 1)
            {
                Finalizar(fechaMin.AddDays(1));
            }
            else
            {
                GenerarNuevaFecha();
            }
        }


        //Al tener la fecha se muestra en pantalla y se abre el siguiente formulario
        private void Finalizar(DateTime fecha)
        {
            lblResultado.Visible = true;
            lblResultado.Text = $"Fecha estimada: {fecha:dd 'de' MMMM 'de' yyyy}.";

            lblPregunta.Visible = false;
            btnAntes.Enabled = false;
            btnDespues.Enabled = false;
            btnContinuar.Enabled = false;


            //Abre el siguiente formulario con un pequeño retraso
            System.Windows.Forms.Timer delay = new System.Windows.Forms.Timer();
            delay.Interval = 2000; 
            delay.Tick += (s, e) =>
            {
                delay.Stop();
                delay.Dispose();

                this.Enabled = false;
                FormCaptcha captcha = new FormCaptcha(_nombreUsuario, _contraseña, true);
                captcha.Show();
            };
            delay.Start();
        }

        //Posiciona aleatoriamente el formulario
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
