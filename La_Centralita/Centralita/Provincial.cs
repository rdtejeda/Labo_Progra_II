using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : LLamada
    {
        public enum EFranja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }
        private EFranja franja;
        protected EFranja Franja { get => franja; set => franja = value; }
        public Provincial(string nroOrigen, EFranja franjaHoraria, float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
            Franja = franjaHoraria;
        }
        public Provincial(EFranja franja, LLamada llamada):this(llamada.NroOrigen,  franja, llamada.Duracion,llamada.NroDestino)
        {

        }
        public float CostoLlamada 
        { 
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float costo=0;            
            switch (Franja)
            {
            case EFranja.Franja_1:
                    costo = duracion *  0.99f;
                    break;
            case EFranja.Franja_2:
                    costo = duracion * 1.25f;
                    break;                
            case EFranja.Franja_3:
                    costo = duracion * 0.66f;
                    break;
            default:                    
                    break;
            }
            return costo;
        }
        public string Mostrar(float duracion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo es de {CalcularCosto()} pesos.");
            sb.AppendLine($"La franja horaria es {Franja}");
            return sb.ToString();
        }
    }
}
