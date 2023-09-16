using Operaciones;
//Ingresar un número y mostrar el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero,
//caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = Calculadora.PedirVerificarNumeroEnteroMayoACero();
            Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}.", numero, (long)Math.Pow(numero,2), (long)Math.Pow(numero,3));
        }
    }
}