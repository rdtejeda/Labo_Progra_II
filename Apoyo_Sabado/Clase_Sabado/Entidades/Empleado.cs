using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Empleado : Usuario
    {
        public string Nombre { get; set; }
        public ulong DNI { get; set; }
        public string Legajo { get; set; }
        public EmpleadoTipo Tipo { get; set; }
        public EmpleadoEstado Estado { get; set; }

        public Empleado(string nombre, ulong dNI, EmpleadoTipo tipo)
        {
            Nombre = nombre;
            DNI = dNI;
            Tipo = tipo;
            Estado = EmpleadoEstado.Libre;
            GenerarLegajoCuentaClave();
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Legajo: {Legajo}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"DNI: {DNI}");
            sb.AppendLine($"Tipo: {Tipo}");

            return sb.ToString();
        }

        private void GenerarLegajoCuentaClave()
        {
            if(this.Tipo == EmpleadoTipo.Operario)
            {
                Legajo = $"O{DNI}";
            }
            else
            {
                Legajo = $"S{DNI}";
            }

            this.Cuenta = Legajo;
            this.Clave = DNI.ToString();
        }
    }
}
