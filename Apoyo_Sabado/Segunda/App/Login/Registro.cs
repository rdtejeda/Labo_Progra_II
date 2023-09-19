using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Registro : Form
    {
        private Usuario[] listaUsuarios;
        public Login login;

        public Registro(Usuario[] usuarios, Login login)
        {
            InitializeComponent();

            listaUsuarios = usuarios;
            this.login = login;
            login.Hide();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            txtError.Visible = false;
            rbtnNoBinario.Checked = true;

            cmbColorFvorito.Items.Add("Azul");
            cmbColorFvorito.Items.Add("Rojo");
            cmbColorFvorito.Items.Add("Verde");

            cmbColorFvorito.SelectedIndex = 2;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario u = new();

            string nombre = tNombre.Text;
            string correo = tCorreo.Text;
            string pass = tPassUno.Text;
            string repass = tPassDos.Text;

            txtError.Visible = false;

            if (nombre != String.Empty)
            {
                if (correo != String.Empty)
                {
                    if (pass == repass && pass != String.Empty)
                    {
                        u.nombre = nombre;
                        u.correo = correo;
                        u.pass = pass;
                        u.codSeg = (int)numCodSeg.Value;
                        u.fechaDeNacimiento = datePickerFecNacimiento.Value;
                        ObtenerValoresVarios(u);

                        if (listaUsuarios + u)
                        {
                            MessageBox.Show("Se dio de alta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo dar de alta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        txtError.Text = "Las contraseñas no coinciden.";
                        txtError.Visible = true;
                    }
                }
                else
                {
                    txtError.Text = "El correo no puede estar vacio.";
                    txtError.Visible = true;
                }
            }
            else
            {
                txtError.Text = "El nombre no puede estar vacio.";
                txtError.Visible = true;
            }
        }

        private void ObtenerValoresVarios(Usuario u)
        {
            u.mayorDeEdad = checkMayorEdad.Checked;
            u.estudia = checkEstudia.Checked;
            u.trabaja = checkTrabaja.Checked;

            foreach (Control item in gbSexo.Controls)
            {
                if (item is RadioButton)
                {
                    if (((RadioButton)item).Checked)
                    {
                        u.sexo = item.Text; //((RadioButton)item).Text
                    }
                }
            }
        }

        private void btnHardcode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int _rnd = rnd.Next(1, 100);
            tNombre.Text = $"Hardcode {_rnd}";
            tCorreo.Text = $"hardcode{_rnd}@h.com";
            tPassUno.Text = $"{_rnd}";
            tPassDos.Text = $"{_rnd}";
            numCodSeg.Value = rnd.Next(1, 11);
            rbtnMasculino.Checked = true;
            cmbColorFvorito.SelectedIndex = rnd.Next(1, 3); ;
        }
    }
}
