using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
    public class Cadete : Empleado
    {        
        protected bool tieneMoto;
        public Cadete()
        {            
        }
        public Cadete(string nombre, float salario, bool tieneMoto) : base(nombre, salario)
        {
            this.TieneMoto = tieneMoto;
        }
        public bool TieneMoto { get => tieneMoto; set => tieneMoto = value; }
        public override string ToString()
        {
            return base.ToString()+$" Tiene moto: {TieneMoto}";
        }
    }
}
