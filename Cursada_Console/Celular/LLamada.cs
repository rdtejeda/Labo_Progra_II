using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Celulares
{
    public class LLamada
    {
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private string numero;
        private string duracion;

        public LLamada(string numeroLlamado, DateTime fechaIni) 
        {
            this.FechaInicio = fechaIni;
            this.Numero = numeroLlamado;                         
        }
        public DateTime FechaFinal {get=>fechaFinal; set=>fechaFinal=value;}

        public string Duracion {get=>duracion; set=>duracion=value;}

        public DateTime FechaInicio {get=>fechaInicio; set=>fechaInicio=value;}
        public string Numero { get=>numero; set=>numero=value; }

        public void CalculaDuracionLlamada(DateTime fechaInicio, DateTime fechaFinal)
        {
            TimeSpan duration = fechaFinal - fechaInicio;
            this.Duracion= $"La duración de la llamada fue de: {duration.Days} dias, {duration.Hours} horas," +
                $" {duration.Minutes} minutos, {duration.Seconds} segundos y {duration.Milliseconds} milisegundos";
            this.FechaFinal = fechaFinal;
        }
    }
}
