using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Item : Producto
    {
        public ulong CantidadStock { get; set; }
        public Item(string cUIT, string razonSocial, string nombre) : base(cUIT, razonSocial, nombre)
        {
            CantidadStock = 0;
        }
        public void Test()
        {
            Console.WriteLine(base.Info());
        }
        public override string Info()
        {
            return base.Info();
        }
        public static bool operator ==(Item a, Item b)
        {
            return false;
        }
        public static bool operator !=(Item a, Item b)
        {
            return !(a == b);
        }

    }
}
