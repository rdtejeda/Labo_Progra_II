using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormException
{
    public class Calculos
    {
        int operando1;
        int operando2;
        public string Operando1
        {
            set
            {
                operando1 = int.Parse(value);
            }
        }
        public string Operando2
        {
            set
            {
                operando2 = int.Parse(value);
            }
        }
        public float Dividir()
        {
            float re;
            if (operando2 != 0) 
            {
                re = (float)operando1 / (float)operando2;
            }
            else
            {
                throw new DivideByZeroException($"Imposible divider {operando1} por 0");
            }
            return re;
        }
    }
}
