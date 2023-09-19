using Biblioteca;

namespace Login
{
    public partial class Clicker : Form
    {
        private int index;
        private Usuario[] usuarios;

        public Clicker(Usuario[] _usuarios, int _index)
        {
            InitializeComponent();
            index = _index;
            usuarios = _usuarios;
        }

        private void Clicker_Load(object sender, EventArgs e)
        {
            this.Text = $"Bienvenido {usuarios[index].nombre}!";
            ActualizarListaRanking();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClicker_Click(object sender, EventArgs e)
        {
            usuarios[index].contadorClicker++;
            this.txtPuntos.Text = usuarios[index].contadorClicker.ToString();
        }

        private void linkActualizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarListaRanking();
        }

        private void ActualizarListaRanking()
        {
            lbRanking.Items.Clear();
            foreach (Usuario item in usuarios)
            {
                if (item != null)
                {
                    lbRanking.Items.Add(Usuario.FormatearUsuario(item));
                }
            }
        }
    }
}
