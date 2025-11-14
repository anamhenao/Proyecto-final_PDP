using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class FormUsuario : Form
    {

        //Constructor
        public FormUsuario()
        {
            InitializeComponent();
            PosicionarAleatoriamente();
        }


        //Hace verificaciones estupidas para el nombre, en caso de que pase todas
        //abre el formulario de contraseña
        private void btnContinuar_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            string nombre = txtNombre.Text.Trim();

            //Se elige uno de los mensajes de forma aleatoria
            void MostrarMensajeAleatorio(string[] opciones)
            {
                int index = random.Next(opciones.Length);
                MostrarMensaje(opciones[index]);
            }


            //Lista de condiciones para el nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MostrarMensajeAleatorio(new[]
                {
            "¿Por favor ingresa algo.",
            "Al menos inventa un nombre.",
            "Esto no es un campo opcional."
        });
            }
            else if (nombre.Length < 3)
            {
                MostrarMensajeAleatorio(new[]
                {
            "¿Tan corto? Eso suena como un apodo de emergencia.",
            "Tan pocas letras no bastan para definir tu existencia.",
            "Muy corto. Escribe algo más decente."
        });
            }
            else if (nombre.Length > 9)
            {
                MostrarMensajeAleatorio(new[]
                {
            "Demasiado largo. No estamos escribiendo una saga épica.",
            "Tu nombre no necesita tener capítulos, reduce un poco.",
            "Eso no es un nombre, es un ensayo."
        });
            }
            else if (nombre.Any(char.IsDigit))
            {
                MostrarMensajeAleatorio(new[]
                {
            "¿Números? escribe un nombre real.",
            "Los humanos no suelen tener dígitos en sus nombres.",
            "Si querías poner tu contraseña, lo estás haciendo mal."
        });
            }
            else if (nombre.Any(c => !char.IsLetter(c)))
            {
                MostrarMensajeAleatorio(new[]
                {
            "Símbolos, espacios o signos... no gracias.",
            "Eso parece una contraseña, no un nombre.",
            "No me pongas cosas raras, usa solo letras."
        });
            }
            else if (nombre.All(char.IsUpper))
            {
                MostrarMensajeAleatorio(new[]
                {
            "¿GRITAS TU NOMBRE? No hace falta tanta energía.",
            "Baja la voz, que esto no es un estadio.",
            "Escribe como una persona civilizada, sin gritar."
        });
            }
            else if (nombre.All(char.IsLower))
            {
                MostrarMensajeAleatorio(new[]
                {
            "¿Todo en minúscula? Al menos una mayúscula por educación.",
            "No te cuesta nada usar una mayúscula inicial, vamos.",
            "Parece que el Shift te tiene miedo usa al menos una mayúscula."
        });
            }
            else if (nombre.Distinct().Count() <= 3)
            {
                MostrarMensajeAleatorio(new[]
                {
            "Eso suena más a glitch que a nombre.",
            "Demasiadas letras repetidas, me suena sospechoso.",
            "Usa más variedad, no uses siempre las mismas letras"
        });
            }
            else if (nombre.Length >= 4 && nombre.Count(char.IsUpper) > 2)
            {
                MostrarMensajeAleatorio(new[]
                {
            "¿Tantas mayúsculas? No estamos en una placa conmemorativa.",
            "Haz usado demasiadas mayúsculas.",
            "Demasiada mayusculas para un simple nombre."
        });
            }
            else if (nombre.Any(c => "xyzXYZqQ".Contains(c)))
            {
                MostrarMensajeAleatorio(new[]
                {
            "Eso suena inventado. ¿Quién usa una 'x', 'y' o 'z' en su nombre?",
            "Demasiado cyberpunk para mi gusto."
        });
            }
            else
            {
                MostrarMensaje("suena suficientemente creíble. Aceptado (por ahora)");

                // 🔹 Abrir el siguiente formulario: FormContraseña
                FormContrasena formContraseña = new FormContrasena(nombre);
                this.Enabled = false;
                formContraseña.FormClosed += (s, args) => this.Enabled = true;
                formContraseña.Show();
            }
        }
        
        //Muestra el mensaje de error
        private void MostrarMensaje(string texto)
        {
            lblResultado.Text = texto;
            if (!lblResultado.Visible)
                 lblResultado.Visible = true;
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


        private void FormUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
