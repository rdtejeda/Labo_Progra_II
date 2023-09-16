using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    public class Empleado
    {
        public string nombre;
        public float salario;
        public string genero;
        public List<string> listaTareas;

        public Empleado(string nombre, float salario, string genero, List<string> listaTareas)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.genero = genero;
            this.listaTareas = new List<string>();
        }
        public List<string> ListaTareas { get=>listaTareas;  }

        public string MyProperty { get; set; }
        public string ToString()
        {
            return $"Sarasa{this.salario}";
        }
    }
}
