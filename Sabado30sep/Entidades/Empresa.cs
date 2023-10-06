using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empresa
    {
        protected Empresa(string cUIT, string razonSocial)
        {
            CUIT = cUIT;
            RazonSocial = razonSocial;
        }
        public string CUIT { get; set; }
        public string RazonSocial { get; set;}
        public virtual string Info()//se hereda y se puede sobreescribir
        {
            return $"Empresa {RazonSocial} -- Cuit {CUIT}";//String.Empty;
        }
        public abstract string info();
        
    }
}
