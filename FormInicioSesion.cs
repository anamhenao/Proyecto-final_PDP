using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class FormInicioSesion : Form
    {
        private string rutaArchivo;

        //Constructor
        public FormInicioSesion()
        {
            InitializeComponent();
            PosicionarAleatoriamente();
            string carpetaEjecutable = Application.StartupPath;
            string rutaProyecto = Path.GetFullPath(Path.Combine(carpetaEjecutable, @"..\..\.."));
            string carpetaRecursos = Path.Combine(rutaProyecto, "Recursos");
            rutaArchivo = Path.Combine(carpetaRecursos, "usuarios.txt");
            PrepararArchivo();
        }

        //Si el archivo para guardar los usuarios no existe, lo crea
        private void PrepararArchivo()
        {
            if (!File.Exists(rutaArchivo))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));
                File.WriteAllText(rutaArchivo, "");
            }
        }


        //Se ejecuta al abrir el formulario
        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "✨ Bienvenido al Universo ✨";
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
        }

        //Evento para el boton de ver contraseña
       private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            // protección básica
            if (txtContrasena == null) return;

            // asegúrate de que el TextBox tenga un PasswordChar inicial en el designer:
            // txtContrasena.PasswordChar = '*';

            // Alternar usando PasswordChar ('\0' = sin máscara)
            if (txtContrasena.PasswordChar == '\0' || txtContrasena.PasswordChar == '\u0000')
            {
                // actualmente visible -> ocultar con '*'
                txtContrasena.PasswordChar = '*';
                btnVerContrasena.Text = "👁"; // o "Ver"
            }
            else
            {
                // actualmente oculto -> mostrar
                txtContrasena.PasswordChar = '\0';
                btnVerContrasena.Text = "🙈"; // o "Ocultar"
            }
        }


        //Evento para el boton de inicio de sesion
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            //Se asegura de que el usuario ingrese valores
            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("¿Vacío? Debes ingresar tus credenciales", "Error");
                return;
            }

            bool usuarioEncontrado = false;
            bool contrasenaCorrecta = false;

            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var linea in lineas)
            {
                var partes = linea.Split(';');
                if (partes.Length == 2 && partes[0] == usuario)
                {
                    usuarioEncontrado = true;
                    if (partes[1] == contrasena)
                        contrasenaCorrecta = true;
                    break;
                }
            }

            
            //Si se encontro el usuario se abre el formulario captcha
            if (usuarioEncontrado && contrasenaCorrecta)
            {
                CustomMessageBox.Mostrar("Identidad confirmada, por favor verifique que es un humano " );
                FormCaptcha captcha = new FormCaptcha(usuario, contrasena, false);
                captcha.Show();
                this.Hide();
            }

            //Si no se encontro el usuario se le da la opcion de volver para registrarse
            else if (!usuarioEncontrado)
            {
                DialogResult resultado = MessageBox.Show(
                    "El usuario ingresado no existe. ¿Deseas registrarte?",
                    "Nuevo Usuario detectado",
                    MessageBoxButtons.YesNo
                );

                //Si el usuario vuelve para registrarse lo lleva al formInicio
                if (resultado == DialogResult.Yes)
                {
                    FormInicio inicio = new FormInicio();
                    inicio.Show();
                    this.Hide();
                }
            }
            else
            {
                CustomMessageBox.Mostrar("Contraseña incorrecta. Intentalo de nuevo");
            }
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
