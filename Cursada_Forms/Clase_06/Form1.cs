namespace Clase_06
{
    public partial class Form1 : Form
    {
        //Atributos
        List<Empleado> listaEmpleados;
        List<string> listaTareas;
        /// <summary>
        /// cada accion encadfena un evento y debo programarla
        /// </summary>
        public Form1()
        {
            InitializeComponent();///esta siempre primer linea
            listaEmpleados = new List<Empleado>();
            listaTareas = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///Se crea el manejador de eventos dando doble clic en el formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Lalogica del boton 
            //string nombre = txtNombre.Text;
            //MessageBox.Show(nombre);
            string nombre;
            float salario = 0;
            string tareas;
            string genero;
            nombre = txtNombre.Text;
            genero = radioButton2.Text;
            if (radioButton1.Checked)
            {
                genero = radioButton1.Text;
            }
            Empleado unEmpleado = new Empleado(nombre, salario, genero, listaTareas);
            // MessageBox.Show(unEmpleado.ToString());
            listaEmpleados.Add(unEmpleado);
            MostrarLista(listaEmpleados);

        }
        private void MostrarLista(List<Empleado> lista)
        {
            listBox1.Items.Clear();
            foreach (Empleado item in lista)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ///contenedeor de controles
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///como unam lista de algo
            int index = listBox1.SelectedIndex;
            //MessageBox.Show(listBox1.Text);
            /// ojoo datagreed
            /// 
            foreach (string item in listaTareas)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = item;
                row.Cells.Add(cell);
                dataGridView1.Rows.Add(row);
                MessageBox.Show("texto","Ttulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            listaTareas.Add(comboBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///fila columna celda
        }
    }
}