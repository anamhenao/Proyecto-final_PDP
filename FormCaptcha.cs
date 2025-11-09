using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class FormCaptcha : Form
    {
        private string _nombreUsuario;
        private string _contraseñaUsuario;
        private bool _esNuevoUsuario;
        private int indicePregunta = 0;

        // Clase para encapsular cada pregunta y su validación
        public class PreguntaCaptcha
        {
            public string Texto { get; set; } 
            public Func<string, bool> Validacion { get; set; }
            public string MensajeError { get; set; }

            public PreguntaCaptcha(string texto, Func<string, bool> validacion, string mensajeError)
            {
                Texto = texto;
                Validacion = validacion;
                MensajeError = mensajeError;
            }
        }

        private List<PreguntaCaptcha> preguntas;

        // Constructor
        public FormCaptcha(string nombre, string contraseña, bool esNuevo)
        {
            InitializeComponent();
            PosicionarAleatoriamente();
            _nombreUsuario = nombre;
            _contraseñaUsuario = contraseña;
            _esNuevoUsuario = esNuevo;
            InicializarPreguntas();
        }



        //Muestra la primera pregunta al cargar el formulario
        private void FormCaptcha_Load(object sender, EventArgs e)
        {
            MostrarPregunta();
        }



        // Inicializa la lista de preguntas con su validación y mensaje de error
        private void InicializarPreguntas()
        {
            preguntas = new List<PreguntaCaptcha>
            {
                new PreguntaCaptcha(
                    "¿Cuántos pingüinos viste hoy?",
                    respuesta => int.TryParse(respuesta, out int n) && n >= 0,
                    "Por favor, ingresa un número válido de pingüinos."
                ),
                new PreguntaCaptcha(
                    "¿A cuánto está el kilo de papa?",
                    respuesta => double.TryParse(respuesta, out double precio) && precio >= 2000 && precio <= 4000,
                    "Eso no parece un precio válido."
                ),
                new PreguntaCaptcha(
                    "Cuánto es 15+23+91",
                    respuesta => double.TryParse(respuesta, out double res) && Math.Abs(res - (15+23+91)) < 0.001,
                    "No, esa no es la respuesta correcta."
                )
            };
        }



        // Muestra la pregunta actual
        private void MostrarPregunta()
        {
            lblResultado.Visible = false;
            lblPregunta.Text = preguntas[indicePregunta].Texto;
            txtRespuesta.Clear();
        }



        // Evento del botón enviar respuesta
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respuesta = txtRespuesta.Text.Trim();

            if (string.IsNullOrEmpty(respuesta))
            {
                MostrarResultado("¿Demasiado difícil la pregunta?", false);
                return;
            }

            // Validación específica de la pregunta actual
            var preguntaActual = preguntas[indicePregunta];

            if (preguntaActual.Validacion(respuesta))
            {
                MostrarResultado("¡Correcto!", true);
                Avanzar();
            }
            else
            {
                MostrarResultado(preguntaActual.MensajeError, false);
            }
        }


        // Muestra el resultado de la respuesta con color según éxito o error
        private void MostrarResultado(string texto, bool exito)
        {
            lblResultado.Visible = true;
            lblResultado.Text = texto;
            lblResultado.ForeColor = exito ? System.Drawing.Color.LimeGreen : System.Drawing.Color.OrangeRed;
        }


        // Avanza a la siguiente pregunta o finaliza el captcha
        private void Avanzar()
        {
            if (indicePregunta < preguntas.Count - 1)
            {
                indicePregunta++;
                MostrarPregunta();
            }
            else
            {
                if (_esNuevoUsuario)
                    GuardarUsuario(); // Guarda el usuario si es nuevo

                FormPanelUniverso fci = new FormPanelUniverso();
                fci.Show();
                this.Hide();
            }
        }

        // Guarda el usuario y contraseña en el archivo usuarios.txt
        private void GuardarUsuario()
        {
            try
            {
                string carpetaEjecutable = Application.StartupPath;
                string rutaProyecto = Path.GetFullPath(Path.Combine(carpetaEjecutable, @"..\..\.."));
                string carpetaRecursos = Path.Combine(rutaProyecto, "Recursos");
                string rutaArchivo = Path.Combine(carpetaRecursos, "usuarios.txt");

                if (!Directory.Exists(carpetaRecursos))
                    Directory.CreateDirectory(carpetaRecursos);

                if (!File.Exists(rutaArchivo))
                    File.WriteAllText(rutaArchivo, "");

                var lineas = File.ReadAllLines(rutaArchivo)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToList();

                bool existe = lineas.Any(l =>
                {
                    string[] partes = l.Split(';');
                    return partes.Length > 0 && partes[0] == _nombreUsuario;
                });

                if (!existe)
                {
                    File.AppendAllText(rutaArchivo, $"{_nombreUsuario};{_contraseñaUsuario}{Environment.NewLine}");
                    MessageBox.Show($"Usuario '{_nombreUsuario}' registrado exitosamente.",
                        "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El usuario '{_nombreUsuario}' ya está registrado. No se añadió nuevamente.",
                        "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
