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
    public partial class VentanaEmergente : Form
    {
        private string titulo;
        private string mensaje;

        public VentanaEmergente(string titulo, string mensaje)///new
        {
            InitializeComponent();
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        private void VentanaEmergente_Load(object sender, EventArgs e)//load se carga en el formulario
        {
            this.lblTitulo.Text = titulo;
            this.lblMsj.Text = mensaje;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
