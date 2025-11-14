using System;
using System.Windows.Forms;

namespace ProyectoEstupido
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        // Método estático para mostrar el MessageBox personalizado
        public static void Mostrar(string mensaje)
        {
            using (var msg = new CustomMessageBox(mensaje))
            {
                msg.ShowDialog();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
