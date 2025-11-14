using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class FormContrasena : Form
    {
        private string nombreUsuario;

        //Constructor
        public FormContrasena(string nombre)
        {
            InitializeComponent();
            PosicionarAleatoriamente();
            nombreUsuario = nombre;
        }


        private void FormContrasena_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = $"Bienvenido, {nombreUsuario}. Ahora elige una contraseña";
            lblResultado.Visible = false;
        }


        //Se valida que la contraseña cumpla algunos requisitos
        //y en caso de que si, abre el siguiente formulario
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string contraseña2 = txtContrasena2.Text.Trim();

            //Muestra el mensaje si no se cumplio alguna condicion
            void MostrarMensaje(string texto)
            {
                lblResultado.Text = texto;
                lblResultado.Visible = true;
            }




            // Validaciones Estupidas
            if (contraseña2.Length < 6)
            {
                MostrarMensaje("Demasiado corta. No confiamos en contraseñas con menos de 6 caracteres.");
                return;
            }

            if (!contraseña2.Any(c => "aeiouAEIOU".Contains(c)))
            {
                MostrarMensaje("Tu contraseña no tiene ni una vocal. ¿Eres un robot sin alma?");
                return;
            }

            if (!contraseña2.Any(c => c == '2' || c == '3' || c == '5' || c == '7'))
            {
                MostrarMensaje("Debe contener un número primo menor a 10");
                return;
            }

            if (contraseña2.ToLower().Contains("contraseña"))
            {
                MostrarMensaje("Ingenioso... pero no puedes usar literalmente la palabra 'contraseña'.");
                return;
            }

            if (contraseña2.All(char.IsLetterOrDigit))
            {
                MostrarMensaje("Que contraseña tan débil, no tiene ni un dígito especial Prueba con un @ o un #.");
                return;
            }

            if (contraseña2.StartsWith(nombreUsuario, StringComparison.OrdinalIgnoreCase))
            {
                MostrarMensaje("¿En serio usaste tu nombre al inicio? Eso es trampa y flojera combinadas.");
                return;
            }

            if (char.IsDigit(contraseña2.Last()))
            {
                MostrarMensaje("Terminar con un número es demasiado predecible. Sé más original.");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(contraseña2, @"(.)\1\1"))
            {
                MostrarMensaje("Tres caracteres iguales seguidos, sospechoso");
                return;
            }

            string invertida = new string(contraseña2.Reverse().ToArray());
            if (contraseña2.Equals(invertida, StringComparison.OrdinalIgnoreCase))
            {
                MostrarMensaje("¿Una contraseña palíndroma? Muy poético, pero no muy seguro.");
                return;
            }

            if (!contraseña2.Any(c => "ñÑwWkKzZ".Contains(c)))
            {
                MostrarMensaje("Tu contraseña carece de personalidad. Usa una letra exótica, como una ñ o una z.");
                return;
            }





            MostrarMensaje($"Sorprendente, {nombreUsuario}. Tu haz creado una contraseña robusta");

            //Abre el siguiente formulario
            FormNacimiento formNacimiento = new FormNacimiento(nombreUsuario, contraseña2);
            this.Enabled = false;
            formNacimiento.FormClosed += (s, args) => this.Enabled = true;
            formNacimiento.Show();
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
