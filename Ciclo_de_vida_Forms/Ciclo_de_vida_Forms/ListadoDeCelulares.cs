using ClasesNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclo_de_vida_Forms
{
    public partial class ListadoDeCelulares : Form
    {
        private List<Celular> listaCelulares = new List<Celular>();
        
        public Celular celularUno = new Celular(EMarca.Xiaomi, "g5", 14, 128);

        public List<Celular> ListaCelulares { get => this.listaCelulares; set => this.listaCelulares = value; }





        public ListadoDeCelulares()
        {
            InitializeComponent();
        }

        private void ListadoDeCelulares_Load(object sender, EventArgs e)
        {
            //muestars las propiedades de l objetro vinculado
            //this.listaCelulares.Clear();
            this.listaCelulares.Add(celularUno);
            dtGCelulares.DataSource = this.listaCelulares;
            dtGCelulares.Columns["Encendido"].Visible = false;
        }

        private void dtGCelulares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
