using Biblioteca;
using Microsoft.VisualBasic.ApplicationServices;

namespace Login
{
    public partial class Login : Form
    {
        private Usuario[] listaUsuarios;

        public Login()
        {
            listaUsuarios = new Usuario[10]; //new Usuario[0];
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.tPass.PasswordChar = '*';
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro reg = new(listaUsuarios, this);
            reg.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool encontroUsuario = false;

            for (int i = 0; i < listaUsuarios.Length; i++)
            {
                if (listaUsuarios[i] != null)
                {
                    if (listaUsuarios[i].correo == tCorreo.Text && listaUsuarios[i].pass == tPass.Text)
                    {
                        encontroUsuario = true;
                        MessageBox.Show("INGRESO OK.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //INSTANCIO UN NUEVO FORMULARIO DEL TIPO - CLICKER - RECIBE COMO PARAMETRO EL USUARIO LOGUEADO
                        Clicker clicker = new Clicker(listaUsuarios, i);
                        clicker.Show();
                    }
                }
            }
            if (!encontroUsuario)
            {
                MessageBox.Show("No encontro usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}