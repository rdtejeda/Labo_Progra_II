using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // sellado porque no quiero que nadie herede de esta clase tambien metodos
    public sealed class Empleado : Usuario
    {
       

        public string Nombre { get; set; }
        public ulong DNI {  get; set; } //sin signo duplico los positivos
        public string Legajo { get; set; }
        public EmpleadoTipo Tipo { get; set; }
        public EmpleadoEstado Estado { get; set; }
        
        public Empleado()
        {
        }

        public Empleado(string nombre, ulong dNI, string legajo, EmpleadoTipo tipo, EmpleadoEstado estado)
        {
            Nombre = nombre;
            DNI = dNI;
            GenerarLegajo();
            //Legajo = legajo;
            Tipo = tipo;
            Estado = estado;
        }

        public override string Mostrar()//sobre escribo con la caracteristica de esta instancia
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre {Nombre}");
            sb.AppendLine($"DNI {DNI}");
            sb.AppendLine($"Legajo {Legajo}");
            sb.AppendLine($"Tipo {Tipo}");

            return sb.ToString(); //String.Empty; //throw new NotImplementedException();
        }
        private void GenerarLegajo()
        {
            //string auxLegajo= String.Empty;
            if(this.Tipo==EmpleadoTipo.Operario) 
            {
               Legajo = $"0{DNI}";
            }
            else
            {
                Legajo = $"S{DNI}";
            }
            this.Cuenta = Legajo;
            this.Clave = DNI.ToString();
            //switch (this.Tipo)
            //{
            //    case EmpleadoTipo.Operario:
            //        break;
            //    case EmpleadoTipo.Supervisor:
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
