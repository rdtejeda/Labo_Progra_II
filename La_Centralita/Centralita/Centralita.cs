using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Centralita.Provincial;

namespace Centralita
{
    public class Centralita
    {
        private List<LLamada> listaDeLLamadas;
        protected string razonSocial;
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public List<LLamada> Llamadas { get => listaDeLLamadas; set => listaDeLLamadas = value; }
        public float GanaciasPorLocal
            {
                get
                {
                return CalcularGanancia(LLamada.ETipoLlamada.Local);
                }
            }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(LLamada.ETipoLlamada.Provicial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(LLamada.ETipoLlamada.Todas);
            }
        }
        public Centralita()
        {
            Llamadas = new List<LLamada>();
        }
        public Centralita(string razonSocial):this()
        {
            RazonSocial = razonSocial;
        }
        private float CalcularGanancia(LLamada.ETipoLlamada tipo)
        {
            float gananciaLocal=0;
            float gananciaProvincial = 0;
            float retorno = 0;
            foreach (LLamada item in listaDeLLamadas)
            {
                if (item is Local l)
                {
                    gananciaLocal += l.Costo;
                }else if(item is Provincial p)
                {
                    gananciaProvincial += p.CostoLlamada;
                }
            }
            switch (tipo)
            {
                case LLamada.ETipoLlamada.Local:
                    retorno= gananciaLocal ;
                    break;
                case LLamada.ETipoLlamada.Provicial:
                    retorno= gananciaProvincial;
                    break;
                case LLamada.ETipoLlamada.Todas:
                    retorno = gananciaLocal + gananciaProvincial;
                    break;
                default:
                    break;
            }
            return retorno;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La razon social es : {RazonSocial}");
            foreach (var llamada in Llamadas)
            {
                sb.AppendLine(llamada.Mostrar());                
            }
            sb.AppendLine($"Ganancias por llamadas locales: {GanaciasPorLocal}");
            sb.AppendLine($"Ganancias por llamadas Provinciales: {GananciasPorProvincial}");
            sb.AppendLine($"Ganancias por llamadas Totales: {GananciasPorTotal}");
            return  sb.ToString();    
        }
        public void OrdenarLlamadas()
        {
            Llamadas.Sort(LLamada.OrdenarPorDuracion);
        }
    }
}
