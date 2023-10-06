using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : Empresa
    {
        public string Nombre { get; set; }
        public Producto(string cUIT, string razonSocial, string nombre) : base(cUIT, razonSocial)
        {
            Nombre = Nombre;
        }
        public override string Info()
        { 
            string retorno =base.Info();
            retorno += $"Info";
            return base.Info();            
        }       

        public override string info()
        {
            throw new NotImplementedException();
        }
    }
}
