using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
   public class Administrativo:Empleado
    {        
        private bool haceHome;
        private int disaVaciones;
        public bool HaceHome { get => haceHome; set => haceHome = value; }
        public int DisaVaciones { get => disaVaciones; set => disaVaciones = value; }
        public Administrativo()
        {            
        }
        public Administrativo(bool haceHome, int disaVaciones, string nombre , float salario): base(nombre,salario)
        {
            this.HaceHome = haceHome;
            this.DisaVaciones = disaVaciones;
        }
        public override string ToString()
        {
            return base.ToString() + $" Hace HC: {HaceHome} - Dias de vacaionnes {DisaVaciones}";
        }
    }
}
