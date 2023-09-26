using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_viajar_es_un_placer
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColor color, short cantidadMarchas, short cantidadPasajeros ) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadRuedas = cantidadRuedas;   
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }

        public string ToString()
        {
            return base.ToString()+$"y ademas tiene {CantidadMarchas} marchas y capacidad para {CantidadPasajeros} pasajeros";
        }
    }
}
