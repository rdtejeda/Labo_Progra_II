namespace FormException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float cociente;
            Calculos calculos;
            try
            {
                calculos = new Calculos();
                calculos.Operando1 = txtBox1.Text;
                calculos.Operando2 = txtBox2.Text;
                cociente = calculos.Dividir();
                MessageBox.Show(cociente.ToString(), "resultado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"El error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}