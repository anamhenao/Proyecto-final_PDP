using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class FormInicio : Form
    {
        private static Random random = new Random();

        //Constructor
        public FormInicio()
        {
            InitializeComponent();
            PosicionarAleatoriamente();
        }


        private void FormInicio_Load(object sender, EventArgs e)
        {
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }
        private void lblSubtitulo_Click(object sender, EventArgs e)
        {
        }


        //Abre el formulario de inicio de sesion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormInicioSesion inicioSesion = new FormInicioSesion();
            inicioSesion.Show();
            this.Hide();
        }


        //Abre un formulario con varias confirmaciones antes del registro
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormConfirmacion confirmacion = new FormConfirmacion();
            this.Enabled = false;
            confirmacion.FormClosed += (s, args) => this.Enabled = true;
            confirmacion.Show();
        }

        //Se posiciona aleatoriamente el formulario
        private void PosicionarAleatoriamente()
        {
            var screen = Screen.PrimaryScreen.WorkingArea;
            int randomX = random.Next(screen.Left, screen.Right - this.Width);
            int randomY = random.Next(screen.Top, screen.Bottom - this.Height);

            this.StartPosition = FormStartPosition.Manual;
            this.Left = randomX;
            this.Top = randomY;
        }
    }
}

