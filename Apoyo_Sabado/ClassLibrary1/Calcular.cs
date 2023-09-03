using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Calcular
    {
        public static float Promedio(float acumulado, int cantidad)
        {
            float retorno;
            retorno = acumulado / cantidad;

            return retorno;
        }
    }
}
