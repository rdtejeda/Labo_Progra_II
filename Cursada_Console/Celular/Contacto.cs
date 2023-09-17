using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public class Contacto
    {
        private string nombre;
        private string numero;

        public Contacto(string nombre, string numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }
        public string Nombre { get=>nombre; set=>numero=value; }
        public string Numero { get=>numero; set=>numero=value; }

    }
}
