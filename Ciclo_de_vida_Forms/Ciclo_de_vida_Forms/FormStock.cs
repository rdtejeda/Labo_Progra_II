using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclo_de_vida_Forms
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource bs = new BindingSource();
            this.dataGridView1.DataSource = bs;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {

        }

        private void FormStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Ciera","cerro",MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {

            }
        }
    }
}