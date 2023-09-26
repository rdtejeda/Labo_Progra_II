namespace Ciclo_de_vida_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra la app
            //this.Close(); // cierra solo el formulario this sigue corriendo la aplñicacuion
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;

            if (usuario == "a" && clave == "a")
            {
                //MessageBox.Show("Usuari entro", "log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VentanaEmergente ve = new VentanaEmergente("Usuario Entro", "Log In");
                //ve.Show();//uso ambos y no necesito respuesta
               // ve.ShowDialog();
                if(ve.ShowDialog() == DialogResult.OK)
                {
                    MenuPrincipal mp=new MenuPrincipal();
                    mp.Show();
                    //this.Hide();
                }

            }
            else
            {
                VentanaEmergente ve = new VentanaEmergente("no usduari", "intenet nuevamente");
                ve.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}