using System.Drawing;
using System.Text;

namespace Clase_01
{
    internal class Program
    {
        static void Main(string[] args) //Entry point otra versi
        {       
            try
            {
                string suNombre;
                int edad;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ingrese su nombre");			
			    suNombre = Console.ReadLine();

			    Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());    

                //Console.WriteLine("Su nombre es " + suNombre);// no usar esto
                Console.WriteLine($"Su nombre es {suNombre}");
                Console.WriteLine("Su nombre es {0} y tenes {1} años", suNombre, edad);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ingese un numero");
            }
            finally
            {
                Console.WriteLine("Final del programa");
            }
		}
    }
}