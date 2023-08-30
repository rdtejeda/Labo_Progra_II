using System.Drawing;
using System.Text;

namespace Clase_1
{
    internal class Program
    {
        static void Main(string[] args) //Entry point otra versi
        {
            //         // Console.WriteLine("Hello, World!");//print - console.log() - printf
            //         int a;
            //         a = 4;
            //         a = int.MinValue;
            //         Console.WriteLine(a);
            //         if (a == int.MinValue)
            //         {
            //             bool valor = true;
            //             Console.WriteLine(valor);
            //         }
            //         float numero = 15;
            //         //int nuemr2= 3.5; no sirve conversion implicita
            //int nuemro = (int)3.1; //conversion explicta si permitida
            //Console.WriteLine(nuemro);
            string suNombre;
            int edad;

            //desde VC 2

           
            try
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ingrese su nombre");			
			    suNombre = Console.ReadLine();

			    Console.WriteLine("Ingrese su edad");
                //edad = Console.ReadLine().Length; 
                //"35".Length;
                edad = int.Parse(Console.ReadLine());


                Console.WriteLine("Su nombre es " + suNombre);// no usar esto
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