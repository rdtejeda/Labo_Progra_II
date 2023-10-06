using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Produccion
    {
        public static bool Elaborar(ProcesoProduccion proceso)
        {
            switch (proceso)
            {
                case ProcesoProduccion.A:
                    Console.WriteLine($"INICIANDO PROCESO: {proceso}...");
                    Console.WriteLine($"INICIO DE PROCESO: {proceso}...");
                    Thread.Sleep( 4000 );
                    if(Stock.SetStock(1, 3))
                    {
                        Console.WriteLine("Status: OK");
                    }
                    else
                    {
                        Console.WriteLine("Status: ERROR");
                        return false;
                    }
                    Console.WriteLine($"FIN DE PROCESO: {proceso}...");
                    break;
                case ProcesoProduccion.B:
                    Console.WriteLine($"INICIANDO PROCESO: {proceso}...");
                    Console.WriteLine($"INICIO DE PROCESO: {proceso}...");
                    Thread.Sleep(5000);
                    if (Stock.SetStock(2, 1))
                    {
                        Console.WriteLine("Status: OK");
                    }
                    else
                    {
                        Console.WriteLine("Status: ERROR");
                        return false;
                    }
                    Console.WriteLine($"FIN DE PROCESO: {proceso}...");
                    break;
                case ProcesoProduccion.C:
                    Console.WriteLine($"INICIANDO PROCESO: {proceso}...");
                    Console.WriteLine($"INICIO DE PROCESO: {proceso}...");
                    Thread.Sleep(2000);
                    if (Stock.SetStock(1, 1))
                    {
                        Console.WriteLine("Status: OK");
                    }
                    else
                    {
                        Console.WriteLine("Status: ERROR");
                        return false;
                    }
                    Console.WriteLine($"FIN DE PROCESO: {proceso}...");
                    break;
            }

            return true;
        }
    }
}
