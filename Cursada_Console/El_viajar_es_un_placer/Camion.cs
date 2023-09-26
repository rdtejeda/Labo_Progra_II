using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_viajar_es_un_placer
{
    public class Camion :VehiculoTerrestre
    {
        private short cantidadMarchs;
        private int pesoCraga;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColor color, short cantidadMarchs, int pesoCraga):base(cantidadRuedas,cantidadPuertas,color)
        {
            this.CantidadMarchs = cantidadMarchs;
            this.PesoCraga = pesoCraga;
        }

        public short CantidadMarchs { get => cantidadMarchs; set => cantidadMarchs = value; }
        public int PesoCraga { get => pesoCraga; set => pesoCraga = value; }
    }
}
