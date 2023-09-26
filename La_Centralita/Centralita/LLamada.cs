using System.Text;

namespace Centralita
{
    public class LLamada
    {
        public enum ETipoLlamada
        {
            Local,
            Provicial,
            Todas,
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public LLamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.Duracion = duracion;
            this.NroDestino = nroDestino;
            this.NroOrigen = nroOrigen;
        }
        public static int OrdenarPorDuracion(LLamada llamada1, LLamada llamada2)
        {
            return string.Compare(llamada1.Duracion.ToString(),llamada2.Duracion.ToString());
        }        
        public float Duracion { get => duracion; set => duracion = value; }
        public string NroDestino { get => nroDestino; set => nroDestino = value; }
        public string NroOrigen { get => nroOrigen; set => nroOrigen = value; }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La duracios de llamada es {Duracion.ToString()} segundos.");
            sb.AppendLine($"El numero de destino es {NroDestino.ToString()}.");
            sb.AppendLine($"El numero de origen es {NroOrigen.ToString()}.");
            return sb.ToString();
        }
    }
}