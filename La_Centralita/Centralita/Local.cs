using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local:LLamada
    {
        protected float costo;
        public Local(LLamada llamada, float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracio, string destino, float costo):this(new LLamada(duracio,destino,origen),costo)
        {
            
        }
        public float Costo 
        {
            get
            {
                return CalcularCosto();
            } 
        }
        private float CalcularCosto()
        {
            return costo * duracion;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());///clase base
            sb.AppendLine($"El costo es de {Costo} pesos.");
            return sb.ToString();
        }
    }
}
