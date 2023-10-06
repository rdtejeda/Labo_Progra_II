using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Stock
    {
        public static List<Item> Inventario { get; set; }

        static Stock()
        {
            Inventario = new List<Item>();
        }

        public static void CargarInventarioRandom()
        {
            foreach (Item item in Inventario)
            {
                //item.CantidadStock = (ulong) new Random().Next(1,10);
                item.CantidadStock = 10;
            }
        }

        public static string MostrarEstadoInventario()
        {
            string rtn = String.Empty;
            foreach (Item item in Inventario)
            {
                rtn += $"******************************************************************************\n";
                rtn += item.Info();
                rtn += $"STOCK: {item.CantidadStock}\n";
                rtn += $"******************************************************************************\n";
            }

            return rtn;
        }

        public static bool SetStock(ulong id, int cantidad)
        {
            foreach (Item item in Inventario)
            {
                if(item == id)
                {
                    //FALTA VALIDAR QUE NO RESTE STOCK SI NO TENGO LA CANTIDAD EN EL INVENTARIO
                    item.CantidadStock -= (ulong)cantidad;
                    return true;
                }
            }

            return false;
        }
    }
}
