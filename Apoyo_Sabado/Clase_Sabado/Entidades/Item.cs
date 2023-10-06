using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Item : Producto
    {
        public static ulong ContadorID { get; set; }
        public ulong CantidadStock { get; set; }
        public ulong ID { get; set; }

        static Item()
        {
            ContadorID = 0;
        }

        public Item(string nombre, string cUIT, string razonSocial) : base(nombre, cUIT, razonSocial)
        {
            ContadorID++;

            CantidadStock = 0;
            ID = ContadorID;
        }

        public static bool operator ==(Item i, ulong id)
        {
            return i.ID == id;
        }

        public static bool operator !=(Item i, ulong id)
        {
            return !(i == id);
        }

        public override string Info()
        {
            return $"ID: {ID}\n{base.Info()}";
        }
    }
}
