using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_viajar_es_un_placer
{
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private EColor color;
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColor color)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.EColor = color;
        }
        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        public EColor EColor { get => color; set => color = value; }


        public string ToSring()
        {
            return $"Tu Vehiculo tiene {CantidadPuertas} puertas, {CantidadRuedas} ruedas y es {EColor}";
        }

    }
}
