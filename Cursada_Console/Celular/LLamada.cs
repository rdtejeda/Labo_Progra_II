using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public class LLamada
    {
        private DateTime fechaInicio;
        //private DateTime fechaFinal;
        private string numero;
        private TimeSpan duracion;

        public LLamada(string numeroLlamado, DateTime fechaIni) 
        {
            this.FechaInicio = fechaIni;
            this.Numero = numeroLlamado;                         
        }
        //public DateTime FechaFinal {get=>fechaFinal; set=>fechaFinal=value;}

        public TimeSpan Duracion {get=>duracion; set=>duracion=value;}

        public DateTime FechaInicio {get=>fechaInicio; set=>fechaInicio=value;}
        public string Numero { get=>numero; set=>numero=value; }

        public void CalculaDuracionLlamada(DateTime fechaInicio, DateTime fechaFinal)
        {
            this.Duracion = fechaFinal - fechaInicio;            
        }
        public override string ToString()
        {
            return $"La duración de la llamada fue de: {this.Duracion.Days} dias, {this.Duracion.Hours} horas," +
                $" {this.Duracion.Minutes} minutos, {this.Duracion.Seconds} segundos y {this.Duracion.Milliseconds} milisegundos";
        }
    }
}
