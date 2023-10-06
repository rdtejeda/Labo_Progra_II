using Entidades;

namespace Clase_Sabado
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CREO UN EMPLEADO
            Empleado e1 = new Empleado("Mathias", 37687769, EmpleadoTipo.Operario);
            //CREO UN SUPERVISOR
            Empleado e2 = new Empleado("Carlos", 40000000, EmpleadoTipo.Supervisor);
            List<Empleado> lista = new();
            lista.Add(e1);
            lista.Add(e2);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            //CREO PRODUCTOS PORQUE SI (POR SI LOS TENGO EN UNA LISTA, ETC)
            Producto p1 = new Producto("Conchol SUPRIME", "30-37687769-7", "Colchones Canon");
            Producto p2 = new Producto("Conchol OPTIMUS", "30-37687769-7", "Colchones Canon");
            Console.WriteLine(p1.Info());
            Console.WriteLine(p2.Info());
            //CREO ITEMS PARA MANEJARLOS EN UN INVENTARIO
            Item item1 = new Item(p1.Nombre, p1.CUIT, p1.RazonSocial);
            Item item2 = new Item(p2.Nombre, p2.CUIT, p2.RazonSocial);
            Console.WriteLine(item1.Info());
            Console.WriteLine(item2.Info());
            //GESTION DE STOCK
            Stock.Inventario.Add(item1);
            Stock.Inventario.Add(item2);
            Stock.CargarInventarioRandom();
            Console.WriteLine(Stock.MostrarEstadoInventario());
            Console.WriteLine(Stock.SetStock(2, 2));
            Console.WriteLine(Stock.SetStock(1, 3));
            Console.WriteLine(Stock.SetStock(2, 5));
            Console.WriteLine(Stock.MostrarEstadoInventario());
            
            
            //PRODUCCION DE UN PRODUCTO
            foreach (Empleado emp in lista)
            {
                if(emp.Tipo == EmpleadoTipo.Operario && emp.Estado == EmpleadoEstado.Libre)
                {
                    emp.Estado = EmpleadoEstado.Ocupado;
                    if (Produccion.Elaborar(ProcesoProduccion.A))
                    {
                        if (Produccion.Elaborar(ProcesoProduccion.B))
                        {
                            if (Produccion.Elaborar(ProcesoProduccion.C))
                            {
                                Console.WriteLine("PRODUCTO FINALIZADO OK");
                                emp.Estado = EmpleadoEstado.Libre;
                            }
                            else
                            {
                                Console.WriteLine($"PRODUCTO SIN STOCK PARA PROCESO {ProcesoProduccion.C}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"PRODUCTO SIN STOCK PARA PROCESO {ProcesoProduccion.B}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"PRODUCTO SIN STOCK PARA PROCESO {ProcesoProduccion.A}");
                    }
                }
            }
        }
    }
}