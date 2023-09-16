using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitB
{
    internal class Persona
    {
        /*
         * sobrecragas igual nombre distinto tipo de parametros
         * no desarmar orden
         */
        int edad;
        int altura;
        string nombre;
        string apellido;
        string dni;

        public Persona()
        {

        }
        public Persona( string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public Persona(int edad, int altura):this("roberto","tejeda","123456")
        {
            this.edad = edad;
            this.altura = altura;
        }
    }
}
