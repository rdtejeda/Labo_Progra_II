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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void celularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeCelulares lc = new ListadoDeCelulares();
            lc.MdiParent = this;  //ledigo a lc donde vive        
            lc.Show();
        }
        //ismdiconteiner true puede contemer otro
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///modalk capta al atencion y devolver
            //

        }
    }
}
